using System;

namespace Bank.WebApi.Models
{
    /// <summary>
    /// Representa una cuenta bancaria con funcionalidades básicas de débito y crédito.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        /// <summary>
        /// Constructor privado para evitar instanciación sin parámetros.
        /// </summary>
        private BankAccount() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="BankAccount"/> con el nombre del cliente y el saldo inicial.
        /// </summary>
        /// <param name="customerName">Nombre del cliente.</param>
        /// <param name="balance">Saldo inicial de la cuenta.</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>
        /// Obtiene el nombre del cliente asociado a la cuenta bancaria.
        /// </summary>
        public string CustomerName { get { return m_customerName; } }

        /// <summary>
        /// Obtiene el saldo actual de la cuenta bancaria.
        /// </summary>
        public double Balance { get { return m_balance; } }

        /// <summary>
        /// Resta un monto al saldo de la cuenta.
        /// </summary>
        /// <param name="amount">Monto a debitar.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Se lanza si el monto es negativo o mayor al saldo disponible.
        /// </exception>
        public void Debit(double amount)
        {
            if (amount > m_balance)
                throw new ArgumentOutOfRangeException(nameof(amount), "El monto excede el saldo disponible.");
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "El monto no puede ser negativo.");
            m_balance -= amount;
        }

        /// <summary>
        /// Agrega un monto al saldo de la cuenta.
        /// </summary>
        /// <param name="amount">Monto a acreditar.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Se lanza si el monto es negativo.
        /// </exception>
        public void Credit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "El monto no puede ser negativo.");
            m_balance += amount;
        }
    }
}
