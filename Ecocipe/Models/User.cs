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
        private int id;
        private string username;

        public int Id { get => id; }
        public string Username { get => username; }


        public User(int id, string username)
        {
            this.id = id;
            this.username = username;
        }
    }
}
