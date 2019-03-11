using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGE
{
    namespace UI
    {
        public interface IUIPointerListener
        {
            void OnPointerOver(PointerEvent.Over e);
            void OnPointerOverBegin(PointerEvent.OverBegin e);
            void OnPointerOverEnd(PointerEvent.OverEnd e);
        }
    }
}
