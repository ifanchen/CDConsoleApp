// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="-">
// Copyright © 2018
// </copyright>
// -----------------------------------------------------------------------
namespace CDConsoleApp
{
    using System;
    using CDUtility;
    
    /// <summary>
    /// Console application for demo
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Console application starting point.
        /// </summary>
        /// <param name="args">list of arguments</param>
        public static void Main(string[] args)
        {
            Question1();
            Question2();
            Question3();
            
            Console.WriteLine();
            Console.WriteLine("Press Enter to terminate...");
            Console.ReadLine();
        }

        #region Questions
        /// <summary>
        /// Q1. Reverse the order of words of a sentence
        /// </summary>
        private static void Question1()
        {                        
            Console.WriteLine("Q1: Reverse the order of words of a sentence");
            var input = "What a lovely day";
            Console.WriteLine("Input:" + input);
            Console.WriteLine("Output:" + StringUtility.RevereSentence(input));
            Console.WriteLine();         
        }

        /// <summary>
        /// Q2. Stack implementation
        /// </summary>
        private static void Question2()
        {
            Console.WriteLine("Q2: Stack implementation");
            var s = new StackContainer<string>();
            Console.WriteLine($"Stack initialized. stack size: {s.Size()} stack is empty? {s.IsEmpty()}");
            s.Push("item1");
            Console.WriteLine($"Push \"item1\" into stack. stack size: {s.Size()} stack is empty? {s.IsEmpty()}");
            s.Push("item2");
            Console.WriteLine($"Push \"item2\" into stack. stack size: {s.Size()} stack is empty? {s.IsEmpty()}");
            var popItem = s.Pop();
            Console.WriteLine($"Pop \"{popItem}\" out of stack. stack size: {s.Size()} stack is empty? {s.IsEmpty()}");
            popItem = s.Pop();
            Console.WriteLine($"Pop \"{popItem}\" out of stack. stack size: {s.Size()} stack is empty? {s.IsEmpty()}");
            Console.WriteLine();            
        }

        /// <summary>
        /// Q3: Get string contains only the characters found in both input strings.
        /// </summary>
        private static void Question3()
        {            
            Console.WriteLine("Q3: Get string contains only the characters found in both input strings.");
            var input1 = "Hello";
            var input2 = "World";
            Console.WriteLine($"The matching characters between \"{input1}\" and \"{input2}\" is \"{StringUtility.GetMatching(input1, input2)}\"");
        }
        #endregion
    }
}