namespace _64BitArray
{
    using System;
    class UlongBitArray
    {
        private ulong number;

        public UlongBitArray(ulong number)
        {
            this.number = number;
        }

        public ulong this[int index]
        {
            get 
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return (this.number & (ulong)(1 << index)); 
            }
            set 
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Only binary digits allowed - 0 or 1!");
                }
                if (value == 1)
                {
                    this.number = this.number | (value << index);
                }
                else
                {
                    this.number = this.number & (~((ulong)1 << index));
                }
            }
        }

        public override bool Equals(object obj)
        {
            return this.number == (obj as UlongBitArray).number;
        }

        public static bool operator ==(UlongBitArray firstArr, UlongBitArray secondArr)
        {
            return firstArr.Equals(secondArr);
        }

        public static bool operator !=(UlongBitArray firstArr, UlongBitArray secondArr)
        {
            return !firstArr.Equals(secondArr);
        }

        public override int GetHashCode()
        {
            return number.GetHashCode();
        }
    }
}
