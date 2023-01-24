using Eksamen_Procjekt___Chris.Main__Menu.Credits;
using Eksamen_Procjekt___Chris.Main__Menu.Exit;
using Eksamen_Procjekt___Chris.Main__Menu.intro;
using Eksamen_Procjekt___Chris.Procjekt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// made by Christoffer / either

namespace Eksamen_Procjekt___Chris.Main__Menu
{
    internal class Manu
    {
        public void Menu()
        {
            int choice_start = 0;
            int choice_end = 0;
            do
            {
                // her kommer logoet fordi jeg kan :P
                Console.WriteLine("___________________________________________");
                Console.WriteLine("         ***Menu***");
                Console.WriteLine("___________________________________________");
                Console.WriteLine("1.introduktion");
                Console.WriteLine("2. Procjekt");
                Console.WriteLine("3. Credits");
                Console.WriteLine("4. Exit");
                choice_start = Convert.ToInt32(Console.ReadLine());
                switch (choice_start)
                {
                    case 1: // her er introduktionen til selve programmet
                        if (choice_start == 1)
                        {
                            intro_start_game intro = new intro_start_game(); // her kommer selve introduktionen til programmet
                            intro.intro_start();
                            Console.Clear(); 
                            // grunden til at der ikke er mere er fordi så kommer man dirakte ud til main hub
                        }
                        else
                        {
                            // her ned kommer man hvis man ikke vælger en af mulighederne hvor jeg smider personen ud af progeammet
                            Console.WriteLine("NOT THIS ONE");
                            return;
                        }
                        break;
                    case 2: // her er selve eksamens procjektet
                        if (choice_start == 2)
                        {
                             // her er selve eksamsprocjektet 
                             // her kalder jeg funktionen af eksamens procjktet
                             Main_hub main_Hub = new Main_hub();
                            main_Hub.main();
                        }
                        else
                        {
                            // her kommer man ned hvis man ikke vælger en af mulighederne
                            Console.WriteLine("NOT THIS ONE");
                            return; // og jeg smider dem ud fordi jeg kan
                        }
                        break;
                    case 3: // her kommer creditsende til dem der har lavet programmet 
                        if (choice_start == 3)
                        {
                            Console.Clear();
                            credits credits = new credits(); // her kalder jeg funktionen credits
                            credits.credits_e_G();
                        }
                        else
                        {
                            // her kommer man ned hvis man ikke vælger en af mulighederne
                            Console.WriteLine("NOT THIS ONE");
                            return;
                        }
                        break;
                    case 4: // her kommer exit method
                        if (choice_start == 4)
                        {
                            // her kalder jeg funktionen at forlade programmet
                            Exit_program exit_Program = new Exit_program();
                            exit_Program.Exit_program_s();
                        }
                        else
                        {
                            // her kommer man ned hvis man ikke vælger mulighederne
                            Console.WriteLine("NOT THIS ONE");
                            return;
                        }
                        break;
                }
            }while (choice_end != 9);
            
        }
    }
}
