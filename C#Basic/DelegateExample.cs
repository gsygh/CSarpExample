using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 대리자 */
/*
    특정 메서드의 참조를 캡슐화하는 객체(메서드를 변수처럼)
    매개변수와 반환 형식을 맞춰줘야 함
    멀티태스킹 가능(+=, -= 로 사용)
    이벤트 발생 시 주로 사용

    필요 시 마다 delegate를 정의하는 것은 불필요한 작업 > 묶음으로서 정의할 수 있도록
    Func<, , .., 반환형식>        반환값이 있는 메서드 캡슐화
    Action< , , >      "반환값이 없는" 메서드 캡슐화
    Predicate   조건에 따라 bool 값을 반환하는 메서드 캡슐화
    Comparison  두 값을 비교하고 정렬 순서를 나타내는 int 반환
 */

delegate void ValueChangeHandler(int result, string msg);

namespace delegate_example
{
    class DelegateExample
    {
        public event ValueChangeHandler? OnValueChanged;
        private int _value;

        public void Plus(int value)
        {
            _value += value;
            OnValueChanged?.Invoke(_value, $"{value}를 더했습니다.");             // ?.invoke() = 앞의 변수가 null이라면 뒷 구문을 무시하고 null을 반환함
        }
        public void Minus(int value)
        {
            _value -= value;
            OnValueChanged?.Invoke(_value, $"{value}를 뺐습니다.");
        }
    }
}
