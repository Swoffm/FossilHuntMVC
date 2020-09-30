using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FossilHuntMVC.Models
{
    public class Question
    {

        public int Id { get; set; }

        [Required]
        public int userId { get; set; }

        [Required]
        public string question { get; set; }

        [Required]
        public int StateId { get; set; }


        public User user;
    }
}
