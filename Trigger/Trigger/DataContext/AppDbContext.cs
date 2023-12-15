using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

using Xamarin.Forms;

namespace Trigger.DataContext
{
    public class AppDbContext : DbContext
    {
        //Path donde se va guardar la base de datos
        string DbPath = string.Empty;


        //Tablas de base de datos
        public DbSet<Person> People { get; set; }
        public DbSet<Compra> Buys { get; set; }



        //Estándar del desarrollo con EFC
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }

    }
}