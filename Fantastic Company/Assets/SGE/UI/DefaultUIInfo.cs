using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGE
{
    namespace UI
    {
        public class DefaultUIInfo : IUIInfo
        {
            public static readonly DefaultUIInfo INSTANCE = new DefaultUIInfo();
            public IDisplayInfo MainScreen
            {
                get { return DefaultDisplayInfo.INSTANCE; }
            }

            public IDisplayInfo[] Screens
            {
                get { throw new NotImplementedException(); }
            }

            public IUIGroupInfo Group
            {
                get { throw new NotImplementedException(); }
            }
        }
    }
}
