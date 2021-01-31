using DataAcccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15 },
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitInStock=3 },
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitInStock=2 },
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitInStock=65 },
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitInStock=1 }
            };
        }
             
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        { 
            Product ProductToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(ProductToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            ProductToUpdate.CategoryId = product.CategoryId;
            ProductToUpdate.UnitInStock = product.UnitInStock;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.ProductName = product.ProductName;

        }
        
    }
}
