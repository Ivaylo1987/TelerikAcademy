namespace GenericRangeException
{
    using System;
    public class RangeException<T> : ApplicationException
    {
        private T startOfRange;
        private T endOfRange;

        public RangeException(string msg, T _startOfRange, T _endOfRange)
            : this(msg, null, _startOfRange, _endOfRange)
        {
        }

        public RangeException(string msg, Exception innerException, T _startOfRange, T _endOfRange)
            : base(msg, innerException)
        {
        }

        public override string Message
        {
            get
            {
                return base.Message + " " + string.Format("Allowed range is: {0} - {1}", this.startOfRange, this.endOfRange);
            }
        }
    }
}
