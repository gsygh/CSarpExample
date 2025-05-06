using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Object Type
    모든 타입을 저장 가능
    선언 시 heap 메모리에 저장(Boxing) 후 불러올 때는 타입을 명시(UnBoxing)
    다중 사용 시 성능 문제 발생할 수 있으므로 정하지 못한 타입을 사용할 때만 사용

as
    안전하게 타입 변환을 하기 위해 사용

Convert Class
    정적 클래스, 변환 실패 시 오류 발생
    주로 string > int, byte > string 으로 변환 시 사용
    Convert.ToInt32(strNumber);

is
    타입이 변환 가능하다면 그 결과를 boolean 값으로 반환
    obj is string str > obj가 string 으로 변환이 가능하다면 str에 변환한 값을 포함시켜 반환
 */

namespace type_casting_example
{
    class TypeCastingExample
    {
        // 타입캐스팅 예제는 main(Program.cs 내 main 문에 기재)
    }
}
