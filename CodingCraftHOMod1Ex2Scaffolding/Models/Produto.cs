using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingCraftHOMod1Ex2Scaffolding.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(300)]
        public String Titulo { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Descrição")]
        [Required]
        public string Descricao { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}