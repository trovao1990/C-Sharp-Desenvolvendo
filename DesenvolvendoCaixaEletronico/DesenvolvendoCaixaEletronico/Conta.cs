using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesenvolvendoCaixaEletronico
{
    class Conta
    {
 
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get;  protected set; }

        public void Saca(double valorSaque)
        {
            this.Saldo -= valorSaque;
        }

        public void Deposita(double valorDeposito)
        {
            this.Saldo += valorDeposito;
        }
        
    }
}
