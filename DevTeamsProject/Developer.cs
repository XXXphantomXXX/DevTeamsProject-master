using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class Developer
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public bool HasPluralSight { get; set; }

        public Developer(string name, string id, bool hasPluralsight)
        {
            Name = name;
            Id = id;
            HasPluralSight = hasPluralsight;
        }

    }
}
