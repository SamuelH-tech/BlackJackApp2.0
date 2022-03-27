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
        private bool isValid = true;
        private DateTime dateRegistered;
        private DateTime lastAccess;
        private int handsWon;
        private int handsLost;
        private int chipsWon;


        public static List<User> users = new List<User>();
      
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
            
        }

        /// <summary>
        /// User constructor: empty constructor used strictly for inheritance and instantiation
        /// </summary>
        public User()
        {

        }

        #endregion

   

    }
}
