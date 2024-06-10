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

        private List<string> allLicensePlates = new List<string>(); // Main list to hold all license plate data
        private List<string> taggedLicensePlates = new List<string>(); // List to hold the license plate data which has been tagged for further investigation
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
                        // Read file content and parse lines
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        foreach (string line in lines)
                        {
                            string rego = line.Trim();
                            if (IsValidRego(rego))
                            {
                                allLicensePlates.Add(rego);
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
                saveFileDialog.InitialDirectory = @"C:\YourDirectory"; // Set the directory where files are saved

                // Set the default file name
                saveFileDialog.FileName = "day_01.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllLines(saveFileDialog.FileName, allLicensePlates.Concat(taggedLicensePlates));
                        MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            SaveData();

        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newRego = textBoxRegoPlate.Text.Trim();

            if (IsValidRego(newRego) && !allLicensePlates.Contains(newRego))
            {
                allLicensePlates.Add(newRego);
                UpdateListBoxes();

            }
            else
            {
                MessageBox.Show("Invalid registration plate format or duplicate detected.");
            }
            textBoxRegoPlate.Clear();
            
        }

        private void buttonEditPlate_Click(object sender, EventArgs e)
        {
            if (listBoxEnteringVehicles.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxEnteringVehicles.SelectedIndex;

                // Get the edited registration plate from textBoxRegoPlate
                string editedRego = textBoxRegoPlate.Text.Trim();

                if (IsValidRego(editedRego) && !allLicensePlates.Contains(editedRego))
                {
                    // Update the registration plate in the list
                    allLicensePlates[selectedIndex] = editedRego;
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
                string selectedRego = allLicensePlates[selectedIndex];

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedRego + "?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    allLicensePlates.RemoveAt(selectedIndex);
                    taggedLicensePlates.Remove(selectedRego); // Remove from the list of vehicles that are exiting
                    UpdateListBoxes();
                }
            }
            else if (listBoxExitingVehicles.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxExitingVehicles.SelectedIndex;
                string selectedRego = taggedLicensePlates[selectedIndex];

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedRego + "?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    taggedLicensePlates.RemoveAt(selectedIndex);
                    allLicensePlates.Remove(selectedRego); // Remove from the list of vehicles that are entering
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
                string selectedRego = allLicensePlates[selectedIndex];

                // Check if the license plate is not already tagged
                if (!selectedRego.EndsWith(" (Tagged)"))
                {
                    selectedRego += " (Tagged)";
                    taggedLicensePlates.Add(selectedRego); // Add to the list of tagged license plates
                    UpdateListBoxes();
                    textBoxRegoPlate.Clear();   
                }
            }
            else
            {
                MessageBox.Show("Please select a registration plate to tag.");
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            allLicensePlates.Clear();
            taggedLicensePlates.Clear();
            UpdateListBoxes();
            textBoxRegoPlate.Clear();

        }
        private void UpdateListBoxes()
                {
                    listBoxEnteringVehicles.Items.Clear();
                    listBoxExitingVehicles.Items.Clear();

                    foreach (string rego in allLicensePlates)
                    {
                        listBoxEnteringVehicles.Items.Add(rego);
                    }

                    foreach (string rego in taggedLicensePlates)
                    {
                        listBoxExitingVehicles.Items.Add(rego);
                    }
                }
        private int BinarySearch(string rego)
        {
            SortListForBinarySearch();
            int low = 0;
            int high = allLicensePlates.Count - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int comparison = string.Compare(allLicensePlates[mid], rego, StringComparison.OrdinalIgnoreCase);

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
            allLicensePlates.Sort(StringComparer.OrdinalIgnoreCase);
        }
        private int LinearSearch(string rego)
        {
            for (int i = 0; i < allLicensePlates.Count; i++)
            {
                if (string.Equals(allLicensePlates[i], rego, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
        private bool IsValidRego(string rego)
        {
            const string regexPattern = @"^[A-Z0-9]{1,7}( \(Tagged\))?$";
            return Regex.IsMatch(rego, regexPattern);
        }

        private void ToggleTag(int selectedIndex)
        {
            string selectedRego = allLicensePlates    [selectedIndex];

            if (selectedRego.EndsWith(" (Tagged)"))
            {
                selectedRego = selectedRego.Substring(0, selectedRego.Length - 9);
            }
            else
            {
                selectedRego += " (Tagged)";
            }

            allLicensePlates.RemoveAt(selectedIndex);
            allLicensePlates.Add(selectedRego);

            UpdateListBoxes();
        }
        private void SortEnteringVehicles()
        {
            // Sort the list, placing tagged vehicles at the end
            allLicensePlates = allLicensePlates
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
        private void SaveData()
        {
            // Check if the TextBox is empty
            if (string.IsNullOrWhiteSpace(textBoxRegoPlate.Text))
            {
                MessageBox.Show("Please enter a registration plate before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate data
            string newRego = textBoxRegoPlate.Text.Trim();
            if (allLicensePlates.Contains(newRego))
            {
                MessageBox.Show("Duplicate registration plate detected. Please enter a unique registration plate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add data to the main List
            allLicensePlates.Add(newRego);
            // Clear the TextBox
            textBoxRegoPlate.Clear();
            // Refocus into the TextBox
            textBoxRegoPlate.Focus();
            // Display a confirmation message
            MessageBox.Show("The data will be added to the main List<>.\nThe TextBox has been cleared, and the cursor has refocused.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
