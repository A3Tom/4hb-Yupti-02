using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Yupti.Data.Contexts;
using Yupti.Data.Models;

namespace Yupti.Data.Repositories
{
    public class PlannerRespository : IPlannerRepository
    {
        public readonly YuptiContext _dbContext;

        public PlannerRespository(YuptiContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Board> AddBoard(Board newBoard)
        {
            var newEntity = _dbContext.Add(newBoard);

            await _dbContext.SaveChangesAsync();

            return newEntity.Entity;
        }

        public async Task<Card> AddCard(Card newCard)
        {
            var newEntity = _dbContext.Add(newCard);

            await _dbContext.SaveChangesAsync();

            return newEntity.Entity;
        }

        public async Task<Grouping> AddGrouping(Grouping newGrouping)
        {
            var newEntity = _dbContext.Add(newGrouping);

            await _dbContext.SaveChangesAsync();

            return newEntity.Entity;
        }

        public async Task<WorklogEvent> AddNewWorklogEvent(WorklogEvent newWorklogEvent)
        {
            var newEntity = _dbContext.Add(newWorklogEvent);

            await _dbContext.SaveChangesAsync();

            return newEntity.Entity;
        }

        public async Task<ICollection<Board>> GetAllBoards()
        {
            return await _dbContext.Boards.ToListAsync();
        }

        public async Task<ICollection<Card>> GetAllCards()
        {
            return await _dbContext.Cards.ToListAsync();
        }

        public async Task<ICollection<Grouping>> GetAllGroupings()
        {
            return await _dbContext.Groupings.ToListAsync();
        }

        public async Task<Card> GetCardById(int cardId)
        {
            return await _dbContext.Cards
                .Where(x => x.Id == cardId)
                .SingleOrDefaultAsync();
        }

        public async Task<ICollection<WorklogEvent>> GetWorklogsForCards(int[] cardIds)
        {
            return await _dbContext.WorklogEvents
                .Where(x => cardIds.Contains(x.CardId))
                .ToListAsync();
        }

        public async Task<Board> LoadFullBoardDataById(int boardId)
        {
            return await _dbContext.Boards
                .Where(x => x.Id == boardId)
                .SingleAsync();
        }

        public async Task<Card> ModifyCardLabels(int id, string newLabels)
        {
            var targetEntity = await GetCardById(id);
            targetEntity.Labels = newLabels;

            await _dbContext.SaveChangesAsync();

            return targetEntity;
        }

        public async Task<Grouping> ModifyGroupingLabels(int id, string newLabels)
        {

            var targetEntity = await GetGroupingById(id);
            targetEntity.Labels = newLabels;

            await _dbContext.SaveChangesAsync();

            return targetEntity;
        }

        public async Task<Grouping> GetGroupingById(int groupingId)
        {
            return await _dbContext.Groupings
                .Where(x => x.Id == groupingId)
                .SingleOrDefaultAsync();
        }

    }
}
