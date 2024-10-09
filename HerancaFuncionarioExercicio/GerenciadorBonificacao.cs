using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionarioExercicio
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.TotalBonificacao += secretario.CalcularBonificacao();
        }   

        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.TotalBonificacao += gerente.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.TotalBonificacao += diretor.CalcularBonificacao();
        }
    }
}