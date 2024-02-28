using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01.Models
{
    internal class ContaCorrente: Conta
    {
        private double chequeEspecial;
        public ContaCorrente()
        {
        }

        public double ChequeEspecial { get => chequeEspecial; set => chequeEspecial = value; }

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
