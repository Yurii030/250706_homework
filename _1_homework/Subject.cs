using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_homework
{
    // 학생의 과목 성적 관리 시스템 만들기
    // 과목 정보를 표현하는 클래스 _ 학생 정보 담는 클래스(x)_ 오직 과목정보만
    internal class Subject     
    {
        //private 필드 포함
        private string name;
        private int scorePoint;

        // getter와 setter메서드 구현
        public string getName() // void(x) 값을 반환해야함
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getScorePoint()
        {
            return scorePoint;
        }
        public void setScorePoint(int scorePoint)
        {
            this.scorePoint = scorePoint;
        }
    }
}
