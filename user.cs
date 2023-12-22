using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public abstract class User
    {
        public int Access { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public void SetPropertiesFromDatabase(int access, string username, string password)
        {
            Access = access;
            Username = username;
            Password = password;
        }
    }

    public class SimpleUser : User
    {
        public SimpleUser()
        {
            Access = 0;
            Username = string.Empty;
            Password = string.Empty;
        }
    }

    internal class Admin : User
    {
        public Admin()
        {
            Access = 1;
            Username = string.Empty;
            Password = string.Empty;
        }
    }


    /*class SimpleUser : User
    {
        public int Access = 0;

        // Общие свойства для всех пользователей, если необходимо
        public string Username { get; set; }
        public string Password { get; set; }

        public SimpleUser()
        {
            // Пример инициализации свойств при создании объекта
            Username = string.Empty;
            Password = string.Empty;
            Access = 0;
        }
    }
   
    internal class Admin : User 
    {
        public int Access = 1;
        public string Username { get; set; }
        public string Password { get; set; }
    }*/
}
