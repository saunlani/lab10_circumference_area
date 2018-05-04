using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class User
    {
        //Data here (member variables) 
        //We typically want data to be private
        //don't put values in here--this is the blueprint
        //DECLARATIONS ONLY
        //  (there can be default values, like paid always starts false)
        //Fields 
        //Full name
        private string name;

        //you can write a property to wrap a field
        //not a method; no parentheses
        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        //password
        private string password;

        //auto generated Password
        public string Password { set => password = value; }

        //email
        private string email;
        public string Email { get => email; set => email = value; }

        //age
        private int age;
        public int Age { get => age; set => age = value; }

        //paid subscriber?
        private bool paid;
        public bool Paid { get => paid; set => paid = value; }

        //registration date
        private DateTime regDate;
        public DateTime RegDate { get => regDate; }


        //Methods
        //we typically want methods to be public
        //these are instance methods--by definition they aren't static

        //Constructor: method that initializes a new instance of this class
        //access modifier: almost always public
        //return type: none (not void, nothing)
        //name: same as class (capitalization counts)
        //parameter list: varies
        //  no-arguments version which sets everything to null or default values
        //  all-arguments version which takes a parameter for each data member
        //  we might use some number in between based on our design

        //shadow variables: I can have a local variable/parameter
        //  with the same name as an instance variable
        public User(string name, string password,
            string email, int age)
        {
            //common mistake: don't put the parameter on the left
            //instance variable always goes on the left
            //this. refers to this actual instance running the code
            this.name = name;
            this.password = password;
            this.email = email;
            this.age = age;
            this.paid = false; //all users start unpaid (false)
            this.regDate = DateTime.Now; //I don't need a parameter, I need NOW
        }

        //other methods
        //TODO: CheckPassword()
        public bool CheckPassword(string password)
        {
            return (this.password == password);
        }

        //the ToString method allows us to custom output instance info
        //whenever the instance is used in a string context
        //the method header should match this exactly:
        public override string ToString()
        {
            return $"{name}\t{email}\t(Age: {age})\tRegistered: {regDate}";
        }
    }
}