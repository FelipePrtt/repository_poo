using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    // Esquerda = Classe Derivada/Subclasse, : = Herança/Herda de, Direita Classe Pai/Superclasse
    public class ClienteFisico : Cliente // : representa a herança -> X :(herda de) Y
    {
        private int cpf;
        private int rg;

        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public ClienteFisico() : base()
        {
            
        }

        public ClienteFisico(int codigo, string nome, int cpf, int rg) : base(codigo, nome)
        {
            Cpf = cpf;
            Rg = rg;
        }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"CPF: {Cpf}\nRG: {Rg}");
            /*
            base() chama construtor
            base.Método chama um método da superclasse 
            */
        }
    }
}