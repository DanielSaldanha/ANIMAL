using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal a1 = new animal();
            animal a2 = new animal();
            animal a3 = new animal();
            animal a4 = new animal();
            animal a5 = new animal();
            int tlcao = 0, tlgato = 0, tlpeixe = 0;
            Console.WriteLine("cntrole de animais");

            //PRIMEIRO ANIMAL

          //  Console.WriteLine("informe nome do primeiro animal: ");
         //  a1.Nome = Console.ReadLine();
            Console.WriteLine("informe o primeiro animal (cao, gato ou peixe)");
            a1.Tipo = Console.ReadLine();
            if (a1.Tipo == "cao") tlcao++;
            if (a1.Tipo == "gato") tlgato++;
            if (a1.Tipo == "peixe") tlpeixe++;

            //SEGUNDO ANIMAL

           // Console.WriteLine("informe nome do segundo animal: ");
          //  a2.Nome = Console.ReadLine();
            Console.WriteLine("informe o segundo animal (cao, gato ou peixe)");
            a2.Tipo = Console.ReadLine();
            if (a2.Tipo == "cao") tlcao++;
            if (a2.Tipo == "gato") tlgato++;
            if (a2.Tipo == "peixe") tlpeixe++;

            //TERCEIRO ANIMAL

          //  Console.WriteLine("informe nome do terceiro animal: ");
          //  a3.Nome = Console.ReadLine();
            Console.WriteLine("informe o terceiro animal (cao, gato ou peixe)");
            a3.Tipo = Console.ReadLine();
            if (a3.Tipo == "cao") tlcao++;
            if (a3.Tipo == "gato") tlgato++;
            if (a3.Tipo == "peixe") tlpeixe++;

            //RESULTADO
            Console.WriteLine("total de animais");
            Console.WriteLine("cao: "+tlcao+"\ngato: " +tlgato+"\npeixe: " +tlpeixe);
            Console.ReadLine();
        }
    }
}
