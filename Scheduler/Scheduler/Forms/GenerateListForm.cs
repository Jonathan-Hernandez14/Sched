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
    public partial class GenerateListForm : Form
    {
        List<string> Months = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
        List<int> Weeks = new List<int>{1, 2, 3, 4, 5};
        List<int> Days = new List<int>{ 1, 2, 3, 4, 5, 6, 7 };
        public GenerateListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// set info for comboboxes and default selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateListForm_Load(object sender, EventArgs e)
        {
            MonthsCombo.DataSource = Months;
            WeekCombo.DataSource = Weeks;
            DaysCombo.DataSource = Days;
            WeekCombo.SelectedIndex = 3;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
