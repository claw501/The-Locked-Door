using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace The_Locked_Door
{
    enum DoorState
    {
        LOCKED,
        CLOSED,
        OPEN
    }

    internal class Door
    {

        int Passcode;

        DoorState doorstate;

        public Door(int Passcode)
        {
            doorstate = DoorState.LOCKED;
            this.Passcode = Passcode;
        }


        public void Run()
        {
            while (true)
            {
                Console.WriteLine("What would you like to do with the door?");

                if (doorstate == DoorState.LOCKED)
                {
                    Console.WriteLine("The door is locked and requires the passcode to open. Would you like to change the passcode? ");
                    string Response = (Console.ReadLine());
                    Response.ToLower();

                    if (Response == "yes")
                    {
                        GetNewPassword();
                    }
                    else;

                    UnlockDoor();

                }
                else if (doorstate == DoorState.CLOSED)
                {
                    ClosedDoor();
                    
                }
                else
                {
                    OpenDoor();
                }

            }
        }

        private void GetNewPassword()
        {
            while (true)
            {
                Console.WriteLine("What is the current password? ");

                int GuessInt = Convert.ToInt16(Console.ReadLine());

                if (GuessInt != Passcode)
                {
                    Console.WriteLine("This is not the current password. Try again. ");
                    continue;
                }

                Console.WriteLine("What would you like for the new password to be? ");

                Passcode = Convert.ToInt16(Console.ReadLine());
                break;
            }
        }
        private void UnlockDoor()
        {
            while (true)
            {
                Console.WriteLine("What is the passcode? ");
                int Guess = Convert.ToInt16(Console.ReadLine());

                if (Guess == Passcode)
                {
                    Console.WriteLine("The door is now unlocked. ");
                    doorstate = DoorState.CLOSED;
                    break;
                }
                else
                {
                    Console.WriteLine("This is not the current password. Try again. ");
                    continue;
                }
            }
        }
        private void ClosedDoor()
        {
            while (true)
            {
                Console.WriteLine("The door is closed. What would you like to do? ");
                string Response = (Console.ReadLine());
                Response.ToLower();
                
                if (Response == "open")
                {
                    Console.WriteLine("The door is now open.");
                    doorstate = DoorState.OPEN;
                    break;
                }
                else if (Response == "lock")
                {
                    Console.WriteLine("The door is now locked.");
                    doorstate = DoorState.LOCKED;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not an option.");
                    continue;
                }
            }
        }
        private void OpenDoor()
        {
            while (true)
            {
                Console.WriteLine("The door is open. Would you like to close it? ");
                string Response = (Console.ReadLine());
                Response.ToLower();
                if (Response == "yes")
                {
                    Console.WriteLine("The door is now closed.");
                    doorstate = DoorState.CLOSED;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not an option.");
                    continue;
                }
            }
        }


    }
}
