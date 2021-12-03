namespace Day2.Models
{
    internal class MoveInstruction
    {
        public Direction Direction { get; private set; }

        public int Amount { get; private set; }

        public MoveInstruction(Direction direction, int amount)
        {
            this.Direction = direction;
            this.Amount = amount;
        }
    }
}
