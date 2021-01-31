using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        public List<Product> GetAllByCategory(int categoryId);
       
    }
}
