// void PrintHello()
// {
//     System.Console.WriteLine("Hello, world!");
// }

// PrintHello();

// **
// void PrintMessage(string msg)
// {
//     System.Console.WriteLine(msg);
// }

// PrintMessage("HOHOHOHO");

// **
// int GetNumber()
// {
//     return 4230;
// }

// int num = GetNumber();
// System.Console.WriteLine(num);

// **
// int Add(int operandA, int operandB)
// {
//     return operandA + operandB;
// }

// int result = Add(3,5);
// System.Console.WriteLine(result);

// **
// void Greet(string name = "용사")
// {
//     System.Console.WriteLine($"어서오세요 {name}님!");
// }

// Greet();
// Greet("페리도트");

// ** ///
// <summary>	메서드, 클래스, 속성 등에 대한 설명	<summary>두 수를 더함</summary>
// <param>	매개변수 설명	<param name="a">첫 번째 숫자</param>
// <returns>	반환값 설명	<returns>두 숫자의 합</returns>
// <remarks>	추가 설명	<remarks>음수도 가능</remarks>
// <example>	사용 예시	<example>Console.WriteLine(Add(1, 2));</example>
// <exception>	예외 정보	<exception cref="ArgumentNullException">NULL 발생 가능</exception>
// <see>	다른 클래스/메서드 참조	<see cref="Math.Abs"/>
// <seealso>	관련 항목 링크	<seealso cref="Math.Pow"/>

// **
// void Divide(int operandA, int operandB, out int quotient, out int remainder)
// {
//     quotient = operandA / operandB;

//     remainder = operandA % operandB;
// }

// int q, r;
// Divide(10, 3, out q, out r);

// System.Console.WriteLine($"몫 : {q}, 나머지 : {r}");

// **
// void Increase(ref int num)
// {
//     num += 10;
// }

// int value = 5;

// Increase(ref value);

// System.Console.WriteLine(value);

// ** 
// int Sum(params int[] arr)
// {
//     int total = 0;

//     foreach (int num in arr)
//     {
//         total += num;
//     }

//     return total;
// }

// System.Console.WriteLine(Sum(1,2,3,4,5));
// System.Console.WriteLine(Sum(1,2,3,4,5,5,4,24,423,424,23,4,4,3,2));

// ** 재귀함수, 무한루프 주의
// void Print(int n)
// {
//     if (n < 0) { return; }
//     System.Console.WriteLine("나는 메가우쿨렐레다");
//     Print(n - 1);
// }

// Print(8);

// int Factorial(int n)
// {
//     if (n < 1) { return 1; }
//     return n * Factorial(n-1);
// }
// System.Console.WriteLine(Factorial(5)); 

// ** 네임스페이스 namespace
// 클래스, 함수, 변수 이름이 충돌하는 것을 방지하기 위함

// namespace dev1
// {
//     class class1
//     {
//         public static void SayHi()
//         {
//             System.Console.WriteLine("Hi");
//         }

//     }
// }

// namespace dev2
// {
//     class class2
//     {
//         static void Main(string[] args)
//         {
//             dev1.class1.SayHi();
//         }
//     }
// }

// ** 화살표함수 람다 lambda
// int AddArrow(int a, int b) => a + b;
// System.Console.WriteLine(AddArrow(3,5));

// **
// System.Console.WriteLine($"Pi : {Math.PI}");
// System.Console.WriteLine($"Square root of 25 : {Math.Sqrt(25)}");
// System.Console.WriteLine($"Power (2^3) : {Math.Pow(2, 3)}");
// System.Console.WriteLine($"Round(3.75) : {Math.Round(3.75)}");

// ** 열거형

// class Program
// {
//     enum DayOfWeek
//     {
//         Sunday,
//         Monday,
//         Tuesday,
//         Wednesday,
//         Thursday,
//         Friday,
//         Saturday
//     }

//     enum StatusCode
//     {
//         Success = 200,
//         BadRequest = 400,
//         Unauthorized = 401,
//         NotFound = 404
//     }
//     static void Main(string[] args)
//     {
//         DayOfWeek today = DayOfWeek.Wednesday;

//         System.Console.WriteLine(today);
//         System.Console.WriteLine((int)today);

//         StatusCode status = StatusCode.NotFound;
//         System.Console.WriteLine(status);
//         System.Console.WriteLine((int)status);
//     }

// }

// **
// class Program
// {
//     enum WeaponType
//     {
//         Sword,
//         Bow,
//         Staff
//     }
//     static void ChooseWeapon(WeaponType weapon)
//     {
//         string weaponName = null;
//         switch (weapon)
//         {
//             case WeaponType.Sword:
//                 weaponName = "검";
//                 break;
//             case WeaponType.Bow:
//                 weaponName = "활";
//                 break;
//             case WeaponType.Staff:
//                 weaponName = "지팡이";
//                 break;
//         }
//         System.Console.WriteLine($"{weaponName}을(를) 선택했습니다.");
//     }
//     static void Main(string[] args)
//     {
//         ChooseWeapon(WeaponType.Bow);
//     }
// }

// ** 구조체

// class Program
// {

//     struct Point
//     {
//         public int X;
//         public int Y;

//         public void Print()
//         {
//             System.Console.WriteLine($"좌표 : {X}, {Y}");
//         }
//     }

//     static void Main(string[] args)
//     {
//         Point p;
//         p.X = 10;
//         p.Y = 20;

//         p.Print();
//     }
// }

// **

// class Program
// {

//     struct Point
//     {
//         public int X = 0;
//         public int Y = 0;

//         public Point() {}

//         public Point(int x = 0, int y = 0)
//         {
//             X = x;
//             Y = y;
//         }

//         public void Print()
//         {
//             System.Console.WriteLine($"좌표 : {X}, {Y}");
//         }
//     }

//     static void Main(string[] args)
//     {
//         Point p1 = new Point(1, 2);
//         Point p2 = new Point();

//         p1.Print();
//         p2.Print();
//     }
// }

// ** 
// class Program
// {
//     struct Rectangle
//     {
//         public int Width;
//         public int Height;
//         public int GetArea() => Width * Height;
//     }
//     static void Main(string[] args)
//     {
//         Rectangle rect = new Rectangle { Width = 5, Height = 4 };

//         System.Console.WriteLine($"Area : {rect.GetArea()}");
//     }
// }

// **
// class Program
// {
//     struct Point
//     {
//         public int X;
//         public int Y;
//     }
//     static void Main(string[] args)
//     {
//         Point[] points = new Point[2];

//         points[0].X = 10;
//         points[0].Y = 10;

//         points[1].X = 20;
//         points[1].Y = 20;

//         foreach (Point pt in points)
//         {
//             System.Console.WriteLine($"Point : {pt.X}, {pt.Y}");
//         }
//     }

// }


// **
// class Program
// {
//     struct Student
//     {
//         public string Name;
//         public int KorScore;
//         public int EngScore;
//         public int MathScore;

//         public void Print()
//         {
//             System.Console.WriteLine($"{Name}\t{KorScore}\t{EngScore}\t{MathScore}");

//         }
//     }
//     static void Main(string[] args)
//     {
//         Student[] students = new Student[3];
//         for (int index = 0; index < students.Length; index++)
//         {
//             System.Console.Write($"학생 {index+1} 이름 입력 : ");
//             students[index].Name = System.Console.ReadLine();

//             System.Console.Write($"{students[index].Name}의 국어 성적 입력 : ");
//             students[index].KorScore = int.Parse(System.Console.ReadLine());

//             System.Console.Write($"{students[index].Name}의 영어 성적 입력 : ");
//             students[index].EngScore = int.Parse(System.Console.ReadLine());

//             System.Console.Write($"{students[index].Name}의 수학 성적 입력 : ");
//             students[index].MathScore = int.Parse(System.Console.ReadLine());
//         }

//         System.Console.WriteLine("이름\t국어\t영어\t수학");
//         foreach (Student student in students)
//         {
//             student.Print();
//         }
//     }
// }

// ** 인벤토리
// namespace Inventory
// {
//     class Program
//     {
//         const int MAX_ITEMS = 10;

//         static string[] itemNames = new string[MAX_ITEMS];
//         static int[] itemCounts = new int[MAX_ITEMS];

//         static void AddItem(string name, int count)
//         {
//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] == name) // 이미 있으면 개수 증가
//                 {
//                     itemCounts[i] += count;
//                     return;
//                 }
//             }

//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] == null)
//                 {
//                     itemNames[i] = name;
//                     itemCounts[i] = count;
//                     return;
//                 }
//             }

//             System.Console.WriteLine("인벤토리가 가득 찼습니다.");
//         }

//         static void RemoveItem(string name, int count)
//         {
//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] == name)
//                 {
//                     if (itemCounts[i] >= count)
//                     {
//                         itemCounts[i] -= count;
//                         if (itemCounts[i] == 0)
//                         {
//                             itemNames[i] = null;
//                         }
//                         return;
//                     }
//                     else
//                     {
//                         System.Console.WriteLine("아이템 개수 부족");
//                         return;
//                     }
//                 }

//             }

//             System.Console.WriteLine("아이템을 찾을 수 없습니다.");
//         }

//         static void ShowInventory()
//         {
//             System.Console.WriteLine("== 현재 인벤토리 == ");
//             bool isEmpty = true;

//             for (int i = 0; i < MAX_ITEMS; i++)
//             {
//                 if (itemNames[i] != null)
//                 {
//                     System.Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
//                     isEmpty = false;
//                 }
//             }

//             if(isEmpty)
//             {
//                 System.Console.WriteLine("인벤토리가 비어 있습니다.");
//             }
//             System.Console.WriteLine("===================");
//         }
//         static void Main(string[] args)
//         {
//             AddItem("칼", 5);
//             AddItem("포션", 8);
//             AddItem("칼", 1);
//             ShowInventory();

//             System.Console.WriteLine("포션 2개 사용");
//             RemoveItem("포션", 2);
//             ShowInventory();

//             System.Console.WriteLine("방패 1개 제거 시도");
//             RemoveItem("방패", 1);
//             ShowInventory();

//             System.Console.WriteLine("포션 6개 사용");
//             RemoveItem("포션", 100);
//             ShowInventory();

//         }
//     }
// }

// ** 슈팅게임
// namespace ShootingGame1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x = 10, y = 10;

//             ConsoleKeyInfo keyInfo;

//             Console.CursorVisible = false;

//             while (true)
//             {
//                 Console.Clear();

//                 Console.SetCursorPosition(x, y);

//                 Console.Write("*"); // 현재위치

//                 keyInfo = Console.ReadKey(true); // 키입력받기

//                 // 방향키 입력에 따른 좌표 변경
//                 switch (keyInfo.Key)
//                 {
//                     case ConsoleKey.W: //uparrow
//                         if (y > 0) { y--; }
//                         break;
//                     case ConsoleKey.S: //downarrow
//                         if (y < Console.WindowHeight - 1) { y++; }
//                         break; 
//                     case ConsoleKey.A: //leftarrow
//                         if (x > 0) { x --; }
//                         break;
//                     case ConsoleKey.D: //rightarrow
//                         if (x < Console.WindowWidth - 1) { x++; }
//                         break;
//                     case ConsoleKey.Spacebar:
//                         System.Console.WriteLine("미사일띠");
//                         break;
//                     case ConsoleKey.Escape:
//                         return;
//                 }
//             }
//         }
//     }

// }

// ** 슈팅게임
// using System.Diagnostics;

// namespace ShootingGame1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] player = new string[]
//             {
//                 "➹➼",
//                 "🀰🀰➨",
//                 "➷➼"
//             };
//             int playerX = 0;
//             int playerY = 12;
//             ConsoleKeyInfo keyInfo;

//             Console.CursorVisible = false;

//             // Stopwatch stopwatch = new Stopwatch();
//             // stopwatch.Start();

//             // long prevSecond = stopwatch.ElapsedMilliseconds;



//             while (true)
//             {
//                 Console.Clear();

//                 // long currentSecond = stopwatch.ElapsedMilliseconds; // 현재시간 가져오기
//                 // if (currentSecond - prevSecond >= 1000)
//                 // {
//                 //     System.Console.WriteLine("1초루프");
//                 for (int i = 0; i < player.Length; i++)
//                 {
//                     // 콘솔 플레이어 좌표 설정
//                     Console.SetCursorPosition(playerX, playerY + i);
//                     System.Console.WriteLine(player[i]);
//                 }
//                 keyInfo = Console.ReadKey(true); // 키입력받기

//                 switch (keyInfo.Key)
//                 {
//                     case ConsoleKey.W: //uparrow
//                         if (playerY > 0) { playerY--; }
//                         break;
//                     case ConsoleKey.S: //downarrow
//                         if (playerY < Console.WindowHeight - 4) { playerY++; }
//                         break;
//                     case ConsoleKey.A: //leftarrow
//                         if (playerX > 0) { playerX--; }
//                         break;
//                     case ConsoleKey.D: //rightarrow
//                         if (playerX < Console.WindowWidth - 3) { playerX++; }
//                         break;
//                     case ConsoleKey.Spacebar:
//                         System.Console.WriteLine("미사일띠");
//                         break;
//                     case ConsoleKey.Escape:
//                         return;
//                 }


//                 //     prevSecond = currentSecond; // 이전시간 업데이트
//                 // }

//             }
//         }
//     }

// }

// **
// namespace Inventory
// {
//     class Program
//     {
//         const int MAX_ITEM_COUNTS = 10;
//         struct Item
//         {
//             public string itemName;
//             public int itemCount;
//             public Item(string name, int count)
//             {
//                 itemName = name;
//                 itemCount = count;
//             }
//         }
//         struct MyInventory
//         {
//             Item[] items;
//             int itemIndex;
//             public MyInventory()
//             {
//                 items = new Item[30];
//                 itemIndex = 0;
//             }
//             public void AddItem(string name, int count)
//             {
//                 if (count > MAX_ITEM_COUNTS || count <= 0)
//                 {
//                     System.Console.WriteLine("잘못된 값 입력");
//                     return;
//                 }
//                 for (int i = 0; i < itemIndex; i++)
//                 {
//                     if (name == items[i].itemName)
//                     {
//                         if (items[i].itemCount >= MAX_ITEM_COUNTS)
//                         {
//                             System.Console.WriteLine($"더 이상 {name} 아이템을 추가할 수 없습니다.");
//                             return;
//                         }
//                         else if (items[i].itemCount + count <= MAX_ITEM_COUNTS)
//                         {
//                             System.Console.WriteLine($"{name} 아이템 {count}개 증가");
//                             items[i].itemCount += count;
//                             return;
//                         }
//                         else if (items[i].itemCount + count > MAX_ITEM_COUNTS)
//                         {
//                             System.Console.WriteLine($"{name} 아이템 {MAX_ITEM_COUNTS-items[i].itemCount}개 증가");
//                             items[i].itemCount = MAX_ITEM_COUNTS;
//                             return;
//                         }
//                     }
//                 }
//                 if (itemIndex < 30)
//                 {
//                     System.Console.WriteLine($"{name} 아이템 {count}개 생성");
//                     items[itemIndex] = new Item(name, count);
//                     itemIndex++;
//                 }
//                 else
//                 {
//                     System.Console.WriteLine("인벤토리가 가득 찼습니다.");
//                 }

//             }
//             public void RemoveItem(string name, int count)
//             {
//                 if (count <= 0 || count > MAX_ITEM_COUNTS)
//                 {
//                     System.Console.WriteLine("잘못된 값 입력");
//                     return;
//                 }
//                 for (int i = 0; i < items.Length; i++)
//                 {
//                     if (name == items[i].itemName && count < items[i].itemCount)
//                     {
//                         System.Console.WriteLine($"{name} 아이템 {count}개 제거");
//                         items[i].itemCount -= count;
//                         return;
//                     }
//                     else if (name == items[i].itemName && count >= items[i].itemCount)
//                     {
//                         System.Console.WriteLine($"{name} 아이템 모두 제거");
//                         items[i].itemCount = 0;
//                         items[i].itemName = null;
//                         items[i] = items[itemIndex - 1];
//                         itemIndex--;
//                         return;
//                     }
//                 }
//                 System.Console.WriteLine($"해당 아이템을 찾을 수 없습니다.");
//             }
//             public void ShowInventory()
//             {
//                 System.Console.WriteLine($"내 인벤토리 =================");
//                 foreach (Item item in items)
//                 {
//                     if (item.itemName != null)
//                     {
//                         System.Console.WriteLine($"[{item.itemName}] : {item.itemCount}개");
//                     }
//                 }
//                 System.Console.WriteLine("=============================");
//             }
//         }

//         static void Menu(ref int select)
//             {
//                 System.Console.WriteLine("=======💼인벤토리 관리💼=======");
//                 System.Console.WriteLine("1. 아이템 추가");
//                 System.Console.WriteLine("2. 아이템 제거");
//                 System.Console.WriteLine("3. 인벤토리 확인");
//                 System.Console.WriteLine("4. 종료");
//                 System.Console.WriteLine("===============================");
//                 select = int.Parse(System.Console.ReadLine());
//             }
//         static void Main(string[] args)
//         {
//             int select = 0;
//             string name;
//             int count;
//             MyInventory inventory = new MyInventory();

//             while (true)
//             {
//                 Menu(ref select);

//                 switch (select)
//                 {
//                     case 1:
//                         System.Console.Write("아이템 이름 입력 : ");
//                         name = System.Console.ReadLine();
//                         System.Console.Write("아이템 개수 입력 : ");
//                         count = int.Parse(System.Console.ReadLine());
//                         inventory.AddItem(name, count);
//                         break;
//                     case 2:
//                         System.Console.Write("아이템 이름 입력 : ");
//                         name = System.Console.ReadLine();
//                         System.Console.Write("아이템 개수 입력 : ");
//                         count = int.Parse(System.Console.ReadLine());
//                         inventory.RemoveItem(name, count);
//                         break;
//                     case 3:
//                         inventory.ShowInventory();
//                         break;
//                     case 4:
//                         return;
//                     default:
//                         System.Console.WriteLine("잘못 입력;;");
//                         break;
//                 }

//             }

//         }
//     }
// }

// **
namespace ShootingGame1
{
    struct Player
    {
        public int playerX;
        public int playerY;
        public string[] playerCharacter;
        public Player(int x, int y, string[] character)
        {
            playerX = x;
            playerY = y;
            playerCharacter = character;
        }

    }
    class Program
    {
        static void DrawPlayer(Player p)
        {
            for (int i = 0; i < p.playerCharacter.Length; i++)
            {
                // 콘솔 플레이어 좌표 설정
                Console.SetCursorPosition(p.playerX, p.playerY + i);
                System.Console.WriteLine(p.playerCharacter[i]);
            }
        }
        static void Main(string[] args)
        {

            Player p1 = new Player(0, 12,
            [
                "➹➼",
                "🀰🀰➨",
                "➷➼"
            ]
            );


            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                DrawPlayer(p1);
                keyInfo = Console.ReadKey(true); // 키입력받기

                switch (keyInfo.Key)
                {
                    case ConsoleKey.W: //uparrow
                        if (p1.playerY > 0) { p1.playerY--; }
                        break;
                    case ConsoleKey.S: //downarrow
                        if (p1.playerY < Console.WindowHeight - 4) { p1.playerY++; }
                        break;
                    case ConsoleKey.A: //leftarrow
                        if (p1.playerX > 0) { p1.playerX--; }
                        break;
                    case ConsoleKey.D: //rightarrow
                        if (p1.playerX < Console.WindowWidth - 3) { p1.playerX++; }
                        break;
                    case ConsoleKey.Spacebar:
                        System.Console.WriteLine("미사일");
                        break;
                    case ConsoleKey.Escape:
                        return;
                }

            }

        }

    }
}