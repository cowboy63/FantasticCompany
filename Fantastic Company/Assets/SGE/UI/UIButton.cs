using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public class UIButton : UIObject
        {
            protected bool isDown = false;
            [SerializeField]
            protected List<IUIButtonListener> buttonListeners;
            public UIButton() : base()
            {
                buttonListeners = new List<IUIButtonListener>();
            }
            public UIButton(Rect boundingRectangle, GUISkin skin, GUIContent content, GUIStyle style)
                : base(boundingRectangle, skin, content, style)
            {
                buttonListeners = new List<IUIButtonListener>();
            }
            public void RegisterButtonListener(IUIButtonListener listener)
            {
                buttonListeners.Add(listener);
            }
            public bool UnregisterButtonListener(IUIButtonListener listener)
            {
                return buttonListeners.Remove(listener);
            }
            public bool IsButtonListenerRegistered(IUIButtonListener listener)
            {
                return buttonListeners.Contains(listener);
            }
            public void RaiseButtonDownEvent(ButtonEvent.Down e)
            {
                foreach (IUIButtonListener listener in buttonListeners)
                    listener.OnButtonDown(e);
            }
            public void RaiseButtonPressEvent(ButtonEvent.Press e)
            {
                foreach (IUIButtonListener listener in buttonListeners)
                    listener.OnButtonPress(e);
            }
            public void RaiseButtonReleaseEvent(ButtonEvent.Release e)
            {
                foreach (IUIButtonListener listener in buttonListeners)
                    listener.OnButtonRelease(e);
            }
            public override void Update(IUIProvider provider)
            {
                if(provider.Button(adapter == null ? boundingRectangle : adapter.AdaptScale(boundingRectangle, provider.UIInfo), contents, style))
                {
                    if (!isDown) RaiseButtonPressEvent(new ButtonEvent.Press());
                    RaiseButtonDownEvent(new ButtonEvent.Down());
                    isDown = true;
                }
                else
                {
                    if (isDown) RaiseButtonReleaseEvent(new ButtonEvent.Release());
                    isDown = false;
                }
            }
        }
    }
    
}
