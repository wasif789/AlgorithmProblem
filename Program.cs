﻿using System;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs!");
            Console.WriteLine("Enter 1-to Calculate Permutation of a string");
            Console.WriteLine("Enter 2-to Perform Binary Search in a Word List");
            Console.WriteLine("Enter 3-to Perform Insertion Sort");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter a string to calculate Permutation");
                    string str = Console.ReadLine();
                    int n = str.Length;

                    Console.WriteLine("Permutation through Recursion Method");
                    Permutation.RecursivePermutation(str, 0, n - 1);

                    Console.WriteLine("\nPermutation through Iteration Method");
                    Permutation.IterativePermutation(str, n);

                    if (Permutation.recursiveList == Permutation.iterativeList)
                    {
                        Console.WriteLine("Both recursive and Iterative Method yield same array!");
                    }
                    else
                    {
                        Console.WriteLine("Both recursive and Iterative Method yield different array!");

                    }
                    break;

                case 2:
                    string txtpath = File.ReadAllText(@"C:\Users\wsffa\c#_projects\AlgorithmProblem\WordList.txt");
                    List<string> wordList = new System.Collections.Generic.List<string>(txtpath.Split(" "));
                    wordList.Sort();
                    BinarySearchInList.BinarySearch(wordList);
                    break;
                case 3:
                    List<int> arr = ArrayInput();
                    InsertionSort.InsertionSorting(arr);
                    break;
            }

        }

        //Get integer List from user
        public static List<int> ArrayInput()
        {
            Console.WriteLine("Enter the Array size");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> array = new List<int>();
            while (number-- > 0)
            {
                Console.WriteLine("Enter a number:");
                array.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return array;
        }
    }  
}
