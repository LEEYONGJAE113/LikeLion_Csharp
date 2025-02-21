// **
// System.Console.WriteLine("Upload");

// **
// int age;
// age = 25;

// System.Console.WriteLine(age);
// System.Console.WriteLine(25);

// **
// int number = 10;
// double pi = 3.14;
// char letter = 'A';
// string name = "Alice";

// System.Console.WriteLine(number);
// System.Console.WriteLine(pi);
// System.Console.WriteLine(letter);
// System.Console.WriteLine(name);

// **
// string title = "캐릭터 정보";
// float hp = 100f;
// float atk = 56.7f;
// string name = "Berserker";
// char rank = 'S';

// System.Console.WriteLine($"{title}");
// System.Console.WriteLine($"hp    : {hp}");
// System.Console.WriteLine($"atk   : {atk}");
// System.Console.WriteLine($"name  : {name}");
// System.Console.WriteLine($"rank  : {rank}");

// **
// string greeting;
// greeting = "Hello, world!";

// System.Console.WriteLine(greeting);

// **
// int score = 100;
// double temperature = 36.5;
// string city = "Seoul";

// System.Console.WriteLine(score);
// System.Console.WriteLine(temperature);
// System.Console.WriteLine(city);

// **
// int x = 10, y = 20, z = 30;

// System.Console.WriteLine(x);
// System.Console.WriteLine(y);
// System.Console.WriteLine(z);

// **
// const double PI = 3.141592;
// const int MAX_SCORE = 100;
// System.Console.WriteLine($"Pi        : {PI}");
// System.Console.WriteLine($"MaxScore  : {MAX_SCORE}");

// **
// int atk = 16755, maxHealth = 78103;
// int chm = 36, th = 1017, ja = 41, ss = 611, inn = 22, sr = 39;

// System.Console.WriteLine("     기본 특성");
// System.Console.WriteLine($"공격력         {atk}");
// System.Console.WriteLine($"최대 생명력    {maxHealth}");
// System.Console.WriteLine();
// System.Console.WriteLine("     전투 특성");
// System.Console.WriteLine($"치명           {chm}");
// System.Console.WriteLine($"특화           {th}");
// System.Console.WriteLine($"제압           {ja}");
// System.Console.WriteLine($"신속           {ss}");
// System.Console.WriteLine($"인내           {inn}");
// System.Console.WriteLine($"숙련           {sr}");

// **
// int integerNum = 10;
// float floatNum = 3.14f;
// double doubleNum = 3.141592;

// System.Console.WriteLine(integerNum);
// System.Console.WriteLine(floatNum);
// System.Console.WriteLine(doubleNum);

// **
// int intValue = -100;
// long longValue = 1234567890L;

// System.Console.WriteLine(intValue);
// System.Console.WriteLine(longValue);

// **
// sbyte singedByte = -50;
// short signedShort = -32000;
// int signedInt = -2000000000;

// System.Console.WriteLine(singedByte);
// System.Console.WriteLine(signedShort);
// System.Console.WriteLine(signedInt);

// **
// byte unsignedByte = 255;
// ushort unsignedShort = 65000;
// uint unsignedInt = 4000000000;

// System.Console.WriteLine(unsignedByte);
// System.Console.WriteLine(unsignedShort);
// System.Console.WriteLine(unsignedInt);

// **
// float singlePrecision = 3.14f;
// double doublePrecision = 3.1415926535;
// decimal highPrecision = 3.1415926535897932384626433833m;

// System.Console.WriteLine(singlePrecision);
// System.Console.WriteLine(doublePrecision);
// System.Console.WriteLine(highPrecision);

// **
// int integerValue = 100;
// long longValue = 100L;
// float floatValue = 3.14f;
// double doubleValue = 3.14;
// decimal decimalValue = 3.14m;

// System.Console.WriteLine(integerValue);
// System.Console.WriteLine(longValue);
// System.Console.WriteLine(floatValue);
// System.Console.WriteLine(doubleValue);
// System.Console.WriteLine(decimalValue);

// **
// char letter = 'A';
// char symbol = '#';
// char number = '9';

// System.Console.WriteLine(letter);
// System.Console.WriteLine(symbol);
// System.Console.WriteLine(number);

// **
// string greeting = "Hello, World!";
// string name = "Alice";

// System.Console.WriteLine(greeting);
// System.Console.WriteLine(name);

// System.Console.WriteLine("{0} {1}", greeting, name);

// **
// bool isRunning = true;
// bool isFinished = false;

// System.Console.WriteLine(isRunning);
// System.Console.WriteLine(isFinished);

// **
// System.Int32 number = 123;
// System.String text = "Hello";
// System.Boolean flag = true;

// System.Console.WriteLine(number);
// System.Console.WriteLine(text);
// System.Console.WriteLine(flag);


// **
// int number = 123;
// string numAsString = number.ToString();

// bool flag = true;
// string flagAsString = flag.ToString();

// System.Console.WriteLine(numAsString);
// System.Console.WriteLine(flagAsString);

// ** 로딩, loading

// System.Console.WriteLine("□□□□□□□□□□");
// Thread.Sleep(1500);
// Console.Clear(); // 콘솔화면 지우기
// System.Console.WriteLine("◼︎□□□□□□□□□");
// Thread.Sleep(1500);
// Console.Clear();
// System.Console.WriteLine("◼︎◼︎□□□□□□□□");
// Thread.Sleep(1500);
// Console.Clear();
// System.Console.WriteLine("◼︎◼︎◼︎□□□□□□□");
// Thread.Sleep(1500);
// Console.Clear();

// string white = "□";
// string black = "◼︎";

// for (int i = 0; i <= 10; i++)
// {
//     Console.Clear();
//     System.Console.WriteLine(new string(black[0], i) + new string(white[0], 10-i));
//     // string 생성자 필수
//     Thread.Sleep(1000);
// }

// **
// System.Console.Write("Enter User Name : ");
// string userName = Console.ReadLine();

// if (userName != null)
// {
//     System.Console.WriteLine($"Hello, {userName}");
// }

// **
// System.Console.Write("Enter your Age : ");
// string input = Console.ReadLine();
// int age = int.Parse(input);

// System.Console.WriteLine($"Age : {age}");

// System.Console.Write("Enter your Age : ");
// string input = Console.ReadLine();

// if (int.TryParse(input, out int age))
// {
//     System.Console.WriteLine($"Your Age is {age}");
// }
// else
// {
//     System.Console.WriteLine("Error! Maybe it is not a number.");
// }

// **
// System.Console.Write("입력 - 루인 스킬 피해 : ");
// string ruinStr = Console.ReadLine();
// float ruin = float.Parse(ruinStr);

// System.Console.Write("입력 - 카드 게이지 확득량 : ");
// string cardStr = Console.ReadLine();
// float card = float.Parse(cardStr);

// System.Console.Write("입력 - 각성기 피해 : ");
// string ultiStr = Console.ReadLine();
// float ulti = float.Parse(ultiStr);

// System.Console.Write("입력 - 최대 마나 : ");
// string maxManaStr = Console.ReadLine();
// int maxMana = int.Parse(maxManaStr);

// System.Console.Write("입력 - 전투 중 마나 회복량 : ");
// string incomManaRegenStr = Console.ReadLine();
// int incomManaRegen = int.Parse(incomManaRegenStr);

// System.Console.Write("입력 - 비전투 중 마나 회복량 : ");
// string outcomManaRegenStr = Console.ReadLine();
// int outcomManaRegen = int.Parse(outcomManaRegenStr);

// System.Console.Write("입력 - 이동 속도 : ");
// string moveSpeedStr = Console.ReadLine();
// float moveSpeed = float.Parse(moveSpeedStr);

// System.Console.Write("입력 - 탈 것 속도 : ");
// string mountSpeedStr = Console.ReadLine();
// float mountSpeed = float.Parse(mountSpeedStr);

// System.Console.Write("입력 - 운반 속도 : ");
// string carryStr = Console.ReadLine();
// float carry = float.Parse(carryStr);

// System.Console.Write("입력 - 스킬 재사용 대기시간 감소 : ");
// string cooldownStr = Console.ReadLine();
// float cooldown = float.Parse(cooldownStr);

// System.Console.WriteLine("활동");
// System.Console.WriteLine($"루인 스킬 피해                 {ruin:F1}%");
// System.Console.WriteLine($"카드 게이지 획득량              {card:F1}%");
// System.Console.WriteLine($"각성기 피해                   {ulti:F1}%");
// System.Console.WriteLine($"최대 마나                     {maxMana}");
// System.Console.WriteLine($"전투 중 마나 회복량             {incomManaRegen}");
// System.Console.WriteLine($"비전투 중 마나 회복량            {outcomManaRegen}");
// System.Console.WriteLine($"이동 속도                     {moveSpeed:F1}%");
// System.Console.WriteLine($"탈 것 속도                    {mountSpeed:F1}%");
// System.Console.WriteLine($"운반 속도                     {carry:F1}%");
// System.Console.WriteLine($"스킬 재사용 대기시간 감소         {cooldown:F1}%");

string white = "□";
string black = "◼︎";
string dot = ".";
const int LENGTH = 80;
string userName;

void Selecting(int going, string endMSG)
{
    System.Console.Write("\n번호 선택 : ");
    int select = int.Parse(System.Console.ReadLine());
    Thread.Sleep(1000);
    Console.Clear();
    if (select != going)
    {
        System.Console.WriteLine(endMSG);
        Thread.Sleep(1000);
        System.Console.WriteLine("\n[ The end. ]");
        Environment.Exit(0);
    }
}

for (int i = 0; i <= LENGTH; i++)
{
    Console.Clear();
    System.Console.WriteLine("Loading" + new string(dot[0], i%6));
    System.Console.WriteLine(new string(black[0], i) + new string(white[0], LENGTH-i));
    Thread.Sleep(50);
}

Thread.Sleep(1000);
Console.Clear();
System.Console.WriteLine("Loading Complete!");
Thread.Sleep(1000);
System.Console.WriteLine("\nPress Enter to Start");
System.Console.ReadLine();
Console.Clear();

System.Console.Write("이름을 입력하세요 : ");
userName = Console.ReadLine();

for (int i = 0; i < 7; i++)
{
    Console.Clear();
    System.Console.WriteLine("📞" + new string(dot[0], i%5));
    Thread.Sleep(500);
}
Console.Clear();

System.Console.WriteLine($"\"여보세요? ...{userName}?\"");
Thread.Sleep(1000);
System.Console.WriteLine();
System.Console.WriteLine("1. 누구세요?");
System.Console.WriteLine("2. 뭔데 너 누군데! 내 이름 어떻게 아는데! 스토커야?");
Selecting(1, "전화가 끊어졌다... 누구였을까?");

System.Console.WriteLine("\"나 진짜 기억 안 나..?\"");
Thread.Sleep(1000);
System.Console.WriteLine("\n진짜 단 하나도 기억나지 않는다. 이 전화가 내 전화는 맞는건가?");
Thread.Sleep(1000);
System.Console.WriteLine();
System.Console.WriteLine("1. 여긴누구 나는어디 너는무엇");
System.Console.WriteLine("2. 죄송한데 진짜 기억이 안 나요");
Selecting(2, "\"뭐래는거야...\"\n일순간 전화가 끊어졌다.");

System.Console.WriteLine("\"서운해죽겠네 진짜\"");
Thread.Sleep(1000);
System.Console.WriteLine("\n\"..잠시만요\"");
Thread.Sleep(1000);
System.Console.WriteLine("\n지금 상대가 누구인지는 내게 그다지 중요한 일이 아니었다.");
System.Console.WriteLine("\'여기는 어디고... 난 왜 여기있는거지?\'");
Thread.Sleep(1000);
System.Console.WriteLine("\n\nPress Enter↵");
System.Console.ReadLine();

Console.Clear();
System.Console.WriteLine("순간 뒤에서 부스럭대는 소리가 들렸다.");
Thread.Sleep(1000);
System.Console.WriteLine();
System.Console.WriteLine("1. 뒤를 돌아본다");
System.Console.WriteLine("2. 전화하고 있는 사람에게 살려달라고 한다");
Selecting(2, "죽어버렸다!");

System.Console.WriteLine("\"갑자기 뭔소리야? 너 어딘데 지금?\"");
Thread.Sleep(1000);
System.Console.WriteLine("\n\"여기가 어딘지도 모르겠어요. 그냥 넓고 하얀 주차장 같은데 있는데...\"");
Thread.Sleep(300);
System.Console.WriteLine("\n\"..!! 당장 거기서 나와 빨리!!!\"");
Thread.Sleep(1000);
System.Console.WriteLine("\n나는 뭔가 불길한 예감에 무작정 앞으로 달리기 시작했다.");
Thread.Sleep(1000);
System.Console.WriteLine("\n불길한 예감은 빗나가지 않았다.");
System.Console.WriteLine("달리는 내 발소리 뒤로, 무언가가 같이 달리는 소리가 들렸다.");
Thread.Sleep(1000);
System.Console.WriteLine("\n\nPress Enter↵");
System.Console.ReadLine();

Console.Clear();
System.Console.WriteLine("그렇게 얼마나 달렸을까, 가슴이 부서질듯이 아파왔다.");



System.Console.WriteLine("미구현 ㅎㅎ");
Environment.Exit(0);
