using System;
using System.Windows.Forms;

namespace Introduccion
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
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("El título no puede estar vacío.");
                return false;
            }

            if (checkedListBoxEnvironment.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un entorno.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxLocation.Text) ||
                string.IsNullOrWhiteSpace(comboBoxType.Text) ||
                string.IsNullOrWhiteSpace(comboBoxCriticity.Text) ||
                string.IsNullOrWhiteSpace(comboBoxStatus.Text) ||
                string.IsNullOrWhiteSpace(comboBoxPercent.Text))
            {
                MessageBox.Show("Por favor, selecciona una opción en todos los campos desplegables.");
                return false;
            }

            return true;
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
