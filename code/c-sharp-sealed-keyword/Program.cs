using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_sealed_keyword
{
    public class Staff
    {
        public virtual int BaseSalary { get; set; }

        // Compiler Error because method is not marked override
        //public sealed void DoSomething() { }

        public virtual void DoSomething()
        {

        }
    }

    public class Manager : Staff
    {
        public sealed override int BaseSalary { get; set; }

        // Compiler Error because method should be marked as override while using sealed keyword
        //public sealed void DoSomething() { }

        public sealed override void DoSomething()
        {

        }
    }

    public class TManager : Manager
    {
        // Compiler Error: Since you cannot override sealed property or a method
        //public sealed override int BaseSalary { get; set; }

        public void Test()
        {
            // Compiler Error cannot use 'sealed' keyword for local variables
            //sealed int hours = 10;
        }
    }
}
