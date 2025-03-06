// string[] names = { "Charlie", "Alice", "Bob" };
// var sortedNames = names.OrderBy(n => n);

// foreach (var name in sortedNames)
// {
//     Console.WriteLine(name);
// }

// var firstName = names.First(n => n.StartsWith("A"));

// Console.WriteLine($"First name starting with A: {firstName}");

// **
// //메서드구문 , 쿼리 구문
// int[] nums = { 5, 3, 8, 1 };

// //메서드구문
// var sortedMethod = nums.OrderByDescending(n => n);

// //쿼리 구문
// var sortedQuery = from n in nums
//                 orderby n
//                 select n;


// Console.WriteLine("Meshod syntax:");
// foreach (var n in sortedMethod)
//     Console.WriteLine(n);

// Console.WriteLine("Query syntax:");
// foreach (var n in sortedQuery)
// {
//     Console.WriteLine(n);
// }

// **
// string[] words = { "apple", "banana", "cherry" };

// //Select로 길이 추출

// var lengths = words.Select(w => w.Length);

// foreach (var length in lengths)
// {
//     System.Console.WriteLine(length);
// }

// // Select
// // Linq 쿼리 연산자중 하나
// // 각 요소를 변환하여 새로운 컬렉션을 생성

// var upperWords = words.Select(w => w.ToUpper());

// foreach (var word in upperWords)
// {
//     System.Console.WriteLine(word);
// }

// **
// int[] datas = { 1, 2, 3, 4, 5 };
// int sum = 0;

// foreach (var data in datas)
// {
//     sum += data;
// }

// System.Console.WriteLine($"Sum : {sum}");   

// **
// int[] data = { 1, 2, 3, 4, 5 };

// int count = data.Length;

// System.Console.WriteLine($"Count : {count}");

// **
// int[] data = { 80, 50, 60, 100 };

// double average = data.Average();

// System.Console.WriteLine($"Average : {average}");

// **
// int[] data = { 80, 50, 60, 100, 29 };
// int max = data.Max();

// System.Console.WriteLine($"Max : {max}");


// **
// int[] data = { 80, 50, 60, 100, 29 };
// int min = data.Min();

// System.Console.WriteLine($"Min : {min}");

// ** 근사값 Near 알고리즘
// int[] data = { 10, 20, 30, 40, 50, 55, 12 };
// int target = 33;
// int nearest = data[0];

// foreach (var d in data)
// {
//     if(Math.Abs(d - target) < Math.Abs(nearest - target))
//     {
//         nearest = d;
//     }
// }
// System.Console.WriteLine($"Nearest to {target} : {nearest}");

// ** Rank 알고리즘
// 각 요소가 몇 번째로 큰지 순위를 매김

// int[] scores = { 93, 12, 54, 73, 26, 30 };

// for (int i = 0; i < scores.Length; ++i)
// {
//     int rank = 1;

//     for (int j = 0; j < scores.Length; ++j)
//     {
//         if (scores[j] > scores[i])
//         {
//             rank++;
//         }
//     }
//     System.Console.WriteLine($"Score : {scores[i]}, Rank : {rank}");
// }

// **
// int[] datas = { 5, 2, 8, 1, 9 };
// Array.Sort(datas);

// foreach (var data in datas)
// {
//     System.Console.WriteLine(data);
// }

// ** 특정값 검색 Search 알고리즘
// int[] datas = { 5, 2, 8, 1, 9 };
// int target = 8;
// int index = -1;

// for (int i = 0; i < datas.Length; ++i)
// {
//     if(datas[i] == target)
//     {
//         index = i;
//         break;
//     }
// }

// System.Console.WriteLine((index >= 0) ? $"Found at index {index}" : "Not Found");

// ** 그룹화하기 Group 알고리즘
// 데이터를 특정 기준으로 그룹화하기

// string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot"/*살구*/ };

// var groups = fruits.GroupBy(f => f[0]); // 첫 글자로 그룹화

// foreach (var group in groups)
// {
//     System.Console.WriteLine($"Key : {group.Key}");

//     foreach (var item in group)
//     {
//         System.Console.WriteLine($"      {item}");
//     }
// }

// ** 상속
// class Animal
// {
//     public string Name { get; set; }
//     public void Eat()
//     {
//         System.Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         System.Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Dog myDog = new Dog();
//         myDog.Name = "김수호천사";
//         myDog.Eat();
//         myDog.Bark();
//     }
// }

// **
// class Player
// {
//     public string Name;
//     public void Render()
//     {
//         System.Console.WriteLine($"플레이어 {Name}");
//     }
// }

// class Wizard : Player
// {
//     public string Job;
//     public void Render2()
//     {
//         System.Console.WriteLine($"직업은 {Job} 입니다");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Player p = new Player();
//         p.Name = "타락파워전사";
//         p.Render();

//         // p.Job;
//         // p.Render2();

//         Wizard w = new Wizard();
//         w.Name = "볼드모트";
//         w.Render();
//         w.Job = "마법사";
//         w.Render2();
//     }
// }

// ** 메소드 오버라이딩 method overriding
// 부모클래스의 메소드를 자식클래스에서 재정의
// class Animal
// {
//     public string Name{get;set;}
//     public virtual void Speak() // 가상메소드 : 자식클래스에서 재정의 가능
//     {
//         System.Console.WriteLine("동물이 소리를 냅니다.");
//     }
// }

// class Dog : Animal
// {
//     public override void Speak()
//     {
//         System.Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Animal myAnimal = new Animal();
//         myAnimal.Name = "동물";
//         myAnimal.Speak();

//         Dog myDog = new Dog();
//         myDog.Name = "김수천";
//         myDog.Speak();

//     }
// }

// ** 업캐스팅 Upcasting
// 자식 -> 부모, 암시적 변환 가능, 
// 안전, 데이터 손실없이 변환 가능

// class Animal
// {
//     public void Speak()
//     {
//         System.Console.WriteLine("동물이 소리를 냅니다.");
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         System.Console.WriteLine("멍멍");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Dog myDog = new Dog();
//         Animal myAnimal = myDog;

//         myAnimal.Speak();

//         // myAnimal.Bark();
//     }
// }

// ** 다운캐스팅 DownCasting
// 명시적 변환 필요
// InvalidCastException발생가능
// as is 키워드로 안전한 형변환 가능

// class Animal
// {
//     public void Speak()
//     {
//         System.Console.WriteLine("동물이 소리를 냅니다.");
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         System.Console.WriteLine("멍멍");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Animal myAnimal = new Dog();
//         Dog myDog = (Dog)myAnimal;

//         myDog.Bark();

//         // Animal myAnimal2 = new Animal();
//         // Dog myDog2 = (Dog)myAnimal2;

//         // myDog2.Bark();

//         if(myAnimal is Dog myDog2)
//         {
//             myDog2.Bark();
//         }
//         else
//         {
//             System.Console.WriteLine("변환 불가");
//         }

//         Dog myDog3 = myAnimal as Dog;

//         if(myDog3 != null)
//         {
//             myDog3.Bark();
//         }
//     }
// }

// **
// class Animal
// {
//     public virtual void Speak()
//     {
//         System.Console.WriteLine("동물이 소리를 냅니다.");
//     }
// }

// class Dog : Animal
// {
//     public override void Speak()
//     {
//         System.Console.WriteLine("멍멍!!!!!!!!");
//     }
//     public void WagTail()
//     {
//         System.Console.WriteLine("꼬리를 흔든다.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Animal animal = new Dog();

//         animal.Speak(); //Dog.Speak();

//         Dog dog = animal as Dog;

//         dog.WagTail();

//         Animal animal2 = new Animal();

//         animal2.Speak();
//     }
// }

// **
// class Parent
// {
//     public virtual void ShowMessage()
//     {
//         System.Console.WriteLine("부모클래스의 메시지");
//     }
// }

// class Child : Parent
// {
//     public override void ShowMessage()
//     {
//         System.Console.WriteLine("자식클래스의 메시지");
//         base.ShowMessage();
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Child child = new Child();

//         child.ShowMessage();
//     }
// }

// **
// class Player
// {
//     protected string Name;

//     public Player()
//     {
//         Name = "플레이어";
//         System.Console.WriteLine("생성자");
//     }

//     public void Show()
//     {
//         System.Console.WriteLine(Name);
//     }
// }

// class Wizard : Player
// {
//     public Wizard()
//     {
//         Name = "마법사";
//         System.Console.WriteLine("자식 생성자");
//     }      
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Player p = new Player();

//         p.Show();
//     }
// }

// class Unit
// {
//     public string Name {get; set;}
//     public int Health { get; set;}

//     public Unit()
//     {
//         Name = "Unknown";
//         Health = 0;
//     }
//     public virtual void Attack()
//     {
//         System.Console.WriteLine($"{Name}이 공격합니다.");
//     }
//     public virtual void Heal(Unit target)
//     {
//         System.Console.WriteLine($"{Name}을 치료할 수 없습니다.");
//     }
//     public virtual void Move()
//     {
//         System.Console.WriteLine($"{Name}이 이동합니다.");
//     }
// }

// class SCV : Unit
// {
//     public SCV()
//     {
//         Name = "SCV";
//         Health = 60;
//     }
//     public override void Attack()
//     {
//         System.Console.WriteLine("SCV가 용접기로 공격합니다! (공격력이 약함)");
//     }

//     public override void Heal(Unit target)
//     {
//         System.Console.WriteLine($"SCV가 {target.Name}을(를) 수리합니다. (기계 유닛만 가능)");
//     }
// }

// class Marine : Unit
// {
//     public Marine()
//     {
//         Name = "Marine";
//         Health = 40;
//     }
//     public override void Attack()
//     {
//         System.Console.WriteLine("Marine이 소총으로 공격합니다.");
//     }
// }
// class Medic : Unit
// {
//     public Medic()
//     {
//         Name = "Medic";
//         Health = 50;
//     }
//     public override void Heal(Unit target)
//     {
//         System.Console.WriteLine($"Medic이 {target.Name}을(를) 치료합니다. (바이오닉 유닛만 가능)");
//     }
// }
// class Tank : Unit
// {
//     public Tank()
//     {
//         Name = "Tank";
//         Health = 150;
//     }
//     public override void Attack()
//     {
//         System.Console.WriteLine("Tank가 포격합니다!!!!!!!!");
//     }

//     public override void Move()
//     {
//         System.Console.WriteLine("Tank가 기어갑니다.....");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Unit> units = new List<Unit>();

//         units.Add(new SCV());
//         units.Add(new Marine());
//         units.Add(new Medic());
//         units.Add(new Tank());

//         foreach(var unit in units)
//         {
//             unit.Move();
//             unit.Attack();
//             System.Console.WriteLine();
//         }

//         foreach (var unit in units)
//         {
//             if (unit.Name == "SCV")
//             {
//                 unit.Heal(units[3]);
//             }
//             if (unit.Name == "Medic")
//             {
//                 unit.Heal(units[1]);
//             }
//         }
//     }
// }

// class Skill
// {
//     public string Name;
//     public int Manacost;
//     public int Cooldown;
//     public int LastUsedTime;

//     public Skill(string name, int manaCost, int cooldown)
//     {
//         Name = name;
//         Manacost = manaCost;
//         Cooldown = cooldown * 1000; // change to millisecond
//         LastUsedTime = 0;
//     }

//     public bool CanUse(int playerMana)
//     {
//         int currentTime = Environment.TickCount;

//         if (playerMana < Manacost)
//         {
//             System.Console.WriteLine($"마나가 부족합니다. (필요 MP : {Manacost})");
//             return false;
//         }
//         if (currentTime - LastUsedTime < Cooldown)
//         {
//             int remainingTime = (Cooldown - (currentTime - LastUsedTime)) / 1000;
//             System.Console.WriteLine($"{Name} 스킬은 아직 사용할 수 없습니다. (남은 시간 : {remainingTime}초)");
//             return false;
//         }
//         return true;
//     }

//     public void Use(ref int playerMana)
//     {
//         if(!CanUse(playerMana)) { return; }

//         playerMana -= Manacost;
//         LastUsedTime = Environment.TickCount; // 현재시간 저장

//         System.Console.WriteLine($"{Name} 스킬 사용");
//         System.Console.WriteLine($"남은 마나 : {playerMana}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         int playerMana = 200; // 초기 마나
//         Skill[] skills = new Skill[]
//         {
//             new Skill("화염구", 20, 3),
//             new Skill("얼음창", 15, 2),
//             new Skill("회복", 30, 5)
//         };

//         while (true)
//         {
//             Console.Clear();
//             System.Console.WriteLine($"현재 마나 : {playerMana}");
//             System.Console.WriteLine("사용 가능한 스킬 : ");
//             for (int i = 0; i < skills.Length; ++i)
//             {
//                 System.Console.WriteLine($"{i + 1}. {skills[i].Name}" +
//                 $"(MP {skills[i].Manacost}, 쿨다운 {skills[i].Cooldown / 1000}s)");
//             }
//             System.Console.WriteLine("0. 종료");
//             System.Console.Write("사용할 스킬 번호 입력 : ");
//             try
//             {
//                 int input = int.Parse(System.Console.ReadLine());

//                 if (input == 0) { break; }

//                 if (input > 0 && input <= skills.Length)
//                 {
//                     skills[input - 1].Use(ref playerMana);
//                 }
//                 else
//                 {
//                     System.Console.WriteLine("없는 스킬 번호입니다.");
//                 }
//             }
//             catch (System.Exception)
//             {
//                 System.Console.WriteLine("숫자를 입력하세요...");
//                 throw;
//             }

//             Thread.Sleep(1000);
//         }
//         System.Console.WriteLine("게임종료");
//     }
// }


class Champion
{
    public string Name;
    public string Spell1;
    public string Spell2;
    public Champion()
    {
        Name = "임시 챔피언";
        Spell1 = "점멸";
    }
    public virtual void Pick()
    {
        System.Console.WriteLine("챔피언이 선택되지 않았습니다.");
    }
    public virtual void QSkill(string target = null)
    {
        System.Console.WriteLine("Something Wrong : Q 스킬 사용");
    }
    public virtual void WSkill(string target = null)
    {
        System.Console.WriteLine("Something Wrong : W 스킬 사용");
    }
    public virtual void ESkill(string target = null)
    {
        System.Console.WriteLine("Something Wrong : E 스킬 사용");
    }
    public virtual void RSkill(string target = null)
    {
        System.Console.WriteLine("Something Wrong : 궁극기 사용");
    }
    public virtual void UseSpell1(string target = null)
    {
        System.Console.WriteLine($"대상 미지정 : {Spell1} 사용");
    }
    public virtual void UseSpell2(string target = null)
    {
        System.Console.WriteLine($"대상 미지정 : {Spell2} 사용");
    }
}

class LeeSin : Champion
{
    bool[] combos;
    public LeeSin()
    {
        combos = [false,false,false];
        Name = "리 신";
        Spell2 = "강타";
    }
    public override void Pick()
    {
        System.Console.WriteLine("당신의 뜻대로 싸우겠소");
    }
    public override void QSkill(string target = null)
    {
        switch (combos[0])
        {
            case false:
                System.Console.WriteLine("음파");
                break;
            case true:
                System.Console.WriteLine("공명의 일격");
                break;
        }
        combos[0] = !combos[0];
    }
    public override void WSkill(string target)
    {
        switch (combos[1])
        {
            case false:
                if (target != null)
                {
                    System.Console.WriteLine($"아군 {target}에게 방호");
                }
                else
                {
                    System.Console.WriteLine("자신에게 방호");
                }
                break;
            case true:
                System.Console.WriteLine("강철의 의지");
                break;
        }
        combos[1] = !combos[1];
    }
    public override void ESkill(string target = null)
    {
        switch (combos[2])
        {
            case false:
                System.Console.WriteLine("폭풍");
                break;
            case true:
                System.Console.WriteLine("무력화");
                break;
        }
        combos[2] = !combos[2];
    }
    public override void RSkill(string target = null)
    {
        System.Console.WriteLine("용의 분노!!!");
    }
    public override void UseSpell2(string target)   
    {
        if (target != null)
        {
            System.Console.WriteLine($"{target}에게 {Spell2} 사용");
        }
        else
        {
            System.Console.WriteLine("대상이 없습니다!");
        }
    }
}


class Yuumi : Champion
{
    bool isRide;
    string Rided;
    public Yuumi()
    {
        isRide = false;
        Name = "유미";
        Spell1 = "회복";
        Spell2 = "탈진";
    }
    public override void Pick()
    {
        System.Console.WriteLine("너랑~ 유미랑~");
    }
    public override void QSkill(string target = null)
    {
        string defaultQ = "사르르탄 발사";
        if (isRide)
        {
            System.Console.Write($"{Rided}(으)로부터 ");
        }
        System.Console.WriteLine(defaultQ);
    }
    public override void WSkill(string target = null)
    {
        if (target == null)
        {
            System.Console.WriteLine($"{Name}는 혼자예요");
            isRide = false;
            Name = "유미";
        }
        else if (!isRide && target != null)
        {
            System.Console.WriteLine($"{target}에 탑승");
            isRide = true;
            Rided = target;
            Name = $"유미 ({Rided} 탑승 중)";
        }
        else if (isRide && target != null)
        {
            System.Console.WriteLine($"계획 변경 : {target}에 탑승");
            isRide = true;
            Rided = target;
            Name = $"유미 ({Rided} 탑승 중)";
        }
    }
    public override void ESkill(string target = null)
    {
        System.Console.Write("슈우우웅~ : ");
        if (isRide)
        {
            System.Console.Write($"{Rided}에게 ");
        }
        else
        {
            System.Console.Write($"{Name} ");
        }
        System.Console.WriteLine("쉴드 부여, 마나회복, 공이속증가");
    }
    public override void RSkill(string target = null)
    {
        string defaultR = "대단원!!";
        if (isRide)
        {
            System.Console.Write($"{Rided}(으)로부터 ");
        }
        System.Console.WriteLine(defaultR);
    }
    public override void UseSpell1(string target)
    {
        if (isRide && target != null)
        {
            System.Console.Write($"{Rided}와(과) {target}에게 ");
        }
        else if (!isRide && target != null)
        {
            System.Console.Write($"{target}와(과) 함께 ");
        }
        else if (isRide && target == null)
        {
            System.Console.Write($"{Rided}에게 ");
        }
        else
        {
            System.Console.Write($"나홀로 ");
        }
        System.Console.WriteLine($"{Spell1} 사용");
    }
    public override void UseSpell2(string target)
    {
        if (target != null)
        {
            System.Console.WriteLine($"{target}에게 {Spell2} 사용");
        }
        else
        {
            System.Console.WriteLine("대상이 없습니다!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Champion> champions = new List<Champion>();
        champions.Add(new LeeSin());
        champions.Add(new Yuumi());

        Champion player = null;

        Console.Clear();
        System.Console.WriteLine("챔피언을 선택하세요");

        for (int i = 0; i < champions.Count; i++)
        {
            System.Console.WriteLine($"{i + 1}. {champions[i]}");
        }
        System.Console.Write("번호 입력 : ");

        try
        {
            int characterIndex = int.Parse(System.Console.ReadLine()) - 1;
            switch (characterIndex)
            {
                case 0:
                    player = new LeeSin();
                    break;
                case 1:
                    player = new Yuumi();
                    break;
                default:
                    player = new Champion();
                    break;
            }
            player.Pick();
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("잘못된 입력");
        }

        while (player.Name != "임시 챔피언")
        {
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine($"챔피언 : {player.Name}");
            System.Console.WriteLine($"스펠1 : {player.Spell1}");
            System.Console.WriteLine($"스펠2 : {player.Spell2}");
            System.Console.WriteLine("종료하려면 z");
            System.Console.Write("스킬 또는 스펠 (q,w,e,r,d,f) 입력 : ");
            string input = System.Console.ReadLine();
            switch (input)
            {
                case "q":
                    player.QSkill();
                    break;
                case "w":
                    System.Console.Write("시전 타겟 (없을시 n): ");
                    string wTarget = System.Console.ReadLine();
                    if (wTarget== "n")
                    {
                        wTarget = null;
                    }
                    player.WSkill(wTarget);
                    break;
                case "e":
                    player.ESkill();
                    break;
                case "r":
                    player.RSkill();
                    break;
                case "d":
                    System.Console.Write("시전 타겟 (없을시 n): ");
                    string dTarget = System.Console.ReadLine();
                    if (dTarget== "n")
                    {
                        dTarget = null;
                    }
                    player.UseSpell1(dTarget);
                    break;
                case "f":
                    System.Console.Write("시전 타겟 (없을시 n): ");
                    string fTarget = System.Console.ReadLine();
                    if (fTarget== "n")
                    {
                        fTarget = null;
                    }
                    player.UseSpell2(fTarget);
                    break;
                case "z":
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("잘못된 입력");
                    break;
            }
        }
    }
}