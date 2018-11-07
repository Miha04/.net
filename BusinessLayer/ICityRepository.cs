using System;
using System.Collections.Generic;
using DataLayer;

namespace BusinessLayer
{
    public interface ICityRepository
    {
        void Create(City city);
        IReadOnlyList<City> GetAll();
        City GetByld(Guid id);
    }
}