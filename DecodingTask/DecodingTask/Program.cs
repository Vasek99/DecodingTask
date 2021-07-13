using System;
using System.Collections.Generic;
using System.IO;

namespace DecodingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Could you please enter path to the message file?");
            string path = Console.ReadLine();
            List<Triplet> triplets = new List<Triplet>();
            try
            {
                StreamReader sr = File.OpenText(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split('#');
                    triplets.Add(new Triplet(arr[0], arr[1], arr[2]));
                }
            }
            catch (IOException)
            {
                Console.WriteLine("An IO error has occured. Did you enter the file name correctly?");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Could you please enter the intial triplet?");
            string initialTriplet = Console.ReadLine();
            
            string message = "";
            bool condition = true;
            //left triplet that will be looked for during each iteration
            string toFind = initialTriplet;
            while (condition)
            {
                condition = false;
                foreach (var triple in triplets)
                {
                    if (triple.Left == toFind)
                    {
                        condition = true;
                        message += triple.Message;
                        char[] array = triple.Right.ToCharArray();
                        Array.Reverse(array);
                        toFind = new String(array);
                        break;
                    }
                }
            }
            if (message.Length != 0) Console.WriteLine(message);
            else
            {
                Console.WriteLine("No message was decoded. Did you enter the first triplet correctly?");
            }
        }
    }
}
