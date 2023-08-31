using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string RA { get; set; }
        public Pessoa(string nome, string ra)
        {
            Nome = nome;
            RA = ra;
        }
    }
}
