using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace truYum.Models
{
    public class MenuItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuId{ get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "FreeDelivery")]
        public bool FreeDelivery { get; set; }
        [Required]
        public double Price { get; set; }
        [Display(Name = "Active")]
        public bool Active { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime? DateOfLaunch { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}