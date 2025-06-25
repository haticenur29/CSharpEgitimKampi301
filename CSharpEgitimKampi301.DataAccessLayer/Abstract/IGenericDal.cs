using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class //dışarıdan bir T değeri alacak ve şartımız T değerinin bir class olması
    {
        //buradaki T değeri sırasıyla bizim bütün entity'lerimiz olacak: Category, Customer, Order, Product vs.

        void Insert(T entity); //T türünde bir entity parametresi alsın
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(); //bütün verileri getirecek olan GetAll isminde metot
        T GetById(int id); //T türünde GetById isminde dışarıdan int id parametresi alan bir metot tanımlamış olduk


    }
}
