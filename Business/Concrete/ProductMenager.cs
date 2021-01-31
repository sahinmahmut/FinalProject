using Business.Abstract;
using DataAcccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductMenager :IProductService
    {
        
        IProductDal _productDal;
        

        public ProductMenager(IProductDal productDal) {
            _productDal = productDal;
        }

       

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
