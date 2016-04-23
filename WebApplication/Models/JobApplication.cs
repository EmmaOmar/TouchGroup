using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class JobApplication
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public string CvPath { get; set; }
        public bool IsViewed { get; set; }
    }
}