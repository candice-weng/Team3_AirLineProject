﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Test
    {
        static void Main()
        {
            LoginRegister lg = new LoginRegister();

            Console.WriteLine(LoginRegister.CheckLoginUser("jame1@gmail.com", "123456"));


            Console.WriteLine(LoginRegister.CheckUserid("jame1@gmail.com"));
            Console.WriteLine(LoginRegister.RegisterUser("james@gmail.com", "good", "99887766"));
        }
    }
}
