using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VHSOnly.DTOs;
using VHSOnly.Models;

namespace VHSOnly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(RentalDto rentalDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if(rentalDto.MovieIds.Count < 1)
                return BadRequest("User must select at least one movie");


            var movies = _context.Movies.Where(
                m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            var customer = _context.Customers.Single(
                c => c.Id == rentalDto.CustomerId);

            foreach (var movie in movies)
            {
                if(movie.NumberInStock == 0)
                    return BadRequest("Movie not in stock");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);

            }


            _context.SaveChanges();
            return Ok();

        }
    }
}
