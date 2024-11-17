using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public class Departamento
    {
        //atributos
        private int codigo;
        private string descricao;
        public List<Funcionario> VetFuncionarios {get; set;}
        

        //gets e sets
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        //Construtores
        public Departamento()
        {
            VetFuncionarios = new List<Funcionario>();
        }
        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
            VetFuncionarios = new List<Funcionario>();
        }

        //métodos
        public double calcularFolhaPagamento(int diasUteis)
        { 
            double gastosTotais = 0;
            for (int i = 0; i < VetFuncionarios.Count; i++)
            {
                gastosTotais += VetFuncionarios[i].calcularSalario(diasUteis);
            }
            return gastosTotais;
        }
        public void admitirFuncionario(Funcionario funcionario)
        {
            VetFuncionarios.Add(funcionario);
        }
        public void demitirFuncionario(int id)
        {
            Funcionario funcionarioDemitido = null;
            foreach (Funcionario f in VetFuncionarios)
            {
                if (f.Codigo == id)
                {
                    funcionarioDemitido = f;
                    break;
                }

            }
            if (funcionarioDemitido != null)
            {
                VetFuncionarios.Remove(funcionarioDemitido);
                Console.WriteLine("Funcionário removido do sistema.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
        public void listaFuncionarios()
        {
            foreach (Funcionario f in VetFuncionarios)
            {
                Console.WriteLine($"Nome: {f.Nome}\t Salário: {f.Salario} Código: {f.Codigo}");
            }
        }
    }
}