using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmn
{
    class Graph
    {
        private int[] vertexs;
        private int[,] edges;

        public Graph(Stream input)
        {
            var reader = new StreamReader(input);
            
            var vCount = ReadInt32(reader);
            var eCount = ReadInt32(reader);

            vertexs = new int[vCount];
            edges = new int[vCount, vCount];

            for (int i = 0; i < eCount; i++)
            {
                var edge = ReadInt32Pair(reader);
                edges[edge.Item1, edge.Item2] = 1;
            }
        }

        private int ReadInt32(TextReader reader)
        {
            return int.Parse(reader.ReadLine().Trim());
        }

        private Tuple<int, int> ReadInt32Pair(TextReader reader)
        {
            var edge = reader.ReadLine().Split(',');
            return new Tuple<int, int>(int.Parse(edge[0]), int.Parse(edge[1]));
        }



        IEnumerator<int> AdjacentVertex(int vIndex)
        {
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                if(edges[vIndex, i] == 1)
                {
                    yield return i;
                }
            }
        }



    }
}
