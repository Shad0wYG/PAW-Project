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
        //public User User {  get; set; }
        Visit Visit {  get; set; }
        public WebsiteCategory one = new WebsiteCategory(1);
        public WebsiteCategory two = new WebsiteCategory(2);
        public WebsiteCategory three = new WebsiteCategory(3);

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
            logForm.one = one;
            logForm.two = two;
            logForm.three = three;
            if (logForm.ShowDialog() == DialogResult.OK) 
            {
                one = logForm.one;
                two = logForm.two;
                three = logForm.three;
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            ViewData viewData = new ViewData();
            viewData.one = one;
            viewData.two = two;
            viewData.three = three;
            viewData.ShowDialog();


            one = viewData.one;
            two = viewData.two;
            three = viewData.three;
        }
    }
}
