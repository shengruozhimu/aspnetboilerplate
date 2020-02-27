﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.DynamicEntityParameters
{
    public interface IEntityDynamicParameterStore
    {
        EntityDynamicParameter Get(int id);

        Task<EntityDynamicParameter> GetAsync(int id);

        List<EntityDynamicParameter> GetAllParameters(string entityFullName);

        Task<List<EntityDynamicParameter>> GetAllParametersAsync(string entityFullName);

        void Add(EntityDynamicParameter entityDynamicParameter);

        Task AddAsync(EntityDynamicParameter entityDynamicParameter);

        void Update(EntityDynamicParameter entityDynamicParameter);

        Task UpdateAsync(EntityDynamicParameter entityDynamicParameter);

        void Delete(int id);

        Task DeleteAsync(int id);
    }
}
