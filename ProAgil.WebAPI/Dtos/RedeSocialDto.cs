using System.ComponentModel.DataAnnotations;

namespace ProAgil.WebAPI.Dtos
{
    public class RedeSocialDto
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="O campo {0} � obrigat�rio")]
        public string Nome { get; set; }
        [Required (ErrorMessage ="O campo {0} � obrigat�rio")]
        public string URL { get; set; }
    }
}