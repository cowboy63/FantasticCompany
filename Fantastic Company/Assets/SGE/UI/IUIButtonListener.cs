using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGE
{
    namespace UI
    {
        public interface IUIButtonListener
        {
            void OnButtonDown(ButtonEvent.Down e);
            void OnButtonPress(ButtonEvent.Press e);
            void OnButtonRelease(ButtonEvent.Release e);
        }
    }
}
