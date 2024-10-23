namespace TaskForms
{
    partial class FormTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button buttonSubmit;
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelCriticity = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelEnvironment = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelpercent = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxCriticity = new System.Windows.Forms.ComboBox();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxPercent = new System.Windows.Forms.ComboBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.checkedListBoxEnvironment = new System.Windows.Forms.CheckedListBox();
            this.buttonNew = new System.Windows.Forms.Button();
            buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSubmit.ForeColor = System.Drawing.SystemColors.HighlightText;
            buttonSubmit.Location = new System.Drawing.Point(666, 617);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new System.Drawing.Size(87, 41);
            buttonSubmit.TabIndex = 27;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(45, 54);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(335, 54);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(70, 20);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Location";
            // 
            // labelCriticity
            // 
            this.labelCriticity.AutoSize = true;
            this.labelCriticity.Location = new System.Drawing.Point(335, 143);
            this.labelCriticity.Name = "labelCriticity";
            this.labelCriticity.Size = new System.Drawing.Size(59, 20);
            this.labelCriticity.TabIndex = 2;
            this.labelCriticity.Text = "Criticity";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(45, 143);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 20);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(45, 312);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(89, 20);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // labelEnvironment
            // 
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.Location = new System.Drawing.Point(637, 143);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(98, 20);
            this.labelEnvironment.TabIndex = 5;
            this.labelEnvironment.Text = "Environment";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(335, 462);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(140, 20);
            this.labelDuration.TabIndex = 6;
            this.labelDuration.Text = "Duration (in hours)";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(45, 462);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(83, 20);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Start Date";
            // 
            // labelpercent
            // 
            this.labelpercent.AutoSize = true;
            this.labelpercent.Location = new System.Drawing.Point(335, 535);
            this.labelpercent.Name = "labelpercent";
            this.labelpercent.Size = new System.Drawing.Size(133, 20);
            this.labelpercent.TabIndex = 8;
            this.labelpercent.Text = "Percent complete";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(45, 535);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(49, 77);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(268, 26);
            this.textBoxTitle.TabIndex = 11;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(49, 335);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(712, 96);
            this.richTextBoxDesc.TabIndex = 14;
            this.richTextBoxDesc.Text = "";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Incident",
            "Project",
            "Note",
            "Task"});
            this.comboBoxType.Location = new System.Drawing.Point(49, 181);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(268, 28);
            this.comboBoxType.TabIndex = 18;
            this.comboBoxType.Text = "Incident";
            // 
            // comboBoxCriticity
            // 
            this.comboBoxCriticity.DisplayMember = "Minor";
            this.comboBoxCriticity.FormattingEnabled = true;
            this.comboBoxCriticity.Items.AddRange(new object[] {
            "Minor",
            "Important",
            "Critical"});
            this.comboBoxCriticity.Location = new System.Drawing.Point(339, 181);
            this.comboBoxCriticity.Name = "comboBoxCriticity";
            this.comboBoxCriticity.Size = new System.Drawing.Size(272, 28);
            this.comboBoxCriticity.TabIndex = 19;
            this.comboBoxCriticity.Text = "Minor";
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.DecimalPlaces = 2;
            this.numericUpDownDuration.Increment = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.numericUpDownDuration.Location = new System.Drawing.Point(339, 485);
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(414, 26);
            this.numericUpDownDuration.TabIndex = 20;
            this.numericUpDownDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(49, 485);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(268, 26);
            this.dateTimePickerStartDate.TabIndex = 22;
            this.dateTimePickerStartDate.UseWaitCursor = true;
            this.dateTimePickerStartDate.Value = new System.DateTime(2024, 10, 23, 10, 44, 45, 0);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Planned",
            "In Proccess",
            "Finished"});
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(49, 558);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(268, 28);
            this.comboBoxStatus.TabIndex = 23;
            this.comboBoxStatus.Text = "Planned";
            // 
            // comboBoxPercent
            // 
            this.comboBoxPercent.FormattingEnabled = true;
            this.comboBoxPercent.Location = new System.Drawing.Point(339, 558);
            this.comboBoxPercent.Name = "comboBoxPercent";
            this.comboBoxPercent.Size = new System.Drawing.Size(414, 28);
            this.comboBoxPercent.TabIndex = 24;
            this.comboBoxPercent.Text = "0 %";
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(49, 602);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(315, 24);
            this.checkBoxEmail.TabIndex = 25;
            this.checkBoxEmail.Text = "Check here if you want to send an email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(550, 617);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 41);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "Barcelona",
            "Madrid",
            "Paris",
            "London",
            "Roma"});
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Barcelona",
            "Madrid",
            "Paris",
            "Londres",
            "Roma",
            "Porto"});
            this.comboBoxLocation.Location = new System.Drawing.Point(339, 77);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(422, 28);
            this.comboBoxLocation.TabIndex = 29;
            // 
            // checkedListBoxEnvironment
            // 
            this.checkedListBoxEnvironment.BackColor = System.Drawing.SystemColors.MenuBar;
            this.checkedListBoxEnvironment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxEnvironment.FormattingEnabled = true;
            this.checkedListBoxEnvironment.Items.AddRange(new object[] {
            "Prod",
            "Prepod",
            "Demo"});
            this.checkedListBoxEnvironment.Location = new System.Drawing.Point(641, 166);
            this.checkedListBoxEnvironment.Name = "checkedListBoxEnvironment";
            this.checkedListBoxEnvironment.Size = new System.Drawing.Size(120, 115);
            this.checkedListBoxEnvironment.TabIndex = 30;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(49, 645);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(108, 42);
            this.buttonNew.TabIndex = 31;
            this.buttonNew.Text = "New Form";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.checkedListBoxEnvironment);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(buttonSubmit);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.comboBoxPercent);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.comboBoxCriticity);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelpercent);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelEnvironment);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelCriticity);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormTask";
            this.Text = "Create New Task";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelCriticity;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelpercent;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxCriticity;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxPercent;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.CheckedListBox checkedListBoxEnvironment;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
    }
}
