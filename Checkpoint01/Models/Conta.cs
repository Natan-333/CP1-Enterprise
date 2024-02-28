using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01.Models
{
    internal class Conta
    {
        private int agencia;
        private int numero;
        private double saldo;

        public Conta()
        {
        }

        public int Agencia { get => agencia; set => agencia = value; }
        public int Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
