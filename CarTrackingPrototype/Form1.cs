using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CarTrackingPrototype
{
    public partial class CarParkTracking : Form
    {

        private List<string> enteringVehicles = new List<string>();
        private List<string> exitingVehicles = new List<string>();
        public CarParkTracking()
        {
            InitializeComponent();
            // Set the TextBox to handle only uppercase letters
            textBoxRegoPlate.CharacterCasing = CharacterCasing.Upper;
            textBoxRegoPlate.MaxLength = 9;
            // Attach event handler for KeyPress to restrict input
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            textBoxRegoPlate.KeyPress += TextBoxRegoPlate_KeyPress;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRegoPlates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEnteringVehicles.SelectedIndex >= 0)
            {
                // Get the selected item from listBoxEnteringVehicles and set it as the text of textBoxRegoPlate
                textBoxRegoPlate.Text = listBoxEnteringVehicles.SelectedItem?.ToString();
            }
        }

        private void CarParkTracking_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);
                        enteringVehicles.Clear(); // Limpiar la lista actual antes de cargar nuevos datos

                        foreach (string line in lines)
                        {
                            string rego = line.Trim();
                            if (IsValidRego(rego) || rego.EndsWith(" (Tagged)"))
                            {
                                enteringVehicles.Add(rego);
                            }
                        }

                        UpdateListBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                    }
                }
            }

        }
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllLines(saveFileDialog.FileName, enteringVehicles.Concat(exitingVehicles));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message);
                    }
                }
            }

        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newRego = textBoxRegoPlate.Text.Trim();

            if (IsValidRego(newRego) && !enteringVehicles.Contains(newRego))
            {
                enteringVehicles.Add(newRego);
                UpdateListBoxes();

            }
            else
            {
                MessageBox.Show("Invalid registration plate format or duplicate detected.");
            }

        }

        private void buttonEditPlate_Click(object sender, EventArgs e)
        {
            if (listBoxEnteringVehicles.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxEnteringVehicles.SelectedIndex;

                // Get the edited registration plate from textBoxRegoPlate
                string editedRego = textBoxRegoPlate.Text.Trim();

                if (IsValidRego(editedRego) && !enteringVehicles.Contains(editedRego))
                {
                    // Update the registration plate in the list
                    enteringVehicles[selectedIndex] = editedRego;
                    UpdateListBoxes();
                    textBoxRegoPlate.Clear();

                }
                else
                {
                    MessageBox.Show("Invalid registration plate format or duplicate detected.");
                }
            }
            else
            {
                MessageBox.Show("Please select a registration plate to edit.");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxEnteringVehicles.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxEnteringVehicles.SelectedIndex;
                string selectedRego = enteringVehicles[selectedIndex];

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedRego + "?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    enteringVehicles.RemoveAt(selectedIndex);
                    exitingVehicles.Add(selectedRego); // Agregar a la lista de veh�culos que est�n saliendo
                    UpdateListBoxes();
                }
            }
            else
            {
                MessageBox.Show("Please select a registration plate to delete.");
            }
        }
        private void buttonLinearSearch_Click(object sender, EventArgs e)
        {
            string regoToFind = textBoxRegoPlate.Text.Trim();
            int index = LinearSearch(regoToFind);

            if (index >= 0)
            {
                MessageBox.Show("Registration plate found at index: " + index);
            }
            else
            {
                MessageBox.Show("Registration plate not found.");
            }

        }
        private void buttonBinarySearch_Click(object sender, EventArgs e)
        {
            string regoToFind = textBoxRegoPlate.Text.Trim();
            int index = BinarySearch(regoToFind);

            if (index >= 0)
            {
                MessageBox.Show("Registration plate found at index: " + index);
            }
            else
            {
                MessageBox.Show("Registration plate not found.");
            }

        }
        private void buttonTag_Click(object sender, EventArgs e)
        {
            if (listBoxEnteringVehicles.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxEnteringVehicles.SelectedIndex;
                ToggleTag(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a registration plate to tag.");
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            enteringVehicles.Clear();
            exitingVehicles.Clear();
            UpdateListBoxes();
            textBoxRegoPlate.Clear();

        }
        private void UpdateListBoxes()
        {
            SortEnteringVehicles();

            listBoxEnteringVehicles.Items.Clear();
            listBoxExitingVehicles.Items.Clear();

            foreach (string rego in enteringVehicles)
            {
                listBoxEnteringVehicles.Items.Add(rego);
            }

            foreach (string rego in exitingVehicles)
            {
                listBoxExitingVehicles.Items.Add(rego);
            }

            // Add tagged vehicles from enteringVehicles to listBoxExitingVehicles
            foreach (string rego in enteringVehicles)
            {
                if (rego.EndsWith(" (TAGGED)"))
                {
                    listBoxExitingVehicles.Items.Add(rego);
                }
            }
        }
        private int BinarySearch(string rego)
        {
            SortListForBinarySearch();
            int low = 0;
            int high = enteringVehicles.Count - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int comparison = string.Compare(enteringVehicles[mid], rego, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    return mid;
                }
                else if (comparison < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
        private void SortListForBinarySearch()
        {
            enteringVehicles.Sort(StringComparer.OrdinalIgnoreCase);
        }
        private int LinearSearch(string rego)
        {
            for (int i = 0; i < enteringVehicles.Count; i++)
            {
                if (string.Equals(enteringVehicles[i], rego, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
        private bool IsValidRego(string rego)
        {
            // Regular expression to validate the registration plate format
            // Ensures only uppercase letters and numbers, optionally followed by " (TAGGED)"
            const string regexPattern = @"^[A-Z0-9]{1,7}( \(TAGGED\))?$";
            return Regex.IsMatch(rego, regexPattern);
        }

        private void ToggleTag(int selectedIndex)
        {
            string selectedRego = enteringVehicles[selectedIndex];

            if (selectedRego.EndsWith(" (Tagged)"))
            {
                selectedRego = selectedRego.Substring(0, selectedRego.Length - 9);
            }
            else
            {
                selectedRego += " (Tagged)";
            }

            enteringVehicles.RemoveAt(selectedIndex);
            enteringVehicles.Add(selectedRego);

            UpdateListBoxes();
        }
        private void SortEnteringVehicles()
        {
            // Sort the list, placing tagged vehicles at the end
            enteringVehicles = enteringVehicles
                .OrderBy(rego => rego.EndsWith(" (Tagged)"))
                .ThenBy(rego => rego, StringComparer.OrdinalIgnoreCase)
                .ToList();
        }
        private void TextBoxRegoPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only uppercase letters and numbers
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxRegoPlate_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow only uppercase letters and numbers
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // This prevents non-alphanumeric characters from being entered
            }
        }
    }
}
