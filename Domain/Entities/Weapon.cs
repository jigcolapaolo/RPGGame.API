using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Weapon
    {
        public Guid WeaponId { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public WeaponType WeaponType { get; set; }
        public ICollection<Character> Characters { get; set; }

    }
}
