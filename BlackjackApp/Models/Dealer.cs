﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackjackApp.Models
{
    public class Dealer : Player
    {
        public bool ShowCards => hand.HasCards && !hand.HiddenCard;
        public bool ShouldHit => hand.Value < 17 || (hand.HasAce && hand.Value == 17);
        public void ShowCard() => hand.HiddenCard = false;
    }
}
