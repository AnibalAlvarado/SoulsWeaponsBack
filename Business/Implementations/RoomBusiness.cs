using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos;
using Entity.Models;
using Entity.SpecificsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class RoomBusiness : BaseModelBusiness<Room, RoomDto>, IRoomBusiness
    {
        private readonly IRoomData _data;
        private readonly IGamePlayerBusiness _gamePlayerBusiness;
        private readonly IDeckBusiness _deckBusiness;
        public RoomBusiness(IRoomData data, IMapper mapper, IGamePlayerBusiness gamePlayerBusiness, IDeckBusiness deckBusiness) : base(data, mapper)
        {
            _data = data;
            _gamePlayerBusiness = gamePlayerBusiness;
            _deckBusiness = deckBusiness;
        }

        public async Task<List<PlayersDeckDto>> CreateRoom(List<PlayerDto> players)
        {
            try
            {
                List<PlayersDeckDto> playersDecks = new ();
                RoomDto newRoom = new()
                {
                    CurrentRound = 1
                };
                RoomDto createdRoom = await Save(newRoom);
                if (createdRoom == null)
                {
                    throw new InvalidOperationException("No se pudo crear la sala.");
                }
                foreach (PlayerDto player in players)
                {
                    GamePlayerDto newGamePlayerDto = new();
                    newGamePlayerDto.PlayerId = (int)player.Id;
                    newGamePlayerDto.RoomId = (int)createdRoom.Id;
                    newGamePlayerDto.Winner = false;
                    GamePlayerDto GamePlayerCreated = await _gamePlayerBusiness.Save(newGamePlayerDto);
                    if(GamePlayerCreated == null)
                    {
                        throw new InvalidOperationException("No se pudo crear el jugador en la sala.");
                    }
                    playersDecks.Add(
                        new PlayersDeckDto
                        {
                            RoomId = (int)createdRoom.Id,
                            GamePlayerId = (int)GamePlayerCreated.Id,
                            PlayerName = player.Name,
                            Cards = new List<CardDto>()
                        }
                    );
                }
                List<PlayersDeckDto> playersWithDecks = await _deckBusiness.AssignCardsToPlayers(playersDecks);
                return playersWithDecks;
            }
            catch(InvalidOperationException IOex)
            {
                throw new InvalidOperationException("Error al crear la sala.", IOex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la sala.", ex);
            }
        }

        public async Task<CardComparisonDto> CardComparison(CardComparisonDto comparison)
        {
            try
            {
                Room room = await _data.GetById((int)comparison.RoomId);
                var attributeSelector = new Dictionary<string, Func<CardDto, decimal>>
                {
                    { "Damage", c => c.Damage },
                    { "FireDamage", c => c.FireDamage },
                    { "ElectricDamage", c => c.ElectricDamage },
                    { "CrtiticalDamage", c => c.CrtiticalDamage },
                    { "PoisionDamage", c => c.PoisionDamage },
                    { "MagicDamage", c => c.MagicDamage }
                };

                if (attributeSelector.TryGetValue(comparison.AttributeComparison, out var selector))
                {
                    var winner = comparison.PlayersSelectedCards
                        .Where(p => p.Card != null)
                        .OrderByDescending(p => selector(p.Card))
                        .FirstOrDefault();
                    comparison.WinnerRoundId = winner?.GamePlayerId;
                    comparison.WinnerCardId = winner?.Card?.Id;

                }
                else
                {
                    throw new InvalidOperationException("El atributo de comparación no es válido.");
                }

                var lossers = comparison.PlayersSelectedCards
                    .Where(p => p.Card != null && p.GamePlayerId != comparison.WinnerRoundId);

                foreach (var player in lossers)
                {
                    DeckDto newDeck = new()
                    {
                        GamePlayerId = (int)comparison.WinnerRoundId,
                        CardId = (int)player.Card.Id,
                        IsEarned = true
                    };
                    DeckDto createdDeck = await _deckBusiness.Save(newDeck);
                    if (createdDeck == null)
                    {
                        throw new InvalidOperationException("No se pudo crear el deck.");
                    }

                    int eliminatedCard = await _deckBusiness.InactiveCardOfDeck((int)player.Card.Id, (int)player.GamePlayerId);
                    if (eliminatedCard == 0)
                    {
                        throw new InvalidOperationException("No se pudo inactivar la carta.");
                    }
                }
                if(room.CurrentRound >= 7)
                {
                   int gameWinner = await GameWinnerSelection();
                   comparison.AbsoluteWinnerId = gameWinner;
                }
                room.CurrentRound++;
                await _data.Update(room);
                return comparison;
            }
            catch (InvalidOperationException IOex)
            {   
                throw new InvalidOperationException("Error al comparar las cartas.", IOex);
            }
            catch (Exception ex )
            {
                throw new Exception("Error al comparar las cartas.", ex);
            }
        }

        private async Task<int> GameWinnerSelection()
        {
            try
            {
                int gameWinnerId = await _deckBusiness.GameWinnerSelection();
                if(gameWinnerId == 0)
                {
                    throw new InvalidOperationException("No se pudo seleccionar el ganador.");
                }
                GamePlayerDto gameplayerWinner = await _gamePlayerBusiness.GetById(gameWinnerId);
                if(gameplayerWinner == null)
                {
                    throw new InvalidOperationException("El jugador ganador no fue encontrado.");
                }
                gameplayerWinner.Winner = true;
                await _gamePlayerBusiness.Update(gameplayerWinner);
                return gameWinnerId;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al seleccionar el ganador.", ex);
            }
        }


    }
}
