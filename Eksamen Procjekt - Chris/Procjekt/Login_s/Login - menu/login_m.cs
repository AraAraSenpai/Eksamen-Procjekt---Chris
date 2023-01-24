using Eksamen_Procjekt___Chris.Main__Menu;
using Eksamen_Procjekt___Chris.Procjekt.Kryptering;
using Eksamen_Procjekt___Chris.Procjekt.Kryptering.Uncrypt;
using Eksamen_Procjekt___Chris.Procjekt.Login___system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen_Procjekt___Chris.Procjekt.Login_s.Login___menu
{
    internal class login_m
    {
        public void login_ma()
        {
         /*  lo_go lo_Go = new lo_go();
            lo_Go.login_system(); brug for hjælp */
         Crypting_hub _Hub = new Crypting_hub();
         _Hub.Crypting();
            int choice2 = 0;
            do
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine("         ***Menu-UnCrypt***");
                Console.WriteLine("_____________________________________");
                Console.WriteLine("1. Uncrypt numbers");
                Console.WriteLine("2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine()); 
                switch (choice)
                {
                    case 1:
                        if(choice == 1)
                        { // her kommer uncrypt programmet
                            UnCrypt_hub unCrypt_Hub = new UnCrypt_hub();
                            unCrypt_Hub.UnCrypt_main_hub();
                        }
                        else
                        {
                            Console.WriteLine("NOT THIS ONE");
                            return;
                        }
                       break;
                    case 2: // her komme man til bage til procjekt menu
                        if (choice == 2)
                        {
                            Manu manu = new Manu();
                            manu.Menu();
                        }else
                        {
                            Console.WriteLine("NOT THIS ONE");
                            return;
                        }
                        break;
                }
            } while (choice2 != 9);
        }
    }
}
