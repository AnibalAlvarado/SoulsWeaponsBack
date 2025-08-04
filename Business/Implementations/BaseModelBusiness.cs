using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Business.Implementations
{
    public class BaseModelBusiness<T, D> : ABaseModelBusiness<T, D> where T : BaseModel where D : BaseDto
    {
        private readonly IBaseModelData<T> _data;
        private readonly IMapper _mapper;

        public BaseModelBusiness(IBaseModelData<T> data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public override async Task<bool> PermanentDelete(int id)
        {
            if (id <= 0)
                throw new ValidationException(nameof(id) + "El ID debe ser mayor que cero.");

            var success = await _data.PermanentDelete(id);
            if (!success)
                throw new InvalidOperationException(typeof(T).Name + " no pudo ser eliminado permanentemente.");

            return true;
        }
        public override async Task<int> Delete(int id)
        {
            if (id <= 0)
                throw new ValidationException(nameof(id) + "El ID debe ser mayor que cero.");
            return await _data.Delete(id);
        }

        public override async Task<List<D>> GetAll()
        {
            try
            {
                var entities = await _data.GetAll();
                var dtos = _mapper.Map<List<D>>(entities);

                return dtos;
            }
            catch (Exception ex)
            {
                throw new Exception("Repositorio Error al obtener todos los registros", ex);
            }
        }

        public override async Task<D> GetById(int id)
        {
            if (id <= 0)
                throw new ValidationException(nameof(id) + "El ID debe ser mayor que cero.");
            T entity = await _data.GetById(id);
            if (entity == null)
                throw new InvalidOperationException(typeof(T).Name + " no pudo ser encontrado.");
            D dto = _mapper.Map<D>(entity);
            return dto;
        }


        public override async Task<D> Save(D dto)
        {
            try
            {
                dto.Asset = true;
                dto.CreatedAt = DateTime.Now;
                BaseModel entity = _mapper.Map<T>(dto);
                entity = await _data.Save((T)entity);
                return _mapper.Map<D>(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la entidad.", ex);
            }
        }

        public override async Task Update(D dto)
        {
            try
            {
                BaseModel entity = _mapper.Map<T>(dto);
                await _data.Update((T)entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la entidad.", ex);
            }
        }

    }
}