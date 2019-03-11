using UnityEngine;
using System.Collections.Generic;

namespace SGE
{
    namespace UI
    {
        public abstract class UIObject
        {
            [SerializeField]
            protected Rect boundingRectangle;
            [SerializeField]
            protected GUISkin skin;
            [SerializeField]
            protected GUIContent contents;
            [SerializeField]
            protected GUIStyle style;
            [SerializeField]
            protected List<IUIPointerListener> pointerListeners;
            [SerializeField]
            protected IScalingAdapter adapter;
            public virtual Rect BoundingRectangle
            {
                get { return boundingRectangle; }
                set { boundingRectangle = value; }
            }
            public virtual GUISkin Skin
            {
                get { return skin; }
                set { skin = value; }
            }
            public virtual GUIContent Contents
            {
                get { return contents; }
                set { contents = value; }
            }
            public virtual GUIStyle Style
            {
                get { return style; }
                set { style = value; }
            }
            public UIObject()
            {
                boundingRectangle = new Rect();
                skin = GUI.skin;
                contents = GUIContent.none;
                style = GUIStyle.none;
                pointerListeners = new List<IUIPointerListener>();
            }
            public UIObject(Rect boundingRectangle, GUISkin skin, GUIContent content, GUIStyle style)
            {
                this.boundingRectangle = boundingRectangle;
                this.skin = skin;
                this.contents = content;
                this.style = style;
                pointerListeners = new List<IUIPointerListener>();
            }
            public void RegisterPointerListener(IUIPointerListener listener)
            {
                pointerListeners.Add(listener);
            }
            public bool UnregisterPointerListener(IUIPointerListener listener)
            {
                return pointerListeners.Remove(listener);
            }
            public bool IsPointerListenerRegistered(IUIPointerListener listener)
            {
                return pointerListeners.Contains(listener);
            }
            protected virtual void RaisePointerOverEvent(PointerEvent.Over e)
            {
                foreach (IUIPointerListener listener in pointerListeners)
                    listener.OnPointerOver(e);
            }
            protected virtual void RaisePointerOverBeginEvent(PointerEvent.OverBegin e)
            {
                foreach (IUIPointerListener listener in pointerListeners)
                    listener.OnPointerOverBegin(e);
            }
            protected virtual void RaisePointerOverEndEvent(PointerEvent.OverEnd e)
            {
                foreach (IUIPointerListener listener in pointerListeners)
                    listener.OnPointerOverEnd(e);
            }
            protected virtual void ApplyScalingAdapter(IScalingAdapter adapter)
            {
                this.adapter = adapter;
            }
            public abstract void Update(IUIProvider provider);
        }
    }
}
