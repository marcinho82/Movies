using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.filmes.Models
{
    public class Movies
    {
        public int movieId { get; set; }
        public string nome { get; set; }
        public int ano_lancamento { get; set; }
        public string imagem { get; set; }
        public string slogan { get; set; }
        public string visaoGeral { get; set; }
        public string classificacao { get; set; }
    }
}
