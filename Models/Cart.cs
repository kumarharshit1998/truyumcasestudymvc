using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace truYum.Models
{
    public class Cart
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CartId { get; set; }

        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}