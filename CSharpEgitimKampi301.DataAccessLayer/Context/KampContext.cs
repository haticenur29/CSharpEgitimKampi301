using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext : DbContext
    {
        //bir sınıfı veritabanına tablo olarak yansıtmak istiyorsan mutlaka
        //KampContext içinde yer almalı

        public DbSet<Category> Categories { get; set; }
        //buradaki Category--> bizim c# tarafında kullanacak olduğumuz sınıfımızın ismi
        //buradaki Categories ifadesi--> SQL'e yansıyacak olan tablo ismi!!!
        //sınıfla tablo birbirinin içerisine girmesin diye yalın hali class olsun çoğul hali tablo olsun

        public DbSet<Product> Products { get; set; }
        //DbSet--> bunun bir tablo olduğunu uygulamaya bildirdiğim kısım

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
