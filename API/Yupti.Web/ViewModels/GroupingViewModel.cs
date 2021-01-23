using System.Collections.Generic;

namespace Yupti.Web.ViewModels
{
    public class GroupingViewModel
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Labels { get; set; }
        public bool? Archived { get; set; }
        public bool? Completed { get; set; }

        public List<CardViewModel> Cards { get; set; }

        public GroupingViewModel()
        {
            Cards = new List<CardViewModel>();
        }
    }
}
