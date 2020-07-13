using api.filmes.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.filmes.Services
{   
    public class MovieService
    {
        private readonly DbMoviesContext _dbMoviesContext;
        public MovieService(DbMoviesContext dbMoviesContext)
        {
            _dbMoviesContext = dbMoviesContext;
        }

        

    }
}
