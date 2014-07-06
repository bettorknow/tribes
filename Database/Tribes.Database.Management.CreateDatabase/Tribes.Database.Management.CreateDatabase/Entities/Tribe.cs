using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribes.Database.Management.CreateDatabase.Entities
{
    public class Tribe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<Clan> Clans { get; set; }
    }
}
