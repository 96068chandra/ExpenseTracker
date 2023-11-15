﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";
        [Column(TypeName = "nvarchar(50)")]
        public string Icon { get; set; } = "";

        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                return this.Icon + " " + this.Title;
            }
        }





    }
}
