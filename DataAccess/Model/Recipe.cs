using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Recipe
    {
        // Our table for the database. Id is primary key
        public int Id { get; set; }
        
        [Required]
        [StringLength(500,ErrorMessage ="Title too long try a shorter one! (500 characters limit)")]
        public string Title { get; set; }

        [Required]
        [StringLength(8000, ErrorMessage = "Description too long try a shorter one! (500 characters limit)")]
        public string Description { get; set; }

        
        
        public DateTime DateCreated { get; set; }   
       
        
        public DateTime DateUpdated { get; set; }

    }
}
