﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEval.Models
{   public enum Gender
    {
        Femenino,
        Masculino,

    }
    public class Estudiante
    {
        [Key]
        [Required]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public int Birthday { get; set; }

        public virtual ICollection<Nota> Notas { get; set; }
    }
}