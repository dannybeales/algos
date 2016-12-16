using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace LinkedListTesting
{
    [TestFixture]
    class Testing
    {
        [Test]
        public void InsertBeginning(T)
        {
            LinkedList<T> list = new LinkedList();

            list.InsertBeginning(1);
            Assert.That(list.Length(), Is.EqualTo(1));

        }

        [Test]
        public void InsertAfter()
        {
            LinkedList<T> list = new LinkedList();

            list.InsertAfter(2);
            Assert.That(list.Length(), Is.EqualTo(2));

           


        }




    }
}
