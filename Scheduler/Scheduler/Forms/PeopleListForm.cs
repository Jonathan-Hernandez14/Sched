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
        public PeopleListForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PeopleListForm_Load(object sender, EventArgs e)
        {
            peopleListGridView.DataSource = DataBase.Instance.peopleDataBase;
        }

        private void peopleListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = peopleListGridView.Rows[index];
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
            }
        }
    }
}
