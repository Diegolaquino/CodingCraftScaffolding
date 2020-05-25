using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodingCraftHOMod1Ex2Scaffolding.Models
{
    [Table("Testes")]
    public class Teste
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}