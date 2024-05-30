using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enum;

namespace Domain.Entities
{
    public class Skill
    {
        public Guid SkillId { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public SkillType Type { get; set; }
    }
}
