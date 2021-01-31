﻿using Business.Concrete;
using DataAcccess.Abstract;
using DataAcccess.Concrete.EntityFramework;
using DataAcccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductMenager productMenager = new ProductMenager(new InMemoryProductDal());
            foreach (var product in productMenager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
