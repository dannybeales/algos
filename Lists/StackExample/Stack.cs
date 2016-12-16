using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTesting
{
    class Stack<T>
    {
        private List<T> stack; //calls on template on list.cs
        private int count; //keep private so other so external parts cannot change things

        public int Count { get { return count; } } //declaring a function that returns count, Makes Count Public while keeping count private.

        public Stack() //stack class
        {
            stack = new List<T>(); //instialize our stack
        }

        ~Stack() //Decronstructor - Signified with "~" - this will allow you to delete the memory clear the scope.
        {
            while (!ISEmpty())
            {
                T output;
                Pop(out output); //pass a value in, we dont care about it anymore as we are removing it
            }
        }
        public void Push(T data)
        {
            count++;
            stack.InsertBeginning(data);

        }
        public bool Pop(out T output)
        {

            //out and ref Keyword allows us to get more information out of a function. Generally a funtion gives one return back
            //we aslo want the value too so we use out, By spevifiyinh ht "out" key we are requesting the output of an argument
            //we are telling it this function is going to fill the value with something. 
            //ref keyword is saying we might use it, or we may not, so there is no expectation
            //Int passed by value, Out and Ref Keyword dont copy the value, pass the memory address around rather than copying the value



            output = default(T);

            if (ISEmpty()) 
                return false;

            output = stack.RemoveBeginning();

            count--;

            return true;

        }

        public bool ISEmpty()
        {
            return count == 0; // this is basically a one liner for if count == 0 return true, else return false.
        }

        //we want to look at the top of the stack but not remove it
        public T Peek()
        {
            return stack.Head; // find out what data is in head

        }



    }
}
