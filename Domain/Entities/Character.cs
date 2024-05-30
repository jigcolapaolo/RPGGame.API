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
        public Guid CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public Guid InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public Guid WeaponId { get; set; }
        public Weapon Weapon { get; set; }

    }
}
