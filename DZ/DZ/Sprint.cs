namespace DZ
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Sprint : DbContext
    {
        public Sprint()
            : base("name=Sprint")
        {
        }
        public DbSet<Player> Players { get; set; }
    }
}