using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace _1_homework
{
    internal class Student
    {
        // 필드 생성
        // 자동구현 프로퍼티 -> 캡슐화 하기 위한 대표적 방식
        // 캡슐화 : 내부데이터를 직접 외부에서 접근하지 못하게 하면서,
        // 값을 안전하게 설정(set), 하고 가져올(get) 수 있게 도와준다.
        public int studentID { get; set; }// 학생 ID
        public string studentName { get; set; } // 학생 이름
        //public Dictionary <int,string> subjectList; 
        //수강 과목 목록
        public List<Subject> SubjectList { get; set; }
        // 이유 : Subject객체를 관리해야할 리스트이다.

        // 생성자로 받아서 초기화 해주기
        public Student(int studentID, string studentName)
        {
            //Student.studentID = studentID;
            this.studentID = studentID;
            //Student.studentName = studentName;
            this.studentName = studentName;
            SubjectList = new List<Subject>(); // 수강 과목 목록 초기화
        }

        // 과목 추가 메서드
        // name보다는 헷갈리지 않게 과목이름인 subjectName으로 주는 게 더 좋다
        public void addSubject(string subjectName, int score)
        {
            Subject subject = new Subject();
            subject.setName(subjectName);
            subject.setScorePoint(score);

            SubjectList.Add(subject);  

        }
        
        // 출력메서드
        public void showStudentInfo()
        {
            int totalScore = 0;
            foreach (Subject subject in SubjectList)
            {
                totalScore += subject.getScorePoint(); // 총합구하기
                Console.WriteLine($"학생{studentName}의 {subject.getName()}과목 성적은 {subject.getScorePoint()}입니다.");
            }
            Console.WriteLine($"학생{studentName}의 총점은 {totalScore}입니다");
        }
    }
}
