using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab23.Models
{
    
    

        public class Item
        {
        [Key]
            public int ID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
        }

        public class DBItemContext : DbContext
        {
            public DbSet<Item> Items { get; set; }
        }
    }
