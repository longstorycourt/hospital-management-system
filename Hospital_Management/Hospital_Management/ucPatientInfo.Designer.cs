namespace Hospital_Management
{
    partial class ucPatientInfo
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
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelPatientInformation = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelpatientID = new System.Windows.Forms.Label();
            this.labelPatientNameEN = new System.Windows.Forms.Label();
            this.labelPatientNameKH = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBOD = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEmergencyContact = new System.Windows.Forms.Label();
            this.labelBloodType = new System.Windows.Forms.Label();
            this.labelEmergencyNumber = new System.Windows.Forms.Label();
            this.labelAllergies = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(51, 93);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 23);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelPatientInformation
            // 
            this.labelPatientInformation.AutoSize = true;
            this.labelPatientInformation.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientInformation.Location = new System.Drawing.Point(353, 22);
            this.labelPatientInformation.Name = "labelPatientInformation";
            this.labelPatientInformation.Size = new System.Drawing.Size(310, 35);
            this.labelPatientInformation.TabIndex = 0;
            this.labelPatientInformation.Text = "Patient\'s Information";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSearch.Location = new System.Drawing.Point(55, 129);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(303, 30);
            this.textBoxSearch.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 478);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // labelpatientID
            // 
            this.labelpatientID.AutoSize = true;
            this.labelpatientID.Location = new System.Drawing.Point(381, 178);
            this.labelpatientID.Name = "labelpatientID";
            this.labelpatientID.Size = new System.Drawing.Size(103, 23);
            this.labelpatientID.TabIndex = 0;
            this.labelpatientID.Text = "Patient ID:";
            this.labelpatientID.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelPatientNameEN
            // 
            this.labelPatientNameEN.AutoSize = true;
            this.labelPatientNameEN.Location = new System.Drawing.Point(381, 218);
            this.labelPatientNameEN.Name = "labelPatientNameEN";
            this.labelPatientNameEN.Size = new System.Drawing.Size(194, 23);
            this.labelPatientNameEN.TabIndex = 0;
            this.labelPatientNameEN.Text = "Patient\'s Name (EN):";
            this.labelPatientNameEN.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelPatientNameKH
            // 
            this.labelPatientNameKH.AutoSize = true;
            this.labelPatientNameKH.Location = new System.Drawing.Point(381, 259);
            this.labelPatientNameKH.Name = "labelPatientNameKH";
            this.labelPatientNameKH.Size = new System.Drawing.Size(194, 23);
            this.labelPatientNameKH.TabIndex = 0;
            this.labelPatientNameKH.Text = "Patient\'s Name (KH):";
            this.labelPatientNameKH.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(381, 301);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(82, 23);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Gender:";
            this.labelGender.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelBOD
            // 
            this.labelBOD.AutoSize = true;
            this.labelBOD.Location = new System.Drawing.Point(381, 338);
            this.labelBOD.Name = "labelBOD";
            this.labelBOD.Size = new System.Drawing.Size(127, 23);
            this.labelBOD.TabIndex = 0;
            this.labelBOD.Text = "Birth of Date:";
            this.labelBOD.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(381, 379);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(145, 23);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Phone Number:";
            this.labelPhone.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(381, 420);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(89, 23);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            this.labelAddress.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(379, 465);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 23);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelEmergencyContact
            // 
            this.labelEmergencyContact.AutoSize = true;
            this.labelEmergencyContact.Location = new System.Drawing.Point(381, 512);
            this.labelEmergencyContact.Name = "labelEmergencyContact";
            this.labelEmergencyContact.Size = new System.Drawing.Size(189, 23);
            this.labelEmergencyContact.TabIndex = 0;
            this.labelEmergencyContact.Text = "Emergency Contact:";
            this.labelEmergencyContact.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelBloodType
            // 
            this.labelBloodType.AutoSize = true;
            this.labelBloodType.Location = new System.Drawing.Point(381, 599);
            this.labelBloodType.Name = "labelBloodType";
            this.labelBloodType.Size = new System.Drawing.Size(115, 23);
            this.labelBloodType.TabIndex = 0;
            this.labelBloodType.Text = "Blood Type:";
            this.labelBloodType.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelEmergencyNumber
            // 
            this.labelEmergencyNumber.AutoSize = true;
            this.labelEmergencyNumber.Location = new System.Drawing.Point(381, 555);
            this.labelEmergencyNumber.Name = "labelEmergencyNumber";
            this.labelEmergencyNumber.Size = new System.Drawing.Size(189, 23);
            this.labelEmergencyNumber.TabIndex = 0;
            this.labelEmergencyNumber.Text = "Emergency Number:";
            this.labelEmergencyNumber.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelAllergies
            // 
            this.labelAllergies.AutoSize = true;
            this.labelAllergies.Location = new System.Drawing.Point(379, 637);
            this.labelAllergies.Name = "labelAllergies";
            this.labelAllergies.Size = new System.Drawing.Size(91, 23);
            this.labelAllergies.TabIndex = 0;
            this.labelAllergies.Text = "Allergies:";
            this.labelAllergies.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(571, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(571, 215);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 30);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(571, 256);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(335, 30);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.Location = new System.Drawing.Point(571, 298);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(335, 30);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox5.Location = new System.Drawing.Point(571, 462);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(335, 30);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox6.Location = new System.Drawing.Point(571, 552);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(335, 30);
            this.textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox7.Location = new System.Drawing.Point(571, 634);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(335, 30);
            this.textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox8.Location = new System.Drawing.Point(571, 596);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(335, 30);
            this.textBox8.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox9.Location = new System.Drawing.Point(571, 509);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(335, 30);
            this.textBox9.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox10.Location = new System.Drawing.Point(571, 417);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(335, 30);
            this.textBox10.TabIndex = 1;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox11.Location = new System.Drawing.Point(571, 376);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(335, 30);
            this.textBox11.TabIndex = 1;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox12.Location = new System.Drawing.Point(571, 335);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(335, 30);
            this.textBox12.TabIndex = 1;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(385, 129);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(78, 30);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(598, 128);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(95, 30);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Location = new System.Drawing.Point(808, 129);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(98, 30);
            this.buttonSaveAll.TabIndex = 4;
            this.buttonSaveAll.Text = "Save All";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            // 
            // ucPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelPatientInformation);
            this.Controls.Add(this.labelEmergencyNumber);
            this.Controls.Add(this.labelAllergies);
            this.Controls.Add(this.labelBloodType);
            this.Controls.Add(this.labelEmergencyContact);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelBOD);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelPatientNameKH);
            this.Controls.Add(this.labelPatientNameEN);
            this.Controls.Add(this.labelpatientID);
            this.Controls.Add(this.labelSearch);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ucPatientInfo";
            this.Size = new System.Drawing.Size(927, 717);
            this.Load += new System.EventHandler(this.ucPatientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelPatientInformation;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelpatientID;
        private System.Windows.Forms.Label labelPatientNameEN;
        private System.Windows.Forms.Label labelPatientNameKH;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBOD;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEmergencyContact;
        private System.Windows.Forms.Label labelBloodType;
        private System.Windows.Forms.Label labelEmergencyNumber;
        private System.Windows.Forms.Label labelAllergies;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSaveAll;
    }
}
