using System;
using System.Collections.Generic;

#nullable disable

namespace Yupti.Data
{
    public partial class Card
    {
        public Card()
        {
            WorklogEvents = new HashSet<WorklogEvent>();
        }

        public int Id { get; set; }
        public int GroupingId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Labels { get; set; }
        public bool? Archived { get; set; }
        public bool? Completed { get; set; }

        public virtual Grouping Grouping { get; set; }
        public virtual ICollection<WorklogEvent> WorklogEvents { get; set; }
    }
}
