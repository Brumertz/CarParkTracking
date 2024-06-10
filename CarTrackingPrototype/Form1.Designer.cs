namespace CarTrackingPrototype
{
    partial class CarParkTracking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarParkTracking));
            listBoxEnteringVehicles = new ListBox();
            buttonOpenFile = new Button();
            buttonSavePlate = new Button();
            buttonTag = new Button();
            buttonBinarySearch = new Button();
            buttonLinearSearch = new Button();
            groupBox1 = new GroupBox();
            buttonReset = new Button();
            textBoxRegoPlate = new TextBox();
            groupBox2 = new GroupBox();
            buttonAddPlates = new Button();
            buttonEditPlate = new Button();
            buttonDeletePlate = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listBoxExitingVehicles = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxEnteringVehicles
            // 
            listBoxEnteringVehicles.FormattingEnabled = true;
            listBoxEnteringVehicles.ItemHeight = 15;
            listBoxEnteringVehicles.Location = new Point(312, 116);
            listBoxEnteringVehicles.Name = "listBoxEnteringVehicles";
            listBoxEnteringVehicles.Size = new Size(182, 409);
            listBoxEnteringVehicles.TabIndex = 0;
            listBoxEnteringVehicles.SelectedIndexChanged += listBoxRegoPlates_SelectedIndexChanged;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(169, 71);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 23);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Open File";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonSavePlate
            // 
            buttonSavePlate.Location = new Point(6, 71);
            buttonSavePlate.Name = "buttonSavePlate";
            buttonSavePlate.Size = new Size(75, 23);
            buttonSavePlate.TabIndex = 3;
            buttonSavePlate.Text = "Save Plate";
            buttonSavePlate.UseVisualStyleBackColor = true;
            buttonSavePlate.UseWaitCursor = true;
            buttonSavePlate.Click += buttonSaveData_Click;
            // 
            // buttonTag
            // 
            buttonTag.Location = new Point(136, 77);
            buttonTag.Name = "buttonTag";
            buttonTag.Size = new Size(75, 23);
            buttonTag.TabIndex = 5;
            buttonTag.Text = "Tag";
            buttonTag.UseVisualStyleBackColor = true;
            buttonTag.Click += buttonTag_Click;
            // 
            // buttonBinarySearch
            // 
            buttonBinarySearch.Location = new Point(115, 40);
            buttonBinarySearch.Name = "buttonBinarySearch";
            buttonBinarySearch.Size = new Size(75, 23);
            buttonBinarySearch.TabIndex = 6;
            buttonBinarySearch.Text = "B Search";
            buttonBinarySearch.UseVisualStyleBackColor = true;
            buttonBinarySearch.Click += buttonBinarySearch_Click;
            // 
            // buttonLinearSearch
            // 
            buttonLinearSearch.Location = new Point(34, 40);
            buttonLinearSearch.Name = "buttonLinearSearch";
            buttonLinearSearch.Size = new Size(75, 23);
            buttonLinearSearch.TabIndex = 7;
            buttonLinearSearch.Text = "L Search";
            buttonLinearSearch.UseVisualStyleBackColor = true;
            buttonLinearSearch.Click += buttonLinearSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonReset);
            groupBox1.Controls.Add(textBoxRegoPlate);
            groupBox1.Controls.Add(buttonSavePlate);
            groupBox1.Controls.Add(buttonOpenFile);
            groupBox1.Location = new Point(22, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rego Plates File";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(88, 71);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.UseWaitCursor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // textBoxRegoPlate
            // 
            textBoxRegoPlate.Location = new Point(79, 39);
            textBoxRegoPlate.Name = "textBoxRegoPlate";
            textBoxRegoPlate.Size = new Size(104, 23);
            textBoxRegoPlate.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonLinearSearch);
            groupBox2.Controls.Add(buttonBinarySearch);
            groupBox2.Location = new Point(28, 373);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 81);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Searching Rego";
            // 
            // buttonAddPlates
            // 
            buttonAddPlates.Location = new Point(43, 46);
            buttonAddPlates.Name = "buttonAddPlates";
            buttonAddPlates.Size = new Size(75, 23);
            buttonAddPlates.TabIndex = 10;
            buttonAddPlates.Text = "Add";
            buttonAddPlates.UseVisualStyleBackColor = true;
            buttonAddPlates.Click += buttonAdd_Click;
            // 
            // buttonEditPlate
            // 
            buttonEditPlate.Location = new Point(136, 46);
            buttonEditPlate.Name = "buttonEditPlate";
            buttonEditPlate.Size = new Size(75, 23);
            buttonEditPlate.TabIndex = 11;
            buttonEditPlate.Text = "Edit";
            buttonEditPlate.UseVisualStyleBackColor = true;
            buttonEditPlate.Click += buttonEditPlate_Click;
            // 
            // buttonDeletePlate
            // 
            buttonDeletePlate.Location = new Point(43, 77);
            buttonDeletePlate.Name = "buttonDeletePlate";
            buttonDeletePlate.Size = new Size(75, 23);
            buttonDeletePlate.TabIndex = 12;
            buttonDeletePlate.Text = "Delete";
            buttonDeletePlate.UseVisualStyleBackColor = true;
            buttonDeletePlate.Click += buttonDelete_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonDeletePlate);
            groupBox3.Controls.Add(buttonEditPlate);
            groupBox3.Controls.Add(buttonAddPlates);
            groupBox3.Controls.Add(buttonTag);
            groupBox3.Location = new Point(22, 219);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 136);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Use Data Rego ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(101, 22);
            label1.Name = "label1";
            label1.Size = new Size(361, 54);
            label1.TabIndex = 14;
            label1.Text = "Active Systems PTY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(468, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBoxExitingVehicles
            // 
            listBoxExitingVehicles.FormattingEnabled = true;
            listBoxExitingVehicles.ItemHeight = 15;
            listBoxExitingVehicles.Location = new Point(514, 116);
            listBoxExitingVehicles.Name = "listBoxExitingVehicles";
            listBoxExitingVehicles.Size = new Size(179, 409);
            listBoxExitingVehicles.TabIndex = 16;
            // 
            // CarParkTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 630);
            Controls.Add(listBoxExitingVehicles);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBoxEnteringVehicles);
            Name = "CarParkTracking";
            Text = "CarParkTracking";
            Load += CarParkTracking_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEnteringVehicles;
        private Button buttonOpenFile;
        private Button buttonSavePlate;
        private Button buttonReset;
        private Button buttonTag;
        private Button buttonBinarySearch;
        private Button buttonLinearSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxRegoPlate;
        private Button buttonAddPlates;
        private Button buttonEditPlate;
        private Button buttonDeletePlate;
        private GroupBox groupBox3;
        private Label label1;
        private PictureBox pictureBox1;
        private ListBox listBoxExitingVehicles;
       
    }
}
