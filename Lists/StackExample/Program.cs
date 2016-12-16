using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            while (!stack.ISEmpty())
                
            { 
                int output;
                stack.Pop(out output);
                Console.WriteLine(output);
            }
       

            Console.Read();
        }
    }
}
