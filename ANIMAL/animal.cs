using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMAL
{
    internal class animal
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string tipo;
        public string Tipo
        {//valores definidos pelo dev = cao gato e peixe ( encapsulamento abaixo )
            get { return tipo; }
            set
            { 
                if(value == "cao" || value == "gato" || value == "peixe")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "peixe";
                }
                tipo = value;
            }
        }

    }
}
