using System;
using System.Data;
using System.Windows.Forms;

namespace StudentGUI
{
    public partial class StudentForm : Form
    {
        Student student = new Student();    // Создание класса Студент
        bool editing;   // False - открытие формы для добавления записи, True - для редактирования

        private MainForm mainForm;   //переменная, которая будет использоваться для связи с главной формой приложения.

        // Инициализация WinForm для работы со студентом
        public StudentForm (MainForm _mainform, Student dop_stud, bool edit = false)
        {
            InitializeComponent();
            mainForm = _mainform;  //Параметр _mainform  используется для передачи ссылки на главную форму приложения
            student = dop_stud;  // dop_stud используется для передачи информации о студенте в конструктор.
            editing = edit;
        }

        // Загрузка формы Студент
        private void StudentForm_Load_1(object sender, EventArgs e)
        {
            while (AcademPerformanceGrid.Rows.Count > 1) 
                for (int i = 1; i <= AcademPerformanceGrid.Rows.Count; i++)
                    AcademPerformanceGrid.Rows.Remove(AcademPerformanceGrid.Rows[i]); //удаление всех строк, кроме первой строки (строки с индексом 0)
            if (editing)
            {
                OpenForEditing(); //метод открывает форму для редактирования существующей записи о студенте.
            }
        }

        // Создание Grid
        void CreateGrid(int LinesNum)
        {
            DataTable matrix = new DataTable("matrix");
            DataColumn[] cols = new DataColumn[2];

            for (int i = 0; i <= 0; i++)
            {
                cols[i] = new DataColumn(i.ToString());
            }
            for (int i = 1; i <= LinesNum; i++) //
            {
                DataRow newRow;
                newRow = matrix.NewRow();
                matrix.Rows.Add(newRow);
            }

           

            AcademPerformanceGrid.DataSource = matrix;
            for (int i = 0; i < 2; i++)
            {
                AcademPerformanceGrid.Columns[i].Width = 51;
            }


            for (int i = 0; i < AcademPerformanceGrid.Rows.Count; i++)
            {
                if (i % 5 == 0) 
                    AcademPerformanceGrid.Rows[i].Cells[0].Value = ((i / 5) + 1) + " сессия";
            }

            AcademPerformanceGrid.AutoGenerateColumns = false;
        }

        // Открыть для редактирования
        public void OpenForEditing()  //открытие формы для редактирования данных студента.
        {
            FIOtextBox.Text = student.FIO;
            CourseTextBox.Text = student.Course.ToString();
            GrouptextBox.Text = student.Group.ToString();



            DataGridViewCell txtCell;
            
            int j = 0;

            int examNum = student.Course * Student.SubjectNum * 2;
            for (int i = 0; i < examNum; i++)
            {
                txtCell = AcademPerformanceGrid.Rows[i].Cells[1];
                txtCell.Value = student.AcademPerformance[i].Subject;

                if (student.AcademPerformance != null)
                    txtCell.Value = student.AcademPerformance[i].Subject;
                else
                    txtCell.Value = "";


                txtCell = AcademPerformanceGrid.Rows[i].Cells[2];
                if (student.AcademPerformance != null)
                    txtCell.Value = student.AcademPerformance[i].Mark.ToString();
                else
                    txtCell.Value = "";  
            }

            if (student.EducationForm == 0)
                Budjet_Button.Checked = true;
            else
                Dogovor_Button.Checked = true;
        }

        // Считать студента
        public Student ReadStudent()
        {
            student.FIO = FIOtextBox.Text;
            student.Course = Int32.Parse(CourseTextBox.Text);
            if (!int.TryParse(GrouptextBox.Text, out student.Group) || student.Group < 1 || student.Group > 10)
                student.Group = 1;

            DataGridViewCell txtCell;
            int examNum = 5 * student.Course * 2;
            for (int i = 0; i < examNum; i++)
            {
                txtCell = AcademPerformanceGrid.Rows[i].Cells[1];
                student.AcademPerformance[i].Subject = txtCell.Value.ToString();
                txtCell = AcademPerformanceGrid.Rows[i].Cells[2];
                string s = txtCell.Value.ToString();
                if (s == "")
                    student.AcademPerformance[i].Mark = 1;
                else student.AcademPerformance[i].Mark = Int32.Parse(s);
            }

            if (Budjet_Button.Checked)
                student.EducationForm = 0;
            else student.EducationForm = 1;

            return student;
        }

        // Сохранить изменения
        private void Save_button_Click(object sender, EventArgs e)
        {
            ReadStudent();
            int examNum = student.Course * Student.SubjectNum * 2;

            for (int i = 0; i < examNum; i++)
                AcademPerformanceGrid.Rows.Remove(AcademPerformanceGrid.Rows[0]);

            MainForm f = this.Owner as MainForm;

            f.Filler(student, editing);
            this.Close();

            f.Enabled = true;
        }

        // Удалить студента
        private void button1_Click(object sender, EventArgs e)
        {  
            Hide();

            mainForm.RemoveStudent();    
        }

        // Ввод группы
        private void GrouptextBox_TextChanged(object sender, EventArgs e)
        {
            if (GrouptextBox.Text != "")
            {
                int LinesNumber;
                if (!int.TryParse(GrouptextBox.Text, out LinesNumber) || (int.Parse(GrouptextBox.Text) > 100))
                {
                    LinesNumber = 1;
                    GrouptextBox.Text = "1";
                }
            }
        }

        // Ввод курса
        private void CourseTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CourseTextBox.Text != "")
            {
                int LinesNumber;
                if (!int.TryParse(CourseTextBox.Text, out LinesNumber) || (int.Parse(CourseTextBox.Text) > 4))
                {
                    LinesNumber = 1;
                    CourseTextBox.Text = "1";
                }
                LinesNumber = LinesNumber * Student.SubjectNum * 2;
                CreateGrid(LinesNumber);
                AcademPerformanceGrid.Columns[0].Width = 100;
                Save_button.Enabled = true;
            }
        }
    }
}