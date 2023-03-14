using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace P4EXI218010004.Models
{
    public class Localizacion
    {
        [PrimaryKey, AutoIncrement]
        public int id {  get; set; }    

        public Double Latitud  { get; set; }

        public Double Longitud { get; set; }

        [MaxLength(200)]
        public  string descripcion_larga { get; set; }

        [MaxLength(60)]
        public  string descripcion_corta { get; set; }
    }
}
