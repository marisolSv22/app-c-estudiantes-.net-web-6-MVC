﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace NotaEstudiantes.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Estudiante = new HashSet<Estudiante>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Estudiante> Estudiante { get; set; }
    }
}