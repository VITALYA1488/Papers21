using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Газета
{
    public partial class Dobavlenie : Form
    {
        public Model1 db { get; set; }
        public Agent agent { get; set; }
        public AgentType agty { get; set; }
        public Dobavlenie()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (agent == null)
            {
                agentBindingSource.AddNew();
                this.Text = "Добавление новой учетной записи";
            }
            else
            {
                agentBindingSource.Add(agent);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (agent == null)
            {
                agent = (Agent)agentBindingSource.Current;
                db.Agent.Add(agent);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void agentTypeIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
