using System;

namespace _05_dominik_igrica
{
    class Dice
    {
        private Random random;

        public int fRollDice(int sides)
        {
            this.sides = sides;
            random = new Random();
            int result = random.Next(1, this.sides + 1);
            return result;
        }
        int sides;
    }

    class Player
    {
        //Accessors
        public bool fGetAlive() { fIsDead(); return alive; }
        public string fGetName() { return name; }
        public int fGetHealth() { return health; }
        public int fGetDamage() { return damage; }
        public int fGetArmor() { return armor; }

        //Functions
        public void fInputName()
        {
            Console.WriteLine("Upisite svoje ime: ");
            name = Console.ReadLine();
            Console.WriteLine("Vase ime je: " + name + "\n");

        }
        public int fRollInitiative()
        {
            return dice.fRollDice(20);
        }
        public int fRollHit()
        {
            return dice.fRollDice(20);
        }
        public int fRollDamage()
        {
            return dice.fRollDice(damage);
        }
        public void fTakeDamage(int damage) { health -= damage; }
        private void fIsDead()
        {
            if (health <= 0)
            {
                alive = false;
            }
        }

        //Variables
        Dice dice = new Dice();
        bool alive = true;
        string name;
        int health = 20;
        int damage = 8;
        int armor = 15;
    }

    class Enemy
    {
        //Constructor
        public Enemy(string name)
        {
            this.name = name;
            alive = true;
            health = 16;
            damage = 4;
            armor = 14;
        }
        //Accessors
        public bool fGetAlive() { fIsDead(); return alive; }
        public string fGetName() { return name; }
        public int fGetHealth() { return health; }
        public int fGetDamage() { return damage; }
        public int fGetArmor() { return armor; }

        //Functions
        public int fRollInitiative()
        {
            return dice.fRollDice(20);
        }
        public int fRollHit()
        {
            return dice.fRollDice(20);
        }
        public int fRollDamage()
        {
            return dice.fRollDice(damage);
        }
        public void fTakeDamage(int damage) { health -= damage; }
        private void fIsDead()
        {
            if (health <= 0)
            {
                alive = false;
            }
        }

        //Variables
        Dice dice = new Dice();
        string name;
        bool alive;
        int health;
        int damage;
        int armor;
    }

    class Logic
    {
        public void fBattle(Player player, Enemy enemy)
        {
            while (player.fGetAlive() == true && enemy.fGetAlive() == true)
            {
                //Ako player ima veci Initiative
                if (player.fRollInitiative() > enemy.fRollInitiative())
                {
                    Console.WriteLine(player.fGetName() + " je prvi na potezu.");
                    //Ako player ima rezultat veci il jednako armoru od enemy-a
                    if (player.fRollHit() >= enemy.fGetArmor())
                    {
                        //Player turn
                        Console.WriteLine(player.fGetName() + " je udario " + enemy.fGetName() + " uspijesno!");
                        int player_rezultat = player.fRollDamage();
                        enemy.fTakeDamage(player_rezultat);
                        Console.WriteLine(enemy.fGetName() + " je ozljeden za " + player_rezultat + " bodova.");
                        Console.WriteLine(enemy.fGetName() + " je ostalo jos " + enemy.fGetHealth() + " zivotnih bodova.\n");
                        if (enemy.fGetAlive() == false)
                        {
                            Console.WriteLine(enemy.fGetName() + " je mrtav.");
                            break;
                        }

                        //Enemy turn
                        Console.WriteLine(enemy.fGetName() + " je na potezu.");
                        //Ako enemy ima rezultat veci il jednako armoru od player-a
                        if (enemy.fRollHit() >= player.fGetArmor())
                        {
                            Console.WriteLine(enemy.fGetName() + " je udario " + player.fGetName() + " uspijesno!");
                            int enemy_rezultat = enemy.fRollDamage();
                            player.fTakeDamage(enemy_rezultat);
                            Console.WriteLine(player.fGetName() + " je ozljeden za " + enemy_rezultat + " bodova.");
                            Console.WriteLine(player.fGetName() + " je ostalo jos " + player.fGetHealth() + " zivotnih bodova.\n");
                            if (player.fGetAlive() == false)
                            {
                                Console.WriteLine(player.fGetName() + " je mrtav.");
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine(enemy.fGetName() + " je promasio " + player.fGetName() + ".\n");
                        }
                    }
                    //Ako player ima rezultat manji od enemy armora
                    else
                    {
                        Console.WriteLine(player.fGetName() + " je promasio " + enemy.fGetName() + ".\n");
                        //Enemy turn
                        Console.WriteLine(enemy.fGetName() + " je na potezu.");
                        //Ako enemy ima rezultat veci il jednako armoru od player-a
                        if (enemy.fRollHit() >= player.fGetArmor())
                        {
                            Console.WriteLine(enemy.fGetName() + " je udario " + player.fGetName() + " uspijesno!");
                            int enemy_rezultat = enemy.fRollDamage();
                            player.fTakeDamage(enemy_rezultat);
                            Console.WriteLine(player.fGetName() + " je ozljeden za " + enemy_rezultat + " bodova.");
                            Console.WriteLine(player.fGetName() + " je ostalo jos " + player.fGetHealth() + " zivotnih bodova.\n");
                            if (player.fGetAlive() == false)
                            {
                                Console.WriteLine(player.fGetName() + " je mrtav.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine(enemy.fGetName() + " je promasio " + player.fGetName() + ".\n");
                        }
                    }
                }
                //Ako enemy ima veci Initiative
                else if (player.fRollInitiative() < enemy.fRollInitiative())
                {
                    Console.WriteLine(enemy.fGetName() + " je prvi na potezu.");
                    //Ako enemy ima rezultat veci il jednako armoru od player-a
                    if (enemy.fRollHit() >= player.fGetArmor())
                    {
                        //Enemy turn
                        Console.WriteLine(enemy.fGetName() + " je udario " + player.fGetName() + " uspijesno!");
                        int enemy_rezultat = enemy.fRollDamage();
                        player.fTakeDamage(enemy_rezultat);
                        Console.WriteLine(player.fGetName() + " je ozljeden za " + enemy_rezultat + " bodova.");
                        Console.WriteLine(player.fGetName() + " je ostalo jos " + player.fGetHealth() + " zivotnih bodova.\n");
                        if (player.fGetAlive() == false)
                        {
                            Console.WriteLine(player.fGetName() + " je mrtav.");
                            break;
                        }

                        //Player turn
                        Console.WriteLine(player.fGetName() + " je na potezu.");
                        //Ako player ima rezultat veci il jednako armoru od enemy-a
                        if (player.fRollHit() >= enemy.fGetArmor())
                        {
                            Console.WriteLine(player.fGetName() + " je udario " + enemy.fGetName() + " uspijesno!");
                            int player_rezultat = player.fRollDamage();
                            enemy.fTakeDamage(player_rezultat);
                            Console.WriteLine(enemy.fGetName() + " je ozljeden za " + player_rezultat + " bodova.");
                            Console.WriteLine(enemy.fGetName() + " je ostalo jos " + enemy.fGetHealth() + " zivotnih bodova.\n");
                            if (enemy.fGetAlive() == false)
                            {
                                Console.WriteLine(enemy.fGetName() + " je mrtav.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine(player.fGetName() + " je promasio " + enemy.fGetName() + ".\n");
                        }
                    }
                    //Ako enemy ima rezultat manji od player armora
                    else
                    {
                        Console.WriteLine(enemy.fGetName() + " je promasio " + player.fGetName() + ".\n");
                        //Player turn
                        Console.WriteLine(player.fGetName() + " je na potezu.");
                        //Ako player ima rezultat veci il jednako armoru od enemy-a
                        if (player.fRollHit() >= enemy.fGetArmor())
                        {
                            Console.WriteLine(player.fGetName() + " je udario " + enemy.fGetName() + " uspijesno!");
                            int player_rezultat = player.fRollDamage();
                            enemy.fTakeDamage(player_rezultat);
                            Console.WriteLine(enemy.fGetName() + " je ozljeden za " + player_rezultat + " bodova.");
                            Console.WriteLine(enemy.fGetName() + " je ostalo jos " + enemy.fGetHealth() + " zivotnih bodova.\n");
                            if (enemy.fGetAlive() == false)
                            {
                                Console.WriteLine(enemy.fGetName() + " je mrtav.");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine(player.fGetName() + " je promasio " + enemy.fGetName() + ".\n");
                        }
                    }
                }
                else
                {
                    fBattle(player, enemy);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy("Goblin");
            Logic logic = new Logic();
            player.fInputName();
            Console.WriteLine(player.fGetName() + " ima: " + player.fGetHealth() + " zivotnih bodova.");
            Console.WriteLine(enemy.fGetName() + " ima: " + enemy.fGetHealth() + " zivotnih bodova.\n");
            logic.fBattle(player, enemy);
        }
    }
}