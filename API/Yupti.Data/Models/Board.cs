using System.Collections.Generic;

#nullable disable

namespace Yupti.Data.Models
{
    public partial class Board
    {
        public Board()
        {
            Groupings = new HashSet<Grouping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Grouping> Groupings { get; set; }
    }
}
