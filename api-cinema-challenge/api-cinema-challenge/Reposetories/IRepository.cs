﻿
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Reposetories
{
    public interface IRepository
    {
        Task<Customer> CreateCustomer(string name, string email, string phoneNumber);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer?> UpdateCustomer(int id, string name, string email, string phoneNumber);
        Task<Customer?> DeleteCustomer(int id);



        /*--------------------------------------------------------------------------------------------------------------------*/



        Task<Movie> CreateMovie(string title, string rating, string description, int runtimeMins);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie?> UpdateMovie(int id, string title, string rating, string description, int runtimeMins);
        Task<Movie?> DeleteMovie(int id);



        /*--------------------------------------------------------------------------------------------------------------------*/



        Task<Screening> CreateScreening(int screenNumber, int capasity, DateTime startsAt, int movieID);
        Task<IEnumerable<Screening>> GetScreenings();
    }
}
