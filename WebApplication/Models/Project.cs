using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Area { get; set; }
        public string Client { get; set; }
        public string LogoPath { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }

    }
}