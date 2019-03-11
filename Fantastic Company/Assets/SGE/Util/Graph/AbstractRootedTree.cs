using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGE.Util.Graph
{
    /// <summary>
    /// Base class for all rooted trees.
    /// </summary>
    /// <typeparam name="E">The type representing the edges.</typeparam>
    /// <typeparam name="V">The type representing the vertices.</typeparam>
    public abstract class AbstractRootedTree<E, V> : AbstractTree<E, V>
    {
        /// <summary>
        /// Gets the immediate children for a given node
        /// </summary>
        /// <param name="node">The node to get the children for.</param>
        /// <returns>The immediate children of the node</returns>
        public abstract V[] GetImmediateChildren(V node);
        /// <summary>
        /// Gets all the children for a given node.
        /// </summary>
        /// <param name="node">The node to get the children for.</param>
        /// <returns>All the children of the node.</returns>
        public abstract V[] GetAllChildren(V node);
        /// <summary>
        /// The root node of the tree.
        /// </summary>
        public abstract V Root
        {
            get;
        }
        /// <summary>
        /// Always returns true for all rooted trees which are directed.
        /// </summary>
        public override bool IsDirected
        {
            get { return true; }
        }
    }
}
