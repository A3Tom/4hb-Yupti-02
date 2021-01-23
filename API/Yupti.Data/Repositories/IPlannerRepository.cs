using System.Collections.Generic;
using System.Threading.Tasks;
using Yupti.Data.Models;

namespace Yupti.Data.Repositories
{
    public interface IPlannerRepository
    {
		Task<Board> AddBoard(Board newBoard);
		Task<Board> LoadFullBoardDataById(int boardId);
		Task<ICollection<Board>> GetAllBoards();

		Task<Card> AddCard(Card newCard);
		Task<Card> GetCardById(int Id);
		Task<Card> ModifyCardLabels(int id, string newLabels);
		Task<ICollection<Card>> GetAllCards();

		Task<Grouping> AddGrouping(Grouping newGrouping);
		Task<Grouping> ModifyGroupingLabels(int id, string newLabels);
		Task<ICollection<Grouping>> GetAllGroupings();

		Task<WorklogEvent> AddNewWorklogEvent(WorklogEvent newWorklogEvent);
		Task<ICollection<WorklogEvent>> GetWorklogsForCards(int[] cardIds);
	}
}
