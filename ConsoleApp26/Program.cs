using System;
using System.Collections.Generic;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>();

            
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

           
            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

            
            HashSet<int> myhash2 = new HashSet<int>() {10,
                               100,1000,10000,100000};

           
            Console.WriteLine("Elements of myhash2:");
            foreach (var value in myhash2)
            {
                Console.WriteLine(value);
            }

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.Write(item + ",");

            int[] arr = new int[] { 1, 2, 3, 4 };
            myStack = new Stack<int>(arr);

            foreach (var item in myStack)
                Console.WriteLine(item + ",");

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek()); 
                Console.WriteLine(myStack.Peek()); 
            }

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count);

            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); 

            Console.WriteLine("Total elements: {0}", strQ.Count);

           strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            if (strQ.Count > 0)
            {
                Console.WriteLine(strQ.Peek()); 
                Console.WriteLine(strQ.Peek()); 
            }

            Console.WriteLine("Total elements: {0}", strQ.Count);

             strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count); 

            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); 

            Console.WriteLine("Total elements: {0}", strQ.Count);

            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            SortedList<string, string> cities = new SortedList<string, string>()
            {
               {"London", "UK"},
               {"New York", "USA"},
               { "Mumbai", "India"},
               {"Johannesburg", "South Africa"}
            };

            numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };

            Console.WriteLine(numberNames[1]); 
            Console.WriteLine(numberNames[2]); 
            Console.WriteLine(numberNames[3]);

             numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

             numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };
            if (numberNames.ContainsKey(4))
            {
                numberNames[4] = "four";
            }

            int result;
            if (numberNames.TryGetValue(4, out result))
                Console.WriteLine("Key: {0}, Value: {1}", 4, result);


            IDictionary<int, string> numberNames1 = new Dictionary<int, string>();
            numberNames.Add(1, "One"); 
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

           

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            
            var cities1 = new Dictionary<string, string>()
            {
              {"UK", "London, Manchester, Birmingham"},
              {"USA", "Chicago, New York, Washington"},
              {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities1)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
