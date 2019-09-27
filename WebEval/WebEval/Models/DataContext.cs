using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebEval.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebEval.Models.Estudiante> Estudiantes { get; set; }

        public System.Data.Entity.DbSet<WebEval.Models.Nota> Notas { get; set; }
    }
}