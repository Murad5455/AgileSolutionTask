using InvitationCard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvitationCard.DataAccess.Abstract
{
    public interface ICardRepository
    {
        List<Card> GetAllCard();

        Card CreateCard(Card card);



    }
}
