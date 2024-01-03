using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Plutus.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Category BaseCategory => new();
        public override string ToString() => nameof(Category);

    }

    public class Unknown : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Unknown);
    }

    public class Income : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Income);
    }

    public class DirectTransfer : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => "Direct transfer";
    }

    public class Car : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Car);

        public class Gas : Car
        {
            public override Category BaseCategory => new Car();
            public override string ToString() => nameof(Gas);
        }
        public class Engine : Car
        {
            public override Category BaseCategory => new Car();
            public override string ToString() => nameof(Engine);
        }
        public class Tires : Car
        {
            public override Category BaseCategory => new Car();
            public override string ToString() => nameof(Tires);
        }
        public class Wash : Car
        {
            public override Category BaseCategory => new Car();
            public override string ToString() => nameof(Wash);
        }
    }

    public class House : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(House);
    }

    public class Groceries : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Groceries);
    }

    public class Restaurants : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Restaurants);
    }

    public class Health : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Health);
    }

    public class Taxi : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Taxi);
    }

    public class Flowers : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Flowers);
    }

    public class Sport : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Sport);
    }

    public class Entertainment : Category
    {
        public override Category BaseCategory => new();
        public override string ToString() => nameof(Entertainment);
    }
}
