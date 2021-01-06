using System;
using System.Collections.Generic;

namespace API.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Squad> Squads { get; set; }
    }
}