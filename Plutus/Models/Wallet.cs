using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Plutus.Database;
using Plutus.Models.Interfaces;
using Plutus.Models.Transactions;

namespace Plutus.Models
{
    public sealed class Wallet : IWallet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = "My Plutus";
        public decimal? Balance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public List<Achievement> Achievements { get; set; } = new List<Achievement>();

        public Account? Account { get; set; }

        public void AddTransaction(Transaction transaction)
        {
            switch (transaction.TransactionType)
            {
                case Enums.TransactionType.Income:
                    Balance += transaction.Amount;
                    break;
                case Enums.TransactionType.Expense:
                    Balance -= transaction.Amount;
                    break;
            }
            using ApplicationContext db = new();
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public void CheckAchievements()
        {
            throw new NotImplementedException();
        }
    }
}
