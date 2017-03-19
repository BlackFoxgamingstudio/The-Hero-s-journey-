using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
	class Program
	{
		enum schoolofmagic { Fire, ice, lighting, shadow, light };
		enum fightingstyles { NORTH_yoga, WEST_brawler, EAST_jeet_kun_do, SOUTH_boxer };
		class Hero
		{
			//Class vars
			public static int Count = 0;

			public string name;
			public int age;
			public float health;
			public float magic;
			public float stamina;
			public float rage;

			//Class constructers
			public Hero()
			{
				name = "Hero";
				age = 1;
				health = 1000;
				magic = 2000;
				stamina = 2000;
				rage = 200;
				Count++;
			}

			public Hero(string _name, int _age, float _health, float _magic, float _stamina, float _rage)
			{
				name = _name;
				age = _age;
				health = _health;
				magic = _magic;
				stamina = _stamina;
				rage = _rage;
				Count++;
			}
			//Class methods
			public void Print()
			{
				Console.WriteLine("Name: " + name);
				Console.WriteLine("age: " + age);
				Console.WriteLine("health: " + health);
				Console.WriteLine("magic: " + magic);
				Console.WriteLine("stamina: " + stamina);
				Console.WriteLine("rage: " + rage);
			}
		}



		class wizard : Hero
		{
			public schoolofmagic schoolofmagic;

			public wizard(string _name, int _age, float _rage,float _health, float _magic, float _stamina, schoolofmagic _schoolofmagic)
			{
				name = _name;
				age = _age;
				rage = _rage;
				health = _health;
				magic = _magic;
				stamina = _stamina;
				rage = _rage;
				schoolofmagic = _schoolofmagic;
			}
			public void Print()
			{
				{
					Console.WriteLine("name: " + name);
					Console.WriteLine("age: " + age);
					Console.WriteLine("rage: " + rage);
					Console.WriteLine("health: " + health);
					Console.WriteLine("magic: " + magic);
					Console.WriteLine("stamina: " + stamina);
					Console.WriteLine("schoolofmagic: " + schoolofmagic);
				}
			}
			public int spellCount;

			public void spell()
			{
				Console.WriteLine("---battlecry: firemage attacks with fireball for 10 hp 'I dame you will the flames of hades!'");

			}
		}

		class fighter : Hero
		{
			public fightingstyles fightingstyle;

			public fighter(string _name, int _age, float _rage, float _health, float _magic, float _stamina, fightingstyles _fightingstyle)
			{
				name = _name;
				age = _age;
				rage = _rage;
				health = _health;
				magic = _magic;
				stamina = _stamina;
				rage = _rage;
				fightingstyle = _fightingstyle;
			}


			public void Print()
			{
				{
					Console.WriteLine("name: " + name);
					Console.WriteLine("age: " + age);
					Console.WriteLine("rage: " + rage);
					Console.WriteLine("health: " + health);
					Console.WriteLine("magic: " + magic);
					Console.WriteLine("stamina: " + stamina);
					Console.WriteLine("fightingstyle: " + fightingstyle);
				}
			}

			public float powerlvl;

			public void poweratack()
			{
				Console.WriteLine("---battlecry: sayan attacks with ki blast for 10 hp Kama..hama....HAAAAAAA!");
			}
		}
		interface IClass
		{
			string name { get; set; }
			void ClassPick();
		}
		interface IPartOfQuest
		{

			void TurnIn();
		}
		interface IItem
		{
			string name { get; set; }
			int goldValue { get; set; }

			void Equip();
			void Sell();

		}

		interface IDamagable
		{
			int durability { get; set; }

			void TakeDamage(int _amount);
		}

		class HeroBag : IItem, IPartOfQuest, IDamagable
		{
			public string name { get; set; }
			public int goldValue { get; set; }

			public int durability { get; set; }

			public HeroBag(string _name)
			{

				name = _name;
				goldValue = 100;
				durability = 30;
			}

			public void Equip()
			{
				Console.WriteLine(name + " equipped.");

			}
			public void Sell()
			{
				Console.WriteLine(name + " sold for " + goldValue + " imaginary dollers!");
			}
			public void TakeDamage(int _dmg)
			{
				durability -= _dmg;
				Console.WriteLine(name + " damaged by " + _dmg + ". It now has a durablitiy of " + durability);
			}
			public void TurnIn()
			{
				Console.WriteLine(name + " turned in ");
			}
		}
		public void Inventorylist()
		{


		}
		class Sword : IItem, IDamagable, IPartOfQuest
		{
			public string name { get; set; }
			public int goldValue { get; set; }

			public int durability { get; set; }

			public Sword(string _name)
			{
				name = _name;
				goldValue = 100;
				durability = 30;
			}
			public void Equip()
			{
				Console.WriteLine(name + " equipped.");

			}
			public void Sell()
			{
				Console.WriteLine(name + " sold for " + goldValue + " imaginary dollers!");
			}
			public void TakeDamage(int _dmg)
			{
				durability -= _dmg;
				Console.WriteLine(name + " damaged by " + _dmg + ". It now has a durablitiy of " + durability);
			}
			public void TurnIn()
			{
				Console.WriteLine(name + " turned in ");
			}
		}

		class Axe : IItem, IDamagable
		{
			public string name { get; set; }
			public int goldValue { get; set; }

			public int durability { get; set; }

			public Axe(string _name)
			{
				name = _name;
				goldValue = 150;
				durability = 50;
			}
			public void Equip()
			{
				Console.WriteLine(name + " equipped.");

			}
			public void Sell()
			{
				Console.WriteLine(name + " sold for " + goldValue + " imaginary dollers!");
			}
			public void TakeDamage(int _dmg)
			{
				durability -= _dmg;
				Console.WriteLine(name + " damaged by " + _dmg + ". It now has a durablitiy of " + durability);
			}
		}
		class HeroClass : IClass
		{
			public string name { get; set; }


			public HeroClass(string _name)
			{
				name = _name;

			}
			public void ClassPick()
			{

				Console.WriteLine("1. Would you like to be a Wizard?\n as a mage you cast fire balls at your enemy from a far and learn a book of spells as you lvl.\n" +
					Environment.NewLine + "2. Would you like to be a Fighter?\n as a fighter you rely on growing powerlvl's and harness ki to do enargy blast at short range,\n  learning new fightingstyles as you lvl\n " +
					Environment.NewLine + "3. Would you like to be a Ninja?\n as a ninja you rely on weapons and techneues of stelth and speed to suprise your enemy and deal powerful blows.\n  as you Level you learn new hidden powers from clan leaders sent to you by scroll you steal or our taught to you by your clan.\n ");
				var ans = Console.ReadLine();
				int choice = 0;
				if (int.TryParse(ans, out choice))
				{
					switch (choice)
					{
						case 1:
							Console.WriteLine("yess...i see it ..the magic of this place runs trough you! and that glow...its haunghting! you may become a powerful mage someday." +
													Environment.NewLine + "Press any kay to see your Hero Stats");
							Console.WriteLine();
							Console.ReadKey();

							wizard firemage = new wizard("Russell", 1, 30f, 400, 3000,300, schoolofmagic.Fire);
							firemage.Print();
						
							Console.WriteLine("^^comment^^ when a fire mage's attack hits, they gets a New_rage " + firemage.rage);
							Console.WriteLine();


							break;
						case 2:
							Console.WriteLine("yess...i see it ..you have the eyes of a warroir! your body is small but over time your eye..YOU EYES will drive you to become strong!" +
													Environment.NewLine + "Press any kay to see your Hero Stats");
							Console.WriteLine();
							Console.ReadKey();
							fighter sayan = new fighter("adam", 1, 55f, 4000,200,3000, fightingstyles.WEST_brawler);
							sayan.Print();
							Console.WriteLine("^^comment^^ when a sayan's attack hits, they gets a New_rage " + sayan.rage);
							Console.WriteLine();
							Console.ReadKey();
							break;
						//something for option 2
						case 3:
							Console.WriteLine("yess...i see it ..you have a one-nce your shadow! would you like me to blow out some candles...i imagine a ninja is more at peace in the dark.. or maybe i should keep them on....I have many enemys I may be your target tonight." +
							Environment.NewLine + "Press any key to see your Hero Stats");
							Console.WriteLine();
							Console.ReadKey();
							fighter ninja = new fighter("andrew", 1, 50f, 4000,200,3000, fightingstyles.EAST_jeet_kun_do);
							ninja.Print();
							Console.WriteLine("^^comment^^ when a ninja's attack hits, they gets a New_rage " + ninja.rage);
							Console.WriteLine();

							break;
						//something for option 3
						default:
							Console.WriteLine("Wrong selection!!!" +
								Environment.NewLine + "Press any kay for exit");
							Console.ReadKey();
							break;
					}
				}
				else
				{
					Console.WriteLine("You must type numeric value only!!!" +
						Environment.NewLine + "Press any kay for exit");
					Console.ReadKey();
				}
			}

			static void Main(string[] args)
			{
				// Change to your number of menuitems.
				const int maxMenuItems = 3;
				int selector = 0;
				bool good = false;
				while (selector != maxMenuItems)
				{
					Console.Clear();
					DrawTitle();
					DrawMenu(maxMenuItems);
					good = int.TryParse(Console.ReadLine(), out selector);
					if (good)
					{
						switch (selector)
						{
							case 1:
								HeroClass heroClass = new HeroClass("Choose your class then choose your path....");
								heroClass.ClassPick();
								break;
							case 2:
								HeroBag heroBag = new HeroBag("See the spoils of war!!!..");
								Sword sword = new Sword("Sword of Destiny");
								sword.Equip();
								sword.TakeDamage(20);
								sword.Sell();
								sword.TurnIn();
								Console.WriteLine();

								Axe axe = new Axe("Axe of Distruction");
								axe.Equip();
								axe.TakeDamage(20);
								axe.Sell();

								//add inventory
								IItem[] inventory = new IItem[2];
								inventory[0] = sword;
								inventory[1] = axe;

								//loop through and turn in all quest items
								for (int i = 0; i < inventory.Length; i++)
								{
									IPartOfQuest questItem = inventory[i] as IPartOfQuest;
									if (questItem != null)
									{
										Console.WriteLine();
										questItem.TurnIn();
									}
								}
								Console.ReadKey();
								break;
							// possibly more cases here
							default:
								if (selector != maxMenuItems)
								{
									ErrorMessage();
								}
								break;
						}
					}
					else
					{
						ErrorMessage();
					}
					Console.ReadKey();
				}
			}
			private static void ErrorMessage()
			{
				Console.WriteLine("Typing error, press key to continue.");
			}
			private static void DrawStarLine()
			{
				Console.WriteLine("************************");
			}
			private static void DrawTitle()
			{
				DrawStarLine();
				Console.WriteLine("+++   The Heros Jeroney   +++");
				DrawStarLine();
			}
			private static void DrawMenu(int maxitems)
			{
				DrawStarLine();
				Console.WriteLine(" 1. Choose Class");
				Console.WriteLine(" 2. View Inventory");
				// more here
				Console.WriteLine(" 3. Exit program");
				DrawStarLine();
				Console.WriteLine("Make your choice: type 1, 2,... or {0} for exit", maxitems);
				DrawStarLine();
			}
		}
	}
}
