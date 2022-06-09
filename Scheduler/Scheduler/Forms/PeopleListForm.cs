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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
