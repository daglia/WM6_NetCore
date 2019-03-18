﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kuzey.Models.Entities
{
    [Table("Categories")]
    public class Category : BaseEntity<int>
    {
        [Required, StringLength(50)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
