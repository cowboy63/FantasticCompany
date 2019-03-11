using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGE.Util.Graph
{
    /// <summary>
    /// Base class for all trees.
    /// </summary>
    /// <typeparam name="E">The type representing the edges.</typeparam>
    /// <typeparam name="V">The type representing the vertices.</typeparam>
    public abstract class AbstractTree<E, V> : IGraph<E, V>
    {
        /// <summary>
        /// Always returns false for all trees which are undirected.
        /// </summary>
        public virtual bool IsDirected
        {
            get { return false; }
        }
        /// <summary>
        /// Returns the maximum height of the tree.
        /// </summary>
        public abstract int Height
        {
            get;
        }
        /// <summary>
        /// Returns the number of leaves in the tree.
        /// </summary>
        public abstract int LeafCount
        {
            get;
        }

        public abstract bool AddVertex(V vertex);

        public abstract bool AddEdge(V from, V to, E weight);

        public abstract bool RemoveVertex(V vertex);

        public abstract bool RemoveEdge(V from, V to);

        public abstract V[] GetNeighbors(V vertex);

        public abstract Edge<E, V>[] GetEdges(V vertex);
        public abstract int VertexCount
        {
            get;
        }

        public abstract int EdgeCount
        {
            get;
        }

        public abstract Edge<E, V>[] Edges
        {
            get;
        }

        public abstract V[] Vertices
        {
            get;
        }
    }
}
