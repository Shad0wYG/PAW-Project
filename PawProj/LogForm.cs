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
        public WebsiteCategory one = new WebsiteCategory(1);
        public WebsiteCategory two = new WebsiteCategory(2);
        public WebsiteCategory three = new WebsiteCategory(3);

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

            Util.AddVisit(visit, one, two, three);
        }
    }
}
