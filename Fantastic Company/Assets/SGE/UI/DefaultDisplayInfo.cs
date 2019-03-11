using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public class DefaultDisplayInfo : IDisplayInfo
        {
            public static readonly DefaultDisplayInfo INSTANCE = new DefaultDisplayInfo();

            public string Name
            {
                get { return "Default Display"; }
            }

            public Vector2 Size
            {
                get { return new Vector2(Screen.width, Screen.height); }
            }

            public Resolution Resolution
            {
                get { return Screen.currentResolution; }
            }
        }
    }
}
