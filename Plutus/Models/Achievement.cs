using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Plutus.Models
{
    public class Achievement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ActualQuantity { get; set; } = 0;
        public int ExpectedQuantity { get; set; } = 0;
        public override string ToString() => $"{Name} – {ActualQuantity}/{ExpectedQuantity}";

        public Wallet? Wallet { get; set; }

        public static Achievement operator ++(Achievement achievement)
        {
            achievement.ActualQuantity++;
            return achievement;
        }
    }
}