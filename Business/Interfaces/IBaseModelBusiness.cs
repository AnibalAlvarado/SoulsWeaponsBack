using Entity.Dtos;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IBaseModelBusiness<T,D> where T : BaseModel where D : BaseDto
    {
        Task<List<D>> GetAll();
        Task<D> GetById(int id);
        Task<D> Save(D entity);
        Task Update(D entity);
        Task<bool> PermanentDelete(int id);
        Task<int> Delete(int id);
    }
}
