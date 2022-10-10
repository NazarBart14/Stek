using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var stack = new Stack<int>();

           
            stack.Push(2);
            stack.Push(19);
            stack.Push(34);
            stack.Push(245);
            stack.Push(2490);
            Console.Write($"В стек є {stack.Count} елементів.");

            
            var item1 = stack.Pop();
            Console.WriteLine($"Верхній елемент {item1}.");
            var item2 = stack.Pop();
            Console.WriteLine($"Перед останній елеметн {item2}.");

           
            stack.Push(455);
            var item3 = stack.Peek();
            Console.WriteLine($"Новий верхній елемент {item3}.");
            var item4 = stack.Peek();
            Console.WriteLine($"Новий верхній елемент {item4}.");

            Console.ReadLine();
        }
    }
}