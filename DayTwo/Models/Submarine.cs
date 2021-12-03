namespace Day2.Models
{
    internal class Submarine
    {
        public int HorizontalPosition { get; protected set; } = 0;

        public int Depth { get ; protected set; } = 0;

        public void Move(IEnumerable<MoveInstruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                this.Move(instruction);
            }
        }

        public void Move(MoveInstruction instruction)
        {
            switch (instruction.Direction)
            {
                case Direction.Up:
                    this.MoveUp(instruction.Amount);
                    break;

                case Direction.Down:
                    this.MoveDown(instruction.Amount);
                    break;

                case Direction.Forward:
                    this.MoveForward(instruction.Amount);
                    break;

                default:
                    throw new NotSupportedException("Invalid direction");
            }
        }

        protected virtual void MoveUp(int amount)
            => this.Depth -= amount;

        protected virtual void MoveDown(int amount)
            => this.Depth += amount;

        protected virtual void MoveForward(int amount)
            => this.HorizontalPosition += amount;
    }
}
