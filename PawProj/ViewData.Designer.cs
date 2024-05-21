namespace PawProj
{
    partial class ViewData
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
            this.btnViewBack = new System.Windows.Forms.Button();
            this.lvShow = new System.Windows.Forms.ListView();
            this.colWebsite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWebCat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnViewBack
            // 
            this.btnViewBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnViewBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBack.Location = new System.Drawing.Point(12, 411);
            this.btnViewBack.Name = "btnViewBack";
            this.btnViewBack.Size = new System.Drawing.Size(114, 69);
            this.btnViewBack.TabIndex = 0;
            this.btnViewBack.Text = "Back";
            this.btnViewBack.UseVisualStyleBackColor = true;
            // 
            // lvShow
            // 
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colWebsite,
            this.colUsername,
            this.colFullName,
            this.colDOB,
            this.colWebCat});
            this.lvShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvShow.FullRowSelect = true;
            this.lvShow.HideSelection = false;
            this.lvShow.Location = new System.Drawing.Point(12, 12);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(774, 393);
            this.lvShow.TabIndex = 1;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            // 
            // colWebsite
            // 
            this.colWebsite.Text = "Accessed Website";
            this.colWebsite.Width = 170;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 117;
            // 
            // colFullName
            // 
            this.colFullName.Text = "Full Name";
            this.colFullName.Width = 155;
            // 
            // colDOB
            // 
            this.colDOB.Text = "Date of Birth";
            this.colDOB.Width = 155;
            // 
            // colWebCat
            // 
            this.colWebCat.Text = "Website Category";
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 488);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.btnViewBack);
            this.Name = "ViewData";
            this.Text = "ViewData";
            this.Load += new System.EventHandler(this.ViewData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewBack;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ColumnHeader colWebsite;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colDOB;
        private System.Windows.Forms.ColumnHeader colWebCat;
    }
}