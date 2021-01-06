using System;
using System.Collections.Generic;

namespace API.Model
{
    public class Squad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Person> Persons { get; set; }
    }
}