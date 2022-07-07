using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_mvc_sql.Models
{
    [Table("Produto")]
    public class Produto
    {
        [colum("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [colum("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
    }
}
