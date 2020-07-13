
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.filmes.Models
{
    [Table("Movies")]
    public class Movies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int movieId { get; set; }
        [StringLength(255)]
        public string nome { get; set; }
        [StringLength(255)]
        public int ano_lancamento { get; set; }
        [StringLength(255)]
        public string imagem { get; set; }
        [StringLength(255)]
        public string slogan { get; set; }
        [StringLength(255)]
        public string visaoGeral { get; set; }
        [StringLength(255)]
        public string classificacao { get; set; }
        [ForeignKey("genresId")]
        public int genresId { get; set; }
        public Genres genres { get; set; }
    }
}
