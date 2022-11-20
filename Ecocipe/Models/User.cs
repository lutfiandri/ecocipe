using Ecocipe.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecocipe.Models
{
    public class User
    {
        private string username;

        public string Username { get => username; }

        public User(string username)
        {
            this.username = username;
        }
    }
}
