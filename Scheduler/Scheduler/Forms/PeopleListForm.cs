using Scheduler.Common;
using Scheduler.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler.Forms
{
    public partial class PeopleListForm : Form
    {
        Person SelectedPerson;
        int SelectionIndex;
        bool ChangesMade = false;

        public PeopleListForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Save any changes done in the screen to the master DB text file
            if (ChangesMade)
            {
                DbOperations.UpdateDB();
            }
            Close();
        }

        private void PeopleListForm_Load(object sender, EventArgs e)
        {
            peopleListGridView.DataSource = DataBase.Instance.peopleDataBase;
        }

        private void peopleListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectionIndex = e.RowIndex;
            if (SelectionIndex >= 0)
            {
                DataGridViewRow selectedRow = peopleListGridView.Rows[SelectionIndex];
                firstNameTB.Text = selectedRow.Cells[0].Value.ToString();
                lastNameTB.Text = selectedRow.Cells[1].Value.ToString();

                bool isMale = (bool)selectedRow.Cells[2].Value;
                maleRB.Checked = isMale;
                femaleRB.Checked = !isMale;

                bool isAdult = (bool)selectedRow.Cells[3].Value;
                adultYesRB.Checked = isAdult;
                adultNoRB.Checked = !isAdult;

                satMorningCB.Checked = (bool)selectedRow.Cells[4].Value;
                satAfternoonCB.Checked = (bool)selectedRow.Cells[5].Value;
                SatEveningCB.Checked = (bool)selectedRow.Cells[6].Value;
                sunMorningCB.Checked = (bool)selectedRow.Cells[7].Value;
                sunAfternoonCB.Checked = (bool)selectedRow.Cells[8].Value;
                sunEveningCB.Checked = (bool)selectedRow.Cells[9].Value;

                SelectedPerson = (Person)DataBase.Instance.peopleDataBase[SelectionIndex];
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //Remove person from Program
            DbOperations.RemovePerson(SelectedPerson);
            clearInputFields();
            ChangesMade = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Get Updated Core Info
            SelectedPerson.FirstName = firstNameTB.Text;
            SelectedPerson.LastName = lastNameTB.Text;
            SelectedPerson.IsMale = maleRB.Checked;
            SelectedPerson.IsAdult = adultYesRB.Checked;

            SelectedPerson.SaturdayMorning = satMorningCB.Checked;
            SelectedPerson.SaturdayAfternoon = satAfternoonCB.Checked;
            SelectedPerson.SaturdayEvening = SatEveningCB.Checked;

            SelectedPerson.SundayMorning = sunMorningCB.Checked;
            SelectedPerson.SundayAfternoon = sunAfternoonCB.Checked;
            SelectedPerson.SundayEvening = sunEveningCB.Checked;

            DbOperations.UpdatePerson(SelectedPerson, SelectionIndex);
            ChangesMade = true;
        }

        private void clearInputFields()
        {
            firstNameTB.Text = String.Empty;
            lastNameTB.Text = String.Empty;

            maleRB.Checked = false;
            femaleRB.Checked = false;
            adultYesRB.Checked = false;
            adultNoRB.Checked = false;
            satMorningCB.Checked = false;
            satAfternoonCB.Checked = false;
            SatEveningCB.Checked = false;
            sunMorningCB.Checked = false;
            sunAfternoonCB.Checked = false;
            sunEveningCB.Checked = false;
        }
    }
}
