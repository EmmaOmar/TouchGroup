using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class CompanyProfile
    {
        [Key]
        public int Id { get; set; }
        public string SectionName { get; set; }
        public string Content { get; set; }
    }
}