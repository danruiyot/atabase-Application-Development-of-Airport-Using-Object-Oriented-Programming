using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sporting2021_power.Models
{
//     public class SportingPower
//     {
//         public DbSet<Technician> Technician { get; set; }
//         public DbSet<Customer> Customer { get; set; }
//         public DbSet<Product> Product { get; set; }
//         public DbSet<Incident> Incident { get; set; }
// // overide
//         protected  void OnConfiguring(DbContextOptionsBuilder options)
//             => options.UseSqlite("Data Source=SportingPower.db");
//     }

    
    public class Technician
    {
        public int TechnicianId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }


    public class Customer
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }

        public int CoID { get; set; }
        
        [ForeignKey("CoID")]

        public Country Country { get; set; }
    }
    public class Product
    {
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ReleaseDate { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
     public class Registration
    {
        public int Id { get; set; }

        public int Product_id { get; set; } 
        [ForeignKey("Product_id")]
        
        public virtual Product Product { get; set; }

        public int Customer_id { get; set; }
        [ForeignKey("Customer_id")]

        public virtual Customer Customer { get; set; }
    }

    public class Incident
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public string DateOpened { get; set; }
        public string DateClosed { get; set; }

        public int TechId { get; set; } 
        [ForeignKey("TechId")]
        
        public virtual Technician Technician { get; set; }

        public int Customer_id { get; set; }
        [ForeignKey("Customer_id")]

        public virtual Customer Customer { get; set; }
 
    }
}