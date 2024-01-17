using System;
using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    public class ResultViewModel
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int MathMarks { get; set; }
        public int ScienceMarks { get; set; }
        public int EnglishMarks { get; set; }
        public double Grade { get; set; }
    }
}

