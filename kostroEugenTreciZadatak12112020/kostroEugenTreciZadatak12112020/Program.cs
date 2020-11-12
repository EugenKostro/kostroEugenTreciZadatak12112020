using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenTreciZadatak12112020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite prvi string: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Upisite drugi string: ");
            string s2 = Console.ReadLine();
            Console.WriteLine("Upisite treci string: ");
            string s3 = Console.ReadLine();


            string a = s1 + s2 + s3;
            a = new string(a.Reverse().ToArray());
            Console.WriteLine(a);


            Console.ReadKey();

           

        }
    }
}
