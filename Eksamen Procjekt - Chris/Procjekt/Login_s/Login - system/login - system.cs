using Eksamen_Procjekt___Chris.Procjekt.Login_s.Defend_protocal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen_Procjekt___Chris.Procjekt.Login___system
{
    internal class lo_go
    {
        private void login_system_matthias()
        {
         string username_M = "Grove";
        string password_M = "Grove";
        }
        private void login_system_chris()
        {
            string username_c = "Either"; // her laver jeg username til mig
            string password_c = "Chris"; // her er password 
        }
        private void login_teacher()
        {
            string username_t = "Line";
            string password_t = "Line123";
        }


        public void login_system(string username_t, string password_t, string username_c, string password_c, string username_M, string password_M) // her tager jeg dem med ned i den offenlige void
        {
            bool username = false; 
            bool password = false;
            bool c_U = false;
            bool c_P = false;
            bool m_U = false;
            bool m_P = false;
            bool t_U = false;
            bool t_P = false;
            string userinput;
            Console.WriteLine("Please enter username");
            userinput = Console.ReadLine();
            if (userinput == username_c)
            {
                c_U = true;
                username = true;
            }else if (userinput == username_M)
            {
                m_U = true; 
                username = true;
            }else if (userinput == username_t)
            {
                username= true;
                t_U = true;
            }
            if(c_U == true) // hvis nu det er christoffer der logger in. 
            {
                Console.WriteLine("Please enter your password");
                userinput= Console.ReadLine();
                if (userinput != password_c)
                {
                    Console.Clear();
                    Console.WriteLine("Intruder");
                    Console.WriteLine("Please wait for defend protocal is being ativaede");
                    System.Threading.Thread.Sleep(1000);
                    IP_ban ip_ban = new IP_ban();
                    ip_ban.ban_or_not();
                }
                else
                {
                    password= true;
                    Console.Clear();
                    Console.WriteLine("Welcome back");
                    Console.WriteLine("Maker");
                    Console.WriteLine("please wait while we load your program");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("all good to go");
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                }
            }
            else
            { // tjekker for matthiases login
                if (m_U == true)
                {
                    Console.WriteLine("please enter your password matthias:");
                    userinput= Console.ReadLine();  
                    if(userinput != password_M) 
                    {
                        Console.Clear();
                        Console.WriteLine("Intruder");
                        Console.WriteLine("Please wait for defend protocal is being ativaede");
                        System.Threading.Thread.Sleep(1000);
                        IP_ban ip_ban = new IP_ban();
                        ip_ban.ban_or_not();
                    }
                    else 
                    {
                        password= true;
                        Console.Clear();
                        Console.WriteLine("Welcome back");
                        Console.WriteLine("Matthias");
                        Console.WriteLine("please wait while we load this program");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("all good to go");
                        System.Threading.Thread.Sleep(100);
                        Console.Clear();
                    }
                }else
                {
                    if(t_U== true) 
                    {
                        Console.WriteLine("Welcome line please enter your password");
                        userinput= Console.ReadLine();
                        if(userinput != password_t) 
                        {
                            Console.Clear();
                            Console.WriteLine("Intruder");
                            Console.WriteLine("Please wait for defend protocal is being ativaede");
                            System.Threading.Thread.Sleep(1000);
                            IP_ban ip_ban = new IP_ban();
                            ip_ban.ban_or_not();
                        }
                        else
                        {
                            password= true;
                            Console.Clear();
                            Console.WriteLine("Welcome back");
                            Console.WriteLine("Line");
                            Console.WriteLine("please wait while we load this eksamens procjekt");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("all good to go");
                            System.Threading.Thread.Sleep(100);
                            Console.Clear();
                        }
                    }
                }
            }
        }


    }
}
