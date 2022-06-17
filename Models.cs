/* enumarations for the card's suit and value... Card objects should have 3 attributes A suit, A value & A score...
Defined suits and values as enumerations.
*/

public enum CardSuit
{
    Hearts,
    Clubs,
    Diamonds,
    Spades
}

public enum CardValue
{
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13,
}

public class Card
{
    public CardSuit { get; set; }
    public CardValue { get; set; }

    public int Score
    {
        get
        {
            if (Value == CardValue.King
            || Value == CardValue.Queen
            || Value == CardValue.Jack)
            {
                return 10;
            }
            if (Value == CardValue.Ace)
            {
                return 11;
            }
            else
            {
                return (int)Value;
            }
            
        }
    }
};

/*Property to hide the dealers second card*/

public class Card
{
    //.. other properties and methods

  public bool IsVisible {get; set} = true;  
}

public class Card

public bool IsTenCard
{
    get
    {
        return Value == CardValue.Ten
        || Value == CardValue.Jack
        || Value == CardValue.Queen
        || Value == CardValue.King;
    }
}
public class Card
{
    public string ImageName {get;set;}
}

public class CardDeck
{
    protected Stack<Card> Cards {get;set;} = new Stack<Card>();
}

public class CardDeck
{
    public int Count
    {
        get
        {
            return Cards.Count;
        }
    }
}

public class CardDeck
{
    public CardDeck()
    {
        List<Card> cards = new List<Card>();

        foreach (CardSuit suit
                  in (CardSuit[])Enum.GetValues(typeof(CardValue)))
                  {
                    foreach (CardValue value
                             in (CardValue[])Enum.GetValues(typeof(CardValue)))
                             {
                                Card newCard = new Card()
                                {
                                    Suit = suit,
                                    Value = value
                                    ImageName = "card" + suit.GetDisplayName()
                                                  + value.GetDisplayName()
                                };
                                cards.Add(newCard);
                             }
                  }
    }
}

//Fisher-Yates shuffling algorithim in C#

public class CardDeck
{
    public CardDeck()
    {
        //Convert new Stack<t> of card objects to an array
        var array = card.ToArray();

        Random rnd = new Random();

        //Step 1: For each unshuffled item in the collection
        for (int n = array.Count() -1; n > 0; --n)
        {
        // Step 2: randomly pick an element which has not been shuffled
        int k = rnd.Next(n + 1);

        //Step 3: Swap the seleceted element with the last unstruck element in the collection

        Card temp = array[n];
        array[n] = array[k];
        array[k] = temp;
        }

        //step 4, insert the now-shuffled cards into the Cards property
        for (int n = 0; n < array.Count(); n++)
        {
            Cards.Push(array[n]);
        }
    }
}
