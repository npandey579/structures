using DataStructures.Graph;
using System;

namespace DSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var la = new Vertex<string>("Los Angeles");
            var sf = new Vertex<string>("San Francisco");
            var lv = new Vertex<string>("Las Vegas");
            var se = new Vertex<string>("Seattle");
            var au = new Vertex<string>("Austin");
            var po = new Vertex<string>("Portland");

            var testGraph = new UndirectedGenericGraph<string>();

            // la <=> sf, lv, po
            testGraph.AddPair(la, sf);
            testGraph.AddPair(la, lv);
            testGraph.AddPair(la, po);

            // sf <=> se, po
            testGraph.AddPair(sf, se);
            testGraph.AddPair(sf, po);

            // lv <=> au
            testGraph.AddPair(lv, au);

            // se <=> po
            testGraph.AddPair(se, po);

            // Check to see that all neighbors are properly set up
            foreach (var vertex in testGraph.Vertices)
            {
                System.Diagnostics.Debug.WriteLine(vertex.ToString());
            }

            // Test searching algorithms
            System.Diagnostics.Debug.WriteLine("D F S result");
            //testGraph.DepthFirstSearch(la, (m) => System.Diagnostics.Debug.WriteLine(m));

            System.Diagnostics.Debug.WriteLine("B F S result");
            testGraph.BreadthFirstSearch(la, (m) => System.Diagnostics.Debug.WriteLine(m));
        }
    }
}
