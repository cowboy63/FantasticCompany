using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public interface IScalingAdapter
        {
            Rect AdaptScale(Rect input, IUIInfo info);
        }
    }
}
