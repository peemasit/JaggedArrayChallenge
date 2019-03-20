using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayChallenge {
    class Program {
        static void Main(string[] args) {
            string[][] friend = new string[][] {
                new string [] {"Martha","Joe"},
                new string [] {"Peem","Phoom"},
                new string [] { "Michael", "Pam" }
            };
            Console.WriteLine($"Hi {friend[1][0]}, i would like to introduce {friend[0][1]} to you");
            Console.WriteLine($"Hi {friend[2][0]}, i would like to introduce {friend[1][1]} to you");
            Console.WriteLine($"Hi {friend[0][0]}, i would like to introduce {friend[2][1]} to you");
            Console.Read();
        }
    }
}
