using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Category
    {
        public Category()
        {
            Projects = new List<Project>();
        }
       [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("StandardRefId")]
        public SubCategory Subcategory { get; set; }
        public List<Project> Projects { get; set; }

    }
}