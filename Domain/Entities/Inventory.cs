using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Inventory
    {
        public Guid InventoryId { get; set; }
        public ICollection<Item> Items { get; set; }
        public Guid CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
