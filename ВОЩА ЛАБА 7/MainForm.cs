using System;
using System.IO;
using System.Windows.Forms;

namespace StudentGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        byte fileType = 0; // 1 - bin 2 - xml 3 - txt

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (fileType == 0)
                 SaveButton.Enabled = false; 
        }

        StudentList listOfStudents;
        public Student person;
        string fileName;
        bool is_delited = false;
        int Selectedin = -1;



        // Создание файла
        private void CreateButton_Click_1(object sender, EventArgs e)
        {
            listOfStudents = new StudentList();
            fileName = "";
            saveFileDialog.Filter = "*.xml|*.xml|*.bin|*.bin|*.txt|*.txt";


            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                fileName = saveFileDialog.FileName;

                string selectedFilter = saveFileDialog.Filter.Substring(0, saveFileDialog.Filter.IndexOf("|"));
                //string ftype = "";

                if (selectedFilter.EndsWith("txt"))
                    fileType = 3;
                else if (selectedFilter.EndsWith("xml"))
                    fileType = 2;
                else if (selectedFilter.EndsWith("bin"))
                    fileType = 1;


                SaveButton.Enabled = true;


                StreamWriter f_out = new StreamWriter(fileName);
                f_out.Close();
                listBox.Items.Clear();

                // изменение filetype

                ShowList();

                MessageBox.Show("Файл создан и открыт");
            }
        }


        // ---- Открытие файлов ---

        private void BinOpenButton_Click(object sender, EventArgs e)
        {
            listOfStudents = new StudentList();

            openBinFileDialog.Filter = "*.bin|*.bin";
            if (openBinFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                fileName = openBinFileDialog.FileName;
                listOfStudents.OpenBinaryFile(fileName);
                fileType = 1;
                SaveButton.Enabled = true;
                ShowList();
            }
        }

        private void XMLOpenButton_Click(object sender, EventArgs e)
        {
            listOfStudents = new StudentList();

            openXMLFileDialog.Filter = "*.xml|*.xml";
            if (openXMLFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                fileName = openXMLFileDialog.FileName;
                listOfStudents.OpenXMLFile(fileName);
                fileType = 2;
                SaveButton.Enabled = true;
                ShowList();

            }
        }

        private void TextOpenButton_Click(object sender, EventArgs e)
        {
            listOfStudents = new StudentList();

            openTextFileDialog.Filter = "*.txt|*.txt";
            if (openTextFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                fileName = openTextFileDialog.FileName;
                listOfStudents.OpenTextFile(fileName);
                fileType = 3;
                SaveButton.Enabled = true;
                ShowList();
            }
        }


        // --- Сохранение и Сохранение как... ---

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            if (fileType == 0)
            {
                fileType = 3;
            }
            else
            {
                if (fileType == 1)
                    listOfStudents.SaveBinaryFile(fileName);
                else
                {
                    if (fileType == 2)
                        listOfStudents.SaveXMLFile(fileName);
                    else listOfStudents.SaveTextFile(fileName);
                }
            }
        }

        private void BinSaveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "*.bin|*.bin";
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                fileName = saveFileDialog.FileName;
                listOfStudents.SaveBinaryFile(fileName);
            }
        }

        private void XMLSaveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "*.xml|*.xml";
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                fileName = saveFileDialog.FileName;
                listOfStudents.SaveXMLFile(fileName);
            }
        }

        private void TextSaveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "*.txt|*.txt";
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                fileName = saveFileDialog.FileName;
                listOfStudents.SaveTextFile(fileName);
            }
        }


        // --- Операции со студентами ----

        //Вставка или замена студента
        public void Filler(Student student, bool editing)
        {
            if (editing)
            {
                listOfStudents.Students.RemoveAt(Selectedin);
            }
            listOfStudents.Students.Insert(Selectedin, student);
            ShowList();
        }

        //Открытие записи на редактирование
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!is_delited)
            {
                Selectedin = listBox.SelectedIndex;
                if (Selectedin < 0)
                    Selectedin = 0;


                person = listOfStudents.Students[Selectedin];
                StudentForm f2 = new StudentForm(this, person, true);
                f2.Owner = this;

                f2.ShowDialog();
            }
        }

        //Добавление студента
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (fileType == 0)
                MessageBox.Show("Вы не открыли файл");
            else
            {
                Selectedin = listOfStudents.Students.Count; 
                person = new Student();
                StudentForm f2 = new StudentForm(this, person);
                f2.Owner = this;
                f2.ShowDialog();
                ShowList();
            }
        }

        //Удаление студента
        public void RemoveStudent()
        {
            is_delited = true;
            if (this.listBox.SelectedIndex >= 0)
            {
                int selectInd = this.listBox.SelectedIndex; // Получаем индекс выбранной ячейки
                listOfStudents.Students.RemoveAt(selectInd); // Удаляем выбранного студента из списка студентов

                this.listBox.Items.RemoveAt(this.listBox.SelectedIndex);
            }
            is_delited = false;
        }

        // Вывод списка студентов в ListBox
        public void ShowList()
        {
            listBox.Items.Clear();
            TasktextBox.Clear();
            if (fileType == 0)
                MessageBox.Show("Файл не создан/не открыт");
            else
            {
                int count = listOfStudents.Students.Count;
                for (int i = 0; i < count; i++)
                {
                    listBox.Items.Add(listOfStudents.Students[i].MakeOut());
                }
                Selectedin = -1;
                listBox.Enabled = true;
            }
        }

        // Подсчет количества студентов бюджетной и договорной форм обучения без задолжностей на каждом курсе
        private void TaskButton_Click(object sender, EventArgs e)
        {
            TasktextBox.Clear();

            if (fileType == 0)
            {
                MessageBox.Show("Файл не открыт.");
            }
            else
            {
                if (listBox.Items.Count <= 0)
                {
                    MessageBox.Show("Файл пуст.");
                }
                else
                {
                    // Вызываем метод для подсчета студентов без задолженностей очной и договорной форм на каждом курсе
                    int[,] counters = listOfStudents.CountStudentsWithoutDebt();

                    // Выводим результат на форму

                    for (int i = 0; i < counters.GetLength(0); i++)
                    {
                        TasktextBox.Text += $"Курс {i + 1}: Бюджет - {counters[i, 0]}, Договор - {counters[i, 1]}\r\n";
                    }
                }
            }
        }

        private void FiletoolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}