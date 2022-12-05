using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Financias.Entidades
{
    class PessoaFisica : Contrato
    {
        
        public int ID { get; set; }
        
        public string CPF { get; set; }
        public int Idade { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(int id, string cpf, int idade, int numero, string contratante, double valor, int prazo) : base(numero, contratante, valor, prazo)  
        {
            
            ID = id;
            CPF = cpf;
            Idade = idade;
        }

         

        public override double CalcularPrestacao()
        {
            return (Valor / Prazo);

            if (Idade <= 30)
            {
                return CalcularPrestacao() + 1;
            }
            if (Idade <= 40)
            {
                return CalcularPrestacao() + 2;
            }
            if (Idade <= 50)
            {
                return CalcularPrestacao() + 3;
            }
            if (Idade > 50)
            {
                return CalcularPrestacao() + 4;
            }
        }

        
        public virtual string ExibirInfo()
        {
            return "O contrato de " + Contratante+ ", "+Idade+" anos, custa $ "+ Valor + ", sua prestação $" + CalcularPrestacao() + " prazo de " + Prazo + " meses.";
        }

    }
}
    
    


