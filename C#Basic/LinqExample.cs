using linq_example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;


/* LINQ(Language Integrated Query */
/* 
    C#과 같은 .net 언어에서 데이터 소스를 통합적으로 조회할 수 있게 해주는 기능
    데이터베이스, XML, 컬렉션 등 다양한 데이터 소스에 대해 일관된 쿼리 방식을 제공
 
    장점
        컬렉션(Ex. List, Array) 내의 데이터를 필터링, 정렬, 그룹화, 변환 등을 간단한 구문으로 수행 가능

쿼리 구문(Query Syntax)
    SQL과 유사한 선언적 문법

    구조
        var 결과 = from 범위 변수 in 데이터소스(컬렉션)
                    let 블락 변수 생성 및 할당 가능
                    where 조건
                    orderby 정렬기준 descending(역순)
                    group 범위 변수 by 변수.속성 into 그룹 이름
                    select 결과 선택;

메서드 구문
    컬렉션 데이터를 처리하는 기능
    메서드 체인을 통해 데이터를 필터링, 정렬, 그룹화, 투영 등의 작업을 할 수 있음

    투영의 특징
        데이터의 형식 변경 (= Int인 Age를 String 타입으로 바꿔서 컬렉션을 만드는 것)
            컬렉션의 요소를 다른 형식으로 변환
            Ex. 객체에서 특정 필드만 추출하거나 계산된 값을 반환
        구조 변경 (= Score 를 Average로 변경하여 반환하는 타입을 만드는 것)
            복합적인 데이터 구조를 단순화하거나, 필요한 데이터만 선택적으로 포함

    중첩 데이터 평탄화(SelectMany 사용)
        중첩된 컬렉션(var scores = students.Select(student => student.Scores)을 하나의 평면 컬렉션(var scores = students.SelectMany(student => student.Scores)으로 전환

Join
    두 개 이상의 컬렉션을 특정 키(Like Primary Key) 를 기준으로 결합할 때 사용하는 Linq 구문
    두 리스트나 컬렉션에 포함된 데이터를 연결하여 새로운 결과를 생성할 수 있음
    Like SQL Join문
 */


List<LinqExample> students = [
    new LinqExample { Id = 1, Age = 20, Gender = "F", Scores = [5, 3, 9], Name = "Alice" },
    new LinqExample { Id = 2, Age = 22, Gender = "M", Scores = [8, 3, 2], Name = "Bob" },
    new LinqExample { Id = 3, Age = 23, Gender = "M", Scores = [4, 4, 1], Name = "Charlie" },
    new LinqExample { Id = 4, Age = 21, Gender = "M", Scores = [5, 6, 2], Name = "David" },
    new LinqExample { Id = 5, Age = 20, Gender = "F", Scores = [9, 8, 7], Name = "Eve" },

];

List<Score> studentScores = [
  new Score { StudentId = 1, ScoreValue = 5, Subject = "Math" },
  new Score { StudentId = 1, ScoreValue = 3, Subject = "Science" },
  new Score { StudentId = 1, ScoreValue = 9, Subject = "History" },
  new Score { StudentId = 2, ScoreValue = 8, Subject = "Math" },
  new Score { StudentId = 2, ScoreValue = 3, Subject = "Science" },
  new Score { StudentId = 2, ScoreValue = 2, Subject = "History" },
  new Score { StudentId = 3, ScoreValue = 4, Subject = "Math" },
  new Score { StudentId = 3, ScoreValue = 4, Subject = "Science" },
  new Score { StudentId = 3, ScoreValue = 1, Subject = "History" },
  new Score { StudentId = 4, ScoreValue = 5, Subject = "Math" },
  new Score { StudentId = 4, ScoreValue = 6, Subject = "Science" },
  new Score { StudentId = 4, ScoreValue = 2, Subject = "History" },
  new Score { StudentId = 5, ScoreValue = 9, Subject = "Math" },
  new Score { StudentId = 5, ScoreValue = 8, Subject = "Science" },
  new Score { StudentId = 5, ScoreValue = 7, Subject = "History" },
];
/* 쿼리 구문 */
/*
var genderGroups = from student in students
                  let gender = student.Gender
                  where gender == "M" || gender == "F"
                  let average = student.Scores.Average()
                  where student.Age <= 22 || average > 5
                  orderby student.Id descending
                  group student by student.Gender into stu_gender
                  select (Gender: stu_gender.Key, Group: stu_gender);
                  //select new { student.Name, student.Age };
                  //select student;
                 

foreach (var genderGroup in genderGroups)
{
    // genderGroups.Gender
    Console.WriteLine($"Gender: {genderGroup.Gender}");

    // genderGroup.Group
    foreach (var student in genderGroup.Group)
    {
        Console.WriteLine($"{student.Name}, {student.Age}, Average: {student.Scores.Average()}");
    }
}

// Join
var join_results = from student in students
             join score in studentScores        // StudentScores애 Join
             on student.Id equals score.StudentId       // student.id를 키 값으로, score.StudentId 를 키 값으로 매핑
             select (student, score);

Console.WriteLine("-----------------------------------------");
foreach (var (student, score) in join_results)
{
    Console.WriteLine($"Student: {student.Name}, Subject: {score.Subject}, Score: {score.ScoreValue}");
}
*/

/* 메서드 구문 */
//var ages = students.Select(student => new { MyName = student.Age, MyAge = student.Age });           // new {} : 익명 타입 But, 임시로 만들어냈기 때문에 컴파일러가 타입을 명확하게 잡아내지 못함 >> Value Tuple 형식으로 사용하면 해당 문제 해결 가능 ((name: value) 형식)
var myStudents = students.Select(student => (MyName: student.Name, MyAge: student.Age));

foreach (var student in myStudents)
{
    Console.WriteLine(student.MyName);
    Console.WriteLine(student.MyAge);
    Console.WriteLine("----------------------");
}

// SelectMany
var scores = students.SelectMany(student => student.Scores);
foreach (var score in scores)
{
    Console.WriteLine(score);
}

// Where
var where_result = students.Where(student => student.Name.EndsWith("e"));
foreach (var student in where_result)
{
    Console.WriteLine(student.Name);
}

// OrderBy
var order_result = students
    .OrderBy(student => student.Age)
    .ThenByDescending(student => student.Id);
foreach (var student in order_result)
{
    Console.WriteLine(student);
}

// Group By(그룹화)
var group_result = students
    .GroupBy(student => student.Gender)
    .OrderByDescending(group => group.Key);

foreach (var genderGroup in group_result)
{
    Console.WriteLine(genderGroup.Key);
    foreach (var student in genderGroup)
    {
        Console.WriteLine(student);
    }
}

// Join
var join_results = students.Join(           //Join 할 첫 번째 인수(students)
    studentScores,          // Join 할 두 번째 인수(studentScores)
    student => student.Id,      // 첫 인수의 Key
    score => score.StudentId,       // 두 번째 인수의 Key (첫 키와 매핑)
    (student, score) => (student, score)            // select 부분 (value tuple 로 반환
    );

Console.WriteLine("-----------------------------------------");
foreach (var (student, score) in join_results)
{
    Console.WriteLine($"Student: {student.Name}, Subject: {score.Subject}, Score: {score.ScoreValue}");
}

Console.ReadKey();

namespace linq_example
{
//Join 예제를 위한 클래스
    class Score
    {
        public int StudentId { get; set; }
        public int ScoreValue { get; set; }
        public string Subject { get; set; } = "";
    }

    class LinqExample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<int> Scores { get; set; }

        public override string ToString()
        {
            return $"id : {Id}, 이름 : {Name}, 나이 : {Age}, 점수 : {Scores.Average()}, 성별: {Gender}";
        }
    }


}
