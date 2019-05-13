using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Bastan.Models
{
    public class PersonModel
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public List<string> GsmNumberList { get; set; }

        public List<string> AddressList { get; set; }
    }
}