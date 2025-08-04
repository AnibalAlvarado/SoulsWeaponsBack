using Entity.Dtos;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Interfaces
{
    public interface IBaseModelController<T,D> where T : BaseModel where D : BaseDto
    {
        public Task<ActionResult<IEnumerable<D>>> GetAll();
        public Task<ActionResult<D>> GetById(int id);
        public Task<ActionResult<D>> Save(D dto);
        public Task<ActionResult<D>> Update(D dto);
        public Task<ActionResult> PermanentDelete(int id);
        public Task<ActionResult> Delete(int id);
    }
}
