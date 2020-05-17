using EndToEnd.Data.EndToEnd;
using EndToEndDB.Data.EndToEnd;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndToEnd.Data
{
    public class MemoriesService
    {
        private readonly EndtoEndContext _context;

        public MemoriesService(EndtoEndContext context)
        {
            _context = context;
        }

        public async Task<List<Memories>>
            GetMemoriesAsync(string strCurrentUser)
        {
            // Get Weather Forecasts  
            return await _context.Memories
                 // Only get entries for the current logged in user
                 .Where(x => x.UserName == strCurrentUser)
                 // Use AsNoTracking to disable EF change tracking
                 // Use ToListAsync to avoid blocking a thread
                 .AsNoTracking().ToListAsync();
        }

        public Task<Memories>
           CreateMemoriesAsync(Memories objMemories)
        {
            _context.Memories.Add(objMemories);
            _context.SaveChanges();
            return Task.FromResult(objMemories);
        }

        public Task<bool>
               UpdateMemoriesAsync(Memories objMemories)
        {
            var ExistingMemories =
                _context.Memories
                .Where(x => x.Id == objMemories.Id)
                .FirstOrDefault();
            if (ExistingMemories != null)
            {
                ExistingMemories.memDate =
                    objMemories.memDate;
                ExistingMemories.memType =
                    objMemories.memType;
                ExistingMemories.memText =
                    objMemories.memText;
                
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        public Task<bool>
            DeleteMemoriesAsync(Memories objMemories)
        {
            var ExistingMemories =
                _context.Memories
                .Where(x => x.Id == objMemories.Id)
                .FirstOrDefault();
            if (ExistingMemories != null)
            {
                _context.Memories.Remove(ExistingMemories);
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}