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

using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
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
        /// Constructor.
        /// </summary>
        private GXDlmsUi()
        {
            GeneratorAddress = "https://certificates.gurux.fi/api/CertificateGenerator";
        }

        /// <summary>
        /// Date-Time values are shown using meter's time zone and it's not localized to use PC time.
        /// </summary>
        static public bool UseMeterTimeZone
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        static public string GeneratorAddress
        {
            get;
            set;
        }


        static private bool Contains<T>(T[] arr, T value)
        {
            if (arr == null)
            {
                return value == null;
            }
            foreach (T it in arr)
            {
                if (it.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        static private bool Equals<T>(T[] arr, T value)
        {
            if (arr == null)
            {
                return value == null;
            }
            if (value == null)
            {
                return arr.Length == 0 || (arr.Length == 1 && arr[0] == null);
            }
            return arr.Length == 1 && arr[0].Equals(value);
        }

        /// <summary>
        /// Get available views.
        /// </summary>
        /// <param name="parent">Parent component where views are shown.</param>
        /// <param name="eventHandler">Event what is called when user press button on the view.</param>
        /// <returns>List of available views.</returns>
        public static Dictionary<Type, List<IGXDLMSView>> GetViews(Control parent, EventHandler eventHandler)
        {
            Dictionary<Type, List<IGXDLMSView>> views = new Dictionary<Type, List<IGXDLMSView>>();
            foreach (Type type in typeof(IGXDLMSView).Assembly.GetTypes())
            {
                GXDLMSViewAttribute[] att = (GXDLMSViewAttribute[])type.GetCustomAttributes(typeof(GXDLMSViewAttribute), true);
                if (!type.IsInterface && typeof(IGXDLMSView).IsAssignableFrom(type))
                {
                    IGXDLMSView view = Activator.CreateInstance(type) as IGXDLMSView;
                    Form f = view as Form;
                    f.TopLevel = false;
                    f.TopMost = false;
                    f.FormBorderStyle = FormBorderStyle.None;
                    f.Dock = DockStyle.Fill;
                    f.Width = parent.Width;
                    f.Height = parent.Height;
                    List<IGXDLMSView> list;
                    if (views.ContainsKey(att[0].DLMSType))
                    {
                        list = views[att[0].DLMSType];
                    }
                    else
                    {
                        list = new List<IGXDLMSView>();
                        views.Add(att[0].DLMSType, list);
                    }
                    list.Add(view);
                    GXDlmsUi.Init(view, eventHandler);
                }
            }
            return views;
        }

        /// <summary>
        /// Get view for COSEM object.
        /// </summary>
        /// <param name="views">List of available views.</param>
        /// <param name="target">Selected COSEM object.</param>
        /// <returns>Assigned view.</returns>
        public static IGXDLMSView GetView(Dictionary<Type, List<IGXDLMSView>> views, GXDLMSObject target)
        {
            List<IGXDLMSView> v = views[target.GetType()];
            foreach (var it in v)
            {
                GXDLMSViewAttribute[] att = (GXDLMSViewAttribute[])it.GetType().GetCustomAttributes(typeof(GXDLMSViewAttribute), true);
                if (att.Length == 1 && Contains<byte>(att[0].Versions, (byte)target.Version))
                {
                    return it;
                }
            }
            return v[0];
        }

        /// <summary>
        /// Get view for COSEM object.
        /// </summary>
        /// <param name="views">List of available views.</param>
        /// <param name="target">Selected COSEM object.</param>
        /// <param name="standard">Used standard.</param>
        /// <returns>Assigned view.</returns>
        public static IGXDLMSView GetView(Dictionary<Type, List<IGXDLMSView>> views, GXDLMSObject target, Standard standard)
        {
            List<IGXDLMSView> v = views[target.GetType()];
            foreach (var it in v)
            {
                GXDLMSViewAttribute[] att = (GXDLMSViewAttribute[])it.GetType().GetCustomAttributes(typeof(GXDLMSViewAttribute), true);
                if (att.Length == 1 && Contains<byte>(att[0].Versions, (byte)target.Version)
                    && Contains<Standard>(att[0].Standards, standard)
                    && Contains<string>(att[0].LogicalNames, target.LogicalName))
                {
                    return it;
                }
            }
            foreach (var it in v)
            {
                GXDLMSViewAttribute[] att = (GXDLMSViewAttribute[])it.GetType().GetCustomAttributes(typeof(GXDLMSViewAttribute), true);
                if (att.Length == 1 && Contains<byte>(att[0].Versions, (byte)target.Version) &&
                    Equals<Standard>(att[0].Standards, Standard.DLMS) && Contains<string>(att[0].LogicalNames, target.LogicalName))
                {
                    return it;
                }
            }
            //Find default UI.
            foreach (var it in v)
            {
                GXDLMSViewAttribute[] att = (GXDLMSViewAttribute[])it.GetType().GetCustomAttributes(typeof(GXDLMSViewAttribute), true);
                if (att.Length == 1 && Contains<byte>(att[0].Versions, (byte)target.Version) &&
                    Equals<Standard>(att[0].Standards, Standard.DLMS) &&
                    Equals<string>(att[0].LogicalNames, null))
                {
                    return it;
                }
            }
            return v[0];
        }

        /// <summary>
        /// Update attribute value for the view.
        /// </summary>
        /// <param name="view">Updated view.</param>
        /// <param name="controls">Update controls.</param>
        /// <param name="index">Attribute index.</param>
        /// <param name="value">Updated value.</param>
        /// <returns></returns>
        private static GXValueField UpdateProperty(IGXDLMSView view, ControlCollection controls, int index, object value)
        {
            GXValueField item = null;
            foreach (Control it in controls)
            {
                if (it is GXValueField)
                {
                    GXValueField obj = it as GXValueField;
                    if (obj.Index == index)
                    {
                        obj.Target = view.Target;
                        obj.UpdateValueItems(view.Target, index, value);
                        if (obj.Index != 1 && view.Target.GetLastReadTime(index) == DateTime.MinValue
                            && obj.Type != ValueFieldType.CheckedListBox)
                        {
                            obj.Value = null;
                        }
                        else
                        {
                            obj.Value = value;
                        }
                        item = obj;
                    }
                }
                else if (it is GXButton)
                {
                    //Do nothing.
                }
                else if (it.Controls.Count != 0)
                {
                    item = UpdateProperty(view, it.Controls, index, value);
                }
                if (item != null)
                {
                    break;
                }
            }
            return item;
        }

        delegate void UpdatePropertyEventHandler(GXDLMSClient client, GXDLMSObject obj, int index, IGXDLMSView view, bool connected, bool user);

        /// <summary>
        /// Update selected values of given COSEM object.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="view"></param>
        public static void UpdateProperty(GXDLMSClient client, GXDLMSObject obj, int index, IGXDLMSView view, bool connected, bool user)
        {
            if (obj == null)
            {
                return;
            }
            if ((view as Form).InvokeRequired)
            {
                try
                {
                    (view as Form).BeginInvoke(new UpdatePropertyEventHandler(UpdateProperty), client, obj, index, view, connected, user);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(view as Form, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
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
            for (int it = 1; it != (obj as IGXDLMSBase).GetAttributeCount() + 1; ++it)
            {
                if (index == 0 || it == index)
                {
                    object value = null;
                    bool dirty = view.Target.GetDirty(it, out value);
                    value = view.Target.GetValues()[it - 1];
                    GXValueField item = UpdateProperty(view, ((Form)view).Controls, it, value);
                    if (item == null || item.NotifyChanges)
                    {
                        GXDLMSViewArguments arg = new GXDLMSViewArguments() { Client = client, Index = it, Connected = connected, User = user, Value = value };
                        view.OnValueChanged(arg);
                    }
                    if (it == index)
                    {
                        break;
                    }
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

        delegate void UpdateAccessRightsEventHandler(IGXDLMSView view, GXDLMSClient client, object target, bool enabled);
        delegate void AccessRightsChangeEventHandler(IGXDLMSView view, GXDLMSClient client, GXDLMSObject target, int index, bool connected, bool method);

        private static void OnUpdateAccessRights(IGXDLMSView view, GXDLMSClient client, object target, bool enabled)
        {
            if ((view as Form).InvokeRequired)
            {
                (view as Form).BeginInvoke(new UpdateAccessRightsEventHandler(OnUpdateAccessRights), view, client, target, enabled);
            }
            else
            {
                if (target is GXValueField)
                {
                    (target as GXValueField).ReadOnly = !enabled;
                }
                else
                {
                    (target as GXButton).Enabled = enabled;
                }
            }
        }
        private static void OnAccessRightsChange(IGXDLMSView view, GXDLMSClient client, GXDLMSObject target, int index, bool connected, bool method)
        {
            if ((view as Form).InvokeRequired)
            {
                (view as Form).BeginInvoke(new AccessRightsChangeEventHandler(OnAccessRightsChange), view, client, target, index, connected, method);
            }
            else
            {
                GXDLMSViewArguments arg = new GXDLMSViewArguments() { Client = client, Index = index, Connected = connected };
                if (method)
                {
                    view.OnMethodAccessRightsChange(arg);
                }
                else
                {
                    view.OnAccessRightsChange(arg);
                }
            }
        }

        private static bool UpdateAccessRights(IGXDLMSView view, GXDLMSClient client, System.Windows.Forms.Control.ControlCollection controls, GXDLMSObject target, int index, bool method, bool connected)
        {
            foreach (Control it in controls)
            {
                if (!method && it is GXValueField)
                {
                    GXValueField obj = it as GXValueField;
                    if (obj.Index == index)
                    {
                        obj.Target = target;
                        bool access = connected;
                        if (connected)
                        {
                            if (client != null)
                            {
                                access = client.CanWrite(target, index);
                            }
                            else
                            {
                                AccessMode am = target.GetAccess(index);
                                access = (am & AccessMode.Write) != 0;
                            }
                        }
                        OnUpdateAccessRights(view, client, obj, connected && access);
                        return !obj.NotifyChanges;
                    }
                }
                else if (it is GXButton)
                {
                    bool access;
                    GXButton btn = it as GXButton;
                    btn.Target = target;
                    //Update custom buttons.
                    if (method && index == 0 && btn.Index < 1)
                    {
                        OnUpdateAccessRights(view, client, btn, connected);
                        continue;
                    }
                    if (method && btn.Index == index && btn.Action == ActionType.Action)
                    {
                        if (client != null)
                        {
                            access = client.CanInvoke(target, index);
                        }
                        else
                        {
                            access = target.GetMethodAccess(index) != MethodAccessMode.NoAccess;
                            if (!access)
                            {
                                access = target.GetMethodAccess3(index) != MethodAccessMode3.NoAccess;
                            }
                        }
                        OnUpdateAccessRights(view, client, btn, connected && access);
                        return true;
                    }
                    if (!method && btn.Index == index && (btn.Action == ActionType.Read || btn.Action == ActionType.Write))
                    {
                        if (btn.Action == ActionType.Read)
                        {
                            if (client != null)
                            {
                                access = client.CanRead(target, index);
                            }
                            else
                            {
                                access = (target.GetAccess(index) & AccessMode.Read) != 0;
                                if (!access)
                                {
                                    access = (target.GetAccess3(index) & AccessMode3.Read) != 0;
                                }
                            }
                            OnUpdateAccessRights(view, client, btn, connected && access);
                        }
                        else if (btn.Action == ActionType.Write)
                        {
                            if (client != null)
                            {
                                access = client.CanWrite(target, index);
                            }
                            else
                            {
                                access = (target.GetAccess(index) & AccessMode.Write) != 0;
                                if (!access)
                                {
                                    access = (target.GetAccess3(index) & AccessMode3.Write) != 0;
                                }
                            }
                            OnUpdateAccessRights(view, client, btn, connected && access);
                        }
                    }
                }
                else if (it.Controls.Count != 0)
                {
                    bool ret = UpdateAccessRights(view, client, it.Controls, target, index, method, connected);
                    //If object is updated.
                    if (ret)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Called when new object is selected. This will update the access rights.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="target"></param>
        /// <param name="connected"></param>
        public static void UpdateAccessRights(IGXDLMSView view, GXDLMSClient client, GXDLMSObject target, bool connected)
        {
            //Update attributes.
            List<int> attributeIndexes = new List<int>();
            List<int> methodIndexes = new List<int>();
            ControlCollection controls = (view as Form).Controls;
            for (int index = 1; index <= (target as IGXDLMSBase).GetAttributeCount(); ++index)
            {
                if (!UpdateAccessRights(view, client, controls, target, index, false, connected))
                {
                    attributeIndexes.Add(index);
                }
            }
            //Update methods.
            for (int index = 0; index <= (target as IGXDLMSBase).GetMethodCount(); ++index)
            {
                if (!UpdateAccessRights(view, client, controls, target, index, true, connected))
                {
                    if (index != 0)
                    {
                        methodIndexes.Add(index);
                    }
                }
            }
            foreach (int index in attributeIndexes)
            {
                OnAccessRightsChange(view, client, target, index, connected, false);
            }
            //Update methods.
            foreach (int index in methodIndexes)
            {
                OnAccessRightsChange(view, client, target, index, connected, true);
            }
        }

        /// <summary>
        /// Called when new object is selected. This will update the access rights.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="target"></param>
        /// <param name="connected"></param>
        public static void ObjectChanged(IGXDLMSView view, GXDLMSClient client, GXDLMSObject target, bool connected)
        {
            UpdateAccessRights(view, client, target, connected);

            for (int index = 1; index <= (target as IGXDLMSBase).GetAttributeCount(); ++index)
            {
                UpdateProperty(client, target, index, view, connected, true);
            }
        }

        private static void Init(IGXDLMSView view, System.Windows.Forms.Control.ControlCollection controls, EventHandler eventHandler)
        {
            foreach (Control it in controls)
            {
                if (it is GXButton)
                {
                    GXButton btn = it as GXButton;
                    btn.View = view;
                    btn.Click += eventHandler;
                }
                else if (it is GXValueField)
                {
                    GXValueField vf = it as GXValueField;
                    vf.DefaultType = vf.Type;
                }
                else if (it.Controls.Count != 0)
                {
                    Init(view, it.Controls, eventHandler);
                }
            }
        }

        public static void Init(IGXDLMSView view, EventHandler eventHandler)
        {
            Init(view, (view as Form).Controls, eventHandler);
        }

        /// <summary>
        /// Show find dialog.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Find(IWin32Window owner, GXFindParameters p)
        {
            GXFindDlg dlg = new GXFindDlg(p);
            if (dlg.ShowDialog(owner) == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Save settings to the registry.
        /// </summary>
        public static void Save()
        {
            Properties.Settings.Default.Save();
        }

        private static bool UpdateError(IGXDLMSView view, System.Windows.Forms.Control.ControlCollection controls,
            GXDLMSObject target, int index, Exception ex)
        {
            bool found = false;
            foreach (Control it in controls)
            {
                if (it is GXValueField)
                {
                    GXValueField obj = it as GXValueField;
                    if (obj.Index == index)
                    {
                        if (ex == null)
                        {
                            view.ErrorProvider.SetError(it, null);
                        }
                        else
                        {
                            view.ErrorProvider.SetError(it, ex.Message);
                        }
                        found = true;
                        break;
                    }
                }
                else if (it.Controls.Count != 0)
                {
                    found = UpdateError(view, it.Controls, target, index, ex);
                }
                if (found)
                {
                    break;
                }
            }
            return found;
        }

        /// <summary>
        ///Update error.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="target"></param>
        /// <param name="connected"></param>
        public static void UpdateError(IGXDLMSView view, GXDLMSObject target, int index, Exception ex)
        {
            UpdateError(view, (view as Form).Controls, target, index, ex);
        }

        /// <summary>
        /// Upgrade previous installed settings.
        /// </summary>
        public static void Upgrade()
        {
            //Update previous installed settings.
            if (Properties.Settings.Default.UpdateSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpdateSettings = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
