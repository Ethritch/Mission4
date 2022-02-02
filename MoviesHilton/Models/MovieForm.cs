﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviesHilton.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        //Build the Foreign Key Relationship
        public int CategoryId { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
       [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
