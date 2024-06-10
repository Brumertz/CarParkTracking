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
            listBoxRegoPlates = new ListBox();
            textBoxRegoPlates = new TextBox();
            buttonOpenFile = new Button();
            buttonSaveData = new Button();
            buttonReset = new Button();
            buttonTag = new Button();
            buttonBinarySearch = new Button();
            buttonLinearSearch = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listBoxVehicleInf = new ListBox();
            label2 = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxRegoPlates
            // 
            listBoxRegoPlates.FormattingEnabled = true;
            listBoxRegoPlates.ItemHeight = 15;
            listBoxRegoPlates.Location = new Point(291, 116);
            listBoxRegoPlates.Name = "listBoxRegoPlates";
            listBoxRegoPlates.Size = new Size(182, 409);
            listBoxRegoPlates.TabIndex = 0;
            listBoxRegoPlates.SelectedIndexChanged += listBoxRegoPlates_SelectedIndexChanged;
            // 
            // textBoxRegoPlates
            // 
            textBoxRegoPlates.Location = new Point(56, 22);
            textBoxRegoPlates.Name = "textBoxRegoPlates";
            textBoxRegoPlates.Size = new Size(106, 23);
            textBoxRegoPlates.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(6, 31);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 23);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Open File";
            buttonOpenFile.UseVisualStyleBackColor = true;
            // 
            // buttonSaveData
            // 
            buttonSaveData.Location = new Point(100, 31);
            buttonSaveData.Name = "buttonSaveData";
            buttonSaveData.Size = new Size(75, 23);
            buttonSaveData.TabIndex = 3;
            buttonSaveData.Text = "Save Data";
            buttonSaveData.UseVisualStyleBackColor = true;
            buttonSaveData.UseWaitCursor = true;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(6, 71);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonTag
            // 
            buttonTag.Location = new Point(110, 57);
            buttonTag.Name = "buttonTag";
            buttonTag.Size = new Size(75, 23);
            buttonTag.TabIndex = 5;
            buttonTag.Text = "Tag";
            buttonTag.UseVisualStyleBackColor = true;
            // 
            // buttonBinarySearch
            // 
            buttonBinarySearch.Location = new Point(115, 51);
            buttonBinarySearch.Name = "buttonBinarySearch";
            buttonBinarySearch.Size = new Size(75, 23);
            buttonBinarySearch.TabIndex = 6;
            buttonBinarySearch.Text = "B Search";
            buttonBinarySearch.UseVisualStyleBackColor = true;
            // 
            // buttonLinearSearch
            // 
            buttonLinearSearch.Location = new Point(17, 51);
            buttonLinearSearch.Name = "buttonLinearSearch";
            buttonLinearSearch.Size = new Size(75, 23);
            buttonLinearSearch.TabIndex = 7;
            buttonLinearSearch.Text = "L Search";
            buttonLinearSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonReset);
            groupBox1.Controls.Add(buttonSaveData);
            groupBox1.Controls.Add(buttonOpenFile);
            groupBox1.Location = new Point(22, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rego Plates File";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonLinearSearch);
            groupBox2.Controls.Add(buttonBinarySearch);
            groupBox2.Controls.Add(textBoxRegoPlates);
            groupBox2.Location = new Point(22, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 122);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Searching Rego";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 23);
            textBox1.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(17, 26);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(110, 26);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(17, 57);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(buttonDelete);
            groupBox3.Controls.Add(buttonEdit);
            groupBox3.Controls.Add(buttonAdd);
            groupBox3.Controls.Add(buttonTag);
            groupBox3.Location = new Point(22, 219);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(242, 174);
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
            // listBoxVehicleInf
            // 
            listBoxVehicleInf.FormattingEnabled = true;
            listBoxVehicleInf.ItemHeight = 15;
            listBoxVehicleInf.Location = new Point(493, 116);
            listBoxVehicleInf.Name = "listBoxVehicleInf";
            listBoxVehicleInf.Size = new Size(179, 409);
            listBoxVehicleInf.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 547);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 18;
            label2.Text = "User Feedback";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 565);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 19);
            listBox1.TabIndex = 19;
            // 
            // CarParkTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 627);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(listBoxVehicleInf);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBoxRegoPlates);
            Name = "CarParkTracking";
            Text = "CarParkTracking";
            Load += CarParkTracking_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRegoPlates;
        private TextBox textBoxRegoPlates;
        private Button buttonOpenFile;
        private Button buttonSaveData;
        private Button buttonReset;
        private Button buttonTag;
        private Button buttonBinarySearch;
        private Button buttonLinearSearch;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private GroupBox groupBox3;
        private Label label1;
        private PictureBox pictureBox1;
        private ListBox listBoxVehicleInf;
        private Label label2;
        private ListBox listBox1;
    }
}
