﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Employee
    {
        [Display(Name = "Employee #")]
        public int EmployeeID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Lastname cannot be longer than 50 and at least 1 characters.")]
        public string EmployeeLastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmployeeFirstName { get; set; }

        [Required]
        [Display(Name = "MI")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string MI { get; set; }

        //SSN = socail security number
        [Required]
        [Display(Name = "SSN")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmployeeSSN { get; set; }

        [Required]
        [Display(Name = "Address")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmAddress1 { get; set; }

        [Required]
        [Display(Name = "Address")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmAddress2 { get; set; }

        [Required]
        [Display(Name = "City")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmCity { get; set; }

        [Required]
        [Display(Name = "State")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmState { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmZipcode { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmTelephone { get; set; }

        [Required]
        [Display(Name = "Marital Status")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string MaritalStatus { get; set; }

        [Required]
        [Display(Name = "Exemption")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public int EmExemption { get; set; }

        [Required]
        [Display(Name = "Pay Rate")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Firstname cannot be longer than 50 and at least 1 characters.")]
        public string EmPayRate { get; set; }

        [Display(Name = "Type")]
        public int EmployeeTypeID { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date, ErrorMessage = "Date Time is invalid")]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy:0}", ApplyFormatInEditMode = true)]
        public DateTime EmStartDate { get; set; }


        public virtual EmployeeType EmployeeType { get; set; }

        public virtual ICollection<Purchase> Purchase { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}
