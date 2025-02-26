// int attack = 0;

// System.Console.Write("소지금 입력\t\t: ");
// int money = int.Parse(System.Console.ReadLine());
// System.Console.Write("캐릭터 이름 입력\t: ");
// string playerName = System.Console.ReadLine();

// if (0 <= money && money <= 100)
// {
//     System.Console.WriteLine("무한의 대검 구매 완료");
//     attack = 1;
// }
// else if (101 <= money && money <= 200)
// {
//     System.Console.WriteLine("카타나 구매 완료");
//     attack = 2;
// }
// else if (201 <= money && money <= 300)
// {
//     System.Console.WriteLine("진은검 구매 완료");
//     attack = 3;
// }
// else if (301 <= money && money <= 400)
// {
//     System.Console.WriteLine("집판검 구매 완료");
//     attack = 4;
// }
// else if (401 <= money && money <= 500)
// {
//     System.Console.WriteLine("엑스칼리버 구매 완료");
//     attack = 5;
// }
// else if (501 <= money && money <= 600)
// {
//     System.Console.WriteLine("유령검 구매 완료");
//     attack = 6;
// }

// System.Console.WriteLine($"캐릭터 이름\t\t: {playerName}");
// System.Console.WriteLine($"공격력\t\t\t: 100 + {attack}");

// **
// int largestInteger;

// System.Console.Write("첫 번째 정수 입력 : ");
// int a = int.Parse(System.Console.ReadLine());

// System.Console.Write("두 번째 정수 입력 : ");
// int b = int.Parse(System.Console.ReadLine());

// System.Console.Write("세 번째 정수 입력 : ");
// int c = int.Parse(System.Console.ReadLine());

// if (a >= b && a >= c)
// {
//     largestInteger = a;
// }
// else if(b >= a && b >= c)
// {
//     largestInteger = b;
// }
// else
// {
//     largestInteger = c;
// }

// System.Console.WriteLine($"최대값 : {largestInteger}");

// **
// System.Console.Write("점수 입력 : ");
// int iScore = int.Parse(System.Console.ReadLine());

// char cScore = '\0';
// if (iScore >= 90)
// {
//     cScore = 'A';
// }
// else if (iScore >= 80 && iScore < 90)
// {
//     cScore = 'B';
// }
// else if (iScore >= 70 && iScore < 80)
// {
//     cScore = 'C';
// }
// else if (iScore >= 60 && iScore < 70)
// {
//     cScore = 'D';
// }
// else if (iScore < 60)
// {
//     cScore = 'F';
// }

// System.Console.WriteLine($"{cScore} 학점");

// **

int operandA, operandB, result;
string sOperator;
System.Console.Write("첫 번째 수 입력 : ");
operandA = int.Parse(System.Console.ReadLine());

System.Console.Write("두 번째 수 입력 : ");
operandB = int.Parse(System.Console.ReadLine());

System.Console.Write("연산자 입력(+,-,*,/) : ");
sOperator = System.Console.ReadLine();

if (sOperator == "+")
{
    System.Console.WriteLine($"결과 : {operandA + operandB}");
}
else if (sOperator == "-")
{
    System.Console.WriteLine($"결과 : {operandA - operandB}");
}
else if (sOperator == "*")
{
    System.Console.WriteLine($"결과 : {operandA * operandB}");
}
else if (sOperator == "/" && operandB != 0)
{
    System.Console.WriteLine($"결과 : {operandA / operandB}");
}
else if (sOperator == "/" && operandB == 0)
{
    throw new Exception("0으로 나눌 수 없습니다.");
}
