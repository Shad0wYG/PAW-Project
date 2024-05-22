namespace PawProj
{
    partial class LogForm
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
            this.components = new System.ComponentModel.Container();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lDateOfBirth = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.lFullName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lWebsite = new System.Windows.Forms.Label();
            this.btnLogCancel = new System.Windows.Forms.Button();
            this.btnLogOK = new System.Windows.Forms.Button();
            this.cbWebsite = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(324, 44);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(331, 27);
            this.dtpDOB.TabIndex = 0;
            this.dtpDOB.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDOB_Validating);
            // 
            // lDateOfBirth
            // 
            this.lDateOfBirth.AutoSize = true;
            this.lDateOfBirth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateOfBirth.Location = new System.Drawing.Point(109, 49);
            this.lDateOfBirth.Name = "lDateOfBirth";
            this.lDateOfBirth.Size = new System.Drawing.Size(168, 20);
            this.lDateOfBirth.TabIndex = 1;
            this.lDateOfBirth.Text = "User\'s Date of Birth";
            this.lDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(109, 108);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(93, 20);
            this.lUserName.TabIndex = 4;
            this.lUserName.Text = "Username";
            this.lUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFullName
            // 
            this.lFullName.AutoSize = true;
            this.lFullName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFullName.Location = new System.Drawing.Point(109, 175);
            this.lFullName.Name = "lFullName";
            this.lFullName.Size = new System.Drawing.Size(147, 20);
            this.lFullName.TabIndex = 5;
            this.lFullName.Text = "User\'s Full Name";
            this.lFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(324, 108);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(331, 22);
            this.tbUserName.TabIndex = 6;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(324, 173);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(331, 22);
            this.tbFullName.TabIndex = 7;
            this.tbFullName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFullName_Validating);
            // 
            // lWebsite
            // 
            this.lWebsite.AutoSize = true;
            this.lWebsite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWebsite.Location = new System.Drawing.Point(109, 252);
            this.lWebsite.Name = "lWebsite";
            this.lWebsite.Size = new System.Drawing.Size(161, 20);
            this.lWebsite.TabIndex = 9;
            this.lWebsite.Text = "Accessed Website";
            this.lWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogCancel
            // 
            this.btnLogCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogCancel.Location = new System.Drawing.Point(12, 385);
            this.btnLogCancel.Name = "btnLogCancel";
            this.btnLogCancel.Size = new System.Drawing.Size(83, 53);
            this.btnLogCancel.TabIndex = 11;
            this.btnLogCancel.Text = "Cancel";
            this.btnLogCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogOK
            // 
            this.btnLogOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogOK.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOK.Location = new System.Drawing.Point(705, 385);
            this.btnLogOK.Name = "btnLogOK";
            this.btnLogOK.Size = new System.Drawing.Size(83, 53);
            this.btnLogOK.TabIndex = 13;
            this.btnLogOK.Text = "OK";
            this.btnLogOK.UseVisualStyleBackColor = true;
            this.btnLogOK.Click += new System.EventHandler(this.btnLogOK_Click);
            // 
            // cbWebsite
            // 
            this.cbWebsite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWebsite.FormattingEnabled = true;
            this.cbWebsite.Items.AddRange(new object[] {
            "Amazon",
            "Emag",
            "Etsy",
            "INSSE",
            "Instagram",
            "Statista",
            "TikTok",
            "TradingEconomics",
            "WhatsApp"});
            this.cbWebsite.Location = new System.Drawing.Point(324, 248);
            this.cbWebsite.Name = "cbWebsite";
            this.cbWebsite.Size = new System.Drawing.Size(331, 26);
            this.cbWebsite.TabIndex = 14;
            this.cbWebsite.Validating += new System.ComponentModel.CancelEventHandler(this.cbWebsite_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbWebsite);
            this.Controls.Add(this.btnLogOK);
            this.Controls.Add(this.btnLogCancel);
            this.Controls.Add(this.lWebsite);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lFullName);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.lDateOfBirth);
            this.Controls.Add(this.dtpDOB);
            this.Name = "LogForm";
            this.Text = "Log the Website Access Information";
            this.Load += new System.EventHandler(this.LogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lDateOfBirth;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label lFullName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lWebsite;
        private System.Windows.Forms.Button btnLogCancel;
        private System.Windows.Forms.Button btnLogOK;
        private System.Windows.Forms.ComboBox cbWebsite;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}