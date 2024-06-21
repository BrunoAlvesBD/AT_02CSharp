using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_02CS
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(double saldo, double limite): base(saldo, limite)
        {
        }
        //construtor vazio para aceitar a entrada de usuário
        public ContaCorrente():base(0,0) { }

        public override void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("valor deve ser maior que 0");
            }
            //chamendo o metodo para alterar o saldo
            AlterarSaldo(valor);
            Console.WriteLine($"Deposito de {valor:c} realizado com sucesso!");

        }

        public override void Sacar(double valor)
        {
            if (valor <= 0) 
            {
                throw new ArgumentException("Valor do saque deve ser maior que 0");
            }
            if (valor > Saldo +Limite)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            AlterarSaldo(-valor);

            Console.WriteLine($"saque de {valor:c} realizado com sucesso!");
        }
    }
}
