﻿using CRM.Data.Infrastructure;
using CRM.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data.Repositories
{
    public class CountryRepository : RepositoryBase<CountryEntity>, ICountryRepository
    {
        public CountryRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public override void Update(CountryEntity entity)
        {
            entity.UpdatedDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface ICountryRepository : IRepository<CountryEntity>
    {

    }
    
}
