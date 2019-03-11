using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SGE
{
    namespace UI
    {
        public interface IUIProvider
        {
            IUIInfo UIInfo
            {
                get;
            }
            Pointer MainPointer
            {
                get;
            }
            Pointer[] Pointers
            {
                get;
            }
            bool Button(Rect position, string text);
            bool Button(Rect position, Texture image);
            bool Button(Rect position, GUIContent contents);
            bool Button(Rect position, string text, GUIStyle style);
            bool Button(Rect position, Texture image, GUIStyle style);
            bool Button(Rect position, GUIContent content, GUIStyle style);
        }
    }
}
