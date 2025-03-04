using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_card_game
{
    internal class deck
    {

        List<car_card> car_Cards;
        public deck(List<car_card> cards)
        {
            this.car_Cards = cards;
        }
        public void shuffle()
        {
            int n = 0;
            car_card temp = null;
            Random rnd = new Random();
            for (int i = 0; i < car_Cards.Count; i++)
            {
                temp = car_Cards[i];
                n = rnd.Next(car_Cards.Count);
                car_Cards[i] = car_Cards[n];
                car_Cards[n] = temp;
            }
        }
        public car_card GetCard(int index)
        {
            if (car_Cards.Count > 0) 
            { 
            car_card c = car_Cards[index];
            car_Cards.RemoveAt(index);
            return c;
            }
            return null;
        } 
        public override string ToString() 
        {
            string retVal = "deck:\n" ;
            foreach (car_card card in car_Cards) 
            {
                retVal += card.ToString() ;
               
            }
            return retVal ;
        }
    }
}
