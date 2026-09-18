using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes = 
                {"juan", "ana", "carlos", "pedro", "josue"};
            for(int i = 0; i < estudiantes.Length; i++)
                Console.WriteLine($"indice[{i}]: {estudiantes[i]}");
        }
    }
}
