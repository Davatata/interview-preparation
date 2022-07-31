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

        public bool ContainsNode(int id)
        {
            return nodeLookup.ContainsKey(id);
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

        public int NumIslands(char[][] grid)
        {
            var seenOnes = new HashSet<(int, int)>();
            var numIslands = 0;
            var rows = grid.Length;
            var cols = grid[0].Length;

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (grid[i][j] == '0')
                    {
                        continue;
                    }

                    if (!seenOnes.Contains((i, j)))
                    {
                        numIslands++;
                        seenOnes.Add((i, j));
                        // check all touching cells
                        NumIslandsHelper(grid, ref seenOnes, i, j, rows, cols);
                    }
                }
            }

            return numIslands;
        }

        private void NumIslandsHelper(char[][] grid, ref HashSet<(int, int)> seenOnes, int i, int j, int rows, int cols)
        {
            // check if up,down,left,right are valid pairs
            // if valid, check if '1'
            // if so, and not seen, add to seenOnes and check neighbors

            // up
            if (IsValidPair(rows, cols, i + 1, j))
            {
                if (grid[i + 1][j] == '1' && !seenOnes.Contains((i + 1, j)))
                {
                    seenOnes.Add((i + 1, j));
                    NumIslandsHelper(grid, ref seenOnes, i + 1, j, rows, cols);
                }
            }

            // down
            if (IsValidPair(rows, cols, i - 1, j))
            {
                if (grid[i - 1][j] == '1' && !seenOnes.Contains((i - 1, j)))
                {
                    seenOnes.Add((i - 1, j));
                    NumIslandsHelper(grid, ref seenOnes, i - 1, j, rows, cols);
                }
            }

            // right
            if (IsValidPair(rows, cols, i, j + 1))
            {
                if (grid[i][j + 1] == '1' && !seenOnes.Contains((i, j + 1)))
                {
                    seenOnes.Add((i, j + 1));
                    NumIslandsHelper(grid, ref seenOnes, i, j + 1, rows, cols);
                }
            }

            // left
            if (IsValidPair(rows, cols, i, j - 1))
            {
                if (grid[i][j - 1] == '1' && !seenOnes.Contains((i, j - 1)))
                {
                    seenOnes.Add((i, j - 1));
                    NumIslandsHelper(grid, ref seenOnes, i, j - 1, rows, cols);
                }
            }



        }

        private bool IsValidPair(int rows, int cols, int i, int j)
        {
            if ((i >= 0 && i < rows) &&
                 (j >= 0 && j < cols))
            {
                return true;
            }

            return false;
        }
    }
}
