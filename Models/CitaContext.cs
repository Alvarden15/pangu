using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Models.CitaContext
{
    public class CitaContext: DbContext{
        public CitaContext(DbContextOptions<CitaContext> options) : base(options){

        }

        public DbSet<pangu.Models.Cita> Cita{get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseMySQL("server=localhost;database=library10;user=root;password=1234567;port=3306");
         }

    }


}
