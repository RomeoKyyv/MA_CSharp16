using System;
using System.Text;

namespace SharpProject.Airport
{
    public class Passenger
    {
        private string FirstName, SecondName, Nation, Passport, Gender, Class;
        private DateTime BirthDate;

        public Passenger(string firstName, string secondName, string nation, string passport, string gender,
            string @class, DateTime birthDate)
        {
            FirstName = firstName;
            SecondName = secondName;
            Nation = nation;
            Passport = passport;
            Gender = gender;
            Class = @class;
            BirthDate = birthDate;
        }

        public string getPassengerInfo()
        {
            StringBuilder builder = new StringBuilder("|Passenger |");
            builder.Append(FirstName);
            builder.Append("|");
            builder.Append(SecondName);
            builder.Append("|");
            builder.Append(Nation);
            builder.Append("|");
            builder.Append(Passport);
            builder.Append("|");
            builder.Append(BirthDate.ToString());
            builder.Append("|");
            builder.Append(Gender);
            builder.Append("|");
            builder.Append(Class);
            builder.Append("|");
            return builder.ToString();
        }
    }
}