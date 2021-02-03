﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Ipad Mini",UnitPrice=699,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Ipad Pro",UnitPrice=999,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="IMac",UnitPrice=699,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Macbook Pro 16",UnitPrice=1199,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="MacBook Air",UnitPrice=999,UnitsInStock=1},

            };

        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // Product productToDelete = _products.Find(prod => prod.ProductId == product.ProductId);
            Product productToDelete = null;
            productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);

             _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> Filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Find the product in the _products List
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}