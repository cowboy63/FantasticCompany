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
            public interface IGraph<E, V>
            {
                bool AddVertex(V vertex);
                bool AddEdge(V from, V to, E weight);
                bool RemoveVertex(V vertex);
                bool RemoveEdge(V from, V to);
                V[] GetNeighbors(V vertex);
                Edge<E, V>[] GetEdges(V vertex);
                int VertexCount
                {
                    get;
                }
                int EdgeCount
                {
                    get;
                }
                bool IsDirected
                {
                    get;
                }
                Edge<E, V>[] Edges
                {
                    get;
                }
                V[] Vertices
                {
                    get;
                }
            }
        }
    }
}
