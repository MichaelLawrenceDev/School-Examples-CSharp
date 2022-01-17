using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelExamples
{
    class matrixmultiply
    {
        static Random rand = new Random();
        public static void matrixmain()
        {
            while (true)
            {
                Stopwatch sw = new Stopwatch();

                Console.WriteLine("Dimensions for matrix A");
                Console.Write("Rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.Write("Columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());

                double[][] matrixA = createMatrix(rows, cols);
                populateMatrix(matrixA);

                Console.WriteLine("Dimensions for matrix B");
                Console.Write("Rows: ");
                rows = Convert.ToInt32(Console.ReadLine());
                Console.Write("Columns: ");
                cols = Convert.ToInt32(Console.ReadLine());

                double[][] matrixB = createMatrix(rows, cols);
                populateMatrix(matrixB);
                /*
                Console.WriteLine("Matrix A");
                printMatrix(matrixA);
                Console.WriteLine("Matrix B");
                printMatrix(matrixB);
                Console.WriteLine("Result");
                */
                try
                {
                    Console.WriteLine("Beginning Sequential matrix multiplication...");
                    sw.Start();
                    double[][] result = sequentialMultiply(matrixA, matrixB);
                    sw.Stop();
                    //printMatrix(result);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                TimeSpan ts = sw.Elapsed;
                Console.WriteLine("Done computing matrix in {0}.\n-----------------------------------",ts.TotalMilliseconds);
                Stopwatch sw2 = new Stopwatch();
                try
                {
                    Console.WriteLine("Beginning Parallel matrix multiplication...");
                    sw2.Start();
                    double[][] result = parallelMultiply(matrixA, matrixB);
                    sw2.Stop();
                    //printMatrix(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                TimeSpan ts2 = sw2.Elapsed;
                Console.WriteLine("Done computing matrix in {0}.\n-----------------------------------", ts2.TotalMilliseconds);
            }
        }
        
        private static double[][] parallelMultiply(double[][] matrixA, double[][] matrixB)
        {
            int aRows = matrixA.Length; int aCols = matrixA[0].Length;
            int bRows = matrixB.Length; int bCols = matrixB[0].Length;
            if (aCols != bRows)
                throw new Exception("Dimensional Mismatch");

            double[][] result = createMatrix(aRows, bCols);

            Parallel.For(0, aRows, i =>  // each Row of A
            {
                for (int j = 0; j < bCols; ++j) // each Col of B
                {
                    for (int k = 0; k < aCols; ++k)
                    {
                        result[i][j] += matrixA[i][k] * matrixB[k][j];
                    }
                }
            });

            return result;
        }
        
        private static double[][] sequentialMultiply(double[][]matrixA, double[][]matrixB)
        {
            int aRows = matrixA.Length; int aCols = matrixA[0].Length;
            int bRows = matrixB.Length; int bCols = matrixB[0].Length;
            if (aCols != bRows)
                throw new Exception("Dimensional Mismatch");

            double[][] result = createMatrix(aRows, bCols);

            for (int i = 0; i < aRows; ++i) // each row of A
                for (int j = 0; j < bCols; ++j) // each col of B
                    for (int k = 0; k < aCols; ++k) // could use k < bRows
                        result[i][j] += matrixA[i][k] * matrixB[k][j];

            return result;
        }

        private static void printMatrix(double [][]matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write("{0}\t",matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

        private static double[][] createMatrix(int rows, int cols)
        {
            double[][] m = new double[rows][];

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                    m[j] = new double[cols];   
            }

            return m;
        }

        private static void populateMatrix(double [][]matrix)
        {
            for(int i =0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = ((rand.Next() % 20) - 9);
                }
            }
        }
    }
}
