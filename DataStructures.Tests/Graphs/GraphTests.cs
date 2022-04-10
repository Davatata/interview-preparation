using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Graphs.Tests
{
    [TestClass()]
    public class GraphTests
    {
        Graph graphU;

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            // Executes once for the test class. (Optional)
        }
        [TestInitialize]
        public void Setup()
        {
            // Runs before each test. (Optional)
            graphU = new Graph();

            graphU.nodeLookup.Add(1, new Graph.Node(1));
            graphU.nodeLookup.Add(2, new Graph.Node(2));
            graphU.nodeLookup.Add(3, new Graph.Node(3));
            graphU.nodeLookup.Add(4, new Graph.Node(4));
            graphU.nodeLookup.Add(5, new Graph.Node(5));
            graphU.nodeLookup.Add(6, new Graph.Node(6));
            graphU.nodeLookup.Add(7, new Graph.Node(7));
            graphU.nodeLookup.Add(8, new Graph.Node(8));

            graphU.AddEdgeUndirect(1, 2);
            graphU.AddEdgeUndirect(1, 3);
            graphU.AddEdgeUndirect(2, 4);
            graphU.AddEdgeUndirect(4, 5);
            graphU.AddEdgeUndirect(4, 7);
            graphU.AddEdgeUndirect(5, 7);
            graphU.AddEdgeUndirect(5, 6);
            graphU.AddEdgeUndirect(7, 6);
            graphU.AddEdgeUndirect(6, 8);
            graphU.AddEdgeUndirect(7, 8);
        }

        [TestMethod()]
        public void AddEdgeUndirect_ShouldAdd2Edges()
        {
            // Arrange
            //var graphU = new Graph();

            // Act
            graphU.AddEdgeUndirect(1, 2);

            // Assert
            var v1Edges = graphU.GetNode(1).Adjacent;
            var v2Edges = graphU.GetNode(2).Adjacent;

            Assert.AreEqual(v1Edges.Count, v2Edges.Count);
        }

        [TestMethod()]
        public void AddEdgeDirect_ShouldAdd1Edges()
        {
            // Arrange
            //var graphU = new Graph();

            // Act
            graphU.AddEdgeDirect(1, 2);

            // Assert
            var v1Edges = graphU.GetNode(1).Adjacent;
            var v2Edges = graphU.GetNode(2).Adjacent;

            Assert.AreNotEqual(v1Edges.Count, v2Edges.Count);
        }

        #region DataRows1
        [DataTestMethod()]
        [DataRow(1, 2)]
        [DataRow(2, 1)]

        [DataRow(1, 3)]
        [DataRow(3, 1)]

        [DataRow(2, 4)]
        [DataRow(4, 2)]

        [DataRow(4, 5)]
        [DataRow(5, 4)]

        [DataRow(4, 7)]
        [DataRow(7, 4)]

        [DataRow(5, 7)]
        [DataRow(7, 5)]

        [DataRow(5, 6)]
        [DataRow(6, 5)]

        [DataRow(6, 7)]
        [DataRow(7, 6)]

        [DataRow(8, 7)]
        [DataRow(7, 8)]

        [DataRow(6, 8)]
        [DataRow(8, 6)]
        #endregion
        public void HasPathDFS_ShouldHavePathFrom_x_To_y(int x, int y)
        {
            Assert.IsTrue(graphU.HasPathDFS(x, y));
        }

        #region DataRows1
        [DataTestMethod()]
        [DataRow(1, 2)]
        [DataRow(2, 1)]

        [DataRow(1, 3)]
        [DataRow(3, 1)]

        [DataRow(2, 4)]
        [DataRow(4, 2)]

        [DataRow(4, 5)]
        [DataRow(5, 4)]

        [DataRow(4, 7)]
        [DataRow(7, 4)]

        [DataRow(5, 7)]
        [DataRow(7, 5)]

        [DataRow(5, 6)]
        [DataRow(6, 5)]

        [DataRow(6, 7)]
        [DataRow(7, 6)]

        [DataRow(8, 7)]
        [DataRow(7, 8)]

        [DataRow(6, 8)]
        [DataRow(8, 6)]
        #endregion
        public void HasPathBFS_ShouldHavePathFrom_x_To_y(int x, int y)
        {
            Assert.IsTrue(graphU.HasPathBFS(x, y));
        }

        [DataTestMethod()]
        [DataRow(1, 7)]
        [DataRow(1, 8)]
        [DataRow(3, 8)]
        [DataRow(4, 6)]
        [DataRow(2, 8)]
        public void HasPathDFS_ShouldHavePathFrom_a_To_b(int a, int b)
        {
            Assert.IsTrue(graphU.HasPathDFS(a, b));
        }

        [DataTestMethod()]
        [DataRow(1, 7)]
        [DataRow(1, 8)]
        [DataRow(3, 8)]
        [DataRow(4, 6)]
        [DataRow(2, 8)]
        public void HasPathBFS_ShouldHavePathFrom_a_To_b(int a, int b)
        {
            Assert.IsTrue(graphU.HasPathBFS(a, b));
        }
    }
}