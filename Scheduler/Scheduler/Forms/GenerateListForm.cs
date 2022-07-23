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
            DaysCombo.SelectedIndex = 0;
        }
        private void GenButton_Click(object sender, EventArgs e)
        {
            DbOperations.GenerateCombos();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Hide and show specific days in date selection table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DaysCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int daysShown = (int)DaysCombo.SelectedItem;
            switch (daysShown)
            {
                case 1:
                    hideDay2TB();
                    hideDay3TB();
                    hideDay4TB();
                    hideDay5TB();
                    hideDay6TB();
                    hideDay7TB();
                    break;
                case 2:
                    showDay2TB();

                    hideDay3TB();
                    hideDay4TB();
                    hideDay5TB();
                    hideDay6TB();
                    hideDay7TB();
                    break;
                case 3:
                    showDay2TB();
                    showDay3TB();

                    hideDay4TB();
                    hideDay5TB();
                    hideDay6TB();
                    hideDay7TB();
                    break;
                case 4:
                    showDay2TB();
                    showDay3TB();
                    showDay4TB();

                    hideDay5TB();
                    hideDay6TB();
                    hideDay7TB();
                    break;
                case 5:
                    showDay2TB();
                    showDay3TB();
                    showDay4TB();
                    showDay5TB();

                    hideDay6TB();
                    hideDay7TB();
                    break;
                case 6:
                    showDay2TB();
                    showDay3TB();
                    showDay4TB();
                    showDay5TB();
                    showDay6TB();

                    hideDay7TB();
                    break;
                case 7:
                    showDay2TB();
                    showDay3TB();
                    showDay4TB();
                    showDay5TB();
                    showDay6TB();
                    showDay7TB();
                    break;
            }
        }

        /// <summary>
        /// Hide and show selected weeks for generation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int weeksShown = (int)WeekCombo.SelectedItem;

            switch (weeksShown)
            {
                case 1:
                    week1LabelFLP.Visible = true;
                    week1DatesFLP.Visible = true;

                    week2LabelFLP.Visible = false;
                    week2DatesFLP.Visible = false;

                    week3LabelFLP.Visible = false;
                    week3DatesFLP.Visible = false;

                    week4LabelFLP.Visible = false;
                    week4DatesFLP.Visible = false;

                    week5LabelFLP.Visible = false;
                    week5DatesFLP.Visible = false;
                    break;
                case 2:
                    week1LabelFLP.Visible = true;
                    week1DatesFLP.Visible = true;

                    week2LabelFLP.Visible = true;
                    week2DatesFLP.Visible = true;

                    week3LabelFLP.Visible = false;
                    week3DatesFLP.Visible = false;

                    week4LabelFLP.Visible = false;
                    week4DatesFLP.Visible = false;

                    week5LabelFLP.Visible = false;
                    week5DatesFLP.Visible = false;
                    break;
                case 3:
                    week1LabelFLP.Visible = true;
                    week1DatesFLP.Visible = true;

                    week2LabelFLP.Visible = true;
                    week2DatesFLP.Visible = true;

                    week3LabelFLP.Visible = true;
                    week3DatesFLP.Visible = true;

                    week4LabelFLP.Visible = false;
                    week4DatesFLP.Visible = false;

                    week5LabelFLP.Visible = false;
                    week5DatesFLP.Visible = false;
                    break;
                case 4:
                    week1LabelFLP.Visible = true;
                    week1DatesFLP.Visible = true;

                    week2LabelFLP.Visible = true;
                    week2DatesFLP.Visible = true;

                    week3LabelFLP.Visible = true;
                    week3DatesFLP.Visible = true;

                    week4LabelFLP.Visible = true;
                    week4DatesFLP.Visible = true;

                    week5LabelFLP.Visible = false;
                    week5DatesFLP.Visible = false;
                    break;
                case 5:
                    week1LabelFLP.Visible = true;
                    week1DatesFLP.Visible = true;

                    week2LabelFLP.Visible = true;
                    week2DatesFLP.Visible = true;

                    week3LabelFLP.Visible = true;
                    week3DatesFLP.Visible = true;

                    week4LabelFLP.Visible = true;
                    week4DatesFLP.Visible = true;

                    week5LabelFLP.Visible = true;
                    week5DatesFLP.Visible = true;
                    break;
            } 
        }

        #region TextBoxVisibility
        private void showDay2TB()
        {
            week1TB2.Visible = true;
            week2TB2.Visible = true;
            week3TB2.Visible = true;
            week4TB2.Visible = true;
            week5TB2.Visible = true;
        }

        private void hideDay2TB()
        {
            week1TB2.Visible = false;
            week2TB2.Visible = false;
            week3TB2.Visible = false;
            week4TB2.Visible = false;
            week5TB2.Visible = false;
        }

        private void showDay3TB()
        {
            week1TB3.Visible = true;
            week2TB3.Visible = true;
            week3TB3.Visible = true;
            week4TB3.Visible = true;
            week5TB3.Visible = true;
        }

        private void hideDay3TB()
        {
            week1TB3.Visible = false;
            week2TB3.Visible = false;
            week3TB3.Visible = false;
            week4TB3.Visible = false;
            week5TB3.Visible = false;
        }

        private void showDay4TB()
        {
            week1TB4.Visible = true;
            week2TB4.Visible = true;
            week3TB4.Visible = true;
            week4TB4.Visible = true;
            week5TB4.Visible = true;
        }

        private void hideDay4TB()
        {
            week1TB4.Visible = false;
            week2TB4.Visible = false;
            week3TB4.Visible = false;
            week4TB4.Visible = false;
            week5TB4.Visible = false;
        }
        private void showDay5TB()
        {
            week1TB5.Visible = true;
            week2TB5.Visible = true;
            week3TB5.Visible = true;
            week4TB5.Visible = true;
            week5TB5.Visible = true;
        }

        private void hideDay5TB()
        {
            week1TB5.Visible = false;
            week2TB5.Visible = false;
            week3TB5.Visible = false;
            week4TB5.Visible = false;
            week5TB5.Visible = false;
        }
        private void showDay6TB()
        {
            week1TB6.Visible = true;
            week2TB6.Visible = true;
            week3TB6.Visible = true;
            week4TB6.Visible = true;
            week5TB6.Visible = true;
        }

        private void hideDay6TB()
        {
            week1TB6.Visible = false;
            week2TB6.Visible = false;
            week3TB6.Visible = false;
            week4TB6.Visible = false;
            week5TB6.Visible = false;
        }
        private void showDay7TB()
        {
            week1TB7.Visible = true;
            week2TB7.Visible = true;
            week3TB7.Visible = true;
            week4TB7.Visible = true;
            week5TB7.Visible = true;
        }

        private void hideDay7TB()
        {
            week1TB7.Visible = false;
            week2TB7.Visible = false;
            week3TB7.Visible = false;
            week4TB7.Visible = false;
            week5TB7.Visible = false;
        }

        #endregion

    }
}
