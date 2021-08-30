﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.eCommerce.WebUI.Models.Entity
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public int AphorismId { get; set; }

        public string AuthorImagePath { get; set; }

        public string AuthorName { get; set; }

        public string AuthorSurname { get; set; }

        public virtual Aphorism Aphorism { get; set; }
    }
}
