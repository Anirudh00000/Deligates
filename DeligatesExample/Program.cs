using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Example delegateExamples = new Example();
                MyOperations myOperations = new MyOperations(delegateExamples.Addition);
                myOperations += new MyOperations(delegateExamples.Subtraction);
                myOperations(2, 9);
                Console.WriteLine("============================");
                List<Emp> emps = new List<Emp>
            {
                new Emp{Id =1, Name ="Anirudh",Exp=3,salary=10000},
                new Emp{Id =2, Name ="Rahul",Exp=4,salary=25000},
                new Emp{Id =3, Name ="Vickey",Exp=2,salary=320000},
                new Emp{Id =4, Name ="Rajan",Exp=5,salary=420000},
            };
                IsPrmote isPrmote = new IsPrmote(Emp.Prmote);
                //isPrmote()
                Emp.Prmotion(emps, isPrmote);
                Console.ReadKey();
            }
        }
    }
}
