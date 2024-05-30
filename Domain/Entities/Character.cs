using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Character
    {
        public Guid CharacterId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }
}
