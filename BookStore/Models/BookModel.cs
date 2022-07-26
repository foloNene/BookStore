using BookStore.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength =4)]
        [Required(ErrorMessage ="Please enter the title of your book")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter the Author name")]
        public string Author { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }
        public int LanguageId { get; set; }

        public string Language { get; set; }
        [Required(ErrorMessage ="Please enter the total Pages")]
        public int TotalPages { get; set; }
        [Display(Name="Choose the cover Photo of your book")]
       [Required]
        public IFormFile CoverPhoto   { get; set; }
        public string  CoverImageUrl { get; set; }

        [Display(Name = "Choose the gallary Image of your book")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Upload Your book in PdF format")]
        public IFormFile BookPdf { get; set; }
        public string BookPdfUrl { get; set; }

    }
}
