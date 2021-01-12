﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace IEnsure.Models
{
    [Table("Country")]
    public class Country
    {
       
        public int CountryId { get; set; }
        public string Name { get; set; }
        public   string Code { get; set; }
        public string Description { get; set; }

    }
}
