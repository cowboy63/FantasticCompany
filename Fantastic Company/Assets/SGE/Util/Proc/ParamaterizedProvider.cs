using UnityEngine;
using System.Collections.Generic;

namespace SGE
{
    namespace Util
    {
        namespace Proc
        {
            /// <summary>
            /// Base delegate for providers of procedural-paramaterized generators.
            /// </summary>
            /// <typeparam name="R">The type of the resulting object.</typeparam>
            public delegate R ParamaterizedProvider<R>(IDictionary<string, object> paramaters);
        }
    }
}

