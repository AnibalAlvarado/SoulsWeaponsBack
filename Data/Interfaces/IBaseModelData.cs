using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBaseModelData<T> where T: BaseModel
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Save(T entity);
        Task Update(T entity);
        Task<bool> PermanentDelete(int id);
        Task<int> Delete(int id);
    }
}
