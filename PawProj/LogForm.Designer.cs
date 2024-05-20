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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lDateOfBirth = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.lFullName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lWebsite = new System.Windows.Forms.Label();
            this.btnLogCancel = new System.Windows.Forms.Button();
            this.lExplainer = new System.Windows.Forms.Label();
            this.btnLogOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 44);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(331, 27);
            this.dateTimePicker1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(324, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 22);
            this.textBox3.TabIndex = 8;
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
            this.btnLogCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogCancel.Location = new System.Drawing.Point(12, 385);
            this.btnLogCancel.Name = "btnLogCancel";
            this.btnLogCancel.Size = new System.Drawing.Size(83, 53);
            this.btnLogCancel.TabIndex = 11;
            this.btnLogCancel.Text = "Cancel";
            this.btnLogCancel.UseVisualStyleBackColor = true;
            // 
            // lExplainer
            // 
            this.lExplainer.AutoSize = true;
            this.lExplainer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExplainer.Location = new System.Drawing.Point(38, 315);
            this.lExplainer.Name = "lExplainer";
            this.lExplainer.Size = new System.Drawing.Size(691, 15);
            this.lExplainer.TabIndex = 12;
            this.lExplainer.Text = "*Available Websites: Tiktok, Instagram, Whatsapp, Amazon, Etsy, Emag, Insse, Stat" +
    "ista, TradingEconomics";
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
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOK);
            this.Controls.Add(this.lExplainer);
            this.Controls.Add(this.btnLogCancel);
            this.Controls.Add(this.lWebsite);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lFullName);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.lDateOfBirth);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "LogForm";
            this.Text = "Log the Website Access Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lDateOfBirth;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label lFullName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lWebsite;
        private System.Windows.Forms.Button btnLogCancel;
        private System.Windows.Forms.Label lExplainer;
        private System.Windows.Forms.Button btnLogOK;
    }
}