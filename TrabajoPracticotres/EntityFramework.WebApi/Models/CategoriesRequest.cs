using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework.WebApi.Models
{
    public class CategoriesRequest
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string CategoryName { get; set; }
    }
}