using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            MachineList machine = new MachineList();
            machine.Show();
            this.Hide();
           
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            Payment card = new Payment();
            card.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogOut exit = new LogOut();
            exit.Show();
            this.Hide();
        }

        private void machineIconHome_Click(object sender, EventArgs e)
        {
            UserControl2 userControl2 = new UserControl2();
            this.Show();
            userControl2.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl2);
            userControl2.BringToFront();
;        }
    }
}
