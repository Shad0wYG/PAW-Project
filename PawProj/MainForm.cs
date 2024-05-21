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
        private Visit Visit {  get; set; }
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
                Visit.User = logForm.User; 


            }
        }
    }
}
