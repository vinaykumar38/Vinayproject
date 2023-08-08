﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YtBookStore.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string Isbn { get; set; }
        [Required]

        public int TotalPages { get; set; }
        [Required]

        public int AuthorId { get; set; }
        [Required]

        public int PublisherId { get; set; }
        [Required]
        public int GenreId { get; set; }


        //the below properties added to book GetAll(bookservice class from imple)

        [NotMapped]
        public string ? AuthorName { get; set; }
        [NotMapped]
        public string ? PublisherName { get; set; }
        [NotMapped]
        public string ? GenreName { get; set;}

        //the below prop added from book ADD(BOOK CONTROLLER CLASS from controllers)
        [NotMapped]
        public List<SelectListItem> ? AuthorList { get; set; }
        [NotMapped]
        public List<SelectListItem> ? PublisherList{ get; set; }
        [NotMapped]
        public List<SelectListItem> ? GenreList { get; set; }







    }
}
