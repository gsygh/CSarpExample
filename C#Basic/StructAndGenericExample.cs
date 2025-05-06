using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 구조체 */
/*
특징              구조체(Struct)                         클래스(Class)
타입              값 타입(Value Type)                    참조 타입(Reference Type)
메모리 할당       스택(Stack)                            힙(Heap)
상속              불가능                                 가능
용도              작은 데이터 구조                       복잡한 데이터 구조 및 기능

 */

/* Generic */
/* 
클래스, 메소드, 인터페이스, Delegate 등을 정의할 때 데이터 타입을 일반화하여 재사용성을 높이고 타입 안정성을 제공하는 기능
Ex) 두 개의 데이터 값을 바꾸는 Swap 함수 구현 > Generic 없이는 각 타입마다의 함수를 선언해야 하지만 Generic을 사용하게 되면 모든 타입에 대응할 수 있는 함수로써 동작

주요 이점
    1. 타입 안정성
    2. 코드 재사용성
    3. 성능 향상

Generic 제약 조건
void func<T>() where T : class (... struct, new, interface ...  등등 가능)

제약 조건 new()
제네릭 타입이 인수가 없는 생성자를 만들 수 있다면 추가할 수 있음

제약조건 Class 명
class 명을 이용해 제약조건을 걸 경우, 해당 클래스의 메소드와 같은 구성을 사용할 수 있음
*/

namespace struct_generic_example
{
    /* Struct 예제 */
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void ChangePoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
    

    /* Generic 예제 */
    // Generic을 활용한 Class Swap 예제
    abstract class Animal
    {
        abstract public string Name { get; }
        abstract public void MakeSount();
        public override string ToString()
        {
            return $"제 이름은 {Name} 입니다.";
        }
    }
    class Dog : Animal
    {
        public override string Name => "멍멍이";

        public override void MakeSount()
        {
            Console.WriteLine("멍멍");
        }
    }
    class Cat : Animal
    {
        public override string Name => "냥냥이";

        public override void MakeSount()
        {
            Console.WriteLine("냥냥");
        }
    }

    // class 내부 Generic 사용 예제
    class GenericBox<T>
    {
        private T _item;

        public void Add(T item)
        {
            _item = item;
        }
        public T GetItem()
        {
            return _item;
        }
    }
}
