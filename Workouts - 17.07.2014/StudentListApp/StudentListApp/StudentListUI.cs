using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentListApp
{
    public partial class StudentListUI : Form
    {
        List<Student> studentList = new List<Student>();
        public StudentListUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            Student aStudent = new Student();

            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            studentList.Add(aStudent);

            MessageBox.Show("Student information has been added.");
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            stuedntListView.Items.Clear();

            foreach (Student aStudent in studentList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aStudent.regNo;
                aListViewItem.SubItems.Add(aStudent.firstName);
                aListViewItem.SubItems.Add(aStudent.lastName);
                stuedntListView.Items.Add(aListViewItem);
            }
        }
    }
}
