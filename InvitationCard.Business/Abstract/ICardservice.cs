using InvitationCard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvitationCard.Business.Abstract
{
    public interface ICardservice
    {
        List<Card> GetAllCard();

        Card CreateCard(Card card);

    }
}
