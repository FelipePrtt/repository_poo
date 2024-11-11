using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public class Assalariado : Funcionario
    {
        public override double calcularSalario(int diasUteis)
        {
            return (Salario / 30) * diasUteis; 
        }
    }
}