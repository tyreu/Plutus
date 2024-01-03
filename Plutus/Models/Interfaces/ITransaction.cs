using Plutus.Enums;
using System;

namespace Plutus.Models.Interfaces
{
    interface ITransaction
    {
        int Id { get; set; }
        TransactionType TransactionType { get; set; }
        string AccountNumber { get; set; }
        decimal Amount { get; set; }
        Currency Currency { get; set; }
        DateTime Date { get; set; }
        Category Category { get; set; }
        string Description { get; set; }
    }
}
