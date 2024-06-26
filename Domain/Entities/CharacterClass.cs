﻿using Domain.Enum;
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
        public string Name { get; set; }
        public CharacterClassType ClassType { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
