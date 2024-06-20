using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Name of employer is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Name must be between 3 and 20 characters.")]
         public string? Name { get; set; }

        [Required(ErrorMessage ="Location is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Location must be between 3 and 20 characters.")]
        public string? Location { get; set; }
    }
}