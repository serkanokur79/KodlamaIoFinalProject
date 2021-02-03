using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;

namespace DataAccess.Abstract
{
    //Generic constraint
    //class : reference type
    // IEntity: IEntity or smthing implemented from IEntity
    //new(): can not be abstract

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
