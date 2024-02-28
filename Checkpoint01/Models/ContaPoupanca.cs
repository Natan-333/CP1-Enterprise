using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01.Models
{
    internal class ContaPoupanca: Conta
    {
        private double rentabilidade;

        public ContaPoupanca()
        {
        }

        public double Rentabilidade { get => rentabilidade; set => rentabilidade = value; }

        public override bool Equals(object? obj)
        {
            return obj is ContaPoupanca poupanca &&
                   base.Equals(obj) &&
                   rentabilidade == poupanca.rentabilidade;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), rentabilidade);
        }
    }
}
