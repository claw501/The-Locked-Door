using The_Locked_Door;


string PasscodeAsString;
int Passcode;

while (true)
{
    Console.WriteLine("What would you like for the passcode to be?");

    PasscodeAsString = Console.ReadLine();
    try
    {
        Passcode = Convert.ToInt16(PasscodeAsString);
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine("This is not an acceptable passcode. It must be an integer. ");
    }
}
Door door = new Door(Passcode);
door.Run();