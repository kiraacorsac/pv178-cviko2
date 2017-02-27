using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConcepts_04
{
    public abstract class BaseAbstractClass
    {
        protected int number;
        /// <summary>
        /// properties can also be abstract
        /// </summary>
        public abstract int Number
        {
            get;
        }

        public abstract int Add(int num1, int num2);
        public abstract int Multiply(int num1, int num2);
    }

    public abstract class DerivedAbstractClass : BaseAbstractClass
    {
        //Implementing AddTwoNumbers
        public override int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class DerivedClass : DerivedAbstractClass
    {
        //Implementing Number property - with an expression body :)
        public override int Number => 42;

        public override int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
