using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class Graph
    {
        public Dictionary<int, Node> nodeLookup = new Dictionary<int, Node>();

        public class Node
        {
            public int Id;
            public LinkedList<Node> Adjacent = new LinkedList<Node>();
            public Node(int id)
            {
                Id = id;
            }
        }

        public Node GetNode(int id)
        {
            return nodeLookup[id];
        }

        public void AddEdgeDirect(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            s.Adjacent.AddLast(d);
        }

        public void AddEdgeUndirect(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            s.Adjacent.AddLast(d);
            d.Adjacent.AddLast(s);
        }

        public bool HasPathDFS(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            var visited = new HashSet<int>();
            return HasPathDFS(s, d, visited);
        }

        private bool HasPathDFS(Node source, Node destination, HashSet<int> visited)
        {
            if (visited.Contains(source.Id))
                return false;

            visited.Add(source.Id);
            if (source.Id == destination.Id)
                return true;

            foreach (Node child in source.Adjacent)
            {
                if (HasPathDFS(child, destination, visited))
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasPathBFS(int source, int destination)
        {
            return HasPathBFS(GetNode(source), GetNode(destination));
        }

        private bool HasPathBFS(Node source, Node destination)
        {
            var nextToVisit = new Queue<Node>();
            var visited = new HashSet<int>();
            nextToVisit.Enqueue(source);

            while (nextToVisit.Count > 0)
            {
                Node node = nextToVisit.Dequeue();
                if (node == destination)
                    return true;

                if (visited.Contains(node.Id))
                {
                    continue;
                }
                visited.Add(node.Id);

                foreach (var child in node.Adjacent)
                {
                    nextToVisit.Enqueue(child);
                }
            }

            return false;
        }
    }
}
