using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public class DefaultUIProvider : IUIProvider
        {
            public IUIInfo UIInfo
            {
                get { return DefaultUIInfo.INSTANCE; }
            }
            public Pointer MainPointer
            {
                get { throw new NotImplementedException(); }
            }

            public Pointer[] Pointers
            {
                get { throw new NotImplementedException(); }
            }

            public bool Button(Rect position, string text)
            {
                return GUI.Button(position, text);
            }

            public bool Button(Rect position, Texture image)
            {
                return GUI.Button(position, image);
            }

            public bool Button(Rect position, GUIContent contents)
            {
                return GUI.Button(position, contents);
            }

            public bool Button(Rect position, string text, GUIStyle style)
            {
                return GUI.Button(position, text, style);
            }

            public bool Button(Rect position, Texture image, GUIStyle style)
            {
                return GUI.Button(position, image, style);
            }

            public bool Button(Rect position, GUIContent content, GUIStyle style)
            {
                return GUI.Button(position, content, style);
            }
        }
    }
    
}
