using System;

namespace Exercise01
{
    class Author
    {
        private char gender;

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Gender
        {
            get
            {
                if (gender == 'm')
                {
                    return "Male";
                }
                else
                {
                    return "Female";
                }
            }
        }

        public Author(string _name, string _email, char _gender)
        {
            Name = _name;
            Email = _email;
            if (_gender != 'm' && _gender != 'f')
            {
                Console.WriteLine("Insert Male or Female");
            }
            gender = _gender;
        }

        public void UpdateEmail(string newemail)
        {
            Email = newemail;
        }

        public string AsString()
        {
            return $"Author[name={Name}, email={Email}, gender={Gender}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Author a1 = new Author("Nikos", "aa@aa.com", 'm');


            a1.UpdateEmail("bb@bb.com");

            Console.WriteLine(a1.AsString());
        }
    }
}
