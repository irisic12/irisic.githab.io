using System;
using System.IO;

// Задача 23
// На каждом курсе найти количество студентов бюджетной и договорной форм обучения без задолжностей.

namespace StudentGUI
{   
    // Класс экзамен
    [Serializable]
    public class Exam
    {
        public string Subject;
        public int Mark;
    }

    // Класс студент
    [Serializable] 
    public class Student
    {
        public string FIO;  // ФИО
        public int Course;    // Курс
        public int Group;   // Группа
        public static int SubjectNum = 5;   // Количество экзаменов в сессию
        public static int SessionNum = 8;   // Количество сессий всего
        public int CountSubSession = SubjectNum * SessionNum;    // Общее максимально возможное количество экзаменов за все сессии
        public Exam[] AcademPerformance;    // Массив экзаменов
        public int EducationForm;   // Форма обучения


        // Конструктор 
        public Student()
        {
            FIO = "";
            Course = 1;
            Group = 1;
            EducationForm = 0;
            AcademPerformance = new Exam[CountSubSession];
            for (int i = 0; i < CountSubSession; i++)
            {
                AcademPerformance[i] = new Exam();
            }
        }

        // Констуктор из потока
        public Student(StreamReader sr)
        {
            FIO = sr.ReadLine();
            Course = Int32.Parse(sr.ReadLine());
            Group = Int32.Parse(sr.ReadLine());

            int examNum = SubjectNum * Course * 2;
            AcademPerformance = new Exam[examNum];

            for (int i = 0; i < examNum; i++)
            {
                AcademPerformance[i] = new Exam();
                if (i % (SubjectNum) == 0)
                {
                    sr.ReadLine();
                }
                string[] Grades = sr.ReadLine().Split(new char[] { '.' });
                AcademPerformance[i].Subject = Grades[0];
                AcademPerformance[i].Mark = Int32.Parse(Grades[1]);
            }
            if (sr.ReadLine() == "Бюджет")
            {
                EducationForm = 0;
            }
            else
            {
                EducationForm = 1;
            }
        }

        // Печать записи
        public void PrintStudent(StreamWriter sr)
        {
            sr.WriteLine();
            sr.WriteLine(FIO);
            sr.WriteLine(Course);
            sr.WriteLine(Group);

            for (int i = 0; i < SubjectNum * 2 * Course; i++)
            {
                if (i % (SubjectNum) == 0)
                {
                    sr.WriteLine((i / (SubjectNum - 1) + 1) + " сессия");
                }

                sr.Write(AcademPerformance[i].Subject + '.' + ' ');
                sr.WriteLine(AcademPerformance[i].Mark);
            }

            if (EducationForm == 0)
                sr.WriteLine("Бюджет");
            else

                sr.WriteLine("Договор");

        }

        // Вывод в файл
        public string MakeOut()
        {
            string s;
            s = FIO + ' ' + Course.ToString() + " курс " + Group.ToString() + " группа";

            if (EducationForm == 0)
            {
                s = s + " (бюджет)";
            }
            else
            {
                s = s + " (договор)";
            }
            return s;
        }

        // Метод для проверки есть ли задолжности у студента
        public bool HasDebt()
        {
            // Проходим по всем экзаменам студента от начала до текущих экзаменов
            for (int i = 0; i < SubjectNum * 2 * Course; i++)
            {
                if (AcademPerformance[i].Mark == 2)
                {
                    return true; // Есть задолженности
                }
            }

            return false; // Нет задолженностей
        }
    }
}