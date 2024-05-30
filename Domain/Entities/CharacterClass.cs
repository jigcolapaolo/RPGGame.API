using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CharacterClass
    {
        public Guid CharacterClassId { get; set; }
        public string ClassName { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
