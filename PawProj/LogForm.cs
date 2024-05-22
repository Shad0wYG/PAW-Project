using PawProj.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawProj
{
    public partial class LogForm : Form 
    {
        public User User { get; set; }
        public Visit visit { get; set; }
        //public WebsiteCategory one = new WebsiteCategory(1);
        //public WebsiteCategory two = new WebsiteCategory(2);
        //public WebsiteCategory three = new WebsiteCategory(3);

        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            if (User != null) 
            {
                tbUserName.Text = User.UserName;
                tbFullName.Text = User.FullName;
                dtpDOB.Value = User.DateOfBirth;
            }
        }

        private void btnLogOK_Click(object sender, EventArgs e)
        {
            User.UserName = tbUserName.Text;
            User.FullName = tbFullName.Text;
            User.DateOfBirth = dtpDOB.Value;
            string website = cbWebsite.Text;

            visit = new Visit(User, website);
            User.VisitHistory.Add(visit);

            Util.AddVisit(visit, MainForm 
        }

        private void tbFullName_Validating(object sender, CancelEventArgs e)
        {
            if(tbFullName.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Name too Short!");
            }

            foreach(char c in tbFullName.Text)
                if(!((c >= 'A' && c <= 'Z' ) || (c>='a' && c<='z')))
                {
                    e.Cancel = true;
                    errorProvider1.SetError((Control)sender, "Name can have only letters!");
                }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (tbUserName.Text.Length < 0) 
            {
                e.Cancel = true;
                errorProvider2.SetError((Control)sender, "This field cannot be empty!");
            }
        }

        private void cbWebsite_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbWebsite.Text))
            {
                e.Cancel= true;
                errorProvider3.SetError((Control)sender, "This field cannot be empty!");
            }
        }
    }
}
