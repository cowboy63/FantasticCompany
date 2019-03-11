using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public class UIGroup : UIObject
        {
            [SerializeField]
            protected List<UIObject> components = new List<UIObject>();
            public UIGroup() : base()
            {
            }
            public UIGroup(Rect boundingRectangle, GUISkin skin, GUIContent content, GUIStyle style) : base(boundingRectangle, skin, content, style)
            {
            }
            public override void Update(IUIProvider provider)
            {
                foreach (UIObject comp in components)
                    comp.Update(provider);
            }
            public void AddComponent(UIObject component)
            {
                components.Add(component);
            }
            public bool RemoveComponent(UIObject component)
            {
                return components.Remove(component);
            }
            public bool ContainsComponent(UIObject component)
            {
                return components.Contains(component);
            }
            public bool SetRelativePriority(UIObject component, int priority)
            {
                int index = components.IndexOf(component);
                if (index > -1)
                {
                    UIObject obj = components[index];
                    components.RemoveAt(index);
                    components.Insert(Math.Max(0, Math.Min(components.Count, priority)), obj);
                    return true;
                }
                else return false;
            }
        }
    }
}
