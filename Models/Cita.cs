using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace pangu.Models
{
    public class Cita{
        [Required]
        [MinLength(4)]
        public string Nombre { get; set; }
        [Required]
        public string Mascota{get; set;}

        [Required]
        public int Telefono{get; set;}

        public string TipoTelefono{get; set;}

        public string Doctor{get; set;}
        [Required]
        [DisplayFormat(DataFormatString = "{dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha{get; set;}

        public string TipoMascota{get; set;}
        public string TipoCita{get; set;}
        public string Direccion{get; set;}
        
    }
}