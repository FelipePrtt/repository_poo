using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAlunoExercicio
{
    public class Aluno
    {
        //ATRIBUTOS
        private static long cont = 1570482313001;
        public long Matricula {get; set;}
        public string Nome {get; set;}



       //CONSTRUTORES

       //construtor sem parametro de nome
        public Aluno()
        {
            Nome = "N/A";
            Matricula = cont++;
        }

        //construtor com parametro de nome
        public Aluno(string nome)
        {
            this.Nome = nome;
            Matricula = cont++;
        }



        //MÉTODOS

        //método para mostrar os dados do aluno
        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome} \nN° de Matrícula: {Matricula}\n\n");
        }
    }
}