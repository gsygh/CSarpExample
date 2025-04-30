



//string message = "안녕하세요.";

//// 정수
//byte max = 255;
//sbyte min = -128;



//Console.WriteLine(message);
//Console.WriteLine("Byte Max : " + max + "\nSbyte Min : " + min + "\n");

//// 실수
//float _f = 1.1f;
//float _f2 = 1.2f;

//Console.WriteLine("Float Sum = " + (_f + _f2));

//double _d = 1.11;
//double _d2 = 1.21;

//Console.WriteLine("Double Sum = " + (_d + _d2));

//// decimal 정확한 값 요구 > 금융과 같은
//decimal _m = 1.11m;
//decimal _m2 = 1.21m;

//Console.WriteLine("Decimal Sum = " + (_m + _m2));

//// 기타
//bool isTrue = false;
//Console.WriteLine("IsTrue : " + isTrue);

//char character = '\u0041';  // 유니코드
//Console.WriteLine("Character : " + character);


// 선언
// 명시적 선언 (Explicit Declaration)
/*
    장점 : 변수의 타입이 명확하게 제시 -> 가독성 상승
    단점 : 객체를 타입으로 삼을 경우, 코드의 길이가 길어질 수 있음.
 */
/*
    int number, double pi ....
 */

// 암시적 선언 (Implicit Declaration) >> 프론트엔드에서 가변 타입으로 썼던 var 사용
/*
    장점 : 코드가 간결해짐
    단점 : 타입 관련 오류를 발견하기 어려움
 */
/*
 *  var number,
 *  var complexDict = new Dictionary<string, List<Tuple<int, string>>>();
 *  var result = from user in users
 *               where user.IsActive
 *               select new { user.Id, user.Name };
 */



// 비교 연산자
// 두 값을 비교 후 true false 반환 ( == , !=, >, <, <=, >==)


// 논리 연산자
// 논리값을 연산하여 true, false 반환 ( &&, ||, ! )
// && -> 앞이 false 면 뒷 연산 X, || -> 앞이 true 면 뒷 연산 X



// 비트 연산자
// 정수형 값에 대해 비트 단위의 연산 ( &, |, ^(XOR), ~(NOT = 보수), <<(비트 왼쪽 시프트), >>(비트 오른쪽 시프트) )
// 2의 보수 > 1의 보수 수 + 1


// Nullable 값 타입
// 값 타입은 기본적으로 Null 불허, Nullable<T> 혹은 T? 를 사용하면 가능
// int? a = null; && Nullable<int> a = null;
// 데이터의 유무를 모를 때 사용 > 주로 hasValue 를 사용하여 검증
// int? b = null;   int a = b ?? 3; >> b의 값이 null인 경우, 3을 반환
// int? a = 2;  int? b = 5;     a ??= b; >> a의 값이 null인 경우, b의 값을 할당



// Switch 문 표현식(C# 8.0 이상)
/* string grade = "B+";
string message = grade switch
{
    "A" => "우수한 성적입니다.",
    string g when g == "B" || g == "B+" => "좋은 성적입니다.",
    "C" => "보통 성적입니다.",
    _ => "예외 상황"
}; */




// 배열 접근
/* string[] fruits = ["사과", "바나나", "레몬"];
Console.WriteLine(fruits[^2]);  --> 기존의 [fruits.Length - 2] 와 같음 */



// 다차원 배열
//int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
/* Console.WriteLine(matrix[1, 1]);
Console.WriteLine(matrix.GetLength(0)); => 1차원의 개수 

2차원 배열의 foreach
foreach(int[] array in arrays) {
    foreach (int item in array) {
        Console.Write(item + " ");
    }
    Console.Writeline();
}
 */



// Array 클래스 메서드
/*
Array.Sort(array) : 배열을 오름차순으로 정렬
Array.Reverse(array) : 배열의 순서를 반대로 뒤집기
Array.indexOf(array, value) : 배열에서 특정 값의 인덱스를 찾음
Array.Resize(ref array, size) : 배열의 크기를 조정함 
 */


// 반복문
/* 
foreach (string fruit in fruits) { Console.WriteLine(fruit); } => 컬렉션의 모든 요소를 순회할 때 사용

do { Console.WriteLine($"카운트: {count}"); count++; } while (count < 3);  => 실행 후 조건문 검사 => 첫 한 번은 무조건 실행
 */



// 최상위문
// 최상위문은 네임스페이스 및 형식 선언 앞에 와야 함
// 시작점인 main 함수를 늘 선언하는 것은 불필요 > 해당 내용을 클래스를 생략하고 앞에 선언함으로서 최상위문을 선언 



// 상수
//const int SUNDAY = 0;
//const int MONDAY = 1;
//const int TUESDAY = 2;
//const int WEDNESDAY = 3;
//const int THURSDAY = 4;
//const int FRIDAY = 5;
//const int SATURDAY = 6;
enum Days       // '상수'들의 집합 (함수 내 정의 불가)
{
    Sunday,             // 0
    Monday = 3,         // 3
    Tuesday,            // 4
    Wednesday,          // 5   
    Thursday,           // 6 ...
    Friday,
    Saturday
}




public class Program
{
    static void Main()
    {
        Days days = Days.Monday;
        Console.WriteLine("main : " + days);
        Console.Write("숫자를 입력하세요 : ");
        String? input = Console.ReadLine();
        Console.WriteLine("입력한 숫자는 " + input + " 입니다.");

        int number = int.Parse(input ?? "0");
        Console.WriteLine("입력한 숫자는 " + number + " 입니다.");
        // 콘솔 프로그램에서 키 입력을 기다릴 때 사용하는 메소드
        Console.ReadKey();
    }
}

