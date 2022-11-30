using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsersAsp.Models
{
    public class UserSearch
    {
        [Key]
        public string SearchText { get; set; }
    }
}