using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace UtilizandoOTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Analisador.AnalisarGravarUsuario(10);
            Console.WriteLine();
            Console.WriteLine();
            Analisador.AnalisarGravarUsuario(1000);
            Console.ReadKey();
        }
    }
}
