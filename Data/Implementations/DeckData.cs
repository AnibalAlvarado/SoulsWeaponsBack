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
using Entity.SpecificsDtos;
using Entity.Dtos;

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

        public async Task<int> GameWinnerSelection()
        {
            try
            {
                var winner = await _context.Set<Deck>()
                    .Where(d => d.Asset) // Solo cartas activas
                    .GroupBy(d => d.GamePlayerId)
                    .Select(group => new
                    {
                        GamePlayerId = group.Key,
                        CardCount = group.Count()
                    })
                    .OrderByDescending(g => g.CardCount)
                    .FirstOrDefaultAsync();

                return winner?.GamePlayerId ?? 0; // Si no hay registros, retorna 0
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

        public async Task<List<PlayersDeckDto>> GetAllPlayersDecksByGamePlayerIds(List<int> playerIds)
        {
            try
            {
                var result = await _context.Decks
                    .Where(d => d.Asset && d.IsEarned == false && playerIds.Contains(d.GamePlayerId))
                    .Include(d => d.Card)
                    .GroupBy(d => d.GamePlayerId)
                    .Select(group => new PlayersDeckDto
                    {
                        GamePlayerId = group.Key,
                        Cards = group.Select(d => new CardDto
                        {
                            Id = d.Card.Id,
                            Name = d.Card.Name,
                            Damage = d.Card.Damage,
                            FireDamage = d.Card.FireDamage,
                            ElectricDamage = d.Card.ElectricDamage,
                            CrtiticalDamage = d.Card.CrtiticalDamage,
                            PoisionDamage = d.Card.PoisionDamage,
                            MagicDamage = d.Card.MagicDamage,
                            Image = d.Card.Image
                        }).ToList()
                    })
                    .ToListAsync();

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
