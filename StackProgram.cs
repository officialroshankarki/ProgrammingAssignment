
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class StackProgram
    {
        static void Main(string[] args)
        {
         

            Stack<int> stack = new Stack<int>();

            static void PrintStack(Stack<int> stack)
            {
                Console.WriteLine("The data of stack:");
                for (int i = 1; i <= stack.data.Count; i++)
                {
                    Console.WriteLine($"{i}: {stack.data[i]}");
                }
            }

            Console.WriteLine($"The stack is empty: {stack.IsEmpty()}");

            stack.Push(10);
            PrintStack(stack);

            stack.Push(1);
            PrintStack(stack);

            stack.Push(15);
            PrintStack(stack);

            Console.WriteLine($"The stack is empty: {stack.IsEmpty()}");

            int popValue = stack.Pop();
            PrintStack(stack);
            Console.WriteLine($"The popped value is: {popValue}.");


            stack.Push(12);
            PrintStack(stack);

            stack.Push(13);
            PrintStack(stack);

            popValue = stack.Pop();
            PrintStack(stack);
            Console.WriteLine($"The popped value is: {popValue}.");

            Console.WriteLine($"Empty Stack: {stack.IsEmpty()}");

            int peekValue = stack.Peek();
            Console.WriteLine($"The peeked value is: {peekValue}.");

            Console.ReadKey();
        }
    }
}

