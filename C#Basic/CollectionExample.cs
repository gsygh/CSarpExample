using collection_example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 열거자 */
/* 
    컬렉션을 순회(iterate)할 수 있게 해주는 객체
    주로 IEnumerable과 IEnumerator 인터페이스를 통해 구현됨

    IEnumerable 인터페이스는 반드시 GetEnumerator함수를 구현하도록 되어 있음
 */

/* 컬렉션 */
/*
List<T>: 동적 배열
    List<T>는 동일한 타입의 객체를 동적으로 관리할 수 있는 Generic 컬렉션
    네임스페이스 : System.Collection.Generic
    특징
        타입 안정성을 제공하여 컴파일 시 타입 검사를 수행
        내부적으로 배열을 사용하며, 필요에 따라 크기를 자동으로 조정

Dictionary (키, 값)

Queue
    선입 선출, FIrst In First Out 방식으로 데이터를 관리하는 제네릭 컬렉션 

Stack
    후입 선출, Last In First Out 방식으로 데이터를 관리하는 제네릭 컬렉션

 */

/* 열거자 예제
CollectionExample collection_example = new CollectionExample();

foreach (int value in collection_example)
{
    Console.WriteLine(value);
}
*/

// 같은 선언 방식
//List<string> strList = new List<string>();
//strList.Add("a");
//strList.Add("b");
//strList.Add("c");
/* 
List<string> strList = ["a", "b", "c"];
List<string> anotherList = ["가", "나", "다"];

// 삽입
strList.AddRange(anotherList);      // 타입이 맞는 다른 리스트를 뒤에 합침
strList.Insert(1, "z");             // 1번 자리에 z 추가
strList.InsertRange(1, anotherList);    // 1번 자리에 anotherList 추가

Console.WriteLine($"{strList.Contains("z", StringComparer.OrdinalIgnoreCase)}");      // 특정 값이 있는지 확인 Contains 는 대소문자 구분, StringComparer.OrdinalIgnoreCase 추가 시 대소문자 구분 X
Console.WriteLine($"{strList.IndexOf("z")}");                                           // 특정 값의 인덱스 반환
string? selectedAlpha = strList.Find(str =>                                             // 조건에 맞는 첫 번째 요소 반환, FineAll : 조건에 맞는 모든 요소를 반환
{
    return str.StartsWith("z");
});
Console.WriteLine(selectedAlpha);

//제거
strList.Remove("b");
strList.RemoveAt(1);
strList.RemoveAll((str) => { return str == "a" || str == "c"; });   // True인 조건에 삭제
strList.Clear();


// 정렬 예제
// Reverse, Sort
var intList = new List<int> { 3, 100, 5, -1, 20 };

intList.Sort((a, b) => a.CompareTo(b));

foreach (int i in intList)
{
    Console.WriteLine(i);
}


// 기타 메서드
// count : 요소의 개수
// ToArray : List<T>를 배열로 반환
Console.WriteLine(intList.Count);
int[] intArray = intList.ToArray();



foreach (string str in strList)
{
    Console.WriteLine(str);
}

*/
/* Dictionary 예제 */
/*
var fruitDict = new Dictionary<string, string>
{
    {"apple", "사과" },
    {"banana", "바나나" },
    {"cherry", "체리" }
};

fruitDict["apple"] = "애플";

fruitDict.Remove("banana");
//fruitDict.Clear();

bool hasKey = fruitDict.TryGetValue("grape", out string? fruit);
if (hasKey)
{
    Console.WriteLine(fruit);
}
else
{
    Console.WriteLine("과일이 Key로 등록되어 있지 않습니다.");
}
*/

/* Queue 예제 */
/*
var fruitQueue = new Queue<string>();

// 삽입
fruitQueue.Enqueue("사과");           
fruitQueue.Enqueue("바나나");
fruitQueue.Enqueue("체리");

// 제거
// Dequeue(제거), Peek(제거는 하지 않고 현재 queue위치의 데이터를 보여줌)
// 안전하게 제거하기 위해서는 마찬가지로 TryDequeue 를 사용
Console.WriteLine(fruitQueue.Dequeue());
Console.WriteLine(fruitQueue.Peek());
Console.WriteLine(fruitQueue.TryDequeue(out string? newFruit));         // boolean 반환하며 newFruit에 삭제된 요소 저장
Console.WriteLine(newFruit);
*/

/* Stack 예제 */
/*
var fruitStack = new Stack<string>();

fruitStack.Push("사과");
fruitStack.Push("바나나");
fruitStack.Push("체리");

Console.WriteLine(fruitStack.Pop());
Console.WriteLine(fruitStack.Pop());
Console.WriteLine(fruitStack.Peek());
fruitStack.TryPop(out string? newFruitStack);
Console.WriteLine(newFruitStack);

Console.ReadKey();
*/
namespace collection_example
{
    class CollectionExample
    {
        /*  열거자 예제
        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;
            yield return 10;
            yield return 20;
            yield return 40;
            yield return 60;
            yield return -50;
        }
        */


    }
}
