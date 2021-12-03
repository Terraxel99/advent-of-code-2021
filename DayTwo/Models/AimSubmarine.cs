namespace Day2.Models
{
    internal class AimSubmarine : Submarine
    {
        public int Aim { get; private set; }

        protected override void MoveDown(int amount)
            => this.Aim += amount;

        protected override void MoveUp(int amount)
            => this.Aim -= amount;

        protected override void MoveForward(int amount)
        {
            base.MoveForward(amount);
            this.Depth += (this.Aim * amount);
        }
    }
}
