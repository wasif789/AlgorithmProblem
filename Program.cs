using System;
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
            Console.WriteLine("Enter 4-to Perform bubble Sort");
            Console.WriteLine("Enter 5-to Perform Merge Sort");
            Console.WriteLine("Enter 6-to check anagram or not");
            Console.WriteLine("Enter 7-to check Prime in a given range and print anagram and palindrome");
            Console.WriteLine("Enter 8-to play a guess number");
            Console.WriteLine("Enter 9-to message demonstration using regex");
            //Creating generics Object for generic Class
            BinarySearchInList<string> binarySearchInList = new BinarySearchInList<string>();
            InsertionSort<int> insertion = new InsertionSort<int>();
            BubbleSort<int> bubbleSort = new BubbleSort<int>();
            MergeSorting<int> obj = new MergeSorting<int>();
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
                    List<string> wordList = new List<string>(txtpath.Split(" "));
                    wordList.Sort();
                    binarySearchInList.BinarySearch(wordList);
                    break;

                case 3:
                    List<int> arr = ArrayInput();
                    insertion.InsertionSorting(arr);
                    break;

                case 4:
                    List<int> buubleSort = ArrayInput();
                    bubbleSort.BubbleSorting(buubleSort);
                    break;
                case 5:
                    List<int> mergeSort = ArrayInput();
                    mergeSort = obj.MergeSort(mergeSort);
                    Console.WriteLine("*****BUBBLE SORT*****");
                    insertion.Display(mergeSort);
                    break;
                case 6:
                    Anagram.CheckAnagram();
                    break;
                case 7:
                    Console.WriteLine("Enter Start range");
                    int start = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter end range");
                    int end = Convert.ToInt32(Console.ReadLine());
                    PrimeCheck.PrimeChecker(start, end);
                    break;
                case 8:
                    GuessANumber obj1 = new GuessANumber();
                    obj1.ThinkANumber();
                    break;
                case 9:
                    MessageDemonstartion.GetInput();
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
