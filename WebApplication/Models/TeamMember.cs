﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string  PicturePath { get; set; }
        public string Details { get; set; }
        public string CvPath { get; set; }
            
    }
}