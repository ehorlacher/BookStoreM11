﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookStoreM11.Models
{
    public partial class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter a book title")]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }

        [Required(ErrorMessage = "Please enter a price")]
        public double Price { get; set; }
    }
}
