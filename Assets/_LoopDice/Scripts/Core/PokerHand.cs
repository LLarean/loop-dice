namespace LoopDice.Core
{
    public record PokerHand
    {
        private readonly int[] _diceValues;

        public PokerHand(int[] diceValues)
        {
            _diceValues = diceValues;
        }

        public HandType Type()
        {
            var diceDictionary = new DiceDictionary(_diceValues);

            if (new FiveKind(diceDictionary).IsValid()) return HandType.FiveKind;
            if (new FourKind(diceDictionary).IsValid()) return HandType.FourKind;
            if (new FullHouse(diceDictionary).IsValid()) return HandType.FullHouse;
            if (new Straight(diceDictionary).IsValid()) return HandType.Straight;
            if (new TwoPair(diceDictionary).IsValid()) return HandType.TwoPair;
            if (new OnePair(diceDictionary).IsValid()) return HandType.OnePair;

            return HandType.Bust;
        }
    }
}