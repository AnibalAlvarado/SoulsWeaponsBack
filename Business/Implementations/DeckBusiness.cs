using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos;
using Entity.Models;
using Entity.SpecificsDtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class DeckBusiness : BaseModelBusiness<Deck, DeckDto>, IDeckBusiness
    {
        private readonly IDeckData _data;
        private readonly ICardBusiness _cardBusiness;
        public DeckBusiness(IDeckData data, IMapper mapper, ICardBusiness cardBusiness) : base(data, mapper)
        {
            _data = data;
            _cardBusiness = cardBusiness;
        }

        public async Task<List<PlayersDeckDto>> AssignCardsToPlayers(List<PlayersDeckDto> playersDeckDto)
        {
            try
            {
                List<CardDto> allCards = await _cardBusiness.GetAll();
                if (allCards == null)
                {
                    throw new InvalidOperationException("No se encontraron cartas para asignar.");
                }
                if (allCards.Count < playersDeckDto.Count * 8)
                {
                    throw new InvalidOperationException("No hay suficientes cartas para asignar.");
                }
                List<CardDto> shuffledCards = allCards
                    .OrderBy(c => Guid.NewGuid())
                    .ToList();
                foreach (PlayersDeckDto playerDeck in playersDeckDto)
                {
                    List<CardDto> cardsToAssign = shuffledCards
                        .Take(8)
                        .ToList();
                    shuffledCards.RemoveRange(0, 8);
                    foreach (CardDto card in cardsToAssign)
                    {
                        DeckDto newDeck = new()
                        {
                            GamePlayerId = playerDeck.GamePlayerId,
                            CardId = (int)card.Id,
                            IsEarned = false
                        };
                        DeckDto createdDeck = await Save(newDeck);
                        if (createdDeck == null)
                        {
                            throw new InvalidOperationException("No se pudo crear el deck.");
                        }
                    }
                    playerDeck.Cards = cardsToAssign;
                }
                return playersDeckDto;
            }
            catch(InvalidOperationException EOex)
            {
                throw new InvalidOperationException("Error al asignar las cartas.", EOex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar las cartas.", ex);
            }
        }

        public async Task<int> InactiveCardOfDeck(int cardId, int playerId)
        {
            return await _data.InactiveCardOfDeck(cardId, playerId);
        }

        public async Task<int> GameWinnerSelection()
        {
            try
            {
                int GameWinnerId = await _data.GameWinnerSelection();
                return GameWinnerId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Business Error: " + ex.Message);
                throw;
            }
        }

        public async Task<List<PlayersDeckDto>> GetAllPlayersDecksByGamePlayerIds(List<int> playerIds)
        {
            try
            {
                List<PlayersDeckDto> playersWithCards = await _data.GetAllPlayersDecksByGamePlayerIds(playerIds);
                if(playersWithCards == null)
                {
                    throw new InvalidOperationException("No se encontraron jugadores con cartas.");
                }
                return playersWithCards;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Business Error: " + ex.Message);
                throw;
            }
        }
    }
}
