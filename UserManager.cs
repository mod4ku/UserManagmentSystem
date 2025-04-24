using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagmentSystem
{
    public class UserManager
    {
        private List _users = new List();

        public void AddUser(string username)
        {
            _users.Add(username);
        }
    }
}
