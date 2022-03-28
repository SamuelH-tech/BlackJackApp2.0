using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackApp2._0
{
    class User
    {

        #region "Variable declarations"

        // Instance variables
        private string userName;
        private string userPassword;
        private DateTime dateRegistered;
        private DateTime lastAccess;
        private int handsWon;
        private int handsLost;
        private int chipsWon;

       //scrapped
       //public static List<User> users = new List<User>();
      
        #endregion

        #region "Constructors"

        /// <summary>
        /// User constructor: accepts a userame and password and sets values as appropriate.
        /// </summary>
        /// <param name="nameValue">the user's name</param>
        /// <param name="messageValue">a user's password</param>
        public User(string nameValue, string passwordValue)
        {
            //set the user's name
            userName = nameValue;
            //set the user's password
            userPassword = passwordValue;
            dateRegistered = DateTime.Now;
            lastAccess = DateTime.Now;
            handsWon = 0;
            handsLost = 0;
            chipsWon = 0;

        }

        /// <summary>
        /// User constructor: empty constructor used strictly for inheritance and instantiation
        /// </summary>
        public User()
        {

        }

        #endregion

        /// <summary>
        /// Gets and sets a user's lastAccess
        /// </summary>
        /// <returns>an employee's name</returns>
        public DateTime SetLastAccess
        {   
            set
            {
                lastAccess = DateTime.Now;
            }
        }
        /// <summary>
        /// Gets and sets a worker's name
        /// </summary>
        /// <returns>an employee's name</returns>
        public int IncrementHandsWon
        {
            get
            {
                return handsWon;
            }
            set
            {
                handsWon = handsWon + 1;
            }
        }

        public int IncrementHandsLost
        {
            get
            {
                return handsLost;
            }
            set
            {
                handsLost = handsLost + 1;
            }
        }
        public int ChipsWon
        {
            get
            {
                return chipsWon;
            }
            set
            {
                chipsWon = chipsWon + value;
            }
        }




    }
}
