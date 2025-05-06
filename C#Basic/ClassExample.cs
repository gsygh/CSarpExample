using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/* 클래스 */
/*
접근 제어자
    public, private, protected(동일 클래스 및 파생 클래스에서 접근 가능), internal : 같은 어셈블리 내에서만 접근 가능), protected internal(같은 어셈블리 혹은 파생 클래스에서 접근 가능)

가변 매개변수
    Params : 배열로 선언을 하게 되면 매개변수를 여러 개 선언하더라도 배열로 생성(가변)

매개변수의 특징
    값 타입 : 값 타입은 데이터를 직접 저장, 메모리의 스택 영역에 할당. 값 타입의 변수를 다른 변수에 할당하면, 값 자체의 복사가 이루어지므로 서로 다른 메모리에 존재 > 독립적인 데이터
    참조 타입 : 데이터가 메모리의 힙 영역에 저장, 변수는 그 데이터를 참조하는 포인터를 저장. 참조 타입을 다른 변수에 할당하면, 메모리 주소가 복사됨 > 동일한 데이터를 참조 (class, array, string(불변 참조 타입, 생성 후 값 변경 불가, 참조를 위해선 ref 사용할 것), interface, delegate, object, ...)
ref 키워드
    외부에서 초기화 필수
out 키워드 
    내부에서 값 선언이 필수적이므로, 외부에서 초기화는 필요없음

속성 선언을 위한 snippet  = propfull

const 와 readonly
C#에에서 const, readonly 는 모두 상수 선언을 위해 사용되지만 목적과 제약이 다름
    const
        컴파일 시점에 설정, 선언과 동시에 값 지정, 기본형이나 불변 객체에만 사용할 수 있음
    readonly (읽기 전용 필드)
        런타임 시점에 값이 설정, 생성자에서 값 할당 가능
        선언할 때 값을 초기화하거나 생성자에서 값 할당 > 객체 생성 시 인스턴스에 따라 다른 값으로 초기화 가능
        객체를 포함한 모든 타입에 사용 가능

정적 메소드 (static)
    객체 자체에 속하며, 객체의 인스턴스 없이 호출 가능, 정적 메소드는 정적 멤버에만 접근 가능 > Class.method();

정적 클래스
    인스턴스 생성 불가, 모든 멤버가 정적으로 선언 > 유틸리티 메소드를 제공할 때 사용
    프로그램 로드 시 메모리를 차지하고 사라지지 않음 > 메모리 관리에 주의

상속
    메소드 오버라이딩 (부모에 virtual, 자식에 override)
    Upcasting 
        Animal dog = new Dog(); ( 자식은 부모의 기능을 모두 보유하므로 선언 가능)
    new
        기존 부모의 요소를 사용하지 않고 자식의 요소를 사용(upcasting 된 부모의 해당 요소는 그대로 사용)
    protected
        해당 클래스와 자식 클래스에서만 접근 가능
        외부에서 접근을 원할 시 해당 클래스에 get을 생성 후 밖에서 호출
    추상 클래스 (abstract)
        인스턴스화 할 수 없음, 추상 메소드는 포함 가능, 추상 메소드는 자식 클래스에서 반드시 구현되어야 함
    상속 체인
        상속은 한 번에 여러 개 불가, 체인 형식으로 가능
    sealed
        다시 재정의되는 것을 원하지 않을 때 sealed 키워드 사용
 */


namespace class_example
{

    class ClassExample
    {
        string brand;
        string model;
        string color;

        public string Brand
        {
            get {  return brand; }
            private set { brand = value; }
        }
        
        // 생성자
        public ClassExample(string brand = "기아", string model = "쏘렌토", string color = "검정")
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
        }
        
        public void SetInformation(string brand, string model, string color = "파랑")
        {
            Brand = brand;
            this.model = model;
            this.color = color;
        }
        
        public string GetBrand()
        {
            return brand;
        }



        // 선택적 매개변수를 활용한 부분출력
        //public void ShowInformation(bool displayBrand = true, bool displayModel = true, bool displayColor = true)
        //{
        //    if (displayBrand) Console.WriteLine($"브랜드는 {brand}입니다.");
        //    if (displayModel) Console.WriteLine($"모델은 {model}입니다.");
        //    if (displayColor) Console.WriteLine($"색상은 {color}입니다.");
        //}


        // 가변 매개변수를 활용한 부분출력
        public void ShowInformation(params string[] options)
        {
            foreach (string option in options)
            {
                if (option == "brand") Console.WriteLine($"브랜드는 {brand}입니다.");
                if (option == "model") Console.WriteLine($"모델은 {model}입니다.");
                if (option == "color") Console.WriteLine($"색상은 {color}입니다.");
            }
        }

        // 소멸자
        ~ClassExample() { Console.WriteLine("소멸자 동작"); }
    }

    // static 예제
    static class MyClass
    {
        public static void Print(this string text) // static을 활용한 확장 함수
        {
            Console.WriteLine($"static 변수의 이름은 {text} 입니다.");
        }
    }

    // 상속(inheritance) 예제
    abstract class Animal
    {
        protected int _hp = 100;
        public int HP => _hp;
        // 추상 클래스 예제
        public abstract void Move();
        public virtual void Eat() 
        {
            Console.WriteLine("먹습니다");
        }
    }

    class Cat : Animal
    {
        public sealed override void Move() // sealed 키워드
        {
            Console.WriteLine("고양이가 움직입니다.");
        }
        public override void Eat()
        {
            _hp += 10;
            Console.WriteLine("고양이가 먹습니다");
        }
    }

    class Tiger : Cat
    {
        public override void Eat()
        {
            Console.WriteLine("호랑이가 먹습니다");
        }
    }

    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("개가 움직입니다.");
        }
        public override void Eat()
        {
            //base.Eat();
            _hp += 15;
            Console.WriteLine("개가 먹습니다.");
        }
    }
}
