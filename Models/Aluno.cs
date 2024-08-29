﻿using System.ComponentModel.DataAnnotations;

namespace DemoRazorPages.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        [DataType(DataType.Date)]

        public DateTime DataCadastre { get; set; }

        public bool Ativo { get; set; }
    }
}

