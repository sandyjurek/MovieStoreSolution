﻿namespace MovieStore.Models
{
    public class MoviesRegistrationResultViewModel
    {
        public string Id { get; set; }

        //[Required]
        //[StringLength(100)]
        public string Title { get; set; }

        public string Genre { get; set; }
        public string Year { get; set; }

        public string Actor { get; set; }

        public string Director { get; set; }

        public string Result { get; set; }
    }
}
