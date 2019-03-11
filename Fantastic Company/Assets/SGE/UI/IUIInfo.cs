using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public interface IUIInfo
        {
            IDisplayInfo MainScreen
            {
                get;
            }
            IDisplayInfo[] Screens
            {
                get;
            }
            IUIGroupInfo Group
            {
                get;
            }
        }
    }
}
