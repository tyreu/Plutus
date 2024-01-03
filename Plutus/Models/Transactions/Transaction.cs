using Plutus.Enums;
using Plutus.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Plutus.Models.Transactions
{
    public class Transaction : ITransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required TransactionType TransactionType { get; set; }
        public required string AccountNumber { get; set; }
        public required decimal Amount { get; set; }
        public Currency Currency { get; set; } = Currency.PLN;
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }

        public Category BaseCategory
        {
            get
            {
                if (Category is not null)
                {
                    if (Category?.GetType()?.Name == "Category")//if it's Category, then BaseName is Category
                    {
                        return Category;
                    }
                    return Category!.BaseCategory.GetType().FullName!.Equals(typeof(Category).FullName, System.StringComparison.Ordinal)
                        ? Category//if it's some Category, like House, Car, etc., then BaseName is House, Car, etc.
                        : Category.BaseCategory;//otherwise BaseName is House, Car, etc.
                }
                else { return new Unknown(); }
            }
        }

        public Wallet? Wallet { get; set; }

        public override string ToString() => $"{nameof(Transaction)}, {Category} – #{TransactionType}, {Amount} {Currency}, {Date:g} — {Description}";
    }
}
