Console.Clear();

// Game Conditions
bool GameOver = false;
bool searchedalready = false;
int sceneID = 1;
int floorNo = 2;
string readnote1 = "No";
string readnote2 = "No";


// Game variables
bool door1Unlocked = false;
bool lockdown = true; //not used rn, deactivated in part 2

// User states
bool isAlive = true;
//int userHP = 100; //unused for now, wait for part 3

/* Weapon Stats (used in Pt. 3 and Pt. 2)
int axeDamage = 30;
int fistDamage = 10;
int gunDamage = 50;
gonna make a class for this */

/* Enemy states
int bossHP = 120;
int bossDamage = 30;
gonna make a class for this as well */

// User Interaction Variables
int userchoice = 0;

//Inventory Variables
bool hasRoomKey = false;
bool hasSecurityKey = false;
bool hasAxe = false;
bool hasBoltCutters = false;
//bool hasGun = false; //unused for now, wait for part 3
int medicalSupply = 0;

Console.WriteLine("=====GAME START=====");
while (!GameOver && isAlive)
{
    switch (sceneID)
    {
        case 1: //part 1
            Console.WriteLine("You are in a dark room, with the stench of decay, What do you do?");
            Console.ReadLine();
            while (sceneID == 1)
            {
                Console.WriteLine("1. Search the room for an exit");
                Console.WriteLine("2. Search the room for items");
                Console.WriteLine("3. Search the closet.");
                Console.WriteLine("What do you choose?");
                userchoice = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (userchoice)
                {
                    case 1:
                        if (hasRoomKey)
                        {
                            Console.WriteLine("You use the key to unlock the door and escape the room...");
                            door1Unlocked = true;
                            sceneID = 2;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("You search the room and find a door, but it's locked. You need a key.");
                        }
                        break;

                    case 2:
                        if (hasRoomKey)
                        {
                            Console.WriteLine("You already have the key.");
                        }
                        else
                        {
                            Console.WriteLine("You search the room and find a rusty key on the floor next to a bloody corpse.");
                            hasRoomKey = true;
                        }
                        break;

                    case 3:
                        if (hasAxe)
                        {
                            Console.WriteLine("You already have the axe.");
                        }
                        else
                        {
                            Console.WriteLine("You search the closet and find a rusty axe.");
                            hasAxe = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        break;
                }
            }
            break;

        case 2: //part 2
            Console.WriteLine("You go out the door and find yourself in an asylum");
            Console.ReadLine();
            while (sceneID == 2)
            {
                if (floorNo == 2)
                {
                    Console.WriteLine("1. Explore the rooms beside you.");
                    Console.WriteLine("2. Go down the hallway.");
                    Console.WriteLine("3. Open the security room.");
                    Console.WriteLine("4. Go back to the room you came from.");
                    Console.WriteLine("What do you do?");
                    userchoice = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    switch (userchoice)
                    {
                        case 1:
                            Console.WriteLine("The cells are locked, some of them have blood seeping through the doors.");
                            Console.WriteLine("Best not to open them.");
                            break;

                        case 2:
                            Console.WriteLine("At the end of the hallway, you see a staircase leading down to the main hall.");
                            Console.WriteLine("What do you do?");
                            Console.WriteLine();
                            Console.WriteLine("1. Go down the stairs.");
                            Console.WriteLine("2. Stay.");
                            userchoice = Convert.ToInt32(Console.ReadLine());

                            if (userchoice == 1)
                            {
                                Console.WriteLine("You go down to the 1st floor");
                                floorNo = 1;
                            }
                            else
                            {
                                Console.WriteLine("You stay on your current floor.");
                            }
                            break;

                        case 3:
                            if (hasSecurityKey)
                            {
                                Console.WriteLine("You slowly open the door to reveal a broken control panel, and a bloodtrail leading into a vent.");
                                Console.WriteLine("There is a note on the panel, as well as a pair of bolt cutters.");
                                hasBoltCutters = true;
                                Console.WriteLine("Do you read the note? (Yes/No)");
                                readnote2 = Console.ReadLine().ToLower();
                                if (readnote2 == "yes")
                                {
                                    Console.WriteLine("note 14");
                                }
                                else if (readnote1 == "no")
                                {
                                    Console.WriteLine("You chose not to read the note.");
                                }
                                else
                                {
                                    Console.WriteLine("Not a valid option");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The door rattles, but it doesn't open.");
                            }
                            break;

                        case 4:
                            if (door1Unlocked)
                            {
                                Console.WriteLine("You go back from where you came...");
                                sceneID = 1;
                            }
                            else
                            {

                                Console.WriteLine("The door is locked.");
                            }
                            break;

                        default:
                            Console.WriteLine("Not a valid choice.");
                            break;
                    }
                }
                else if (floorNo == 1)
                {
                    Console.WriteLine("You go down the stairs, into the main hall.");
                    Console.ReadLine();
                    while (floorNo == 1)
                    {
                        Console.WriteLine("1. Pry open the janitors closet.");
                        Console.WriteLine("2. Search the tables for supplies.");
                        Console.WriteLine("3. Check the security gate.");
                        Console.WriteLine("4. Check the chained door");
                        Console.WriteLine("5. Go back to floor 2.");
                        Console.WriteLine("What do you do?");
                        userchoice = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        switch (userchoice)
                        {
                            case 1:
                                Console.WriteLine("You try and open the janitors closet.");
                                if (hasAxe)
                                {
                                    Console.WriteLine("The door opens, and a pungent smell meets your nose.");
                                    Console.ReadLine();
                                    Console.WriteLine("You see a corpse.. with a facility ID");
                                    Console.WriteLine("and a note.");
                                    Console.WriteLine("Do you read it? (Yes/No)");
                                    readnote1 = Console.ReadLine().ToLower();
                                    if (readnote1 == "yes")
                                    {
                                        Console.WriteLine("note 14");
                                    }
                                    else if (readnote1 == "no")
                                    {
                                        Console.WriteLine("You chose not to read the note.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The door is sealed shut, maybe a tool can be used to break this open?");
                                }
                                break;

                            case 2:
                                Console.WriteLine("You search the tables for supplies.");
                                if (!searchedalready)
                                {
                                    Console.WriteLine("You have found bandages.");
                                    medicalSupply++;
                                    searchedalready = true;
                                }
                                else
                                {
                                    Console.WriteLine("There are no more items in this room.");
                                }
                                break;

                            case 3:
                                if (lockdown)
                                {
                                    Console.WriteLine("The security gate is sealed shut because of a lockdown.");
                                    Console.WriteLine("If we were to disable the lockdown..");
                                }
                                else if (!lockdown)
                                {
                                    Console.WriteLine("The door is open, it leads to the main corridor.");
                                    Console.WriteLine("The exit is near.");
                                    sceneID = 3;
                                }
                                break;

                            case 4:

                                if (hasBoltCutters)
                                {
                                    Console.WriteLine("You pull out your bolt cutters and snap the lock.");
                                    Console.WriteLine("The chains rattle and fall onto the floor.");
                                    Console.WriteLine("Do you open the door?");
                                    //tbc im tired
                                }
                                else
                                {
                                    Console.WriteLine("There are chains all over a door..");
                                    Console.WriteLine("We need something to cut the chains..");
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid Option.");
                                break;
                        }
                    }
                }
            }
            break;
    }
}