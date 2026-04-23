using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        int currentId = 1;

        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentName.Text))
            {
                MessageBox.Show("Enter student name");
                return;
            }

            int age;

            if (!int.TryParse(StudentAge.Text, out age))
            {
                MessageBox.Show("Enter valid age");
                return;
            }

            Student s = new Student()
            {
                ID = currentId++,
                Name = StudentName.Text,
                Age = age
            };

            students.Add(s);
            RefreshGrid();
            StudentName.Clear();
            StudentAge.Clear();
            StudentName.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var confirm = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    Student selected = (Student)dataGridView1.CurrentRow.DataBoundItem;
                    students.Remove(selected);
                    RefreshGrid();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = students
    .Where(s => s.Name.Contains(Search.Text))
    .ToList();

            if (result.Count == 0)
            {
                MessageBox.Show("Student not found");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
