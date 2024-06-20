using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage ="Job name is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Job name must be between 3 and 20 characters.")]
        public string? Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem>? Employers { get; set; } 
        // public Job? Job { get; set; }
        public AddJobViewModel(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();
            
            foreach(var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
            // Job = theJob;
        }
        public AddJobViewModel()
        {
        } 
    }
}