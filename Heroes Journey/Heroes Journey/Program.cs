using System;

namespace Heroes_Journey
{
    public class Races
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public Races(string name, int health, int strength, int agility)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Agility = agility;
        }
    }
    public class CharacterClass
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Agility { get; set; }

        public CharacterClass(string name, int health, int agility)
        {
            Name = name;
            Health = health;
            Agility = agility;
        }
    }
    public class Character
    {
        public string Name { get; set; }
        public string RacesName { get; set; }
        public string CharacterClassName { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public Character(string name, string racesName, string characterClassName, int health, int strength, int agility)
        {
            Name = name;
            RacesName = racesName;
            CharacterClassName = characterClassName;
            Health = health;
            Strength = strength;
            Agility = agility;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            string[] emails = { "chuckskullgreen@gmail.com", "pgpetar3@gmail.com" };
            string[] passwords = { "cakitest", "iAmthebest"};
            string emailLogin;
            string passwordLogin;
            int checkEmail;
            int checkPassword;
            int checker = 1;



            Console.WriteLine("Enter email: ");
            emailLogin = Console.ReadLine().ToLower();

            Console.WriteLine("Enter password: ");
            passwordLogin = Console.ReadLine().ToLower();

            while (emailLogin == "" || passwordLogin == "")
            {
                Checker(checker++);
                Console.WriteLine("Don't leave email or password empty! Press enter to try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter email: ");
                emailLogin = Console.ReadLine().ToLower();
                Console.WriteLine("Enter password: ");
                passwordLogin = Console.ReadLine().ToLower();
            }
            while (!emailLogin.Contains(".") || !emailLogin.Contains("@"))
            {
                Checker(checker++);
                Console.WriteLine("Email is not valid. Press enter to try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter email: ");
                emailLogin = Console.ReadLine().ToLower();
                Console.WriteLine("Enter password: ");
                passwordLogin = Console.ReadLine().ToLower();
            }

            checkEmail = Array.IndexOf(emails, emailLogin);
            checkPassword = Array.IndexOf(passwords, passwordLogin);

            while (checkEmail == -1 || checkPassword == -1 || checkEmail != checkPassword)
            {
                Checker(checker++);
                Console.WriteLine("Email or password did not match. Press enter to try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter email: ");
                emailLogin = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                passwordLogin = Console.ReadLine();
                checkEmail = Array.IndexOf(emails, emailLogin);
                checkPassword = Array.IndexOf(passwords, passwordLogin);
            }

            Console.WriteLine("Welcome {0}!", emailLogin);
            Console.WriteLine("Press Enter to start with character creation...");
            Console.ReadLine();
            Console.Clear();
            Game();

            Console.ReadLine();
        }
        static void Checker(int number)
        {
            if (number == 5)
            {
                Console.WriteLine("You tried too many times! Press enter to exit...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        static void Game()
        {
            string name;
            int userRace;

            Races dwarf = new Races("Dwarf", 100, 6, 2);
            Races elf = new Races("Elf", 60, 4, 6);
            Races human = new Races("Human", 80, 5, 4);
            Races userRaceChoosed;


            int userClass;
            CharacterClass userClassChoosed;
            CharacterClass warrior = new CharacterClass("Warrior", +20, -1);
            CharacterClass rogue = new CharacterClass("Rogue", -20, +1);
            CharacterClass mage = new CharacterClass("Mage", +20, -1);


            Console.WriteLine("Choose a name:");
            name = Console.ReadLine();
            while (name.Length < 2 || name.Length > 20)
            {
                Console.WriteLine("Hero name must be from 2 to 20 characters long. Press enter to try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Choose a name:");
                name = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Choose a race:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1) {0}", dwarf.Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2) {0}", elf.Name);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3) {0}", human.Name);
            Console.ResetColor();
            bool success = Int32.TryParse(Console.ReadLine(), out userRace);
            while (!success || userRace < 1 || userRace > 3)
            {
                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Choose a race:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1) {0}", dwarf.Name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2) {0}", elf.Name);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3) {0}", human.Name);
                Console.ResetColor();
                success = Int32.TryParse(Console.ReadLine(), out userRace);
            }
            if (userRace == 1)
            {
                userRaceChoosed = dwarf;
            }
            else if (userRace == 2)
            {
                userRaceChoosed = elf;
            }
            else
            {
                userRaceChoosed = human;
            }

            Console.Clear();

            Console.WriteLine("Choose a class:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1) {0}", warrior.Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2) {0}", rogue.Name);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3) {0}", mage.Name);
            Console.ResetColor();
            bool success2 = Int32.TryParse(Console.ReadLine(), out userClass);
            while (!success2 || userClass < 1 || userClass > 3)
            {
                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Choose a class:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1) {0}", warrior.Name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2) {0}", rogue.Name);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3) {0}", mage.Name);
                Console.ResetColor();
                success2 = Int32.TryParse(Console.ReadLine(), out userClass);
            }

            if (userClass == 1)
            {
                userClassChoosed = warrior;
            }
            else if (userClass == 2)
            {
                userClassChoosed = rogue;
            }
            else
            {
                userClassChoosed = mage;
            }
            Character character = new Character(name, userRaceChoosed.Name, userClassChoosed.Name, userRaceChoosed.Health + userClassChoosed.Health, userRaceChoosed.Strength, userRaceChoosed.Agility + userClassChoosed.Agility);

            Console.WriteLine("Character successfully created!");
            Console.WriteLine("{0}({1}) the {2}", character.Name, character.RacesName, character.CharacterClassName);
            Console.WriteLine("Status: {0} HP, {1} STR, {2} AGI", character.Health, character.Strength, character.Agility);
            Console.WriteLine("Press Enter to start the game...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Bandits attack you out of nowhere. They seem very dangerous...");
            Console.WriteLine("Health: {0}", character.Health);
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");

            bool success3 = Int32.TryParse(Console.ReadLine(), out int answer);
            while (!success3 || answer < 1 || answer > 2)
            {
                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Bandits attack you out of nowhere. They seem very dangerous...");
                Console.WriteLine("Health: {0}", character.Health);
                Console.WriteLine("1) Fight");
                Console.WriteLine("2) Run");
                success3 = Int32.TryParse(Console.ReadLine(), out answer);
            }
            Answer(answer, character, -20);

            Console.WriteLine("You bump in to one of the guards of the nearby village. They attack you without warning...");
            Console.WriteLine("Health: {0}", character.Health);
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");

            success3 = Int32.TryParse(Console.ReadLine(), out answer);
            while (!success3 || answer < 1 || answer > 2)
            {
                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You bump in to one of the guards of the nearby village. They attack you without warning...");
                Console.WriteLine("Health: {0}", character.Health);
                Console.WriteLine("1) Fight");
                Console.WriteLine("2) Run");
                success3 = Int32.TryParse(Console.ReadLine(), out answer);
            }
            Answer(answer, character, -30);

            Console.WriteLine("A Land Shark appears. It starts chasing you down to eat you...");
            Console.WriteLine("Health: {0}", character.Health);
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");

            success3 = Int32.TryParse(Console.ReadLine(), out answer);
            while (!success3 || answer < 1 || answer > 2)
            {
                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("A Land Shark appears. It starts chasing you down to eat you...");
                Console.WriteLine("Health: {0}", character.Health);
                Console.WriteLine("1) Fight");
                Console.WriteLine("2) Run");
                success3 = Int32.TryParse(Console.ReadLine(), out answer);
            }
            Answer(answer, character, -50);

            Console.WriteLine("You accidentally step on a rat. His friends are not happy. They attack...");
            Console.WriteLine("Health: {0}", character.Health);
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");

            success3 = Int32.TryParse(Console.ReadLine(), out answer);
            while (!success3 || answer < 1 || answer > 2)
            {
                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You accidentally step on a rat. His friends are not happy. They attack...");
                Console.WriteLine("Health: {0}", character.Health);
                Console.WriteLine("1) Fight");
                Console.WriteLine("2) Run");
                success3 = Int32.TryParse(Console.ReadLine(), out answer);
            }
            Answer(answer, character, -10);

            Console.WriteLine("You find a huge rock. It comes alive somehow and tries to smash you...");
            Console.WriteLine("Health: {0}", character.Health);
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");

            success3 = Int32.TryParse(Console.ReadLine(), out answer);
            while (!success3 || answer < 1 || answer > 2)
            {
                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You find a huge rock. It comes alive somehow and tries to smash you...");
                Console.WriteLine("Health: {0}", character.Health);
                Console.WriteLine("1) Fight");
                Console.WriteLine("2) Run");
                success3 = Int32.TryParse(Console.ReadLine(), out answer);
            }
            Answer(answer, character, -30);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You won!");
            Console.ResetColor();
            PlayAgain();


        }

        static void Answer(int answer, Character character, int dmg)
        {
            int Randomnumber;
            var random = new Random();


            if (answer == 1)
            {
                Randomnumber = random.Next(1, 10);
                if (Randomnumber < character.Strength)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won fight!");
                    Console.ResetColor();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    character.Health += dmg;
                    Checker2("fight", character.Health);
                }
            }
            else
            {
                Randomnumber = random.Next(1, 10);
                if (Randomnumber < character.Agility)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you run away");
                    Console.ResetColor();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    Console.Clear();

                }
                else
                {
                    character.Health += dmg;
                    Checker2("run", character.Health);
                }
            }

        }

        static void Checker2(string word, int number)
        {

            if (number <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You Lost!");
                Console.ResetColor();
                PlayAgain();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (word == "fight")
                {
                    Console.WriteLine("You lost the fight!");

                }
                else
                {
                    Console.WriteLine("You didn't manage to run away!");
                }
                Console.ResetColor();
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void PlayAgain()
        {
            Console.WriteLine("Want to play again?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");
            bool question = Int32.TryParse(Console.ReadLine(), out int answer);
            while (!question || answer < 1 || answer > 2)
            {
                Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Want to play again?");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
                question = Int32.TryParse(Console.ReadLine(), out answer);
            }
            if (answer == 1)
            {
                Console.Clear();
                Console.WriteLine("Press Enter to start with character creation...");
                Console.ReadLine();
                Console.Clear();
                Game();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thank you for playing. Press Enter to exit and have a nice day!");
                Console.ReadLine();
                Environment.Exit(0);

            }
        }
    }
}
