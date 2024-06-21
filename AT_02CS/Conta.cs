using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_02CS
{
    internal abstract class Conta
    {
        private double _saldo;
        private double _limite;

        public double Saldo  => _saldo;
        public double Limite
        {
            get => _limite;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("limite não pode ser negativo");
                }
                _limite = value;
            }
        }
        public Conta(double saldo, double limite)
        {
            _saldo = saldo;
            Limite = limite;

        }
        public Conta() { }
        //metodo para acessar e alterar o atributo somente leitura _saldo
        protected void AlterarSaldo(double valor)
        {
            _saldo += valor;
        }

        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
    }
}
