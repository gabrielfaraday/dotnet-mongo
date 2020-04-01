using System;
using System.Collections.Generic;

namespace Api.Models
{
    public class Infectado
    {
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}