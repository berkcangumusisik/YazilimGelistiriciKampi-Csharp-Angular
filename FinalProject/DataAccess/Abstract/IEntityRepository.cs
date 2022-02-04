using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

/*
 * Expression<Func<T,bool>> filter filtreleme işlemini sağlıyor
 * Generic constraint Generic kısıt vermektir. Veritabanı nesneleri dışında veri yazmayı önler.
 * class demek referans tip olabilir demektir.
 * IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
 * new():newlenebilir olması gerekliliğini belirtir.
 */