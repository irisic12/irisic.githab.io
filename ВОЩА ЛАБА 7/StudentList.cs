using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace StudentGUI
{
    // Список студентов
    class StudentList
    {
        // Студенты
        public List<Student> Students;

        public StudentList()
        {
            Students = new List<Student>();
        }


        // Открыть TXT файл
        public void OpenTextFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            
            while ((sr.ReadLine()) != null)
            {
                Student person = new Student(sr);
                Students.Add(person);
            }

            sr.Close();
        }


        // Открыть BIN файл
        public void OpenBinaryFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Students = (List<Student>)formatter.Deserialize(fs);
            fs.Close();
        }


        // Открыть XML файл
        public void OpenXMLFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
            Students = (List<Student>)formatter.Deserialize(fs);
            fs.Close();
        }


        // Сохранить TXT файл
        public void SaveTextFile(string fileName)
        {
            StreamWriter sr = new StreamWriter(fileName);
            int StudentNum = Students.Count;
            for (int i = 0; i < StudentNum; i++)
            {
                Students[i].PrintStudent(sr);
            }
            sr.Close();
        }


        // Сохранить BIN файл
        public void SaveBinaryFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Students);
            fs.Close();
        }


        // Сохранить XML файл
        public void SaveXMLFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
            formatter.Serialize(fs, Students);
            fs.Close();
        }


        // Метод для подсчета количества студентов бюджетной и договорной форм обучения без задолжностей на каждом курсе
        public int[,] CountStudentsWithoutDebt()
        {
            // Инициализация двумерного массива для хранения количества студентов без задолженностей
            // (двумерный массив счетчиков)
            // по курсам и формам обучения (0 - бюджет, 1 - договор)
            int[,] countByCourseAndForm = new int[4, 2];

            // Проход по списку студентов
            foreach (Student student in Students)
            {
                // Если студент без задолженностей, увеличиваем соответствующий счетчик
                if (!student.HasDebt())
                {
                    countByCourseAndForm[student.Course - 1, student.EducationForm]++;
                }
            }

            // Возвращаем двумерный массив счетчиков
            return countByCourseAndForm;
        }
    }
}