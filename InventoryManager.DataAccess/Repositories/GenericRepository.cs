﻿using System;
using System.Collections.Generic;
using System.Linq;
using InventoryManager.DataAccess.Abstract;
using InventoryManager.DataAccess.Concrete;

namespace InventoryManager.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T entity)
        {
            using var context = new Context();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new Context();
            context.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var context = new Context();
            context.Update(entity);
            context.SaveChanges();
        }

        public List<T> GetList()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }
    }
}