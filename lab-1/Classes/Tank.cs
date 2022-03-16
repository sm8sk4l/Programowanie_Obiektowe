using System;
namespace lab_1.Classes
{
    public class Tank
    {
        public readonly int Capacity;
        private int _level;
        public Tank(int capacity)
        {
            Capacity = capacity;
        }
        public int Level
        {
            get { return _level; }
            set
            {
                if (value < 0 || value > Capacity) throw new ArgumentOutOfRangeException();
                _level = value;
            }
        }
        public bool Consume(int w)
        {
            if (w > _level)
            {
                return false;
            }
            Level = _level - w;
            return true;
        }
        public void Refuel(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Argument cant be non positive!");
            }
            if (_level + amount > Capacity)
            {
                throw new ArgumentException("Argument is to large!");
            }
            _level += amount;
        }
        public bool Refuel(Tank sourceTank, int amount)
        {
            if (this.Level + amount > Capacity)
            {
                return false;
            }
            if (sourceTank.Consume(amount))
            {
                this.Refuel(amount);
                return true;
            }

            return false;
        }

    }
}
