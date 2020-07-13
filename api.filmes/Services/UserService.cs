using api.filmes.DataContext;
using api.filmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace api.filmes.Services
{
    public class UserService
    {
        private readonly DbMoviesContext _moviesContext;

        public UserService(DbMoviesContext moviesContext)
        {
            _moviesContext = moviesContext;
        }

        public void InsertUser(Users users) 
        {
            _moviesContext.Users.Add(users);
            _moviesContext.SaveChanges();
        }

        public int GetUser(Users users)
        {
            var id = _moviesContext.Users.Find(users).userId;  
            if (id == 0)
            {
                InsertUser(users);
                id = _moviesContext.Users.Find(users).userId;
            }
            return id;
        }
    }
}
