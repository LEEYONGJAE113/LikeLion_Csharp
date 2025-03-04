// DateTime now = DateTime.Now;
// Console.WriteLine($"Current Date and Time: {now}");

// TimeSpan duration = new TimeSpan(1, 30, 0);
// Console.WriteLine($"Duration: {duration}");



// **
// class Person
//     {
//         public string name;

//         public void ShowInfo()
//         {
//             Console.WriteLine("이름 : "+name);
//         }
//     }

// class Program
//     {
//         static void Main(string[] args)
//         {
//             //클래스
//             //
//             Person p1 = new Person(); //객체 생성  instance 
//             p1.ShowInfo();


//         }
//     }

// **
// class Person
// {
//     public string Name;
//     public int Age;
//     //기본생성자 
//     //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
//     //클래스와 같은이름가지며, 반환형이 없다 (void도 사용하지않음)
//     //객체를 만들때 필요한 초기값을 설정할대 사용많이한다.

//     public Person()
//     {
//         Name = "이름 없음";
//         Age = 0;
//         Console.WriteLine("기본 생성자가 실행됨");
//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         //클래스
//         //
//         Person p1 = new Person(); //객체 생성  instance 
//         p1.ShowInfo();


//     }
// }

// **
// class Person
// {
//     public string Name;
//     public int Age;
//     //기본생성자 
//     //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
//     //클래스와 같은이름가지며, 반환형이 없다 (void도 사용하지않음)
//     //객체를 만들때 필요한 초기값을 설정할대 사용많이한다.




//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//         Console.WriteLine("매개변수있는 생성자가 실행됨");
//     }

//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         //클래스
//         //
//         Person p1 = new Person("철수", 25); //객체 생성  instance 
//         p1.ShowInfo();

//         Person p2 = new Person("영희", 30);
//         p2.ShowInfo();


//     }
// }


// **
//이름,미네랄  = 50
//기본생성자 , 인자있는생성자 
//SCV 클래스를 만드세요.
//이름,미네랄  = 50
//기본생성자 , 인자있는생성자 
// class Marin
// {
//     public string Name;
//     public int Mineral;

//     public Marin()
//     {
//         Name = "마린";
//         Mineral = 50;
//     }

//     public Marin(string _name, int _mineral)
//     {
//         Name = _name;
//         Mineral = _mineral;
//     }


//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
//     }
// }

// class SCV
// {
//     public string Name;
//     public int Mineral;

//     public SCV()
//     {
//         Name = "SCV";
//         Mineral = 50;
//     }

//     public SCV(string _name, int _mineral)
//     {
//         Name = _name;
//         Mineral = _mineral;
//     }


//     public void ShowInfo()
//     {
//         Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
//     }
// }

// class Barrack
// {
//     public string Name;
//     public int Mineral;

//     public Barrack()
//     {
//         Name = "배럭";
//         Mineral = 150;
//     }
//     public Barrack(string name, int mineral)
//     {
//         Name = name;
//         Mineral = mineral;
//     }

//     public void ShowInfo()
//     {
//         System.Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
//     }
// }

// class Mineral
// {
//     public int TotalMinerals;
//     public Mineral()
//     {
//         TotalMinerals = 1500;
//     }

//     public Mineral(int totalMinerals)
//     {
//         TotalMinerals = totalMinerals;
//     }

//     public void ShowInfo()
//     {
//         System.Console.WriteLine($"미네랄 보유량 : {TotalMinerals}");
//     }

// }

// class Game
// {
//     public static int mineral;
//     public static int gas;
//     public static int charCount;

//     public static void ShowInfo()
//     {
//         System.Console.WriteLine($"미네랄 : {mineral}");
//         System.Console.WriteLine($"가스  : {gas}");
//         System.Console.WriteLine($"인구수 : {charCount}");
//     }

// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Game.mineral = 50;
//         Game.gas = 0;
//         Game.charCount = 4;
//         Game.ShowInfo();

//         Marin marin = new Marin("불꽃테란", 100);
//         SCV scv = new SCV("열받은SCV", 70);
//         Barrack barrack = new Barrack();
//         Mineral[] minerals = new Mineral[7];

//         for (int index = 0; index < minerals.Length; ++index)
//         {
//             minerals[index] = new Mineral();
//         }


//         marin.ShowInfo();

//         scv.ShowInfo();
//         barrack.ShowInfo();

//         foreach (Mineral mineral in minerals)
//         {
//             mineral.ShowInfo();
//         }
//     }
// }


// **
// class Person
// {
//     private string name;
//     public string GetName()
//     {
//         return name;
//     }
//     public void SetName(string name)
//     {
//         this.name = name;
//     }
// }
// class Person
// {
//     private string name;
//     public string Name
//     {
//         get { return name; }
//         set { name = value; }
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Person p = new Person();

//         p.Name = "홍길동";

//         System.Console.WriteLine("이름 : " + p.Name);
//     }
// }

// **
// class Person
// {
//     private int count = 100;
//     public string Name { get; set; }
//     public int Count
//     {
//         get { return count; }
//     }

//     public float Balance { get; private set; }
//     public void AddBal()
//     {
//         Balance += 100;
//     }
// }

// class Marin
// {
//     public string Name { get; private set; } = "마린";
//     public int Mineral { get; private set; } = 50;
//     public void ShowInfo()
//     {
//         System.Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person p = new Person();
//         p.Name = "홍길동";
//         p.AddBal();
//         System.Console.WriteLine($"이름 : {p.Name}, Count : {p.Count}, Balance : {p.Balance}");

//         Marin m = new Marin();

//         m.ShowInfo();
//     }
// }

// **

// namespace ShootingGame
// {
//     public class Bullet
//     {
//         public int X;
//         public int Y;
//         public bool Fire;

//     }

//     public class Player
//     {
//         #region 상수
//         const int BULLET_COUNT = 20;
//         // const int UPKEY = 72; // for ASCII
//         // const int DOWNKEY = 80; // for ASCII
//         // const int LEFTKEY = 75; // for ASCII
//         // const int RIGHTKEY = 77; // for ASCII
//         // const int SPACEBAR = 32; // for ASCII
//         #endregion

//         // [DllImport("msvcrt.dll")] //c언어 dll 추가
//         // static extern int _getch(); //c언어 가져옴
//         public int PlayerX;
//         public int PlayerY;
//         public Bullet[] PlayerBullets = new Bullet[BULLET_COUNT];
//         public Bullet[] ItemBullets1 = new Bullet[BULLET_COUNT];
//         public Bullet[] ItemBullets2 = new Bullet[BULLET_COUNT];
//         public int Score = 100;
//         public Item item = new Item();
//         public int ItemCount = 0;

//         public Player()
//         {
//             PlayerX = 0;
//             PlayerY = 12;

//             for (int index = 0; index < BULLET_COUNT; ++index)
//             {
//                 PlayerBullets[index] = new Bullet();
//                 ItemBullets1[index] = new Bullet();
//                 ItemBullets2[index] = new Bullet();

//                 PlayerBullets[index].X = 0;
//                 PlayerBullets[index].Y = 0;

//                 ItemBullets1[index].X = 0;
//                 ItemBullets1[index].Y = 0;

//                 ItemBullets2[index].X = 0;
//                 ItemBullets2[index].Y = 0;

//                 PlayerBullets[index].Fire = false;
//                 ItemBullets1[index].Fire = false;
//                 ItemBullets2[index].Fire = false;

//             }
//         }
//         public void GameMain()
//         {
//             KeyControl();
//             PlayerDraw();

//             ScoreUI();

//             if(item.IsItemLive)
//             {
//                 item.ItemMove();
//                 item.ItemDraw();
//                 CrashItem();
//             }
//         }

//         public void KeyControl()
//         {
//             ConsoleKey pressKey;
//             // int pressKey;
//             if(Console.KeyAvailable) // 키 입력시 true
//             {
//                 // pressKey = _getch(); // ASCII값이 들어옴

//                 // switch (pressKey)
//                 // {
//                 //     case UPKEY:
//                 //         PlayerY--;
//                 //         if(PlayerY < 1) { PlayerY = 1; }
//                 //         break;
//                 //     case LEFTKEY:
//                 //         PlayerX--;
//                 //         if(PlayerX < 0) { PlayerX = 0; }
//                 //         break;
//                 //     case RIGHTKEY:
//                 //         PlayerX++;
//                 //         if(PlayerX > 75) { PlayerX = 75; }
//                 //         break;
//                 //     case DOWNKEY:
//                 //         PlayerY++;
//                 //         if(PlayerY > 23) { PlayerX = 23; }
//                 //         break;
//                 //     case SPACEBAR:
//                 //         for (int index = 0; index < BULLET_COUNT; ++index)
//                 //         {
//                 //             if (!PlayerBullets[index].Fire)
//                 //             {
//                 //                 PlayerBullets[index].Fire = true;
//                 //                 PlayerBullets[index].X = PlayerX + 5;
//                 //                 PlayerBullets[index].Y = PlayerY + 1;
//                 //                 break; //한발씩 쏘기위함
//                 //             }
//                 //         }
//                 //         break;
//                 pressKey = Console.ReadKey(true).Key; // ASCII값이 들어옴

//                 switch (pressKey)
//                 {
//                     case ConsoleKey.UpArrow:
//                         PlayerY--;
//                         if(PlayerY < 1) { PlayerY = 1; }
//                         break;
//                     case ConsoleKey.LeftArrow:
//                         PlayerX--;
//                         if(PlayerX < 0) { PlayerX = 0; }
//                         break;
//                     case ConsoleKey.RightArrow:
//                         PlayerX++;
//                         if(PlayerX > 75) { PlayerX = 75; }
//                         break;
//                     case ConsoleKey.DownArrow:
//                         PlayerY++;
//                         if(PlayerY > 23) { PlayerY = 23; }
//                         break;
//                     case ConsoleKey.Spacebar:
//                         for (int index = 0; index < BULLET_COUNT; ++index)
//                         {
//                             if (!PlayerBullets[index].Fire)
//                             {
//                                 PlayerBullets[index].Fire = true;
//                                 PlayerBullets[index].X = PlayerX + 4;
//                                 PlayerBullets[index].Y = PlayerY + 1;
//                                 break; //한발씩 쏘기위함
//                             }
//                             if (!ItemBullets1[index].Fire)
//                             {
//                                 ItemBullets1[index].Fire = true;
//                                 ItemBullets1[index].X = PlayerX + 4;
//                                 ItemBullets1[index].Y = PlayerY;
//                                 break; //한발씩 쏘기위함
//                             }
//                             if (!ItemBullets2[index].Fire)
//                             {
//                                 ItemBullets2[index].Fire = true;
//                                 ItemBullets2[index].X = PlayerX + 4;
//                                 ItemBullets2[index].Y = PlayerY+2;
//                                 break; //한발씩 쏘기위함
//                             }
//                         }
//                         break;
//                 }
//             }
//         }
//         public void PlayerDraw()
//         {
//             string[] player =
//             [
//                 "➹➼",
//                 "🀰🀰➨",
//                 "➷➼"
//             ];

//             for (int index = 0; index < player.Length; ++index)
//             {
//                 Console.SetCursorPosition(PlayerX, PlayerY+index);
//                 System.Console.WriteLine(player[index]);
//             }
//         }
//         public void BulletDraw()
//         {
//             string Bullet = "♦︎➺";

//             for (int index = 0; index < BULLET_COUNT; index++)
//             {
//                 if(PlayerBullets[index].Fire)
//                 {
//                     Console.SetCursorPosition(PlayerBullets[index].X, PlayerBullets[index].Y);
//                     System.Console.Write(Bullet);

//                     PlayerBullets[index].X++;

//                     if (PlayerBullets[index].X > 78)
//                     {
//                         PlayerBullets[index].Fire = false;
//                     }
//                 }
//             }
//         }

//         public void ItemBulletDraw1()
//         {
//             string Bullet = "♦︎➺";

//             for (int index = 0; index < BULLET_COUNT; index++)
//             {
//                 if(ItemBullets1[index].Fire)
//                 {
//                     Console.SetCursorPosition(ItemBullets1[index].X, ItemBullets1[index].Y);
//                     System.Console.Write(Bullet);

//                     ItemBullets1[index].X++;

//                     if (ItemBullets1[index].X > 78)
//                     {
//                         ItemBullets1[index].Fire = false;
//                     }
//                 }
//             }
//         }
//         public void ItemBulletDraw2()
//         {
//             string Bullet = "♦︎➺";

//             for (int index = 0; index < BULLET_COUNT; index++)
//             {
//                 if(ItemBullets2[index].Fire)
//                 {
//                     Console.SetCursorPosition(ItemBullets2[index].X, ItemBullets2[index].Y);
//                     System.Console.Write(Bullet);

//                     ItemBullets2[index].X++;

//                     if (ItemBullets2[index].X > 78)
//                     {
//                         ItemBullets2[index].Fire = false;
//                     }
//                 }
//             }
//         }

//         public void CrashEnemyAndBullet(Enemy enemy)
//         {
//             for (int index = 0; index < BULLET_COUNT; index++)
//             {
//                 if (PlayerBullets[index].Fire)
//                 {
//                     if (PlayerBullets[index].Y == enemy.EnemyY)
//                     {
//                         if (PlayerBullets[index].X >= enemy.EnemyX - 1
//                             && PlayerBullets[index].X <= enemy.EnemyX + 1)
//                         {
//                             item.IsItemLive = true;
//                             item.ItemX = enemy.EnemyX;
//                             item.ItemY = enemy.EnemyY;

//                             Random rand = new Random();
//                             enemy.EnemyX = 75;
//                             enemy.EnemyY = rand.Next(2,22);

//                             PlayerBullets[index].Fire = false;

//                             Score += 100;
//                         }
//                     }
//                 }
//             }
//         }

//         public void CrashEnemyAndBullet2(Enemy enemy)
//         {
//             for (int index = 0; index < BULLET_COUNT; index++)
//             {
//                 if (ItemBullets1[index].Fire)
//                 {
//                     if (ItemBullets1[index].Y == enemy.EnemyY)
//                     {
//                         if (ItemBullets1[index].X >= enemy.EnemyX - 1
//                             && ItemBullets1[index].X <= enemy.EnemyX + 1)
//                         {
//                             item.IsItemLive = true;
//                             item.ItemX = enemy.EnemyX;
//                             item.ItemY = enemy.EnemyY;

//                             Random rand = new Random();
//                             enemy.EnemyX = 75;
//                             enemy.EnemyY = rand.Next(2,22);

//                             ItemBullets1[index].Fire = false;

//                             Score += 100;
//                         }
//                     }
//                 }
//             }
//         }

//         public void CrashEnemyAndBullet3(Enemy enemy)
//         {
//             for (int index = 0; index < BULLET_COUNT; index++)
//             {
//                 if (ItemBullets2[index].Fire)
//                 {
//                     if (ItemBullets2[index].Y == enemy.EnemyY)
//                     {
//                         if (ItemBullets2[index].X >= enemy.EnemyX - 1
//                             && ItemBullets2[index].X <= enemy.EnemyX + 1)
//                         {
//                             item.IsItemLive = true;
//                             item.ItemX = enemy.EnemyX;
//                             item.ItemY = enemy.EnemyY;

//                             Random rand = new Random();
//                             enemy.EnemyX = 75;
//                             enemy.EnemyY = rand.Next(2,22);

//                             ItemBullets2[index].Fire = false;

//                             Score += 100;
//                         }
//                     }
//                 }
//             }
//         }

//         public void ScoreUI()
//         {
//             Console.SetCursorPosition(63, 0);
//             Console.Write("┏━━━━━━━━━━━━━━┓");
//             Console.SetCursorPosition(63, 1);
//             Console.Write("┃              ┃");
//             Console.SetCursorPosition(65, 1);
//             Console.Write($"Score : {Score}");
//             Console.SetCursorPosition(63, 2);
//             Console.Write("┗━━━━━━━━━━━━━━┛");
//         }

//         public void CrashItem()
//         {
//             if(PlayerY + 1 == item.ItemY)
//             {
//                 if (PlayerX >= item.ItemX - 2 && PlayerX <= item.ItemX +2)
//                 {
//                     item.IsItemLive = false;

//                     if(ItemCount < 3)
//                     {
//                         ItemCount++;
//                     }

//                     for (int index = 0; index < BULLET_COUNT; ++index)
//                     {
//                         PlayerBullets[index] = new Bullet();
//                         PlayerBullets[index].X = 0;
//                         PlayerBullets[index].Y = 0;
//                         PlayerBullets[index].Fire = false;

//                         ItemBullets1[index] = new Bullet();
//                         ItemBullets1[index].X = 0;
//                         ItemBullets1[index].Y = 0;
//                         ItemBullets1[index].Fire = false;

//                         ItemBullets2[index] = new Bullet();
//                         ItemBullets2[index].X = 0;
//                         ItemBullets2[index].Y = 0;
//                         ItemBullets2[index].Fire = false;
//                     }
//                 }
//             }
//         }

//     }

//     public class Enemy
//     {
//         public int EnemyX;
//         public int EnemyY;

//         public Enemy()
//         {
//             EnemyX = 75;
//             EnemyY = 12;
//         }

//         public void EnemyDraw()
//         {
//             string enemy = "☣︎☣︎";
//             Console.SetCursorPosition(EnemyX, EnemyY);
//             System.Console.Write(enemy);
//         }

//         public void EnemyMove()
//         {
//             Random rand = new Random();
//             EnemyX--;

//             if(EnemyX < 6) //왼쪽 넘어가면 위치 초기화
//             {
//                 EnemyX = 77;
//                 EnemyY = rand.Next(2, 22);
//             }
//         }
//     }

//     public class Item
//     {
//         public string ItemName;
//         public string ItemSprite;
//         public int ItemX = 0;
//         public int ItemY = 0;
//         public bool IsItemLive = false;

//         public void ItemDraw()
//         {
//             Console.SetCursorPosition(ItemX, ItemY);
//             ItemSprite = "🂫";
//             System.Console.Write(ItemSprite);
//         }

//         public void ItemMove()
//         {

//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.CursorVisible = false;

//             // Console.SetWindowSize(80, 25);
//             // Console.SetBufferSize(80, 25);


//             Player player = new Player();
//             Enemy enemy = new Enemy();

//             // (deltaTime)
//             int dwTime = Environment.TickCount; // 1ms

//             while (true)
//             {
//                 // 50ms 지나면 실행
//                 if(dwTime + 50 < Environment.TickCount)
//                 {
//                     dwTime = Environment.TickCount;
//                     Console.Clear();

//                     player.GameMain();
//                     if (player.ItemCount == 0)
//                     {
//                         player.BulletDraw();
//                     }
//                     else if (player.ItemCount == 1)
//                     {
//                         player.BulletDraw();
//                         player.ItemBulletDraw1();
//                     }
//                     else if (player.ItemCount == 2)
//                     {
//                         player.BulletDraw();
//                         player.ItemBulletDraw1();
//                         player.ItemBulletDraw2();
//                     }
//                     enemy.EnemyMove();
//                     enemy.EnemyDraw();

//                     player.CrashEnemyAndBullet(enemy);
//                 }
//             }

//         }
//     }


// }


// **



namespace ShootingGameOwn
{
    // console size : 80 * 25
    class Bullet
    {
        public int BulletX;
        public int BulletY;
        public bool isFired;
        public void FireNewBullet(int x, int y)
        {
            BulletX = x;
            BulletY = y;
            isFired = true;
        }
        public void DrawBullet()
        {
            if (!isFired) { return; }
            if (BulletX >= 79)
            { 
                isFired = false;
                return;
            }
            string bullet = "➽";
            Console.SetCursorPosition(++BulletX, BulletY);
            System.Console.Write(bullet);
        }
    }

    class Player
    {
        public GameManagement gameManager;
        public int PlayerX;
        public int PlayerY;
        Bullet basicBullet = new Bullet();
        Bullet itemBullet1 = new Bullet();
        Bullet itemBullet2 = new Bullet();
        string[] playerSprite =
            [
                "🀫☪︎",
                "🀫🀫✚",
                "🀫☪︎"
            ];
        public Player()
        {
            PlayerX = 0;
            PlayerY = 12;
        }
        public void DrawPlayer()
        {
            
            for (int index = 0; index < playerSprite.Length; ++index)
            {
                Console.SetCursorPosition(PlayerX, PlayerY+index);
                System.Console.WriteLine(playerSprite[index]);
            }
        }
        
        public void ControlPlayer()
        {
            ConsoleKey keyInput; // can not found dll file on Mac > use ConsoleKey
            if (!Console.KeyAvailable) { return; }
            keyInput = Console.ReadKey(true).Key;
            switch (keyInput)
            {
                case ConsoleKey.UpArrow:
                    PlayerY--;
                    if (PlayerY < 1) { PlayerY = 1; }
                    break;
                case ConsoleKey.LeftArrow:
                    PlayerX--;
                    if (PlayerX < 0) { PlayerX = 0; }
                    break;
                case ConsoleKey.RightArrow:
                    PlayerX++;
                    if (PlayerX > 75) { PlayerX = 75; }
                    break;
                case ConsoleKey.DownArrow:
                    PlayerY++;
                    if (PlayerY > 23) { PlayerY = 23; }
                    break;
                case ConsoleKey.Spacebar:
                    if (!gameManager.CanShoot(ref basicBullet, gameManager.bullets)) { return; }
                    basicBullet.FireNewBullet(PlayerX + 3, PlayerY + 1);
                    if (gameManager.GettedItem >= 1
                    && gameManager.CanShoot(ref itemBullet1, gameManager.subBullets1))
                    {
                        itemBullet1.FireNewBullet(PlayerX + 3, PlayerY); // 위
                    }
                    if (gameManager.GettedItem >= 2
                    && gameManager.CanShoot(ref itemBullet2, gameManager.subBullets2))
                    {
                        itemBullet2.FireNewBullet(PlayerX + 3, PlayerY +2); // 아래
                    }
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    class Enemy
    {
        public int EnemyX;
        public int EnemyY;
        public Enemy(int x = 75, int y = 12)
        {
            EnemyX = x;
            EnemyY = y;
        }

        public void DrawEnemy()
        {
            string enemy = "⚉";
            Console.SetCursorPosition(EnemyX, EnemyY);
            System.Console.Write(enemy);
        }

        public void MoveEnemy()
        {
            Random rand = new Random();
            EnemyX--;

            if(EnemyX < 2) //왼쪽 넘어가면 위치 초기화
            {
                EnemyX = 77;
                EnemyY = rand.Next(2, 22);
            }
        }
    }
    class Item
    {
        string ItemSprite = "[P]";
        public int ItemX;
        public int ItemY;
        public bool IsItemLive;

        public Item(int x, int y)
        {
            IsItemLive = true;
            ItemX = x;
            ItemY = y;
        }
        public void DrawItem()
        {
            if (ItemX < 2 || !IsItemLive) { return; }
            Console.SetCursorPosition(--ItemX, ItemY);
            System.Console.Write(ItemSprite);
        }

    }

    class GameManagement
    {
        const int MAX_BULLET_COUNT = 30;
        Player player;
        public Bullet[] bullets;
        public Bullet[] subBullets1;
        public Bullet[] subBullets2;
        Enemy enemy;
        Item item;
        public int Score;
        public int GettedItem;

        public void StartGame()
        {
            Console.CursorVisible = false;
            Score = 100;
            player = new Player();
            bullets = new Bullet[MAX_BULLET_COUNT];
            subBullets1 = new Bullet[MAX_BULLET_COUNT];
            subBullets2 = new Bullet[MAX_BULLET_COUNT];
            for (int index = 0; index < MAX_BULLET_COUNT; ++index)
            {
                bullets[index] = new Bullet();
                subBullets1[index] = new Bullet();
                subBullets2[index] = new Bullet();
            }
            enemy = new Enemy();
            player.gameManager = this;
        }

        public void UpdateGame()
        {
            Console.Clear();
            player.DrawPlayer();
            player.ControlPlayer();
            DrawAllBullet();
            CheckEnemy();
            enemy.MoveEnemy();
            enemy.DrawEnemy();
            if (item != null)
            {
                CheckItem();
                item.DrawItem();
            }
        }

        public void UpdateUI()
        {
            int remainBullet = 0;
            for (int index = 0; index < MAX_BULLET_COUNT; index++)
            {
                if (!bullets[index].isFired) { ++remainBullet; }
            }
            Console.SetCursorPosition(1, 0);
            Console.Write("┏━━━━━━━━━━━┓");
            Console.SetCursorPosition(1, 1);
            Console.Write($"┃ 잔탄 : {remainBullet:D2} ┃");
            Console.SetCursorPosition(1, 2);
            Console.Write("┗━━━━━━━━━━━┛");
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write($"Score : {Score}");
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        public bool CanShoot(ref Bullet bul, Bullet[] bulletArray)
        {
            foreach (Bullet bullet in bulletArray)
            {
                if (!bullet.isFired)
                { 
                    bul = bullet; 
                    return true;
                }
            }
            return false;
        }
        
        public void DrawAllBullet()
        {
            for (int index = 0; index < MAX_BULLET_COUNT; ++index)
            {
                bullets[index].DrawBullet();
                if (GettedItem >= 1)
                {
                    subBullets1[index].DrawBullet();
                }
                if (GettedItem >= 2)
                {
                    subBullets2[index].DrawBullet();
                }
            }
        }

        public void CheckEnemy()
        {
            if (CheckEnemyCrash(bullets, 0)) { return; }
            if (GettedItem >= 1 && CheckEnemyCrash(subBullets1, -1)) { return; }
            if (GettedItem >= 2 && CheckEnemyCrash(subBullets2, 1)) { return; }
        }

        public bool CheckEnemyCrash(Bullet[] bullets, int y)
        {
            foreach (Bullet bullet in bullets)
            {
                if (!bullet.isFired) continue;

                if (bullet.BulletX >= enemy.EnemyX - 2 && bullet.BulletX <= enemy.EnemyX + 2)
                {
                    if (bullet.BulletY == enemy.EnemyY + y)
                    {
                        EnemyHit();
                        return true;
                    }
                }
            }
            return false;
        }
        public void EnemyHit()
        {
            item = new Item(enemy.EnemyX, enemy.EnemyY);
            Random rand = new Random();
            enemy.EnemyX = 75;
            enemy.EnemyY = rand.Next(2, 22);

            Score += 100;
        }

        public void CheckItem()
        {
            if (!item.IsItemLive) { return; }
            if (player.PlayerX >= item.ItemX - 2
                && player.PlayerX <= item.ItemX + 2
                && player.PlayerY >= item.ItemY - 1
                && player.PlayerY <= item.ItemY + 1)
            {
                GetItem();
                item.IsItemLive = false;
            }
        }
        public void GetItem()
        {
            if (GettedItem > 2) { return; }
            switch (++GettedItem)
            {
                case 1:
                    for (int index = 0; index < MAX_BULLET_COUNT; ++index)
                    {
                        subBullets1[index] = new Bullet();
                    }
                    break;
                case 2:
                    for (int index = 0; index < MAX_BULLET_COUNT; ++index)
                    {
                        subBullets2[index] = new Bullet();
                    }
                    break;
            }
            
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            GameManagement gameManager = new GameManagement();
            gameManager.StartGame();
            
            int dwTime = Environment.TickCount; // 1ms

            while (true)
            {
                if(dwTime + 50 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;
                    gameManager.UpdateGame();
                    gameManager.UpdateUI();
                }
            }
        }
    }
}