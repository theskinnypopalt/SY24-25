using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_card_game
{
    internal class hand
    {
        List<car_card> car_Cards;
        public car_card top_card()
        {
            return car_Cards[0];
        }

      public void add(car_card car_Card)
        {
            car_Cards.Add(car_Card);
        }

    }
}
