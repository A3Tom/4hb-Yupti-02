using System;

#nullable disable

namespace Yupti.Data.Models
{
    public partial class WorklogEvent
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
        public bool? FinalFurlong { get; set; }
        public byte[] CreatedOn { get; set; }

        public virtual Card Card { get; set; }
    }
}
