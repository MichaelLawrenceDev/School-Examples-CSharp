using System;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Collections.Concurrent;

namespace ParallelProgramming2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parallel For Example
            forexample();
            parallelforexample();

            // Directory size Example
            //Console.WriteLine("\nEnter File Path: ");
            //string read = Console.ReadLine();
            //Console.WriteLine("\n(Sequential) Directory Size: {0}", computeFilePath(read));
            //Console.WriteLine("(Parallel) Directory Size: {0}", ParallelComputeFilePath(read));

            ParallelExamples.matrixmultiply.matrixmain();

            Console.Read();

        }
        static void forexample()
        {
            Console.WriteLine("For Loop: ");
            for(int i = 0; i < 30; i++)
            {
                Thread.Sleep(1000);
                Console.Write(i + " ");
            }
        }
        static void parallelforexample()
        {
            // Parrallel.For(start, end, lambda);
            Console.WriteLine("\nParallel.For: ");
            Parallel.For(0, 30, i =>
            {
                Thread.Sleep(1000);
                Console.Write(i + " ");
            });
        }

        private static long computeFilePath(string filepath)
        {
            long totalsize = 0;
            string[] direc = Directory.GetDirectories(filepath);
            string[] files = Directory.GetFiles(filepath);

            foreach(string d in direc)
            {
                totalsize += computeFilePath(d);
            }

            foreach(string f in files)
            {
                FileInfo fi = new FileInfo(f);
                totalsize += fi.Length;
            }

            return totalsize;
        }

        private static long ParallelComputeFilePath(string filepath)
        {
            long totalsize = 0;
            string[] direc = Directory.GetDirectories(filepath);
            string[] files = Directory.GetFiles(filepath);

            ConcurrentBag<long> resultcollection = new ConcurrentBag<long>();

            Parallel.ForEach(direc, (currentDirectory) =>
            {
                resultcollection.Add(computeFilePath(currentDirectory));
            });

            foreach(long l in resultcollection)
            {
                totalsize += 1;
            }

            Parallel.ForEach(files, (f) =>
            {
                FileInfo fi = new FileInfo(f);
                totalsize += fi.Length;
                //resultcollection.Add(fi.Length);
            });

            return totalsize;
        }
    }
}
