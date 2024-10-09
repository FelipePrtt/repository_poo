using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionarioExercicio
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual void MostrarAtributos()
        {
            Console.WriteLine($"Código do funcionário:{Codigo}\nNome do funcionario:{Nome}\nSalário do funcionario{Salario}\n");
        }

        public virtual double CalcularBonificacao()
        {
            return Salario * 10/100; //ou 0.10
        }
    }
}