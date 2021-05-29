/**
 * File             :   Program.cs
 * Project          :   None
 * Programmer       :   Braiden Gole
 * First version    :   2021-05-29
 * Description      :   This is a depth first traversal implementation.
 */
using System;

namespace CSharpDepthFirstTraversal
{
    class Program
    {
        private const int rowLength = 8;
        private const int columnLength = 8;
        private static char[] letters;
        private static bool[,] visitedNodes;

        private static void DepthFirstTraversal(int[,] graph)
        {
            for (int rows = 0; rows < rowLength; rows++)
            {
                for (int cols = 0; cols < columnLength; cols++)
                {
                    if (graph[rows, cols] == 1)
                    {   
                        if (visitedNodes[rows, cols] == false)
                        {
                            visitedNodes[rows, cols] = true;
                            Console.WriteLine("Hit: " + letters[cols]);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {   
            letters = new char[rowLength] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            visitedNodes = new bool[rowLength, columnLength];

            // Set all nodes to false meaning that they have not been visited.
            for (int rows = 0; rows < rowLength; rows++)
            {
                for (int cols = 0; cols < columnLength; cols++)
                {
                    visitedNodes[rows, cols] = false;
                }
            }
            
            int[,] graph = new int[rowLength, columnLength]
            {
                {0, 1, 0, 1, 1, 1, 0, 1},
                {1, 1, 1, 0, 1, 0, 0, 1},
                {0, 1, 0, 1, 1, 1, 0, 1},
                {0, 0, 0, 1, 0, 1, 0, 0},
                {0, 1, 0, 1, 0, 0, 0, 1},
                {0, 0, 0, 1, 1, 1, 0, 1},
                {0, 0, 0, 0, 1, 1, 0, 1},
                {0, 1, 0, 1, 1, 0, 0, 1},
            };

            DepthFirstTraversal(graph);
        }
    }
}
