﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecordShopFunctionApp.Model
{
    public class AlbumsFilter
    {

            public string? Title { get; set; }
           
            public string? ArtistName{ get; set; }           

           
            public int? MusicGenre { get; set; }
            
            public int? ReleaseYear { get; set; }

        }
}
