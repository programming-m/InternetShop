﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class Kurs
    {

        public int KursId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kursu")]
        [StringLength(100)]
        public string TytulKursu { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe autora")]
        [StringLength(100)]
        public string AutorKursu { get; set; }
        public DateTime DataDodania { get; set; }
        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisKursu { get; set; }
        public decimal CenaKursu { get; set; }
        public bool Bestsseller { get; set; }
        public bool Ukryty { get; set; }
        public string OpisSkrocony { get; set; }
        




        public virtual Kategoria kategoria { get; set; }

    }
}