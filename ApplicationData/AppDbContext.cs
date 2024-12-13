using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16.ApplicationData
{
    public class AppDbContext

    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }


    }

        public class Product { /* Свойства из таблицы Products */ }
        public class Category { /* Свойства из таблицы Categories */ }
        public class Material { /* Свойства из таблицы Materials */ }
        public class Color { /* Свойства из таблицы Colors */ }
        public class Country { /* Свойства из таблицы Countries */ }


    }

