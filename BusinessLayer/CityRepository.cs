using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class CityRepository : ICityRepository
    {
        private CityContext _context;

        //private readonly CityContext _context;

        public CityRepository(CityContext context)
        {
            _context = context;
        }
        public void Create(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }
        public City GetByld(Guid id)
        {
            return _context.Cities.Find(id);
        }
        public IReadOnlyList<City>GetAll()
        {
            return _context.Cities.ToList();
        }
    }
}
