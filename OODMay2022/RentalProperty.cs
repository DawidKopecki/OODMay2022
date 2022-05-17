using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODMay2022
{
    public class RentalProperty
    {
        public RentalType TypeOfRental;

        public int ID { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        
    }
    public enum RentalType
    {
        House, Flat, Share
    }

    public class RentData:DbContext
    {
        public RentData() : base("MyPropertyData") { }

        public DbSet <RentalProperty> RentalProperties { get; set; }
    }
}
