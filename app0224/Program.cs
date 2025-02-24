// System.Console.Write("Enter Binary Number : ");
// string binaryInput = System.Console.ReadLine();
// int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환

// string binaryOutput = Convert.ToString(decimalValue, 2); // 10진수 -> 2진수

// System.Console.WriteLine($"입력값    : {binaryInput}");
// System.Console.WriteLine($"10진수    : {decimalValue}");
// System.Console.WriteLine($"2진수     : {binaryOutput}");

// **
// var name = "Alice";
// var age = 25;
// var isStudent = true;

// System.Console.WriteLine($"이름 : {name}");
// System.Console.WriteLine($"나이 : {age}");
// System.Console.WriteLine($"학생 여부 : {isStudent}");

// **
// int defaultInt = default;
// string? defaultString = default;
// bool defaultBool = default;

// System.Console.WriteLine($"정수 기본값 : {defaultInt}");
// System.Console.WriteLine($"문자열 기본값 : {defaultString}");
// System.Console.WriteLine($"불린 기본값 : {defaultBool}");

// **
// int a = 5, b = 3;
// int sum = a + b;
// bool isEqual = (a == b);
// Console.WriteLine($"합 : {sum}");
// Console.WriteLine($"equal? : {isEqual}");

// **
// int num = -5;
// System.Console.WriteLine(+num);
// System.Console.WriteLine(-num);

// bool flag = true;
// System.Console.WriteLine(!flag);

// **
// double pi = 3.14;
// int intPi = (int)pi;

// System.Console.WriteLine(intPi);

// **
// string fName = "Alice";
// string lName = "Kim";

// System.Console.WriteLine(fName + " " + lName);

// **
// int a = 5; // 0101
// int b = 3; // 0011
// System.Console.WriteLine(a & b);
// System.Console.WriteLine(a | b);
// System.Console.WriteLine(a ^ b);
// System.Console.WriteLine(~a); // int32기준

// **
// int a = 5; // 0101
// System.Console.WriteLine(a << 1); // 1010
// System.Console.WriteLine(a >> 1); // 0010


// **
// int korScore, engScore, mathScore;
// float sum, average;

// System.Console.Write("국어 점수 입력 : ");
// korScore = int.Parse(System.Console.ReadLine());

// System.Console.Write("영어 점수 입력 : ");
// engScore = int.Parse(System.Console.ReadLine());

// System.Console.Write("수학 점수 입력 : ");
// mathScore = int.Parse(System.Console.ReadLine());

// sum = (float)(korScore + engScore + mathScore);
// average = sum / 3f;
// System.Console.WriteLine($"총점 : {sum}");
// System.Console.WriteLine($"평균 : {average:F2}");

// **
int input;
System.Console.Write("Enter A Integer : ");
input = int.Parse(System.Console.ReadLine());

System.Console.WriteLine($"원래 값       : {input}");
System.Console.WriteLine($"비트 반전 값  : {~input}");