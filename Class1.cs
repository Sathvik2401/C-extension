using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class Assembly1Class1
    {
        protected internal int Id = 101;

    }
    public class Assembly1Class2
    {
        public void SampleMethod()
        {
            Assembly1Class1 A1 = new Assembly1Class1();
            Console.WriteLine(A1.Id);
            Console.ReadKey();
        }
    }

}
