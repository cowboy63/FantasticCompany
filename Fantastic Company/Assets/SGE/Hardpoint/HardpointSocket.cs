using UnityEngine;
using System.Collections;

namespace SGE
{
    namespace Hardpoint
    {
        public class HardpointSocket
        {
            protected string slotType;
            public virtual string SocketType
            {
                get { return slotType; }
                set { slotType = value; }
            }
            public HardpointSocket()
            {
            }
            public HardpointSocket(string slotType)
            {
                this.slotType = slotType;
            }
        }
    }
}