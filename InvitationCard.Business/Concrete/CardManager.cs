using InvitationCard.Business.Abstract;
using InvitationCard.DataAccess.Abstract;
using InvitationCard.DataAccess.Concrete;
using InvitationCard.Entities;
using System;
using System.Collections.Generic;

namespace InvitationCard.Business.Concrete
{
    public class CardManager : ICardservice
    {
        private ICardRepository _cardRepository;

        public CardManager(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public Card CreateCard(Card card)
        {
            return _cardRepository.CreateCard(card);
        }

        public List<Card> GetAllCard()
        {
            return _cardRepository.GetAllCard();
        }
    }
}
