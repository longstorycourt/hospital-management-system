namespace Hospital_Management
{
    partial class ucAdmissionInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dateTimeAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textSymptoms = new System.Windows.Forms.TextBox();
            this.textSeach = new System.Windows.Forms.TextBox();
            this.textPrescriptions = new System.Windows.Forms.TextBox();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.textDoctorID = new System.Windows.Forms.TextBox();
            this.textPatientID = new System.Windows.Forms.TextBox();
            this.textAdmissionID = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelAdmissionReason = new System.Windows.Forms.Label();
            this.labelPrescriptions = new System.Windows.Forms.Label();
            this.labelDischargeNotes = new System.Windows.Forms.Label();
            this.labelDoctorID = new System.Windows.Forms.Label();
            this.labelAdmissionDate = new System.Windows.Forms.Label();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.labelDischargeDate = new System.Windows.Forms.Label();
            this.labelAdmissionID = new System.Windows.Forms.Label();
            this.labelAdmission = new System.Windows.Forms.Label();
            this.dateTimeDischargeDate = new System.Windows.Forms.DateTimePicker();
            this.labelAdmittedBy = new System.Windows.Forms.Label();
            this.textAdmittedBy = new System.Windows.Forms.TextBox();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.textRoomID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 460);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 217);
            this.dataGridView1.TabIndex = 130;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAll.Location = new System.Drawing.Point(302, 345);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(84, 30);
            this.buttonSaveAll.TabIndex = 129;
            this.buttonSaveAll.Text = "Save All";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(157, 345);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(81, 30);
            this.buttonUpdate.TabIndex = 128;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(22, 345);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(78, 30);
            this.buttonNew.TabIndex = 127;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // dateTimeAdmissionDate
            // 
            this.dateTimeAdmissionDate.Location = new System.Drawing.Point(171, 114);
            this.dateTimeAdmissionDate.Name = "dateTimeAdmissionDate";
            this.dateTimeAdmissionDate.Size = new System.Drawing.Size(215, 22);
            this.dateTimeAdmissionDate.TabIndex = 125;
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textStatus.Location = new System.Drawing.Point(171, 232);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(215, 32);
            this.textStatus.TabIndex = 122;
            // 
            // textSymptoms
            // 
            this.textSymptoms.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textSymptoms.Location = new System.Drawing.Point(171, 189);
            this.textSymptoms.Multiline = true;
            this.textSymptoms.Name = "textSymptoms";
            this.textSymptoms.Size = new System.Drawing.Size(215, 32);
            this.textSymptoms.TabIndex = 121;
            // 
            // textSeach
            // 
            this.textSeach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textSeach.Location = new System.Drawing.Point(521, 409);
            this.textSeach.Multiline = true;
            this.textSeach.Name = "textSeach";
            this.textSeach.Size = new System.Drawing.Size(310, 32);
            this.textSeach.TabIndex = 119;
            // 
            // textPrescriptions
            // 
            this.textPrescriptions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textPrescriptions.Location = new System.Drawing.Point(171, 278);
            this.textPrescriptions.Multiline = true;
            this.textPrescriptions.Name = "textPrescriptions";
            this.textPrescriptions.Size = new System.Drawing.Size(215, 32);
            this.textPrescriptions.TabIndex = 118;
            // 
            // textNotes
            // 
            this.textNotes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textNotes.Location = new System.Drawing.Point(457, 278);
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(374, 112);
            this.textNotes.TabIndex = 117;
            // 
            // textDoctorID
            // 
            this.textDoctorID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textDoctorID.Location = new System.Drawing.Point(532, 104);
            this.textDoctorID.Multiline = true;
            this.textDoctorID.Name = "textDoctorID";
            this.textDoctorID.Size = new System.Drawing.Size(215, 32);
            this.textDoctorID.TabIndex = 115;
            // 
            // textPatientID
            // 
            this.textPatientID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textPatientID.Location = new System.Drawing.Point(532, 59);
            this.textPatientID.Multiline = true;
            this.textPatientID.Name = "textPatientID";
            this.textPatientID.Size = new System.Drawing.Size(215, 32);
            this.textPatientID.TabIndex = 116;
            // 
            // textAdmissionID
            // 
            this.textAdmissionID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textAdmissionID.Location = new System.Drawing.Point(171, 67);
            this.textAdmissionID.Multiline = true;
            this.textAdmissionID.Name = "textAdmissionID";
            this.textAdmissionID.Size = new System.Drawing.Size(215, 32);
            this.textAdmissionID.TabIndex = 114;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(18, 236);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(66, 21);
            this.labelStatus.TabIndex = 110;
            this.labelStatus.Text = "Status:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(453, 413);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(72, 21);
            this.labelSearch.TabIndex = 109;
            this.labelSearch.Text = "Search:";
            // 
            // labelAdmissionReason
            // 
            this.labelAdmissionReason.AutoSize = true;
            this.labelAdmissionReason.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmissionReason.Location = new System.Drawing.Point(18, 194);
            this.labelAdmissionReason.Name = "labelAdmissionReason";
            this.labelAdmissionReason.Size = new System.Drawing.Size(158, 21);
            this.labelAdmissionReason.TabIndex = 108;
            this.labelAdmissionReason.Text = "AdmissionReason:";
            // 
            // labelPrescriptions
            // 
            this.labelPrescriptions.AutoSize = true;
            this.labelPrescriptions.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrescriptions.Location = new System.Drawing.Point(19, 285);
            this.labelPrescriptions.Name = "labelPrescriptions";
            this.labelPrescriptions.Size = new System.Drawing.Size(119, 21);
            this.labelPrescriptions.TabIndex = 107;
            this.labelPrescriptions.Text = "Prescriptions:";
            // 
            // labelDischargeNotes
            // 
            this.labelDischargeNotes.AutoSize = true;
            this.labelDischargeNotes.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDischargeNotes.Location = new System.Drawing.Point(400, 254);
            this.labelDischargeNotes.Name = "labelDischargeNotes";
            this.labelDischargeNotes.Size = new System.Drawing.Size(143, 21);
            this.labelDischargeNotes.TabIndex = 106;
            this.labelDischargeNotes.Text = "DischargeNotes:";
            // 
            // labelDoctorID
            // 
            this.labelDoctorID.AutoSize = true;
            this.labelDoctorID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorID.Location = new System.Drawing.Point(400, 114);
            this.labelDoctorID.Name = "labelDoctorID";
            this.labelDoctorID.Size = new System.Drawing.Size(90, 21);
            this.labelDoctorID.TabIndex = 103;
            this.labelDoctorID.Text = "Doctor ID:";
            // 
            // labelAdmissionDate
            // 
            this.labelAdmissionDate.AutoSize = true;
            this.labelAdmissionDate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmissionDate.Location = new System.Drawing.Point(18, 114);
            this.labelAdmissionDate.Name = "labelAdmissionDate";
            this.labelAdmissionDate.Size = new System.Drawing.Size(139, 21);
            this.labelAdmissionDate.TabIndex = 104;
            this.labelAdmissionDate.Text = "Admission Date:";
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientID.Location = new System.Drawing.Point(400, 69);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(93, 21);
            this.labelPatientID.TabIndex = 102;
            this.labelPatientID.Text = "Patient ID:";
            // 
            // labelDischargeDate
            // 
            this.labelDischargeDate.AutoSize = true;
            this.labelDischargeDate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDischargeDate.Location = new System.Drawing.Point(18, 155);
            this.labelDischargeDate.Name = "labelDischargeDate";
            this.labelDischargeDate.Size = new System.Drawing.Size(139, 21);
            this.labelDischargeDate.TabIndex = 101;
            this.labelDischargeDate.Text = "Discharge Date:";
            // 
            // labelAdmissionID
            // 
            this.labelAdmissionID.AutoSize = true;
            this.labelAdmissionID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmissionID.Location = new System.Drawing.Point(19, 70);
            this.labelAdmissionID.Name = "labelAdmissionID";
            this.labelAdmissionID.Size = new System.Drawing.Size(118, 21);
            this.labelAdmissionID.TabIndex = 113;
            this.labelAdmissionID.Text = "Admission ID:";
            // 
            // labelAdmission
            // 
            this.labelAdmission.AutoSize = true;
            this.labelAdmission.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmission.Location = new System.Drawing.Point(287, 11);
            this.labelAdmission.Name = "labelAdmission";
            this.labelAdmission.Size = new System.Drawing.Size(361, 38);
            this.labelAdmission.TabIndex = 99;
            this.labelAdmission.Text = "Admission Management";
            // 
            // dateTimeDischargeDate
            // 
            this.dateTimeDischargeDate.Location = new System.Drawing.Point(171, 154);
            this.dateTimeDischargeDate.Name = "dateTimeDischargeDate";
            this.dateTimeDischargeDate.Size = new System.Drawing.Size(215, 22);
            this.dateTimeDischargeDate.TabIndex = 125;
            // 
            // labelAdmittedBy
            // 
            this.labelAdmittedBy.AutoSize = true;
            this.labelAdmittedBy.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmittedBy.Location = new System.Drawing.Point(400, 199);
            this.labelAdmittedBy.Name = "labelAdmittedBy";
            this.labelAdmittedBy.Size = new System.Drawing.Size(110, 21);
            this.labelAdmittedBy.TabIndex = 103;
            this.labelAdmittedBy.Text = "Admitted By:";
            // 
            // textAdmittedBy
            // 
            this.textAdmittedBy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textAdmittedBy.Location = new System.Drawing.Point(532, 189);
            this.textAdmittedBy.Multiline = true;
            this.textAdmittedBy.Name = "textAdmittedBy";
            this.textAdmittedBy.Size = new System.Drawing.Size(215, 32);
            this.textAdmittedBy.TabIndex = 115;
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomID.Location = new System.Drawing.Point(400, 156);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(84, 21);
            this.labelRoomID.TabIndex = 103;
            this.labelRoomID.Text = "Room ID:";
            // 
            // textRoomID
            // 
            this.textRoomID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textRoomID.Location = new System.Drawing.Point(532, 146);
            this.textRoomID.Multiline = true;
            this.textRoomID.Name = "textRoomID";
            this.textRoomID.Size = new System.Drawing.Size(215, 32);
            this.textRoomID.TabIndex = 115;
            // 
            // ucAdmissionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dateTimeDischargeDate);
            this.Controls.Add(this.dateTimeAdmissionDate);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textSymptoms);
            this.Controls.Add(this.textSeach);
            this.Controls.Add(this.textPrescriptions);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.textAdmittedBy);
            this.Controls.Add(this.textRoomID);
            this.Controls.Add(this.textDoctorID);
            this.Controls.Add(this.textPatientID);
            this.Controls.Add(this.textAdmissionID);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelAdmissionReason);
            this.Controls.Add(this.labelPrescriptions);
            this.Controls.Add(this.labelAdmittedBy);
            this.Controls.Add(this.labelRoomID);
            this.Controls.Add(this.labelDischargeNotes);
            this.Controls.Add(this.labelDoctorID);
            this.Controls.Add(this.labelAdmissionDate);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.labelDischargeDate);
            this.Controls.Add(this.labelAdmissionID);
            this.Controls.Add(this.labelAdmission);
            this.Name = "ucAdmissionInfo";
            this.Size = new System.Drawing.Size(1079, 771);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DateTimePicker dateTimeAdmissionDate;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.TextBox textSymptoms;
        private System.Windows.Forms.TextBox textSeach;
        private System.Windows.Forms.TextBox textPrescriptions;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.TextBox textDoctorID;
        private System.Windows.Forms.TextBox textPatientID;
        private System.Windows.Forms.TextBox textAdmissionID;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelAdmissionReason;
        private System.Windows.Forms.Label labelPrescriptions;
        private System.Windows.Forms.Label labelDischargeNotes;
        private System.Windows.Forms.Label labelDoctorID;
        private System.Windows.Forms.Label labelAdmissionDate;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.Label labelDischargeDate;
        private System.Windows.Forms.Label labelAdmissionID;
        private System.Windows.Forms.Label labelAdmission;
        private System.Windows.Forms.DateTimePicker dateTimeDischargeDate;
        private System.Windows.Forms.Label labelAdmittedBy;
        private System.Windows.Forms.TextBox textAdmittedBy;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.TextBox textRoomID;
    }
}
