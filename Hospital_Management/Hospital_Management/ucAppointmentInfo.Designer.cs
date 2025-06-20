namespace Hospital_Management
{
    partial class ucAppointmentInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelAppointmentManagement = new System.Windows.Forms.Label();
            this.labelAppointmentID = new System.Windows.Forms.Label();
            this.labelAppointmentDate = new System.Windows.Forms.Label();
            this.labelAppointmentTime = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelreason = new System.Windows.Forms.Label();
            this.labelCreatedDate = new System.Windows.Forms.Label();
            this.labelModifiedDate = new System.Windows.Forms.Label();
            this.labelAppointmentType = new System.Windows.Forms.Label();
            this.textAppointmentID = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textDuration = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.textType = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textReason = new System.Windows.Forms.TextBox();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.labelDoctorID = new System.Windows.Forms.Label();
            this.textPatientID = new System.Windows.Forms.TextBox();
            this.textDoctorID = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.textCreatedBy = new System.Windows.Forms.TextBox();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textSeach = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppointmentManagement
            // 
            this.labelAppointmentManagement.AutoSize = true;
            this.labelAppointmentManagement.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentManagement.Location = new System.Drawing.Point(290, 11);
            this.labelAppointmentManagement.Name = "labelAppointmentManagement";
            this.labelAppointmentManagement.Size = new System.Drawing.Size(404, 39);
            this.labelAppointmentManagement.TabIndex = 0;
            this.labelAppointmentManagement.Text = "Appointment Management";
            // 
            // labelAppointmentID
            // 
            this.labelAppointmentID.AutoSize = true;
            this.labelAppointmentID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentID.Location = new System.Drawing.Point(21, 70);
            this.labelAppointmentID.Name = "labelAppointmentID";
            this.labelAppointmentID.Size = new System.Drawing.Size(136, 21);
            this.labelAppointmentID.TabIndex = 0;
            this.labelAppointmentID.Text = "Appointment ID:";
            // 
            // labelAppointmentDate
            // 
            this.labelAppointmentDate.AutoSize = true;
            this.labelAppointmentDate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentDate.Location = new System.Drawing.Point(21, 113);
            this.labelAppointmentDate.Name = "labelAppointmentDate";
            this.labelAppointmentDate.Size = new System.Drawing.Size(157, 21);
            this.labelAppointmentDate.TabIndex = 0;
            this.labelAppointmentDate.Text = "Appointment Date:";
            // 
            // labelAppointmentTime
            // 
            this.labelAppointmentTime.AutoSize = true;
            this.labelAppointmentTime.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentTime.Location = new System.Drawing.Point(21, 155);
            this.labelAppointmentTime.Name = "labelAppointmentTime";
            this.labelAppointmentTime.Size = new System.Drawing.Size(158, 21);
            this.labelAppointmentTime.TabIndex = 0;
            this.labelAppointmentTime.Text = "Appointment Time:";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(21, 197);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(83, 21);
            this.labelDuration.TabIndex = 0;
            this.labelDuration.Text = "Duration:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(21, 282);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 21);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status:";
            // 
            // labelreason
            // 
            this.labelreason.AutoSize = true;
            this.labelreason.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreason.Location = new System.Drawing.Point(21, 322);
            this.labelreason.Name = "labelreason";
            this.labelreason.Size = new System.Drawing.Size(77, 21);
            this.labelreason.TabIndex = 0;
            this.labelreason.Text = "Reason:";
            // 
            // labelCreatedDate
            // 
            this.labelCreatedDate.AutoSize = true;
            this.labelCreatedDate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedDate.Location = new System.Drawing.Point(21, 365);
            this.labelCreatedDate.Name = "labelCreatedDate";
            this.labelCreatedDate.Size = new System.Drawing.Size(122, 21);
            this.labelCreatedDate.TabIndex = 0;
            this.labelCreatedDate.Text = "Created Date:";
            // 
            // labelModifiedDate
            // 
            this.labelModifiedDate.AutoSize = true;
            this.labelModifiedDate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifiedDate.Location = new System.Drawing.Point(21, 407);
            this.labelModifiedDate.Name = "labelModifiedDate";
            this.labelModifiedDate.Size = new System.Drawing.Size(126, 21);
            this.labelModifiedDate.TabIndex = 0;
            this.labelModifiedDate.Text = "Modified Date:";
            // 
            // labelAppointmentType
            // 
            this.labelAppointmentType.AutoSize = true;
            this.labelAppointmentType.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentType.Location = new System.Drawing.Point(21, 240);
            this.labelAppointmentType.Name = "labelAppointmentType";
            this.labelAppointmentType.Size = new System.Drawing.Size(159, 21);
            this.labelAppointmentType.TabIndex = 0;
            this.labelAppointmentType.Text = "Appointment Type:";
            // 
            // textAppointmentID
            // 
            this.textAppointmentID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textAppointmentID.Location = new System.Drawing.Point(174, 67);
            this.textAppointmentID.Multiline = true;
            this.textAppointmentID.Name = "textAppointmentID";
            this.textAppointmentID.Size = new System.Drawing.Size(215, 32);
            this.textAppointmentID.TabIndex = 1;
            // 
            // textTime
            // 
            this.textTime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textTime.Location = new System.Drawing.Point(174, 149);
            this.textTime.Multiline = true;
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(215, 32);
            this.textTime.TabIndex = 1;
            // 
            // textDuration
            // 
            this.textDuration.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textDuration.Location = new System.Drawing.Point(174, 191);
            this.textDuration.Multiline = true;
            this.textDuration.Name = "textDuration";
            this.textDuration.Size = new System.Drawing.Size(215, 32);
            this.textDuration.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(174, 364);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(174, 407);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // textType
            // 
            this.textType.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textType.Location = new System.Drawing.Point(174, 235);
            this.textType.Multiline = true;
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(215, 32);
            this.textType.TabIndex = 1;
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textStatus.Location = new System.Drawing.Point(174, 278);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(215, 32);
            this.textStatus.TabIndex = 1;
            // 
            // textReason
            // 
            this.textReason.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textReason.Location = new System.Drawing.Point(174, 316);
            this.textReason.Multiline = true;
            this.textReason.Name = "textReason";
            this.textReason.Size = new System.Drawing.Size(215, 32);
            this.textReason.TabIndex = 1;
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientID.Location = new System.Drawing.Point(403, 70);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(93, 21);
            this.labelPatientID.TabIndex = 0;
            this.labelPatientID.Text = "Patient ID:";
            // 
            // labelDoctorID
            // 
            this.labelDoctorID.AutoSize = true;
            this.labelDoctorID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorID.Location = new System.Drawing.Point(403, 113);
            this.labelDoctorID.Name = "labelDoctorID";
            this.labelDoctorID.Size = new System.Drawing.Size(90, 21);
            this.labelDoctorID.TabIndex = 0;
            this.labelDoctorID.Text = "Doctor ID:";
            // 
            // textPatientID
            // 
            this.textPatientID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textPatientID.Location = new System.Drawing.Point(502, 67);
            this.textPatientID.Multiline = true;
            this.textPatientID.Name = "textPatientID";
            this.textPatientID.Size = new System.Drawing.Size(215, 32);
            this.textPatientID.TabIndex = 1;
            // 
            // textDoctorID
            // 
            this.textDoctorID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textDoctorID.Location = new System.Drawing.Point(502, 107);
            this.textDoctorID.Multiline = true;
            this.textDoctorID.Name = "textDoctorID";
            this.textDoctorID.Size = new System.Drawing.Size(215, 32);
            this.textDoctorID.TabIndex = 1;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(403, 155);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(62, 21);
            this.labelNotes.TabIndex = 0;
            this.labelNotes.Text = "Notes:";
            // 
            // textNotes
            // 
            this.textNotes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textNotes.Location = new System.Drawing.Point(502, 149);
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(332, 112);
            this.textNotes.TabIndex = 1;
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.Location = new System.Drawing.Point(403, 284);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(105, 21);
            this.labelCreatedBy.TabIndex = 0;
            this.labelCreatedBy.Text = "Created By:";
            // 
            // textCreatedBy
            // 
            this.textCreatedBy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textCreatedBy.Location = new System.Drawing.Point(502, 278);
            this.textCreatedBy.Multiline = true;
            this.textCreatedBy.Name = "textCreatedBy";
            this.textCreatedBy.Size = new System.Drawing.Size(215, 32);
            this.textCreatedBy.TabIndex = 1;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAll.Location = new System.Drawing.Point(750, 354);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(84, 30);
            this.buttonSaveAll.TabIndex = 64;
            this.buttonSaveAll.Text = "Save All";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(609, 354);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(81, 30);
            this.buttonUpdate.TabIndex = 63;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(459, 354);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(78, 30);
            this.buttonNew.TabIndex = 62;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(456, 413);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(72, 21);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";
            // 
            // textSeach
            // 
            this.textSeach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textSeach.Location = new System.Drawing.Point(609, 407);
            this.textSeach.Multiline = true;
            this.textSeach.Name = "textSeach";
            this.textSeach.Size = new System.Drawing.Size(225, 32);
            this.textSeach.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 460);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 217);
            this.dataGridView1.TabIndex = 65;
            // 
            // ucAppointmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textReason);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textDuration);
            this.Controls.Add(this.textSeach);
            this.Controls.Add(this.textCreatedBy);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.textDoctorID);
            this.Controls.Add(this.textPatientID);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.textAppointmentID);
            this.Controls.Add(this.labelModifiedDate);
            this.Controls.Add(this.labelCreatedDate);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelAppointmentType);
            this.Controls.Add(this.labelCreatedBy);
            this.Controls.Add(this.labelreason);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelAppointmentTime);
            this.Controls.Add(this.labelDoctorID);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.labelAppointmentDate);
            this.Controls.Add(this.labelAppointmentID);
            this.Controls.Add(this.labelAppointmentManagement);
            this.Name = "ucAppointmentInfo";
            this.Size = new System.Drawing.Size(1034, 747);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointmentManagement;
        private System.Windows.Forms.Label labelAppointmentID;
        private System.Windows.Forms.Label labelAppointmentDate;
        private System.Windows.Forms.Label labelAppointmentTime;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelreason;
        private System.Windows.Forms.Label labelCreatedDate;
        private System.Windows.Forms.Label labelModifiedDate;
        private System.Windows.Forms.Label labelAppointmentType;
        private System.Windows.Forms.TextBox textAppointmentID;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textDuration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.TextBox textReason;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.Label labelDoctorID;
        private System.Windows.Forms.TextBox textPatientID;
        private System.Windows.Forms.TextBox textDoctorID;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.TextBox textCreatedBy;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textSeach;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
