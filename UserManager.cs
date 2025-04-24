using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagmentSystem
{
    public class UserManager
    {
        private List _users = new List();
        private int_count
        public void AddUser(string username)
        {
            _users.Add(username);
        }
        public bool RemoveUser(string username)
        {
            return _users.Remove(username);
        }
    }
}
