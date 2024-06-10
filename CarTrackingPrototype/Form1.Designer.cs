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
            components = new System.ComponentModel.Container();
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
            toolTipTextBox = new ToolTip(components);
            toolTipButtonSavePlate = new ToolTip(components);
            toolTipButtonReset = new ToolTip(components);
            toolTipButtonOpenFile = new ToolTip(components);
            toolTipButtonAddPlate = new ToolTip(components);
            toolTipButtonDeletePlate = new ToolTip(components);
            toolTipButtonEditPlate = new ToolTip(components);
            toolTipButtonTag = new ToolTip(components);
            toolTipButtonLinearSearch = new ToolTip(components);
            toolTipButtonBinarySearch = new ToolTip(components);
            toolTipListBoxEnteringVehicles = new ToolTip(components);
            toolTipListBoxExitingVehicles = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxEnteringVehicles
            // 
            listBoxEnteringVehicles.FormattingEnabled = true;
            listBoxEnteringVehicles.Location = new Point(357, 155);
            listBoxEnteringVehicles.Margin = new Padding(3, 4, 3, 4);
            listBoxEnteringVehicles.Name = "listBoxEnteringVehicles";
            listBoxEnteringVehicles.Size = new Size(207, 544);
            listBoxEnteringVehicles.TabIndex = 0;
            listBoxEnteringVehicles.SelectedIndexChanged += listBoxRegoPlates_SelectedIndexChanged;
            listBoxEnteringVehicles.DoubleClick += listBoxEnteringVehicles_DoubleClick;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(193, 95);
            buttonOpenFile.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(86, 31);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Open File";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonSavePlate
            // 
            buttonSavePlate.Location = new Point(7, 95);
            buttonSavePlate.Margin = new Padding(3, 4, 3, 4);
            buttonSavePlate.Name = "buttonSavePlate";
            buttonSavePlate.Size = new Size(86, 31);
            buttonSavePlate.TabIndex = 3;
            buttonSavePlate.Text = "Save Plate";
            buttonSavePlate.UseVisualStyleBackColor = true;
            buttonSavePlate.UseWaitCursor = true;
            buttonSavePlate.Click += buttonSaveData_Click;
            // 
            // buttonTag
            // 
            buttonTag.Location = new Point(155, 103);
            buttonTag.Margin = new Padding(3, 4, 3, 4);
            buttonTag.Name = "buttonTag";
            buttonTag.Size = new Size(86, 31);
            buttonTag.TabIndex = 5;
            buttonTag.Text = "Tag";
            buttonTag.UseVisualStyleBackColor = true;
            buttonTag.Click += buttonTag_Click;
            // 
            // buttonBinarySearch
            // 
            buttonBinarySearch.Location = new Point(131, 53);
            buttonBinarySearch.Margin = new Padding(3, 4, 3, 4);
            buttonBinarySearch.Name = "buttonBinarySearch";
            buttonBinarySearch.Size = new Size(86, 31);
            buttonBinarySearch.TabIndex = 6;
            buttonBinarySearch.Text = "B Search";
            buttonBinarySearch.UseVisualStyleBackColor = true;
            buttonBinarySearch.Click += buttonBinarySearch_Click;
            // 
            // buttonLinearSearch
            // 
            buttonLinearSearch.Location = new Point(39, 53);
            buttonLinearSearch.Margin = new Padding(3, 4, 3, 4);
            buttonLinearSearch.Name = "buttonLinearSearch";
            buttonLinearSearch.Size = new Size(86, 31);
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
            groupBox1.Location = new Point(25, 144);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(301, 133);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rego Plates File";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(101, 95);
            buttonReset.Margin = new Padding(3, 4, 3, 4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(86, 31);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.UseWaitCursor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // textBoxRegoPlate
            // 
            textBoxRegoPlate.Location = new Point(90, 52);
            textBoxRegoPlate.Margin = new Padding(3, 4, 3, 4);
            textBoxRegoPlate.Name = "textBoxRegoPlate";
            textBoxRegoPlate.Size = new Size(118, 27);
            textBoxRegoPlate.TabIndex = 5;
            textBoxRegoPlate.KeyPress += textBoxRegoPlate_KeyPress_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonLinearSearch);
            groupBox2.Controls.Add(buttonBinarySearch);
            groupBox2.Location = new Point(32, 497);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(301, 108);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Searching Rego";
            // 
            // buttonAddPlates
            // 
            buttonAddPlates.Location = new Point(49, 61);
            buttonAddPlates.Margin = new Padding(3, 4, 3, 4);
            buttonAddPlates.Name = "buttonAddPlates";
            buttonAddPlates.Size = new Size(86, 31);
            buttonAddPlates.TabIndex = 10;
            buttonAddPlates.Text = "Enter";
            buttonAddPlates.UseVisualStyleBackColor = true;
            buttonAddPlates.Click += buttonAdd_Click;
            // 
            // buttonEditPlate
            // 
            buttonEditPlate.Location = new Point(49, 103);
            buttonEditPlate.Margin = new Padding(3, 4, 3, 4);
            buttonEditPlate.Name = "buttonEditPlate";
            buttonEditPlate.Size = new Size(86, 31);
            buttonEditPlate.TabIndex = 11;
            buttonEditPlate.Text = "Edit";
            buttonEditPlate.UseVisualStyleBackColor = true;
            buttonEditPlate.Click += buttonEditPlate_Click;
            // 
            // buttonDeletePlate
            // 
            buttonDeletePlate.Location = new Point(155, 61);
            buttonDeletePlate.Margin = new Padding(3, 4, 3, 4);
            buttonDeletePlate.Name = "buttonDeletePlate";
            buttonDeletePlate.Size = new Size(86, 31);
            buttonDeletePlate.TabIndex = 12;
            buttonDeletePlate.Text = "Exit";
            buttonDeletePlate.UseVisualStyleBackColor = true;
            buttonDeletePlate.Click += buttonDelete_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonDeletePlate);
            groupBox3.Controls.Add(buttonEditPlate);
            groupBox3.Controls.Add(buttonAddPlates);
            groupBox3.Controls.Add(buttonTag);
            groupBox3.Location = new Point(25, 292);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(301, 181);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Use Data Rego ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(115, 29);
            label1.Name = "label1";
            label1.Size = new Size(452, 67);
            label1.TabIndex = 14;
            label1.Text = "Active Systems PTY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(597, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBoxExitingVehicles
            // 
            listBoxExitingVehicles.FormattingEnabled = true;
            listBoxExitingVehicles.Location = new Point(587, 155);
            listBoxExitingVehicles.Margin = new Padding(3, 4, 3, 4);
            listBoxExitingVehicles.Name = "listBoxExitingVehicles";
            listBoxExitingVehicles.Size = new Size(204, 544);
            listBoxExitingVehicles.TabIndex = 16;
            listBoxExitingVehicles.DoubleClick += listBoxExitingVehicles_DoubleClick;
            // 
            // CarParkTracking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 840);
            Controls.Add(listBoxExitingVehicles);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBoxEnteringVehicles);
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolTip toolTipTextBox;
        private ToolTip toolTipButtonSavePlate;
        private ToolTip toolTipButtonReset;
        private ToolTip toolTipButtonOpenFile;
        private ToolTip toolTipButtonAddPlate;
        private ToolTip toolTipButtonDeletePlate;
        private ToolTip toolTipButtonEditPlate;
        private ToolTip toolTipButtonTag;
        private ToolTip toolTipButtonLinearSearch;
        private ToolTip toolTipButtonBinarySearch;
        private ToolTip toolTipListBoxEnteringVehicles;
        private ToolTip toolTipListBoxExitingVehicles;
    }
}
