using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        /// <summary>
        /// Метод, который позволяет положить денежные средства на счёт
        /// </summary>
        /// <param name="amount">То количество денег, которое мы хотим положить на счёт</param>
        /// <exception cref="ArgumentOutOfRangeException">Ошибка, которая появляется, если параметр не подходит под условия</exception>
        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }


        /// <summary>
        /// Метод, который позволяет снять денежные средства со счёта
        /// </summary>
        /// <param name="amount">То количество денег, которое мы можем снять со счёта</param>
        /// <exception cref="ArgumentOutOfRangeException">Ошибка, которая появляется, если параметр не подходит под условия</exception>
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Roman Abramovich", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }
}
