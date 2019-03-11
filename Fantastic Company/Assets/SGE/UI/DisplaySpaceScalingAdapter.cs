using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public class DisplaySpaceScalingAdapter : IScalingAdapter
        {
            public static readonly DisplaySpaceScalingAdapter INSTANCE = new DisplaySpaceScalingAdapter();
            public Rect AdaptScale(Rect input, IUIInfo info)
            {
                return new Rect(input.x * info.MainScreen.Size.x, input.y * info.MainScreen.Size.y, input.width * info.MainScreen.Size.x, input.height * info.MainScreen.Size.y);
            }
        }
    }
    
}
