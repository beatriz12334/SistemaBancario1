using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using System.Security.Cryptography.X509Certificates;

namespace SistemaBancario1.Models
{
    // Classe abstrata aplicando o pilar da abstração
    // Uma classe não pode ser instanciada
    public abstract class ContaBancaria
    {
        // Pilar Encapsulamento:Campos privados protegidos por
        // Propriedades publicas 
        private string _numeroConta;
        private decimal _saldo;
        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }
        //Propriedade públicas Saldo
        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }
        public string NomeTitular { get; set; }



        public List<string> ExtratoTransacoes { get; set; } = new List<string>();
        // Conastrutor
        protected ContaBancaria(string numeroConta, decimal saldoInicial, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"conta criada com saldo de R${saldoInicial:F2}");
        }
        //Método virtual (polimorfismo) 
        public virtual void Depositar(decimal valor)
        {
        if (valor > 0)
            {
                Saldo += valor;
                ExtratoTransacoes.Add($"Depósito: +R$ {valor:F2} | Saldo Atual: {Saldo:F2}");
            }
        }
        // Método abstrato: obriga 
        public abstract bool Sacar(decimal valor);
        



    }
}
