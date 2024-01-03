using Plutus.Models.Transactions;

namespace Plutus.Models.Interfaces
{
    internal interface IWallet
    {
        public void AddTransaction(Transaction transaction);

        public void CheckAchievements();
    }
}