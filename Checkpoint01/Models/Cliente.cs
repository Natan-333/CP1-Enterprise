using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01.Models
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private int idade;
        private string email;
        private Conta conta;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Email { get => email; set => email = value; }
        internal Conta ContaCliente { get => conta; set => conta = value; }

        public Cliente()
        {
        }


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
