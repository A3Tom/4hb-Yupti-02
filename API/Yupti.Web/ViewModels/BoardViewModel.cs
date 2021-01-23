using System.Collections.Generic;

namespace Yupti.Web.ViewModels
{
    public class BoardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

        public List<GroupingViewModel> Groupings { get; set; }

        public BoardViewModel()
        {
            Groupings = new List<GroupingViewModel>();
        }
    }
}
