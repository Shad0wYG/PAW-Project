namespace PawProj
{
    partial class MainForm
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
            this.logBtn = new System.Windows.Forms.Button();
            this.btnViewData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.Location = new System.Drawing.Point(12, 12);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(158, 114);
            this.logBtn.TabIndex = 0;
            this.logBtn.Text = "Log a New Website Visit";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // btnViewData
            // 
            this.btnViewData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewData.Location = new System.Drawing.Point(227, 12);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(158, 114);
            this.btnViewData.TabIndex = 1;
            this.btnViewData.Text = "View Logged Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.logBtn);
            this.Name = "MainForm";
            this.Text = "Internet Provider App ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button btnViewData;
    }
}

