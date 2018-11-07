using BusinessLayer;
using CityApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CityApplication.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICityRepository _repository;

        public CitiesController(ICityRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var cities = _repository.GetAll();
            var citiesVM = new List<CityViewModel>();

            foreach (var city in cities)
            {
                citiesVM.Add(new CityViewModel
                {
                    Description = city.Description
                });
            }
            return View(citiesVM);
        }
    }
}