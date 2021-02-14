﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    // Generic Constraint - Generic Kısıt
    // class : referans tip olabilir
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> 
        where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> fiter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
