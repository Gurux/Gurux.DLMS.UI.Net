using Gurux.DLMS.Objects;
using System;

namespace Gurux.DLMS.UI
{
    public class GXActionArgs
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="target">Target COSEM object.</param>
        /// <param name="index">Attribute index.</param>
        public GXActionArgs(GXDLMSObject target, int index)
        {
            Target = target;
            Index = index;
        }

        /// <summary>
        /// Target COSEM object.
        /// </summary>
        public GXDLMSObject Target
        {
            get;
            private set;
        }

        /// <summary>
        /// Attribute index of queried object.
        /// </summary>
        public int Index
        {
            get;
            set;
        }

        /// <summary>
        /// object value
        /// </summary>
        public object Value
        {
            get;
            set;
        }

        /// <summary>
        /// Is request handled.
        /// </summary>
        public bool Handled
        {
            get;
            set;
        }

        /// <summary>
        /// Occurred Exception.
        /// </summary>
        public Exception Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Trace text.
        /// </summary>
        public string Text
        {
            get;
            set;
        }
        
        /// <summary>
        /// Client.
        /// </summary>
        public GXDLMSClient Client
        {
            get;
            set;
        }

        /// <summary>
        /// Executed action.
        /// </summary>
        public ActionType Action
        {
            get;
            set;
        }

        /// <summary>
        /// Is meter rebooting.
        /// </summary>
        /// <remarks>
        /// This is used when new image is updated.  
        /// </remarks>
        public bool Rebooting
        {
            get;
            set;
        }
    }
}
