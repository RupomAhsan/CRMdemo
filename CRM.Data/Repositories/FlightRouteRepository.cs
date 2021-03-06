﻿using CRM.Data.Infrastructure;
using CRM.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data.Repositories
{
    public class FlightRouteRepository : RepositoryBase<FlightRouteEntity>, IFlightRouteRepository
    {
        public FlightRouteRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public override void Update(FlightRouteEntity entity)
        {
            entity.UpdatedDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IFlightRouteRepository : IRepository<FlightRouteEntity>
    {

    }
    
}
