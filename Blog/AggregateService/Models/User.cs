using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregateService.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Phone { get; set; }

        public int TeamId { get; set; }
    }
}
