using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace _1_homework
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Student studentLee = new Student(1001, "Lee");
            studentLee.addSubject("국어", 100);
            studentLee.addSubject("수학", 50);

            Student studentKim = new Student(1002, "Kim");
            studentKim.addSubject("국어", 70);
            studentKim.addSubject("수학", 85);
            studentKim.addSubject("영어", 100);

            studentLee.showStudentInfo();
            Console.WriteLine("========================");
            studentKim.showStudentInfo();
        }
    }
}
        // 과목 추가 메서드는 student클래스로 가야함
/*        static void addSubject(string name, int score)
        {
            string Subject;


        }*/
// 출력 구문도 stuent클래스로 가야함_ 이유 : "학생 한 명"에 대한 정보와 행동을 담는 클래스이기 때문에
// 학생 이름,ID, 수강 과목들(List<Subject>를 알고 있고 이 정보를 출력할 책임도 가지고 있어야함.
/*        static void showStudentInfo()
        {
            Console.WriteLine($"학생{name}의 {subjectname}은 {score}입니다");
        }*/

