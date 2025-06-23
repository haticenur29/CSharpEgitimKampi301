using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; } 
        //Product sınıfında tanımladığımız kategori tablosunu kategori tablosundan haberdar etmek için
        //Product tarafına tekil olarak CategoryId ekledik, çünkü her bir ürünün sadece bir tane kategorisi olacak
        //Ama bir kategori birden fazla ürün içerebilir
    }
}
