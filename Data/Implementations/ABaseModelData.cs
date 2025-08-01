using Data.Interfaces;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public abstract class ABaseModelData<T> : IBaseModelData<T> where T : BaseModel
    {
        public abstract Task<IEnumerable<T>> GetAll();
        public abstract Task<T> GetById(int id);
        public abstract Task<T> Save(T entity);
        public abstract Task Update(T entity);
        public abstract Task<bool> PermanentDelete(int id);
        public abstract Task<int> Delete(int id);
    }
}
