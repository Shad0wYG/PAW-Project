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
    public partial class MainForm : Form
    {
        User User {  get; set; }
        Visit Visit {  get; set; }
        WebsiteCategory one = new WebsiteCategory(1);
        WebsiteCategory two = new WebsiteCategory(2);
        WebsiteCategory three = new WebsiteCategory(3);

        public MainForm()
        {
            Visit = new Visit();
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            User user = new User();
            logForm.User = user;
            if (logForm.ShowDialog() == DialogResult.OK) 
            {
                Visit = logForm.visit;
                one = logForm.one;
                two = logForm.two;
                three = logForm.three;
                User = logForm.User;

            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            ViewData viewData = new ViewData();
            viewData.ShowDialog();
        }
    }
}
