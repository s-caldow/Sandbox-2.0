using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homepage.Models;

namespace Homepage.HarrowDeck
{
    public class HarrowReading
    {
		private const int TraditionalNumCards = 9;

	    public HarrowReading()
	    {
	    }

	    public TraditionalHand TraditionalReading(HarrowDeck deck)
	    {
			var hand = new TraditionalHand();
		    var shuffle = deck.Shuffle(TraditionalNumCards);

		    hand.LawfulGood = deck.Deck[shuffle[0]];
		    hand.NeutralGood = deck.Deck[shuffle[1]];
		    hand.ChaoticGood = deck.Deck[shuffle[2]];

		    hand.LawfulNeutral = deck.Deck[shuffle[3]];
		    hand.TrueNeutral = deck.Deck[shuffle[4]];
		    hand.ChaoticNeutral = deck.Deck[shuffle[5]];

		    hand.LawfulEvil = deck.Deck[shuffle[6]];
		    hand.NeutralEvil = deck.Deck[shuffle[7]];
		    hand.ChaoticEvil = deck.Deck[shuffle[8]];

			return hand;
	    }
    }
}
