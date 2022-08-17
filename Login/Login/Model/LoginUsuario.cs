using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Login.Model
{
    public class LoginUsuario : ContentPage
    {
        public LoginUsuario()
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string nome { get; set; }
        }
    }
}