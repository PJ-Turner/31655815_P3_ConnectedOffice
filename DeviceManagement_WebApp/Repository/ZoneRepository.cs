﻿using DeviceManagement_WebApp.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Policy;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }
        //private readonly IGenericRepository<Zone> _ZoneRepository;

        public Zone GetMostRecentZone()
        {
            throw new System.NotImplementedException();
            //return _context.Zone.OrderByDescending(Device => Zone.DateCreated).FirstOrDefault();
            
        }



        
    }




}
