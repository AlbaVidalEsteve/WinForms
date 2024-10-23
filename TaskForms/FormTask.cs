using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskForms
{
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            string message =
                "Campos: "
               + "\n Title: " + textBoxTitle.Text
               + "\n Location:" + comboBoxLocation.Text
               + "\n Type: " + comboBoxType.Text
               + "\n Criticity: " + comboBoxCriticity.Text
               + "\n Environment: " + WriteCheckList(checkedListBoxEnvironment)
               + "\n Description: " + richTextBoxDesc.Text
               + "\n Start Date: " + dateTimePickerStartDate.Text
               + "\n Durantion: " + numericUpDownDuration.Value
               + "\n Status: " + comboBoxStatus.Text
               + "\n Percentage: " + comboBoxPercent.Text
               + "\n Send Email: " + checkBoxEmail.Checked;

            if (ValidarCampos())
            {
                MessageBox.Show(message);
            }

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipalNueva = new FormPrincipal();
            formPrincipalNueva.Show();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                string.IsNullOrWhiteSpace(richTextBoxDesc.Text) ||
                (checkedListBoxEnvironment.CheckedItems.Count == 0))
            {
                MessageBox.Show("El título o la descripción no puede estar vacío. Y debe seleccionar al menos un entorno.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private string WriteCheckList(CheckedListBox checkedList)
        {

            string checks = string.Empty;

            if (checkedList.CheckedItems.Count > 0)
            {
                foreach (var item in checkedList.CheckedItems)
                {
                    checks += item.ToString() + ", ";
                }

                if (checks.Length > 0)
                {
                    checks = checks.TrimEnd(',', ' ');
                }
            }
            return checks;
        }
    }
}
