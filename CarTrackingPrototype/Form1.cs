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
            AddToolTips();
            // Subscribe to the FormClosing event 
            // Set the TextBox to handle only uppercase letters
            textBoxRegoPlate.CharacterCasing = CharacterCasing.Upper;
            textBoxRegoPlate.MaxLength = 8;
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
                openFileDialog.InitialDirectory = Application.StartupPath; // Set the initial directory to the application directory
                openFileDialog.Filter = "Text files (*.txt)|*.txt"; // Allow .txt files
                openFileDialog.Multiselect = false; // Allow only the selection of one file

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Get the file name (without the full path)
                        string fileName = Path.GetFileName(openFileDialog.FileName);

                        // Regular expression to match the format "day_##.txt"
                        string pattern = @"^day_\d{2}\.txt$";

                        if (Regex.IsMatch(fileName, pattern))
                        {
                            // If the file name follows the format "day_##.txt"
                            // Clear the current list before loading new data
                            allLicensePlates.Clear();
                            listBoxEnteringVehicles.Items.Clear(); // Clear the list boxes
                            listBoxExitingVehicles.Items.Clear();

                            // Read all lines from the selected file
                            string[] lines = File.ReadAllLines(openFileDialog.FileName);

                            foreach (string line in lines)
                            {
                                string rego = line.Trim();
                                if (IsValidRego(rego) || rego.EndsWith(" (Tagged)"))
                                {
                                    allLicensePlates.Add(rego); // Add valid registration plates to the main list
                                }
                            }

                            // Update the list boxes with the loaded data
                            UpdateListBoxes();
                        }
                        else
                        {
                            // If the file name does not follow the format, show an error message
                            MessageBox.Show("Invalid file name format. Please select a file with the name format 'day_##.txt'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // If there's an error reading the file, show an error message
                        MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                saveFileDialog.FileName = "day_00.txt";

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
            textBoxRegoPlate.Focus();
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
            textBoxRegoPlate.Focus();

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
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? selectedRego = listBoxEnteringVehicles.SelectedItem.ToString(); // Retrieve the selected item correctly
#pragma warning restore CS8602 // Dereference of a possibly null reference.


                if (taggedLicensePlates.Contains(selectedRego + " (Tagged)"))
                {
                    // Untag the license plate
                    taggedLicensePlates.Remove(selectedRego + " (Tagged)");

                    // Add the untagged license plate to entering vehicles list
                    allLicensePlates.Add(selectedRego);

                    // Update the list boxes
                    UpdateListBoxes();
                }
                else
                {
                    // Tag the license plate
                    // Remove the license plate from entering vehicles list
                    allLicensePlates.Remove(selectedRego);

                    // Add the tagged license plate to the tagged list
                    taggedLicensePlates.Add(selectedRego + " (Tagged)");

                    // Update the list boxes
                    UpdateListBoxes();
                }
            }
            else if (listBoxExitingVehicles.SelectedIndex >= 0) // Check if a plate is selected in the exiting vehicles list
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                string? selectedRego = listBoxExitingVehicles.SelectedItem.ToString(); // Retrieve the selected item correctly
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                // Untag the license plate
                taggedLicensePlates.Remove(selectedRego);

                // Add the untagged license plate to entering vehicles list
                allLicensePlates.Add(selectedRego.Substring(0, selectedRego.Length - 9)); // Remove the " (Tagged)" part

                // Update the list boxes
                UpdateListBoxes();
            }
            else
            {
                MessageBox.Show("Please select a registration plate to tag or untag.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            allLicensePlates.Clear();
            taggedLicensePlates.Clear();
            UpdateListBoxes();
            textBoxRegoPlate.Clear();

        }
        private void listBoxEnteringVehicles_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender; // Convert the sender object to ListBox
            if (listBox.SelectedItem != null)
            {
                string? selectedRego = listBox.SelectedItem!.ToString(); // Assert that listBox.SelectedItem is not null
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedRego + "?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (listBox == listBoxEnteringVehicles)
                    {
                        allLicensePlates.Remove(selectedRego); // Remove the item from the entering vehicles list
                    }
                    else if (listBox == listBoxExitingVehicles)
                    {
                        taggedLicensePlates.Remove(selectedRego); // Remove the item from the exiting vehicles list
                    }
                    UpdateListBoxes(); // Update the lists after deletion
                }
            }
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
            // Regular expression pattern to match the required format: "1AAA-111"
            const string regexPattern = @"^[1-9][A-Z]{3}-\d{3}$";
            return Regex.IsMatch(rego, regexPattern);
        }
       
        private void UpdateListBox()
        {
            listBoxEnteringVehicles.Items.Clear();
            foreach (string rego in allLicensePlates)
            {
                listBoxEnteringVehicles.Items.Add(rego);
            }
        }
        private void TextBoxRegoPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only uppercase letters and numbers
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void textBoxRegoPlate_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow only uppercase letters and numbers
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false; // This prevents non-alphanumeric characters from being entered
            }
        }

        private int fileCounter = 0; // Counter for auto-incrementing file names

        // Method to save data to a text file
        private void SaveData()
        {
            

            // Construct the file name with the auto-incrementing counter
            string fileName = $"day_{fileCounter:00}.txt";
            // Increment the counter for the next file
            fileCounter++;
            try
            {
                // Write all license plate data to the file
                File.WriteAllLines(fileName, allLicensePlates);

                // Display a success message
                MessageBox.Show($"Data saved to {fileName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display an error message if saving fails
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void listBoxExitingVehicles_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender; // Convert the sender object to ListBox
            if (listBox.SelectedItem != null)
            {
                string? selectedRego = listBox.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedRego + "?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (listBox == listBoxEnteringVehicles)
                    {
                        allLicensePlates.Remove(selectedRego); // Remove the item from the entering vehicles list
                    }
                    else if (listBox == listBoxExitingVehicles)
                    {
                        taggedLicensePlates.Remove(selectedRego); // Remove the item from the exiting vehicles list
                    }
                    UpdateListBoxes(); // Update the lists after deletion
                }
            }
        }

        private void AddToolTips()
        {
            // ToolTip for TextBox
            ToolTip toolTipTextBox = new ToolTip();
            toolTipTextBox.SetToolTip(textBoxRegoPlate, "Enter the registration plate");

            // ToolTip for Buttons
            ToolTip toolTipButtons = new ToolTip();
            toolTipButtons.SetToolTip(buttonSavePlate, "Save the File");
            toolTipButtons.SetToolTip(buttonOpenFile, "Open the File");
            toolTipButtons.SetToolTip(buttonDeletePlate, "Vehicle Exit");
            toolTipButtons.SetToolTip(buttonEditPlate, "Edit the Plate");
            toolTipButtons.SetToolTip(buttonAddPlates, "Enter Plate");
            toolTipButtons.SetToolTip(buttonReset, "Reset all the data");
            toolTipButtons.SetToolTip(buttonBinarySearch, "Binary Searching");
            toolTipButtons.SetToolTip(buttonLinearSearch, "Linear Searching");

            // ToolTip for ListBox EnteringVehicles
            ToolTip toolTipListBoxEnteringVehicles = new ToolTip();
            toolTipListBoxEnteringVehicles.SetToolTip(listBoxEnteringVehicles, "List of entering vehicles");

            // ToolTip for ListBox ExitingVehicles
            ToolTip toolTipListBoxExitingVehicles = new ToolTip();
            toolTipListBoxExitingVehicles.SetToolTip(listBoxExitingVehicles, "Vehicles Tagged");
        }
    }

}