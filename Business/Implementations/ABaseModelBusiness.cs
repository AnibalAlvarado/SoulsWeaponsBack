using Business.Interfaces;
using Entity.Dtos;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public abstract class ABaseModelBusiness<T,D> : IBaseModelBusiness<T,D> where T : BaseModel where D : BaseDto
    {
        public abstract Task<List<D>> GetAll();
        public abstract Task<D> GetById(int id);
        public abstract Task<D> Save(D entity);
        public abstract Task Update(D entity);
        public abstract Task<bool> PermanentDelete(int id);
        public abstract Task<int> Delete(int id);
    }
}
