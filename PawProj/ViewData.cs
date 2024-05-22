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
    public partial class ViewData : Form
    {
        public WebsiteCategory one;
        public WebsiteCategory two;
        public WebsiteCategory three;
        public User user { get; set; }
        public Visit visit { get; set; }
        public ViewData()
        {
            InitializeComponent();
        }

        private void addItem(WebsiteCategory category) 
        {
            //foreach (var visit in category.Visits)
            //{
            //    ListViewItem lvi = new ListViewItem(visit.WebsiteName);
            //    lvi.SubItems.Add(user.UserName);
            //    lvi.SubItems.Add(user.FullName);
            //    lvi.SubItems.Add(user.DateOfBirth.ToString());
            //    lvi.Tag = visit;
            //    lvShow.Items.Add(lvi);
            //}

            foreach(var visit in category.Visits)
            {
                foreach(var user in visit.UserHistory)
                {
                    ListViewItem lvi = new ListViewItem(visit.WebsiteName);
                    lvi.SubItems.Add(user.UserName);
                    lvi.SubItems.Add(user.FullName);
                    lvi.SubItems.Add(user.DateOfBirth.ToString());
                    lvi.Tag = visit;
                    lvShow.Items.Add(lvi);
                }
            }
            
        }

        private void DisplayInfo()
        {
            lvShow.Items.Clear();
            addItem(one);
            addItem(two);
            addItem(three);
        }


        private void ViewData_Load(object sender, EventArgs e)
        {
            DisplayInfo();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(rbEdit.Checked) 
            {
                visit = (Visit)lvShow.SelectedItems[0].Tag;
                user = new User();
                LogForm logForm = new LogForm();
                logForm.User = user;
                logForm.one = one;
                logForm.two = two;
                logForm.three = three;
                if (logForm.ShowDialog() == DialogResult.OK) 
                {
                    Util.DeleteVisit(visit, one, two, three);
                    
                }

            }

            if(rbDelete.Checked)
            {
                Util.DeleteVisit((Visit)lvShow.SelectedItems[0].Tag, one, two, three);
            }
        }
    }
}
