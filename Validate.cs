using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Validate
{
    public partial class ValidateForm : Form
    {
        public ValidateForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var emptyBoxes =
                from Control currentControl in Controls
                where currentControl is TextBox
                let box = currentControl as TextBox
                where string.IsNullOrEmpty(box.Text)
                orderby box.TabIndex
                select box;

            if (emptyBoxes.Any())
            {
                MessageBox.Show(
                    "Please fill in all fields",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                emptyBoxes.First().Select();
            }
            else
            {
                if (!ValidateInput(
                        lastNameTextBox.Text,
                        "^[A-Z][a-zA-Z]*$",
                        "Invalid last name"))
                {
                    lastNameTextBox.Select();
                }
                else if (!ValidateInput(
                        firstNameTextBox.Text,
                        "^[A-Z][a-zA-Z]*$",
                        "Invalid first name"))
                {
                    firstNameTextBox.Select();
                }
                else if (!ValidateInput(
                        addressTextBox.Text,
                        @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$",
                        "Invalid address"))
                {
                    addressTextBox.Select();
                }
                else if (!ValidateInput(
                        cityTextBox.Text,
                        @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$",
                        "Invalid city"))
                {
                    cityTextBox.Select();
                }
                else if (!ValidateInput(
                        stateTextBox.Text,
                        @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$",
                        "Invalid state"))
                {
                    stateTextBox.Select();
                }
                else if (!ValidateInput(
                        zipCodeTextBox.Text,
                        @"^\d{5}$",
                        "Invalid zip code"))
                {
                    zipCodeTextBox.Select();
                }
                else if (!ValidateInput(
                        phoneTextBox.Text,
                        @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$",
                        "Invalid phone number"))
                {
                    phoneTextBox.Select();
                }
                else
                {
                    Hide();
                    MessageBox.Show(
                        "Thank You!",
                        "Information Correct",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }

        private bool ValidateInput(
            string input, string expression, string message)
        {
            bool valid = Regex.Match(input, expression).Success;

            if (!valid)
            {
                MessageBox.Show(
                    message,
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return valid;
        }
    }
}
