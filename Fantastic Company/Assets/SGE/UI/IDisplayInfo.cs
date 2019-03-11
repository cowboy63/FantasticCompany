using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public interface IDisplayInfo
        {
            string Name
            {
                get;
            }
            Vector2 Size
            {
                get;
            }
            Resolution Resolution
            {
                get;
            }
        }
    }
}
