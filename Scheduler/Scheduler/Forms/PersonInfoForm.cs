using Newtonsoft.Json;
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
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTB.Text))
            {
                MessageBox.Show("Por favor ingrese el primer nombre del publicador");
            }
            else if (string.IsNullOrEmpty(lastNameTB.Text))
            {
                MessageBox.Show("Por favor ingrese el apellido del publicador");
            }
            else
            {
                // Add Person to our db
                Person personToAdd = new Person(
                    firstNameTB.Text
                    , lastNameTB.Text
                    , isMale.Checked
                    , adult.Checked
                    , SatMorning.Checked
                    , SatAfternoon.Checked
                    , SatEvening.Checked
                    , SunMorning.Checked
                    , SunAfternoon.Checked
                    , SunEvening.Checked
                    );

                DbOperations.AddPerson(personToAdd);
                //DbOperations.CategorizePerson(personToAdd);

                Close();
            }

        }
    }
}
