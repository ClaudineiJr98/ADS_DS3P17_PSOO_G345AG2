using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aluno:Pessoa
    {
        public Aluno(string nome, string ra) : base(nome, ra)
        {
        }
        public bool DocumentoAluno()
        {
            return RA == "G345AG2";
        }
    }
}
