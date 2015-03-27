namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        #region Constructors
        public InvalidRangeException(string message, T start, T end, Exception exception)
            : base(message, exception)
        {
            this.Start = start;
            this.End = end;
        }
        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {

        }
        public InvalidRangeException(T start, T end)
            : this(string.Empty, start, end, null)
        {

        }
        #endregion

        #region Properties
        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }
        #endregion
    }
}
