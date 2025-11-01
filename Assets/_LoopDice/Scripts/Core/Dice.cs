using System;

namespace LoopDice.Core
{
    public record Dice
    {
        private const int MinimumValue = 1;

        private readonly int _maximumValue;
        private readonly Random _random;
        private readonly int _currentValue = MinimumValue;

        public Dice(Random random, int maximumValue)
        {
            _random = random;
            _maximumValue = maximumValue;
        }

        private Dice(Random random, int maximumValue, int currentValue) : this(random, maximumValue)
        {
            _currentValue = currentValue;
        }

        public Dice Roll()
        {
            var randomValue = _random.Next(MinimumValue, _maximumValue + 1);
            return new Dice(_random, _maximumValue, randomValue);
        }

        public int Value()
        {
            return _currentValue;
        }
    }
}