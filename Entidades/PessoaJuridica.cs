using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financias.Entidades
{
    class PessoaJuridica : Contrato
    {
       
        public double CNPJ { get; set; }
        public string Inscricao { get; set; }

        public PessoaJuridica ()
    {
    }
     
        public PessoaJuridica(double cnpj, string inscricao, int numero, string contratante, double valor, int prazo) : base(numero, contratante, valor, prazo)
        {
            
            CNPJ = cnpj;
            Inscricao = inscricao;
        }


        public override double CalcularPrestacao()
        {
            return ((Valor / Prazo) + 3);
        }

        public override string ExibirInfo()
        {
            return "Seu contrato custa $" + Valor + ", sua prestação $" + CalcularPrestacao() + " prazo de " + Prazo + " meses.";
        }
    }
}
