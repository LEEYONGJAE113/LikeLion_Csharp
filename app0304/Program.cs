// System.Console.WriteLine("Exit Program");

// string path = Environment.GetEnvironmentVariable("PATH");
// System.Console.WriteLine($"PATH : {path}");

// Environment.Exit(0);

// **
// Random rand = new Random();

// int randNumber = rand.Next(1, 101);
// System.Console.WriteLine($"랜덤 숫자 : {randNumber}");

// **
// using System.Diagnostics;

// Stopwatch stopwatch = Stopwatch.StartNew();
// for (int index = 0; index < 1000; ++index)
// {
//     Thread.Sleep(1);
// }

// stopwatch.Stop();

// System.Console.WriteLine($"for문 시간 : {stopwatch.ElapsedMilliseconds} ms");

// **
// using System.Text.RegularExpressions;

// string input = "Hello, my phone number is 010-1234-5678.";
// string pattern = @"\d{3}-\d{4}-\d{4}"; // 패턴

// bool isMatch = Regex.IsMatch(input, pattern); // 패턴 검사

// System.Console.WriteLine($"전화번호가 존재하는가? {isMatch}");

// ** 클래스 시그니처 기본구성
// C#에서 클래스 시그니처 = 클래스 선언부
// {접근 지정자} {수정자} class {클래스 이름} : {부모 클래스}, {인터페이스}
// 접근 지정자 = public private protected internal(default)
// 수정자 = abstract sealed static partial

// class Player // 기본 클래스
// {
//     public string Name { get; set; }
//     public int Score { get; set; }
// }

// class Warrior : Player // 상속 클래스
// {
//     public int Strength { get; set; }
// }

// // class Enemy : IAttackable, IMovable // 인터페이스 구현클래스
// // {
// //     public void Attack() {}
// //     public void Move() {}
// // }

// abstract class Animal // 추상 클래스
// {
//     public abstract void MakeSound();
// }

// ** 값 형식과 참조 형식
// 값형식 = stack, 참조형식 = heap

// int valueType = 10;
// object referenceType = valueType;

// valueType = 20;

// System.Console.WriteLine($"ValueType : {valueType}");
// System.Console.WriteLine($"ReferenceType : {referenceType}");

// ** boxing, unboxing 박싱, 언박싱
// 값타입 -> 참조타입 = boxing
// 참조타입 -> 다시 값타입 = unboxing

// int value = 42;
// object boxed = value; // boxing
// int unboxed = (int)boxed; // unboxing

// System.Console.WriteLine($"Boxed : {boxed}, Unboxed : {unboxed}");

// ** is 연산자 형식 비교하기
// 객체가 특정 형식인지 확인

// object obj = "Hello";

// System.Console.WriteLine(obj is string);
// System.Console.WriteLine(obj is int);

// ** as 연산자 형식 변환하기
// as 연산자를 사용해 안전한 형 변환

// object obj = "Hello";
// string str = obj as string;
// // as는 참조타입만 가능

// System.Console.WriteLine(str is string);
// System.Console.WriteLine(str);


// **
// var obj = 42;

// if(obj is int number)
// {
//     System.Console.WriteLine($"Number : {number}");
// }
// else
// {
//     System.Console.WriteLine("Not a number");
// }

// ** 문자열다루기
// string greeting = "Hello";
// string name = "Alice";

// string message = greeting + ", " + name + "!";
// string message2 = $"{greeting}, {name}!";

// System.Console.WriteLine(message);
// System.Console.WriteLine(message2);

// System.Console.WriteLine($"Length of name : {name.Length}");
// System.Console.WriteLine($"To Uppercase : {name.ToUpper()}");
// System.Console.WriteLine($"Substring : {name.Substring(1)}");

// ** string methods
// string text = "C# is awesome!";
// System.Console.WriteLine($"Contains \"awesome\" : {text.Contains("awesome")}");
// System.Console.WriteLine($"Starts with \"C#\" : {text.StartsWith("C#")}");
// System.Console.WriteLine($"Index of \"is\" : {text.IndexOf("is")}");
// System.Console.WriteLine($"Replace \"awesome\" with \"great\" : {text.Replace("awesome", "great")}");

// **
// using System.Text;

// StringBuilder sb = new StringBuilder("Hello");
// sb.Append(",");
// sb.Append("World!");

// System.Console.WriteLine(sb.ToString());

// ** string과 stringbuilder 성능 차이
// 반복적으로 문자열을 수정할때 stringbuilder가 효율적임

// using System.Diagnostics;
// using System.Text;

// int iterations = 10000;

// Stopwatch sw = Stopwatch.StartNew();

// string text = "";

// for (int i = 0; i < iterations; ++i)
// {
//     text += "a";
// }

// sw.Stop();
// System.Console.WriteLine($"String : {sw.ElapsedMilliseconds}ms");

// sw.Restart();

// StringBuilder sb = new StringBuilder();

// for (int i = 0; i < iterations; ++i)
// {
//     sb.Append("a");
// }

// sw.Stop();
// System.Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");

// ** 예외처리 try catch
// // 예외는 프로그램 실행 중 발생하는 오류
// // 예외를 처리하면 프로그램이 중단되지않고 실행을 계속할수있음

// // while (true)
// // {
//     try
//     {
//         int[] numbers = { 1, 2, 3 };
//         System.Console.WriteLine(numbers[5]);
//     }
//     catch (IndexOutOfRangeException ex)
//     {
//         System.Console.WriteLine($"Error : {ex.Message}");
//     }
// // }

// ** finally 블록
// // 예외 발생 여부와 상관없이 항상 실행

// try
// {
//     int number = int.Parse("Nan");
// }
// catch (FormatException ex)
// {
//     System.Console.WriteLine($"Format Exception : {ex.Message}");
// }
// finally
// {
//     System.Console.WriteLine("항상 실행");
// }

// ** Exception class
// try
// {
//     int number = int.Parse("ABC");
// }
// catch (System.Exception ex)
// {
//     System.Console.WriteLine($"General Error : {ex.Message}");
// }

// ** throw로 직접 예외 발생
// try
// {
//     int age = -5;
//     if (age <0)
//     {
//         throw new ArgumentException("Age connot be negative");
//     }
// }
// catch (System.Exception ex)
// {
//     System.Console.WriteLine($"Exception : {ex.Message}");
// }

// **
// int[] numbers = { 1, 2, 3, 4, 5 };
// foreach (int num in numbers)
// {
//     System.Console.WriteLine(num);
// }

// ** List
// // 배열과 비슷하지만 동적으로 크기가 벼하는 가변 길이 구조 컬렉션
// List<string> names = new List<string> { "Alice", "Bob", "Charlie"};

// names.Add("Dave");
// names.Remove("Bob");

// foreach (string name in names)
// {
//     System.Console.WriteLine(name);
// }

// **
// List<int> list = new List<int>();
// list.Add(1);;
// list.Add(2);
// list.Add(3);

// foreach (int num in list)
// {
//     System.Console.WriteLine(num);
// }

// System.Console.WriteLine(list[1]);
// list.Insert(1, 100);
// System.Console.WriteLine(list[1]);

// foreach (int num in list)
// {
//     System.Console.WriteLine(num);
// }

// System.Console.WriteLine(list[0]);
// System.Console.WriteLine(list.Count);

// ** stack LIFO
// Stack<int> stack = new Stack<int>();
// // Generic 안쓰면 <> 필요없
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);
// while (stack.Count > 0)
// {
//     System.Console.WriteLine(stack.Pop());
// }

// ** Queue FIFO
// Queue<int> queue = new Queue<int>();
// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);

// while (queue.Count > 0)
// {
//     System.Console.WriteLine(queue.Dequeue());
// }

// **
// Queue<string> queue = new Queue<string>();
// queue.Enqueue("Q");
// queue.Enqueue("W");
// queue.Enqueue("E");
// queue.Enqueue("R");
// queue.Enqueue("D");
// queue.Enqueue("F");

// while (queue.Count > 0)
// {
//     System.Console.WriteLine(queue.Dequeue());
// }

// ** ArrayList
// using System.Collections;

// ArrayList arrayList = new ArrayList();

// arrayList.Add(1);
// arrayList.Add("Hello");
// arrayList.Add(3.14);

// foreach (var element in arrayList)
// {
//     System.Console.WriteLine($"ArrayList : {element}");
// }

// arrayList.Remove(1);
// System.Console.WriteLine();

// foreach (var element in arrayList)
// {
//     System.Console.WriteLine($"ArrayList : {element}");
// }

// ** Hashtable
// 키-값 쌍을 저장하는 컬렉션
// 키를 이용해 값을 빠르게 검색

// using System.Collections;

// Hashtable hashtable = new Hashtable();

// hashtable["Alice"] = 25;
// hashtable["Bob"] = 30;
// hashtable["포션"] = 20;

// foreach (DictionaryEntry entry in hashtable)
// {
//     System.Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
// }

// System.Console.WriteLine($"Alice의 나이 : {hashtable["Alice"]}");

// ** 제네릭
// <T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들 수 있음

// class Program
// {
//     class Cup<T>
//     {
//         public T Content { get; set; }
//     }
//     static void Main(string[] args)
//     {
//         // Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
//         // Cup<int> cupOfInt = new Cup<int> { Content = 42 };

//         // System.Console.WriteLine($"CupOfString : {cupOfString.Content}");
//         // System.Console.WriteLine($"CupOfInt : {cupOfInt.Content}");

//         // Stack<int> stack = new Stack<int>();

//         // stack.Push(10);
//         // stack.Push(20);
//         // stack.Push(30);

//         // while(stack.Count > 0)
//         // {
//         //     System.Console.WriteLine(stack.Pop());
//         // }

//         List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
//         names.Add("Dave");

//         foreach (string name in names)
//         {
//             System.Console.WriteLine(name);
//         }
//     }
// }


// ** IEnumerator
// C# : 컬렉션 순회 반복할 수 있는 인터페이스
// ✔ 컬렉션을 직접 제어하며 순회할 수 있음
// ✔ foreach 없이도 컬렉션 순회 가능
// ✔ LINQ나 커스텀 컬렉션을 만들 때 유용함
// Unity : Coroutine

// using System.Collections;

// ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

// IEnumerator enumerator = list.GetEnumerator();

// while (enumerator.MoveNext())
// {
//     System.Console.WriteLine(enumerator.Current);
// }

// ** custom Collection
// using System.Collections;
// class SimpleCollection : IEnumerable<int>
// {
//     private int[] data = { 1, 2, 3, 4, 5 };
//     public IEnumerator<int> GetEnumerator()
//     {
//         foreach (var item in data)
//         {
//             yield return item;
//         }
//     }
//     IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         var collection = new SimpleCollection();

//         foreach (var item in collection)
//         {
//             System.Console.WriteLine(item);
//         }
//     }
// }

// **
// Dictionary<string, int> ages = new Dictionary<string, int>();

// ages["금도끼"] = 10;
// ages["은도끼"] = 5;
// ages["돌도끼"] = 1;

// foreach (var pair in ages)
// {
//     System.Console.WriteLine($"{pair.Key} : {pair.Value}");
// }

// ** null값
// reference type은 null가능, value type은 기본적으로 null 불가

// string str = null;

// if(str == null)
// {
//     System.Console.WriteLine("str is null");
// }

// int? nullableInt = null;

// System.Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No Value");
// nullableInt = 10;
// System.Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No Value");

// ** ?? , ?. 연산자
// ?? null일때 대체값 제공, ?. 안전하게 Null 접근

// string str = null;

// System.Console.WriteLine(str ?? "DefaultValue"); //null이면 defaultvalue 출력
// System.Console.WriteLine(str?.Length);

// str = "Hello";

// System.Console.WriteLine(str?.Length);

// if(str != null)
// {
//     System.Console.WriteLine(str.Length);
// }

// ** LINQ
// int[] numbers = { 1, 2, 3, 4, 5 };

// var evenNumbers = numbers.Where(n => n%2 == 0);

// foreach (var num in evenNumbers)
// {
//     System.Console.WriteLine(num);
// }

// **
// class Warrior
// {
//     public string Name { get; set; }
//     public int Score { get; set; }
//     public float Strength { get; set; }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Warrior warrior = new Warrior();
//         warrior.Name = "전사";
//         warrior.Score = 100;
//         warrior.Strength = 50f;

//         System.Console.WriteLine($"Name     : {warrior.Name}");
//         System.Console.WriteLine($"Score    : {warrior.Score}");
//         System.Console.WriteLine($"Strength : {warrior.Strength}");
//     }
// }

// **
// System.Console.Write("정수 입력 : ");
// try
// {
//     int input = int.Parse(System.Console.ReadLine());
//     System.Console.WriteLine(input);
// }
// catch (FormatException)
// {
//     System.Console.WriteLine("올바른 숫자를 입력하세요!");
// }

// **
// List<string> fruits = new List<string>
// {
//     "사과",
//     "바나나",
//     "포도"
// };
// foreach (string fruit in fruits)
// {
//     System.Console.WriteLine(fruit);
// }

// Queue<string> works = new Queue<string>();
// works.Enqueue("첫 번째 작업");
// works.Enqueue("두 번째 작업");
// works.Enqueue("세 번째 작업");
// foreach (string work in works)
// {
//     System.Console.WriteLine(work);
// }

// Stack<int> integers = new Stack<int>();
// integers.Push(10);
// integers.Push(20);
// integers.Push(30);
// foreach (int integer in integers)
// {
//     System.Console.WriteLine(integer);
// }

// **
// System.Console.Write("문자열 입력 : ");
// string input = System.Console.ReadLine();
// System.Console.WriteLine($"To Uppercase : {input.ToUpper()}");
// System.Console.WriteLine($"C# to Csharp : {input.Replace("C#", "Csharp")}");
// System.Console.WriteLine($"Length : {input.Length}");

// **
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

System.Console.Write("Even Numbers : ");
foreach (int number in numbers.Where(n => n % 2 == 0) )
{
    System.Console.Write($"{number} ");
}

System.Console.WriteLine($"\nSum : {numbers.Sum()}");