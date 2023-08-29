using InvitationCard.DataAccess.Abstract;
using InvitationCard.Entities;
using System.Collections.Generic;

namespace InvitationCard.DataAccess.Concrete
{
    public class CardRepository : ICardRepository
    {
        private readonly CardDbContext _context;

        public CardRepository(CardDbContext context)
        {
            _context = context;
        }

        public Card CreateCard(Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
            return card;
        }

        public List<Card> GetAllCard()
        {
            return _context.Cards.ToList();
        }
    }
}
