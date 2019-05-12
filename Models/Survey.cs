    
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis;

namespace DojoSurvey.Models
{
    public class Survey
    {
        
        [Required (ErrorMessage = "Name is required!")]
        [MinLength(3, ErrorMessage = "Name must be 3 characters or more!")]
        [Display (Name="Enter Name")]
        public string Name{get;set;}
        
        [Required (ErrorMessage = "Location is required!")]
        [Display (Name="Enter Comment")]
        public string Location{get;set;}

        [Required (ErrorMessage = "Language is required!")]
        [Display (Name="Enter Comment")]
        public string Language{get;set;}

        [Required (ErrorMessage = "Comment is required!")]
        [MinLength(5, ErrorMessage = "Comment must be 10 characters or more!")]
        [Display (Name="Enter Comment")]
        public string Comment{get;set;}
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Lang: {Language}");
        }
    }
}