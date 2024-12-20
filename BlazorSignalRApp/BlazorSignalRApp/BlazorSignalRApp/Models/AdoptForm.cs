using BlazorSignalRApp.Data;
using BlazorSignalRApp.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace BlazorSignalRApp.Models
{
    public class AdoptForm
    {
        public int Id { get; set; }

        // Pet Details
        [Required]
        public int PetId { get; set; }

        public string PetName { get; set; }
        public string PetBreed { get; set; }
        public DateOnly PetBirthDate { get; set; }

        // Applicant Details
        [Required]
        public string FullName { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        public string Address { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime ApplicationDate { get; set; } = DateTime.Now;

        public string UserId { get; set; }
    }
}
