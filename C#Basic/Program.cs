
using class_example;
using interface_example;
using System.Runtime.Remoting;
using type_casting_example;
using struct_generic_example;
using delegate_example;
using collection_example;


delegate int Dele_Operation(int a, int b);     // delegate 선언

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



// 문자열
/* 
 C#에서의 문자열은 불변 -> string sen = sen + "1"; 하게 되면 문자열 수정이 아닌 새로운 문자열 생성
 C#에서는 문자열 보간을 사용하여 문자열 내 변수 값 포함 가능 $기호 사용 -> string fullName = $"{firstName} {lastName}"; -> +를 사용한 재선언 보다 보간법이 더 가시성이 좋음 
 문자열 형식화
 ...name, ...age
 string foarmatted = string.Format("Name: {0}, Age: {1}", name, age);
내부 함수
 Substring(start index, number)
 Contain("contain string") (return boolean) (대, 소문자 구분)
 Equal("compare string", StringComparison.OrdinalIgnoreCase) (StringComparison.OrdinalIgnoreCase 는 대소문자 비교 무시)
 sen.toUpper, sen.toLower
 trim, trimStart, trimEnd(인자값이 있으면 인자값도 제거)
 split(',') (특정 구분자로 나누어 "배열"로 반환)
 join(',') ("배열 문자열"을 특정 구분자를 결합하여 하나의 문자열로 반환)
 \n, \t, \"(큰 따옴표), \\(백슬래시)
 
 여러 문자열 조작이 필요할 경우, StringBuilder를 사용
    StringBuilder sb = new StringBuilder();
    sb.Append("...");
    sb.Append("...");
    sb.Append("...");
    string resuolt = sb.ToString();
 */



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




public partial class Program
{
    static void Main()
    {
        /*
        Days days = Days.Monday;
        Console.WriteLine("main : " + days);
        Console.Write("숫자를 입력하세요 : ");
        String? input = Console.ReadLine();
        Console.WriteLine("입력한 숫자는 " + input + " 입니다.");

        int number = int.Parse(input ?? "0");
        Console.WriteLine("입력한 숫자는 " + number + " 입니다.");

        ClassExample example = new ClassExample();

        Console.WriteLine(example.GetBrand()); */

        /* Class 예제 */
        /*
        // static 예제
        string name = "john";

        name.Print();

        // 상속 예제
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.Eat();
        dog.Eat();
        dog.Eat();

        cat.Move();
        Console.WriteLine($"Dog Hp : {dog.HP}");
        */

        /* 인터페이스 예제 */
        /*
        IInterfaceExample dog = new interface_example.Dog();
        Bird bird = new interface_example.Bird();

        dog.MakeSound();
        bird.Fly();
        //bird.MakeSound(); 명시적 접근 예제로 인터페이스를 통한 선언을 해야 접근 가능

        // 디폴트 구현 (C# 8.0 이상 예제)
        dog.PrintInformation();
        */


        /* Type Casting 예제 */
        /*
        // 더 큰 타입에서 작은 타입으로 바꿀 때는 명시적 변환이 필수, 반대의 경우는 암시적 변환 가능
        int intNum = 100;
        double doubleNum = intNum; // 암시적 변환(int > double : 데이터 손실 X)
        Console.WriteLine($"int: {intNum}, double: {doubleNum}");

        double anotherDoubleNum = 123.456;
        int anotherIntNum = (int)anotherDoubleNum; // 명시적 변환 ( double > int : 데이터 손실 O)
        Console.WriteLine($"double: {anotherDoubleNum}, int: {anotherIntNum}");

        // Object Type
        // 대표적인 오류 예제
        object stringObject = "C#";
        //int number = (int)stringObject; // 오류 발견 X, 실행 시 알게 됨

        // as 예제
        object obj = "C#";
        int? intValue = obj as int?;            // 오류 발생
        string? stringValue = obj as string;

        if (stringValue != null)
        {
            Console.WriteLine($"{stringValue}");
        }

        // Convert Class 예제(string > int)
        string strNumber = "789";
        int convertedInt = Convert.ToInt32(strNumber);
        Console.WriteLine($"String: {strNumber}, Int: {convertedInt}");

        // Convert Class 에제(byte > string)
        byte[] bytes = { 1, 2, 3, 4, };
        string base64String =Convert.ToBase64String(bytes);
        Console.WriteLine(base64String);

        // is 연산자 예제
        object isObj = "C# Programming";

        if (isObj is string isStr)
        {
            Console.WriteLine(isStr);
        }
        */

        /* Struct & Generic 예제 */
        // Struct 예제
        /*
        Point point = new Point{ X = 10, Y = 20};

        point.ChangePoint(100, 200);        // 매개변수로 구조체를 넘겨 변경할 경우는 값 타입이기 때문에 복사본만 함수 내에서 변경되고 기존 주소값인 원본에는 영향을 끼치지 않음

        Console.WriteLine(point.ToString());

        // Generic 예제
        int genNum = 10;
        int genNum2 = 20;

        void Swap<T>(ref T a,  ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        Swap<int>(ref genNum, ref genNum2);
        Console.WriteLine($"a: {genNum}, b: {genNum2}");

        // Generic 제약 조건 Class 예제
        struct_generic_example.Animal genDog = new struct_generic_example.Dog();
        struct_generic_example.Animal genCat = new struct_generic_example.Cat();

        void SwapForClass<T>(ref T a, ref T b)
            where T : class
        {
            T temp = a;
            a = b;
            b = temp;
        }

        SwapForClass(ref genDog, ref genCat);
        Console.WriteLine($"genDog : {genDog}, genCat: {genCat}");

        // Generic 제약 조건 new() 예제
        void CreateInstance<T, T2>(out T a, out T2 b)
            where T: class, new()
            where T2: class, new()
        {
            a = new T();
            b = new T2();
        }
        CreateInstance(out struct_generic_example.Dog newDog, out struct_generic_example.Cat newCat);

        Console.WriteLine($"newDog : {newDog}, newCat: {newCat}");
        
        // Generic 제약 조건 new() 를 이용한 객체 생성 예제
        T CreateInstance2<T> ()
            where T : class, new()
        {
            return new T();
        }
        var newAnimal = CreateInstance2<struct_generic_example.Cat>();
        Console.WriteLine($"{newAnimal}");

        // Generic 제약 조건 "Class 명" 을 이용한 객체 생성 예제
        T CreateInstance3<T>()
            where T : struct_generic_example.Animal, new()
        {
            T instance = new T();
            instance.MakeSount();
            return instance;
        }
        var ClassNameAnimal = CreateInstance3<struct_generic_example.Cat>();
        Console.WriteLine($"{ClassNameAnimal}");

        // class 내부 Generic 사용 예제
        GenericBox<int> genericBox = new GenericBox<int>();
        genericBox.Add(3);
        var item = genericBox.GetItem();
        Console.WriteLine($"genericBox: {item}");
        */

        /* Delegate 에제 */
        /* 
        int Plus(int a, int b)
        {
            return a + b;
        }

        int Minus(int a, int b)
        {
            return a - b;
        }

        Dele_Operation? dele_operation = Plus;
        dele_operation += Minus;
        dele_operation -= Minus;

        int result = dele_operation(10, 5);
        Console.WriteLine(result);

        // delegate 를 이용한 Calculate 예제
        DelegateExample calculate = new DelegateExample();
        calculate.OnValueChanged += Calculate_OnValueChanged;

        calculate.Plus(5);
        calculate.OnValueChanged -= Calculate_OnValueChanged;       // onvalueChanged 에서 이벤트 Delegate를 제외하여 Minus는 동작하지 않음
        calculate.Minus(3);

        // 매개변수에 Delegate를 사용하는 예제(함수를 매개변수로 활용)
        void ApplyOperation(int a, int b, Func<int, int, int> operation)
        {
            int result = operation(a, b);
            Console.WriteLine(result);
        }

        ApplyOperation(5, 10, Plus);
        ApplyOperation(10, 5, Minus);
        */

        /* 열거자(Enumerator) */

        // 콘솔 프로그램에서 키 입력을 기다릴 때 사용하는 메소드
        Console.ReadKey();
    }

    
    // delegate 를 이용한 Calculate 예제에 필요한 함수
    private static void Calculate_OnValueChanged(int result, string msg)
    {
        Console.WriteLine($"{msg} - 현재 값 : {result}");
    }
}
