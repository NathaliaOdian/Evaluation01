﻿
namespace WebEval.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public enum Estado
    {
        Aprobado,
        Reprobado,
    }
    public class Nota
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public int Note { get; set; }
        [Required]
        public int Materia { get; set; }
        [Required]
        public Estado Estado { get; set; }

        public Estudiante Estudiante { get; set; }
        
    }
}