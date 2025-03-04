namespace app0302
{
    class Slot
    {
        Random rand = new Random();
        int[] typeList = { 100, 10, 1 };
        public int type;
        public bool isSelected;
        public Slot()
        {
            type = typeList[rand.Next(0, typeList.Length)];
        }
        public void Shuffle()
        {
            type = typeList[rand.Next(0, typeList.Length)];
        }
        public void HideSlot(int x)
        {
            Console.SetCursorPosition(6 + (2 * x), 12);
            System.Console.Write(" ");
        }
        public void DrawSlot(int x)
        {
            Console.SetCursorPosition(6 + (2*x), 12);
            switch (type)
            {
                case 100:
                    System.Console.Write("♜");
                    break;
                case 10:
                    System.Console.Write("♝");
                    break;
                case 1:
                    System.Console.Write("♞");
                    break;
            }
            Console.SetCursorPosition(6 + (2*x), 13);
            if (isSelected)
            { 
                System.Console.Write("✓");
            }
            else
            {
                System.Console.Write(" ");
            }
        }
    }

    class Enemy
    {
        public string name = "적 1";
        public int hp = 99999999;
        public void DrawHP()
        {
            Console.SetCursorPosition(13, 1);
            System.Console.Write($"{hp,8}");
        }
        public void DrawName()
        {
            Console.SetCursorPosition(2, 0);
            System.Console.Write($"{name}");
        }
    }

    class Player
    {
        #region 키 스트링 상수, 나중에 enum으로 변환
        const string UPKEY = "up";
        const string DOWNKEY = "down";
        const string LEFTKEY = "left";
        const string RIGHTKEY = "right";
        #endregion
        ConsoleKey keyInput;
        public Slot[] slots = new Slot[5];
        int selectSlot;
        int hp;
        string lastInput = null;
        int guidePage = 0;

        public Player()
        {
            selectSlot = 0;
            hp = 100;
            for (int index = 0; index < slots.Length; ++index)
            {
                slots[index] = new Slot();
            }
        }
        public void StartMenu()
        {
            string title = "Project 3-3-5"; // 13 characters
            Console.CursorVisible = false;
            // Console.SetWindowSize(21, 15);
            // Console.SetBufferSize(21, 15);
            Console.Clear();
            System.Console.WriteLine("♜♝♞♜♝♞♜♝♞♜♝♞♜♝♞♜♝♞♜♝♞");
            System.Console.WriteLine("♜                   ♞");
            System.Console.WriteLine("♝                   ♝");
            System.Console.WriteLine("♞                   ♜");
            System.Console.WriteLine("♞♝♜♞♝♜♞♝♜♞♝♜♞♝♜♞♝♜♞♝♜");
            Console.SetCursorPosition(4,2);
            for (int index = 0; index < title.Length; ++index)
            {
                System.Console.Write($"{title[index]}");
                Thread.Sleep(50);
            }
            Console.SetCursorPosition(0,5);
            System.Console.WriteLine();
            Thread.Sleep(200);
            Console.SetCursorPosition(5, 8);
            System.Console.WriteLine("How to Play");
            Thread.Sleep(200);
            Console.SetCursorPosition(8, 11);
            System.Console.WriteLine("Start");
        }
        public void GuideMenu(int guidePage)
        {
            switch (guidePage)
            {
                case 0:
                    Console.Clear();
                    Console.SetCursorPosition(2, 5);
                    System.Console.WriteLine("♜룩 ♝비숍 ♞나이트");
                    Thread.Sleep(200);
                    Console.SetCursorPosition(2, 10);
                    System.Console.WriteLine("3종류의 말이");
                    System.Console.WriteLine("\t  있습니다.");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(9, 14);
                    System.Console.Write("Next Page ↵");
                    break;
                case 1:
                    Console.Clear();
                    Console.SetCursorPosition(2, 4);
                    System.Console.WriteLine("랜덤하게");
                    Console.SetCursorPosition(6, 5);
                    System.Console.WriteLine("5개를 줍니다.");
                    Thread.Sleep(200);
                    Console.SetCursorPosition(0, 10);
                    System.Console.Write("┏━━━━━━━━━━━━━━━━━━━┓");
                    Console.SetCursorPosition(0, 11);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 12);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 13); 
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 14);
                    System.Console.Write("┗━━━━━━━━━━━━━━━━━━━┛");
                    Thread.Sleep(200);
                    Console.SetCursorPosition(6, 12);
                    System.Console.Write("♝ ♞ ♜ ♜ ♝");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(9, 15);
                    System.Console.Write("Next Page ↵");
                    break;
                case 2:
                    Console.Clear();
                    Console.SetCursorPosition(0, 10);
                    System.Console.Write("┏━━━━━━━━━━━━━━━━━━━┓");
                    Console.SetCursorPosition(0, 11);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 12);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 13); 
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 14);
                    System.Console.Write("┗━━━━━━━━━━━━━━━━━━━┛");
                    Console.SetCursorPosition(6, 12);
                    System.Console.Write("♝ ♞ ♜ ♜ ♝");
                    Console.SetCursorPosition(2, 4);
                    System.Console.WriteLine("3개를 선택합니다.");
                    Console.SetCursorPosition(1, 6);
                    System.Console.WriteLine("좌우방향키, 스페이스");
                    Console.SetCursorPosition(6, 11);
                    Thread.Sleep(500);
                    System.Console.Write("⬇︎");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(6, 11);
                    System.Console.Write(" ");
                    Console.SetCursorPosition(8, 11);
                    System.Console.Write("⬇︎");
                    Console.SetCursorPosition(6, 13);
                    System.Console.Write("✓");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(8, 11);
                    System.Console.Write(" ");
                    Console.SetCursorPosition(14, 11);
                    System.Console.Write("⬇︎");
                    Console.SetCursorPosition(8, 13);
                    System.Console.Write("✓");
                    Thread.Sleep(200);
                    Console.SetCursorPosition(14, 13);
                    System.Console.Write("✓");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(9, 15);
                    System.Console.Write("Next Page ↵");
                    break;
                case 3:
                    Console.Clear();
                    Console.SetCursorPosition(0, 10);
                    System.Console.Write("┏━━━━━━━━━━━━━━━━━━━┓");
                    Console.SetCursorPosition(0, 11);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 12);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 13); 
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 14);
                    System.Console.Write("┗━━━━━━━━━━━━━━━━━━━┛");
                    Console.SetCursorPosition(2, 4);
                    System.Console.WriteLine("선택에 따라");
                    System.Console.WriteLine("   공격이 나갑니다.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶    신의 대행자    ◀︎");
                    for (int i = 8; i > 5; --i)
                    {
                        Console.SetCursorPosition(9, i);
                        System.Console.Write("✸⚔︎✸");
                        Thread.Sleep(100);
                        Console.SetCursorPosition(9, i);
                        System.Console.Write("   ");
                    }
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(9, 15);
                    System.Console.Write("Next Page ↵");
                    break;
                case 4:
                    Console.Clear();
                    int[] enemyHpTemp = [84000, 57000, 21000, 0];
                    System.Console.Write($"➤ Enemy HP : {enemyHpTemp[0],8}");
                    Console.SetCursorPosition(0, 1);
                    System.Console.Write("✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎");
                    Console.SetCursorPosition(3, 3);
                    System.Console.Write("적의 hp를");
                    Console.SetCursorPosition(3, 4);
                    System.Console.Write("모두 없애면");
                    Console.SetCursorPosition(3, 5);
                    System.Console.Write("승리합니다.");
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶    공격 중....    ◀︎");
                    Console.SetCursorPosition(0, 10);
                    System.Console.Write("┏━━━━━━━━━━━━━━━━━━━┓");
                    Console.SetCursorPosition(0, 11);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 12);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 13);
                    System.Console.Write("┃                   ┃");
                    Console.SetCursorPosition(0, 14);
                    System.Console.Write("┗━━━━━━━━━━━━━━━━━━━┛");
                    for (int index = 1; index < enemyHpTemp.Length; ++index)
                    {
                        Thread.Sleep(1000);
                        for (int i = 8; i > 1; --i)
                        {
                            if (i <= 5 && i >= 3) { continue; }
                            Console.SetCursorPosition(9, i);
                            System.Console.Write("✸✸✸");
                            Thread.Sleep(100);
                            Console.SetCursorPosition(9, i);
                            System.Console.Write("   ");
                        }
                        Console.SetCursorPosition(0, 0);
                        System.Console.Write($"➤ Enemy HP : {enemyHpTemp[index],8}");
                    }
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(9, 15);
                    System.Console.Write("Main Menu ↵");
                    break;
            }
        }

        public void BattleScene()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            System.Console.Write("➤ ");
            Console.SetCursorPosition(0, 1);
            System.Console.Write("➤ Enemy HP : ");
            Console.SetCursorPosition(0, 2);
            System.Console.Write("✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎✖︎");
            
            Console.SetCursorPosition(0, 10);
            System.Console.Write("┏━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 11);
            System.Console.Write("┃                   ┃");
            Console.SetCursorPosition(0, 12);
            System.Console.Write("┃                   ┃");
            Console.SetCursorPosition(0, 13);
            System.Console.Write("┃                   ┃");
            Console.SetCursorPosition(0, 14);
            System.Console.Write("┗━━━━━━━━━━━━━━━━━━━┛");

            Console.SetCursorPosition(1, 11);
            System.Console.Write("♥︎");
            Console.SetCursorPosition(6, 12);
            System.Console.Write("♝ ♞ ♜ ♜ ♝");
        }
        public void KeyControl(ref int page)
        {
            if (!Console.KeyAvailable) { return; }
            keyInput = Console.ReadKey(true).Key;
            switch (keyInput)
            {
                case ConsoleKey.UpArrow:
                    if (page != 0) { return; }
                    Console.SetCursorPosition(2, 8);
                    System.Console.Write("☛");
                    Console.SetCursorPosition(18, 8);
                    System.Console.Write("☚");
                    Console.SetCursorPosition(2, 11);
                    System.Console.Write(" ");
                    Console.SetCursorPosition(18, 11);
                    System.Console.Write(" ");
                    lastInput = UPKEY;
                    break;
                case ConsoleKey.DownArrow:
                    if (page != 0) { return; }
                    Console.SetCursorPosition(2, 11);
                    System.Console.Write("☛");
                    Console.SetCursorPosition(18, 11);
                    System.Console.Write("☚");
                    Console.SetCursorPosition(2, 8);
                    System.Console.Write(" ");
                    Console.SetCursorPosition(18, 8);
                    System.Console.Write(" ");
                    lastInput = DOWNKEY;
                    break;
                case ConsoleKey.LeftArrow:
                    if (page != 2 || selectSlot < 1) { return; }
                    --selectSlot;
                    break;
                case ConsoleKey.RightArrow:
                    if (page != 2 || selectSlot > 3) { return; }
                    ++selectSlot;
                    break;
                case ConsoleKey.Spacebar:
                    if (lastInput == UPKEY && page == 0)
                    {
                        GuideMenu(0);
                        page = 1;
                    }
                    else if ( lastInput == DOWNKEY && page == 0 )
                    {
                        BattleScene();
                        page = 2;
                    }
                    if (page == 2)
                    {
                        slots[selectSlot].isSelected = !slots[selectSlot].isSelected; //?
                    }
                    break;
                case ConsoleKey.Enter:
                    if ( page != 1 ) { break; }
                    if ( guidePage < 4 )
                    {
                        GuideMenu(++guidePage);
                    }
                    else if ( guidePage == 4 )
                    {
                        guidePage = 0;
                        page = 0;
                        StartMenu();
                    }
                    break;
                case ConsoleKey.Escape:
                    if(page == 0) { Environment.Exit(0); }
                    else
                    {
                        page = 0;
                        Console.Clear();
                        StartMenu();
                    }
                    break;
            }
        }
        public void DrawHP()
        {
            Console.SetCursorPosition(2, 11);
            System.Console.Write($"{hp, 3}");
        }
        public void DrawArrow()
        {
            Console.SetCursorPosition(6, 11);
            System.Console.Write("          ");
            Console.SetCursorPosition(6 + (2*selectSlot), 11);
            System.Console.Write("⬇︎");
        }
        public void CheckAttack(ref Enemy target)
        {
            int count = 0;
            int type = 0;
            for (int index = 0; index < slots.Length; ++index)
            {
                if(slots[index].isSelected)
                {
                    ++count;
                }
            }
            if (count == 3)
            {
                for (int index = 0; index < slots.Length; ++index)
                {
                    if (slots[index].isSelected)
                    {
                        type += slots[index].type;
                    }
                }
                Attack(type, ref target);
            }
        }
        void Attack(int attackType, ref Enemy target)
        {
            //timer
            switch (attackType)
            {
                case 003:
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶♞나이트나이트나이트◀︎");
                    target.hp /= 2;
                    break;
                case 030:
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶     ♝빛으로!      ◀︎");
                    target.hp -= 40000000;
                    hp += 20;
                    break;
                case 300:
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶      ♜철옹성      ◀︎");
                    target.hp -= 19999999;
                    hp += 100;
                    break;
                case 021:
                case 012: // 012 추가예정
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶    신의 대행자    ◀︎");
                    target.hp -= 20000000;
                    break;
                case 210: // 210 추가예정
                case 120: 
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶    수호의 축복    ◀︎");
                    hp += 30;
                    break;
                case 102:
                case 201: // 201 추가예정
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶     폭주 전차     ◀︎");
                    target.hp -= 34000000;
                    hp -= 5;
                    break;
                case 111:
                    Console.SetCursorPosition(0, 9);
                    System.Console.Write("▶         ⚔︎         ◀︎");
                    target.hp -= 10000000;
                    break;
            
            }
            for (int index = 0; index < slots.Length; ++index)
            {
                slots[index].isSelected = false;
                Console.SetCursorPosition(6, 11);
                System.Console.Write("          ");
                Console.SetCursorPosition(6, 12);
                System.Console.Write("          ");
                Console.SetCursorPosition(6, 13);
                System.Console.Write("          ");
                slots[index].Shuffle();
            }
            Thread.Sleep(1000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int page;
            Player player = new Player();
            Enemy enemy = new Enemy();
            
            Console.Clear();
            Console.SetCursorPosition(2, 6);
            System.Console.WriteLine("해상도를 21*15로");
            Console.SetCursorPosition(7, 7);
            System.Console.WriteLine("설정해주세요");

            Thread.Sleep(2500);

            page = 0;
            player.StartMenu();
            
            while (true)
            {
                player.KeyControl(ref page);
                if (page != 2) { continue; }
                if ( enemy.hp <= 0 )
                {
                    enemy.name = "적 처치 완료";
                    enemy.DrawName();
                    enemy.hp = 0;
                    enemy.DrawHP();
                }
                enemy.DrawName();
                enemy.DrawHP();
                for (int index = 0; index < player.slots.Length; ++index)
                {
                    player.slots[index].DrawSlot(index);
                }
                player.DrawHP();

                player.DrawArrow();
                player.CheckAttack(ref enemy);
            }
        }
    }
}
