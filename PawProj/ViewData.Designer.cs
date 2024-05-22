﻿namespace PawProj
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewBack
            // 
            this.btnViewBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnViewBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBack.Location = new System.Drawing.Point(12, 584);
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
            this.lvShow.Location = new System.Drawing.Point(12, 157);
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
            this.colWebCat.Width = 179;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "You may select an item to";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(672, 584);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 69);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEdit.Location = new System.Drawing.Point(22, 19);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(63, 24);
            this.rbEdit.TabIndex = 6;
            this.rbEdit.TabStop = true;
            this.rbEdit.Text = "Edit";
            this.rbEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDelete);
            this.groupBox1.Controls.Add(this.rbEdit);
            this.groupBox1.Location = new System.Drawing.Point(257, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDelete.Location = new System.Drawing.Point(22, 60);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(84, 24);
            this.rbDelete.TabIndex = 9;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Delete";
            this.rbDelete.UseVisualStyleBackColor = true;
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.btnViewBack);
            this.Name = "ViewData";
            this.Text = "ViewData";
            this.Load += new System.EventHandler(this.ViewData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewBack;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ColumnHeader colWebsite;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colDOB;
        private System.Windows.Forms.ColumnHeader colWebCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDelete;
    }
}