using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the New Adventure");
            Console.WriteLine("What is your name ?");
            Novice Player = new Novice();
            Player.Name = Console.ReadLine();
            Console.WriteLine($"Hi {Player.Name}, Ready to begin new adventure ? [y/n]");
            string bReady = Console.ReadLine();
            if (bReady == "y")
            {
                Console.WriteLine("===============================================");
                Console.WriteLine($"{Player.Name} is entering the world...");
                Enemy enemy1 = new Enemy("wolf");
                Console.WriteLine($"{Player.Name} is encountering {enemy1.Name}");
                Console.WriteLine($"{enemy1.Name} attacking you...");
                Console.WriteLine("Choose your action");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Run Away");
                Console.WriteLine(" ");

                while (!Player.IsDead && !enemy1.IsDead && !Player.IsRunningAway)
                {
                    string PlayerAction = Console.ReadLine();
                    switch(PlayerAction)
                    {
                        case"1":
                        Console.WriteLine("\n-----------------------------------------------------");
                        Console.WriteLine($"{Player.Name} is doing Single Attack");
                        enemy1.GetHit(Player.AttackPower);
                        enemy1.Attack(enemy1.AttackPower);
                        Player.Experience += 0.3f;
                        Player.GetHit(enemy1.AttackPower);
                        Console.WriteLine($"Player Health : {Player.Health} | Enemy Health : {enemy1.Health}\n");
                        break;
                        case"2":
                        Console.WriteLine("\n-----------------------------------------------------");
                        Player.Swing();
                        Player.Experience += 0.9f;
                        enemy1.GetHit(Player.AttackPower);
                        Console.WriteLine($"Player Health : {Player.Health} | Enemy Health : {enemy1.Health}\n");
                        break;
                        case"3":
                        Console.WriteLine("\n-----------------------------------------------------");
                        Player.Rest();
                        Console.WriteLine("Energy is being restored...");
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        Console.WriteLine($"Player Health : {Player.Health} | Enemy Health : {enemy1.Health}\n");
                        break;
                        case"4":
                        Console.WriteLine("\n-----------------------------------------------------");
                        Console.WriteLine($"{Player.Name} is running away...");
                        Player.RunningAway();
                        break;

                    }
                }
                Console.WriteLine($"{Player.Name} get {Player.Experience} exp point");
                Console.ReadKey();
                Console.WriteLine("\n===============================================");
                Console.WriteLine("Nama : M Hashfi Fanny AYD");
                Console.WriteLine("Nim : 2207115276");
                Console.WriteLine("kelas : Teknik Informatika - A");
                Console.WriteLine("===============================================");
          
            }
            else
            {
                Console.WriteLine("Goodbye adventurer....");
                Console.ReadKey();
                Console.WriteLine("\n===============================================");
                Console.WriteLine("Nama : M Hashfi Fanny AYD");
                Console.WriteLine("Nim : 2207115276");
                Console.WriteLine("kelas : Teknik Informatika - A");
                Console.WriteLine("===============================================");
            }

        }

    }

    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        public bool IsRunningAway { get; set; }
        Random rnd = new Random();
        public Novice()
        {
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }

        public void Swing()
        {
            if(SkillSlot > 0)
            {
                Console.WriteLine("SWINGGG!!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
            }
            else
            {
                Console.WriteLine("You do not have energy!");
            }
        }

        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name} get hit by {hitValue}");
            Health = Health - hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }
        public void Rest()
            {
                SkillSlot = 3;
                AttackPower = 1;
            }

        public void Die()
        {
            Console.WriteLine($"You are dead. Game Over");
            IsDead = true;
        }

        public void RunningAway()
        {
            IsRunningAway = true;
        }
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Health = 50;
            Name = name;
        }

        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1,10);
        }

        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name} get hit by {hitValue}");
            Health = Health - hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine($"{Name} is dead");
            IsDead = true;
        }
    }

}