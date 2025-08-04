using Data.Interfaces;
using Entity.Contexts;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class DeckData : BaseModelData<Deck>, IDeckData
    {
        public DeckData(ApplicationDbContext context, IConfiguration configuration) : base(context, configuration)
        {
        }

        public async Task<int> InactiveCardOfDeck(int cardId, int playerId)
        {
            try
            {
                var entity = await _context.Set<Deck>().FirstOrDefaultAsync(d => d.CardId == cardId && d.GamePlayerId == playerId);
                if (entity == null)
                    throw new DataException($"No se encontró ningún registro.");

                // Marcar como inactivo (soft delete)
                entity.Asset = false;

                _context.Entry(entity).State = EntityState.Modified;
                int result = await _context.SaveChangesAsync();

                return result;
            }
            catch (DbException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
                throw;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Database update (EF) failed: " + ex.InnerException?.Message);
                throw;
            }
        }
    }
}
