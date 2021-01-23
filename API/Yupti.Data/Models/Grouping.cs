using System;
using System.Collections.Generic;

#nullable disable

namespace Yupti.Data
{
    public partial class Grouping
    {
        public Grouping()
        {
            Cards = new HashSet<Card>();
        }

        public int Id { get; set; }
        public int BoardId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Labels { get; set; }
        public bool? Archived { get; set; }
        public bool? Completed { get; set; }

        public virtual Board Board { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
