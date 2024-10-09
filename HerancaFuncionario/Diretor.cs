using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
        }


        //Retorno de 10% do salário + 1000
        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao()+1000;
        }
    }
}