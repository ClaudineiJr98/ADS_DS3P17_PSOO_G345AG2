using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** TRABALHO DE PSOO ***");
        Aluno aluno = new Aluno("Claudinei Santos", "G345AG2");

        Console.WriteLine("Nome: " + aluno.Nome);
        Console.WriteLine("RA: " + aluno.RA);

        if (aluno.DocumentoAluno())
        {
            Console.WriteLine("RA Valido");
        }
        else
        {
            Console.WriteLine("RA Invalido");
        }
    }
}