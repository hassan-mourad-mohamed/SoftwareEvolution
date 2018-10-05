using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hassan");
            var firstStudent = new Student()
            {
                Name = "hassan mourad mohamed",
                level = LevelEnum.four,
                GPA = 2.5 
            };
        }
    }
}
