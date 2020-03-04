using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entidades
{
    public class Produto : Base
    {
        [Display(Name ="Preço")]
        public decimal preco { get; set; }
    }
}
