﻿
using Fluxus.Domain.Entities;
using System.Collections.Generic;

namespace Fluxus.Domain.Interfaces
{
    public interface IServiceRepository
    {
        public int Insert(Service body);

        public bool Update(Service body);

        public bool Delete(int id);

        public Service GetById(int id);

        public List<Service> GetAll();
    }
}