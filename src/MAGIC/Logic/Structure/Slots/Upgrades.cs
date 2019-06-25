﻿using System;
using System.Collections.Generic;
using ClashLand.Logic.Structure.Slots.Items;

namespace ClashLand.Logic.Structure.Slots
{
    internal class Upgrades : List<Slot>, ICloneable
    {
        internal Player Player;
        
        internal Upgrades()
        {
            // Upgrades.
        }

        internal Upgrades(Player _Player)
        {
            this.Player = _Player;
        }
        internal Upgrades Clone()
        {
            return this.MemberwiseClone() as Upgrades;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}