// **
// int[] num = new int[3];

// num[0] = 10;
// num[1] = 20;
// num[2] = 30;

// // System.Console.WriteLine(num[0]);
// // System.Console.WriteLine(num[1]);
// // System.Console.WriteLine(num[2]);

// for (int index = 0; index < 3; index++)
// {
//     System.Console.WriteLine(num[index]);
// }

// **
// int[] numbers = { 1, 2, 0 };
// int[] numbers2 = new int[3];
// int[] numbers3 = new int[] { 1, 2, 3 };

// for (int index = 0; index < 3; index++)
// {
//     System.Console.WriteLine(numbers[index]);
// }

// **
// string[] fruits = { "사과", "바나나", "orange" };

// for (int index = 0; index < 3; index++)
// {
//     System.Console.WriteLine(fruits[index]);
// }

// **
// int[] korScore = new int[3];
// int[] engScore = new int[3];
// int[] mathScore = new int[3];
// int[] sum = new int[3];
// float[] average = new float[3];

// for (int index = 0; index < 3; index++)
// {
//     System.Console.WriteLine($"{index+1}번 학생의 성적 입력");
//     System.Console.Write("국어 성적 : ");
//     korScore[index] = int.Parse(System.Console.ReadLine());
//     System.Console.Write("영어 성적 : ");
//     engScore[index] = int.Parse(System.Console.ReadLine());
//     System.Console.Write("수학 성적 : ");
//     mathScore[index] = int.Parse(System.Console.ReadLine());

//     sum[index] = korScore[index] + engScore[index] + mathScore[index];
//     average[index] = sum[index] / 3f;
// }

// for (int index = 0; index < 3; index++)
// {
//     System.Console.WriteLine($"{index+1}번 학생의 성적");
//     System.Console.WriteLine($"국어 : {korScore[index]}, 영어 : {engScore[index]}, 수학 : {mathScore[index]}");
//     System.Console.WriteLine($"총점 : {sum[index]}, 평균 : {average[index]:F2}");
// }

// **
// int[] scores = new int[3];

// scores[0] = 90;
// scores[1] = 85;
// scores[2] = 88;

// for (int index = 0; index < scores.Length; index++)
// {
//     System.Console.WriteLine($"점수 {index+1} : {scores[index]}");
// }

// ** 소수점 포맷
// float value = 123.45324524345f;
// System.Console.WriteLine($"{value:F2}");
// System.Console.WriteLine(value.ToString("F2"));
// System.Console.WriteLine(String.Format("셋째 자리 : {0:F3}", value));

// **
// float value = 1252443545.12313f;
// float value2 = 125_244_333.12f;

// System.Console.WriteLine(value.ToString("N2"));
// System.Console.WriteLine($"{value:N3}");
// System.Console.WriteLine($"{value2}");

// **
// int[,] matrix = new int[2,3]
// {
//     {10, 20, 30},
//     {40, 50, 60}
// };

// for (int index = 0; index < 2; index++)
// {
//     for (int jndex = 0; jndex < 3; jndex++)
//     {
//         System.Console.Write($"{matrix[index, jndex]}\t");
//     }
//     System.Console.WriteLine();
// }

// ** 가변배열
// int[][] matrix = [new int[3], new int[3]]; 

// matrix[0][0] = 10;
// matrix[0][1] = 15;
// matrix[0][2] = 20;

// matrix[1][0] = 240;
// matrix[1][1] = 213;
// matrix[1][2] = 202;

// for (int index = 0; index < matrix.Length; index++)
// {
//     for (int jndex = 0; jndex < matrix[index].Length; jndex++)
//     {
//         System.Console.Write($"{matrix[index][jndex]}\t");
//     }
//     System.Console.WriteLine();
// }

// **
// System.Console.WriteLine("가변 배열");
// int[][] jaggedArray = new int[3][];

// jaggedArray[0] = new int [] { 1, 2, 3 };
// jaggedArray[1] = new int [] { 10, 20, 30 };
// jaggedArray[3] = new int [] { 10342, 2340, 3024 };

// for (int index = 0; index < jaggedArray.Length; index++)
// {
//     for (int jndex = 0; jndex < jaggedArray[index].Length; jndex++)
//     {
//         System.Console.Write($"{jaggedArray[index][jndex]}\t");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("var");
// var numbers = new[] { 1, 3, 5, 7, 9 };
// System.Console.WriteLine($"배열 타입 : {numbers.GetType()}");

// ** 빙고
// int[] bingos = new int[25];

// for (int index = 0; index < bingos.Length; index++)
// {
//     bingos[index] = index + 1;
// }

// // for (int index = 0; index < 5; index++)
// // {
// //     for (int jndex = 0; jndex < 5; jndex++)
// //     {
// //         System.Console.Write($"{bingos[index*5+jndex]:D2}\t");
// //     }
// //     System.Console.WriteLine();
// // }

// Random rand = new Random();

// for (int i = 0; i < 100; i++)
// {
//     int indexA = rand.Next(0, 25);
//     int indexB = rand.Next(0, 25);
//     int indexTemp = 0;

//     indexTemp = bingos[indexA];
//     bingos[indexA] = bingos[indexB];
//     bingos[indexB] = indexTemp;
// }
// int input = 0;
// int iBingo = 0;
// int count = 0;


// while (true)
// {
//     Console.Clear();

//     for (int index = 0; index < 5; index++)
//     {
//         for (int jndex = 0; jndex < 5; jndex++)
//         {
//             if (bingos[index * 5 + jndex] == 0)
//             {
//                 System.Console.Write("**\t");
//             }
//             else
//             {
//                 System.Console.Write($"{bingos[index * 5 + jndex]:D2}\t");
//             }
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine($"빙고 개수 : {iBingo}");
//     System.Console.Write("숫자 입력 : ");
//     input = int.Parse(System.Console.ReadLine());

//     iBingo = 0;

//     for (int index = 0; index < bingos.Length; index++)
//     {
//         if (bingos[index] == input)
//         {
//             bingos[index] = 0;
//             break;
//         }
//     }

//     for (int index = 0; index < 5; index++)
//     {
//         for (int jndex = 0; jndex < 5; jndex++)
//         {
//             if (bingos[index * 5 + jndex] == 0)
//             {
//                 ++count;
//             }
//             if(count == 5)
//             {
//                 ++iBingo;
//             }
//         }
//         count = 0;
//     }

//     for (int index = 0; index < 5; index++)
//     {
//         for (int jndex = 0; jndex < 5; jndex++)
//         {
//             if (bingos[index + 5 * jndex] == 0)
//             {
//                 ++count;
//             }
//             if(count == 5)
//             {
//                 ++iBingo;
//             }
//         }
//         count = 0;
//     }

//     for (int index = 0; index < 5; ++index)
//     {
//         if (bingos[index * 4 + 4] == 0)
//         {
//             ++count;
//         }
//         if (count == 5)
//         {
//             ++iBingo;
//         }
//     }
//     count = 0;

//     for (int index = 0; index < 5; ++index)
//     {
//         if (bingos[index * 6] == 0)
//         {
//             ++count;
//         }
//         if (count == 5)
//         {
//             ++iBingo;
//         }
//     }
//     count = 0;

//     if (iBingo >= 5)
//     {
//         System.Console.WriteLine("Success");
//         break;
//     }
// }


// ** 빙고 2차원배열

// int [,] board = new int[5, 5]; // 빙고판
// bool [,] isMarked = new bool[5, 5];

// int bingoCount = 0;

// Random rand = new Random();

// int[] numbers = new int[25];

// for (int index = 0; index < 25; ++index)
// {
//     numbers[index] = index + 1;
// }

// for (int i = 0; i < 100; ++i)
// {
//     int a = rand.Next(25);
//     int b = rand.Next(25);

//     (numbers[a], numbers[b]) = (numbers[b], numbers[a]); // tuple
// }

// int numbersIndex = 0;
// for (int index = 0; index < 5; ++index)
// {
//     for (int jndex = 0; jndex < 5; jndex++)
//     {
//         board[index, jndex] = numbers[numbersIndex++];
//     }
// }

// while(bingoCount < 5)
// {
//     Console.Clear();

//     System.Console.WriteLine("============= 빙고판 =============");

//     for (int index = 0; index < 5; ++index)
//     {
//         for (int jndex = 0; jndex < 5; ++jndex)
//         {
//             if(isMarked[index, jndex])
//             {
//                 System.Console.Write("**\t");
//             }
//             else
//             {
//                 System.Console.Write($"{board[index, jndex]:D2}\t");
//             }
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine($"빙고 개수 : {bingoCount}");
//     System.Console.Write("숫자 입력 : ");
//     int input = int.Parse(System.Console.ReadLine());

//     bool isFound = false;
//     for (int index = 0; index < 5; index++)
//     {
//         for (int jndex = 0; jndex < 5; jndex++)
//         {
//             if(board[index, jndex] == input)
//             {
//                 isMarked[index,jndex] = true;
//                 isFound = true;
//                 break;
//             }
//         }
//         if (isFound) { break; }
//     }
    
//     bingoCount = 0;

//     for (int index = 0; index < 5; ++index)
//     {
//         bool rowBingo = true;

//         for (int jndex = 0; jndex < 5; ++jndex)
//         {
//             if (!isMarked[index, jndex]) { rowBingo = false; }
//         }
//         if (rowBingo) { bingoCount++; }
//     }

//     for (int index = 0; index < 5; ++index)
//     {
//         bool colBingo = true;

//         for (int jndex = 0; jndex < 5; ++jndex)
//         {
//             if (!isMarked[jndex, index]) { colBingo = false; }
//         }
//         if (colBingo) { bingoCount++; }
//     }
    
//     bool diag1Bingo = true;
//     for (int index = 0; index < 5; ++index)
//     {
//         if (!isMarked[index, index]) { diag1Bingo = false; }
//     }
//     if (diag1Bingo) { bingoCount++; }

//     bool diag2Bingo = true;
//     for (int index = 0; index < 5; ++index)
//     {
//         if (!isMarked[index, 4-index]) { diag2Bingo = false; }
//     }
//     if (diag2Bingo) { bingoCount++; }

//     System.Console.WriteLine("Success");
// }

// **
// void AttackFunction(int attack)
// {
//     System.Console.WriteLine($"공격력 : {attack}");
// }
// int BaseAttack()
// {
//     int baseAttack = 10;
//     return baseAttack;
// }

// int attack = 0;
// int baseAttack;
// System.Console.Write("캐릭터 공격력 입력 : ");
// attack = int.Parse(System.Console.ReadLine());
// baseAttack = BaseAttack();

// AttackFunction(baseAttack+attack);

// **
// int Add(int operandA, int operandB)
// {
//     return operandA+ operandB;
// }
// int result = Add(10, 20);
// System.Console.WriteLine($"10 + 20 = {result}");

// **
// string[] fruits = { "apple", "banana", "cherry"};
// foreach (string fruit in fruits)
// {
//     System.Console.WriteLine(fruit);
// }

// **
// int[] arr = { 10, 20, 30, 40, 50 };
// for (int index = 0; index < arr.Length; index++)
// {
//     System.Console.Write($"{arr[index]} ");
// }
// System.Console.WriteLine();

// **
// int[] arr = new int[5];
// int sum = 0;

// System.Console.Write("숫자 입력 : ");
// string input = System.Console.ReadLine();
// string[] sArr = input.Split(' ');

// for (int index = 0; index < arr.Length; index++)
// {
//     arr[index] = int.Parse(sArr[index]);
//     sum += arr[index];
// }

// System.Console.WriteLine($"총 합 : {sum}");

// **
// int[] arr = {3, 8, 15, 6, 2};
// int largest = arr[0];

// for (int index = 0; index < arr.Length; index++)
// {
//     if (arr[index] > largest)
//     {
//         largest = arr[index];
//     }
// }

// System.Console.WriteLine($"최대값 : {largest}");

// **
// for (int i = 0; i < 10; i++)
// {
//     System.Console.Write(i+1 + " ");
// }
// System.Console.WriteLine();

// **
// int count = 0;
// while(count <= 10)
// {
//     ++count;
//     if (count % 2 == 0)
//     {
//         System.Console.Write(count + " ");
//     }
// }
// System.Console.WriteLine();

// **
// int[] arr = { 1, 2, 3, 4, 5 };

// foreach(int element in arr)
// {
//     System.Console.Write(element + " ");
// }

// System.Console.WriteLine();

// **
// int Add(int operandA, int operandB)
// {
//     return operandA + operandB;
// }

// int operandA, operandB;
// System.Console.Write("첫 번째 수 입력 : ");
// operandA = int.Parse(System.Console.ReadLine());

// System.Console.Write("두 번째 수 입력 : ");
// operandB = int.Parse(System.Console.ReadLine());

// System.Console.WriteLine($"{operandA}과(와) {operandB}의 합 : {Add(operandA, operandB)}");

// **
// int GetStringLength(string input)
// {
//     return input.Length;
// }

// System.Console.Write("문자열 입력 : ");
// string input = System.Console.ReadLine();
// System.Console.WriteLine($"문자열 길이 : {GetStringLength(input)}");

// **
int[] arr = new int[3];

int GetLargest(int[] arr)
{
    int largest = arr[0];

    foreach (int element in arr)
    {
        if (element > largest)
        {
            largest = element;
        }
    }
    return largest;
}

void GetInput()
{
    for (int index = 0; index < arr.Length; index++)
    {
        System.Console.Write($"{index + 1}. 숫자 입력 : ");
        arr[index] = int.Parse(System.Console.ReadLine());
    }
}

GetInput();
System.Console.WriteLine($"가장 큰 수 : {GetLargest(arr)}");