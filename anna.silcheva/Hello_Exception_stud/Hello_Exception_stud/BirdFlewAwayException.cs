using System;

namespace Hello_Exception_stud
{
    //Create the BirdFlewAwayException class, derived from ApplicationException  with two properties  
    //When
    //Why
    //Create constructors
    public class BirdFlewAwayException : ApplicationException
    {
        public DateTime When{get; set;}
        public string Why { get; set; }
        public BirdFlewAwayException() { }
        public BirdFlewAwayException(string message, string cause, DateTime time)
            :base(message)
        {
            Why = cause;
            When = time;
        }
    }


}
