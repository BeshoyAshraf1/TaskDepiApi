using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2G1.DAL;

public interface IGenericRepository<TEntity> where TEntity : class
{
    List<TEntity> GetAll();
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    void Delete(Guid id);
    void SaveChanges();
}
