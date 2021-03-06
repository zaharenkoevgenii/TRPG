﻿using System;
using System.Collections.Generic;
using System.Linq;
using Library.Entities.Enumerables;

namespace Library.Entities.Common.Dice
{
    internal class Dices : IDices
    {
        private readonly Dictionary<DiceType, byte> dices;
        private readonly Random random;

        internal Dices(string diceString)
        {
            dices = new Dictionary<DiceType, byte>();
            foreach (var dice in diceString.Split('+'))
            {
                var index = dice.IndexOf("d", StringComparison.InvariantCultureIgnoreCase);
                if (index < 0) continue;
                var key = (DiceType) Enum.Parse(typeof(DiceType), dice.Substring(index));
                var value = byte.Parse(dice.Substring(0, index));
                if (dices.ContainsKey(key))
                    dices[key] += value;
                else
                    dices.Add(key, value);
            }

            random = new Random();
        }

        public uint GetValue()
        {
            uint val = 0;
            foreach (var dice in dices)
                for (var i = 0; i < dice.Value; i++)
                    val += (uint) random.Next(1, int.Parse(dice.Key.ToString().Substring(1)));
            return val;
        }

        public string GetDiceString()
        {
            return string.Join("+", dices.Select(d => $@"{d.Value}{d.Key}"));
        }
    }
}