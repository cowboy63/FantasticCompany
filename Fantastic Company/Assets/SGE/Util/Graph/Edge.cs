using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGE
{
    namespace Util
    {
        namespace Graph
        {
            public sealed class Edge<E, V>
            {
                public readonly V Start;
                public readonly V End;
                public readonly E Value;
                public readonly bool IsDirected;
                public Edge(V start, V end, E value, bool directed)
                {
                    Start = start;
                    End = end;
                    Value = value;
                    IsDirected = directed;
                }
            }
        }
    }
}
