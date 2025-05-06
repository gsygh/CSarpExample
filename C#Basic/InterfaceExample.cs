using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 인터페이스 */
/*
java 에서 사용하던 interface(추상 클래스) 개념 그대로.
    method, property, event 등을 정의할 수 있으며, field나 세부 구현은 불가.
    interface naming 시 대문자 I 추가 (암묵적인 룰)

다중 구현
    2가지의 인터페이스를 부모로 둘 수 있으며, A 부모클래스로 선언 시, B 부모 클래스의 메소드는 사용 불가한 것을 유의할 것

명시적 구현
    인터페이스 멤버를 클래스의 다른 멤버와 구분하기 위해 명시적 구현 가능, 이 경우, 인터페이스를 통해서만 접근이 가능

디폴트 구현(C# 8.0 이상)
    인터페이스 내에 메소드 구현 가능
    
 */

namespace interface_example
{
    interface IInterfaceExample
    {
        void MakeSound();
        string Name { get; set; }
        void PrintInformation()
        {
            Console.WriteLine($"안녕하세요. 저는 {Name}입니다.");
        }
    }

    interface IFlyable
    {
        void Fly();
    }

    class Dog : IInterfaceExample
    {
        public string Name { get; set; } = "멍멍이";

        public void MakeSound()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Bird : IInterfaceExample, IFlyable
    {
        public string Name { get; set; } = "짹짹이";

        public void Fly()
        {
            Console.WriteLine("날아요");
        }

        // 명시적 구현 예제
        void IInterfaceExample.MakeSound()
        {
            Console.WriteLine("짹짹");
        }
    }
}
