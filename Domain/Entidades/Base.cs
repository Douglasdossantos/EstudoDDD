﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entidades
{
   public class Base

    {
        [Display(Name="Código")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
