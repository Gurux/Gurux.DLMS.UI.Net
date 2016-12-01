//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL$
//
// Version:         $Revision$,
//                  $Date$
//                  $Author$
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License for more details.
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// This class is used to update Gurux DLMS COSEM components user interface.
    /// </summary>
    public class GXDlmsUi
    {
        /// <summary>
        /// Update attribute value for the view.
        /// </summary>
        /// <param name="view">Updated view.</param>
        /// <param name="controls">Update controls.</param>
        /// <param name="index">Attribute index.</param>
        /// <param name="value">Updated value.</param>
        /// <returns></returns>
        private static bool UpdateProperty(IGXDLMSView view, ControlCollection controls, int index, object value)
        {
            bool found = false;
            foreach (Control it in controls)
            {
                if (it is GXValueField)
                {
                    GXValueField obj = it as GXValueField;
                    if (obj.Index == index)
                    {
                        obj.Target = view.Target;
                        obj.UpdateValueItems(view.Target, index, value);
                        obj.Value = value;
                        found = true;
                    }
                }
                else if (it is GXButton)
                {
                    GXButton obj = it as GXButton;
                    obj.Enabled = false;
                }
                else if (it.Controls.Count != 0)
                {
                    found = UpdateProperty(view, it.Controls, index, value);
                }
                if (found)
                {
                    break;
                }
            }
            return found;
        }

        /// <summary>
        /// Update attribute value for the view.
        /// </summary>
        /// <param name="view">Updated view.</param>
        /// <param name="index">Attribute index.</param>
        /// <param name="value">Updated value.</param>
        /// <returns></returns>
        public static void UpdateProperty(IGXDLMSView view, int index, object value)
        {
            UpdateProperty(view, ((Form)view).Controls, index, value);
        }

        /// <summary>
        /// Update all values of given COSEM object.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="view"></param>
        public static void UpdateProperties(IGXDLMSBase obj, IGXDLMSView view)
        {
            if (obj == null)
            {
                return;
            }
            GXDLMSObject tmp = view.Target;
            view.Description = tmp.Description;
            //If we want to show what properties are changed.
            if (view.ErrorProvider != null)
            {
                view.ErrorProvider.Clear();
                foreach (int it in tmp.GetDirtyAttributeIndexes())
                {
                    UpdateDirty(view, ((Form)view).Controls, tmp, it, true);
                }
            }
            //Update atribute values.
            for (int it = 1; it != obj.GetAttributeCount() + 1; ++it)
            {
                object value = null;
                bool dirty = view.Target.GetDirty(it, out value);
                value = view.Target.GetValues()[it - 1];
                bool bFound = UpdateProperty(view, ((Form)view).Controls, it, value);
                if (!bFound)
                {
                    view.OnAccessRightsChange(it, view.Target.GetAccess(it));
                }
                if (!bFound)
                {
                    view.OnValueChanged(it, value, false);
                }
            }
        }

        public static bool UpdateDirty(IGXDLMSView view, System.Windows.Forms.Control.ControlCollection controls, GXDLMSObject target, int index, bool dirty)
        {
            bool found = false;
            foreach (Control it in controls)
            {
                if (it is GXValueField)
                {
                    GXValueField obj = it as GXValueField;
                    if (obj.Index == index)
                    {
                        if (dirty && index != 0)
                        {
                            view.ErrorProvider.SetError(it, Properties.Resources.ValueChangedTxt);
                        }
                        else
                        {
                            view.ErrorProvider.Clear();
                        }
                        found = true;
                    }
                }
                else if (it.Controls.Count != 0)
                {
                    found = UpdateDirty(view, it.Controls, target, index, dirty);
                }
                if (found)
                {
                    break;
                }
            }
            return found;
        }
    }
}
