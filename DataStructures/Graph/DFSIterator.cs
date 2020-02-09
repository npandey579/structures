using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Graph
{
    public class DFSIterator<T>
    {
        private readonly Vertex<T> root;
        private readonly HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();
        public DFSIterator(Vertex<T> rootVertex)
        {
            root = rootVertex;
        }

        public IEnumerable<Vertex<T>> Iterate()
        {
            visited.Clear();

            return DepthFirstSearch(root, visited);
        }

        private IEnumerable<Vertex<T>> DepthFirstSearch(Vertex<T> vertex, HashSet<Vertex<T>> visited)
        {
            if (visited.Contains(vertex))
                yield break;

            visited.Add(vertex);

            yield return vertex;

            foreach (Vertex<T> neighbor in vertex.Neighbors.SelectMany(n => DepthFirstSearch(n, visited)))
                yield return neighbor;
        }
    }
}
