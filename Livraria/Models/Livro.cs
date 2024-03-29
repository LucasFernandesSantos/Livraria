﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{

    public class Livro
    {
        public int IdLivro { get; set; }
        public string PageCoutn { get; set; }
        public List<Items> items { get; set; } = new List<Items>();
    }

    public class Items
    {
        public string Id { get; set; }
        public VolumeInfo volumeInfo { get; set; }
        public int Quantidade { get; set; }
        public string Volume { get; set; }
        public string AvarageRating { get; set; }
    }

    public class VolumeInfo
    {
        public string IdTittle { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
    }

    public class Autores
    {
        public string IdAuthors { get; set; }
        public string Authors { get; set; }
    }
}



