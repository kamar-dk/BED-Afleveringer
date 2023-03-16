﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class JobDtoSimple
    {
        public string? Customer { get; set; }
        public DateTime StartDate { get; set; }
        public int Days { get; set; }
        [MaxLength(128)]
        public string? Location { get; set; }
        [MaxLength(2000)]
        public string? Comments { get; set; }

        public List<string> Model_Name { get; set; }
    }
}