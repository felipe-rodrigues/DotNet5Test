using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using API.Model;


namespace API.Data
{
    public class SquadContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=mypw;database=ef",
                new MySqlServerVersion(new Version(8,0,22)),
                mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend)
            );
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Squad> Squads { get; set; }
    }
}