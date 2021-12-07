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
    public partial class Information : Form
    {
        Model1 db = new Model1();
        public Information()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            agentBindingSource.DataSource = db.Agent.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Тип агента")
            {
                agentBindingSource.DataSource = db.Agent.OrderBy(a => a.AgentTypeID).ToList();
            }
            if (comboBox1.Text == "Приоритет")
            {
                agentBindingSource.DataSource = db.Agent.OrderBy(a => a.Priority).ToList();
            }
            if (comboBox1.Text == "Вернуть исходные значения")
            {
                agentBindingSource.DataSource = null;
                agentBindingSource.DataSource = db.Agent.ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dobavlenie frm = new Dobavlenie();
            frm.agent = null;
            DialogResult dr = frm.ShowDialog();
            if(dr == DialogResult.OK)
            {
                agentBindingSource.DataSource = null;
                agentBindingSource.DataSource = db.Agent.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent agent = (Agent)agentBindingSource.Current;
            Dobavlenie frm = new Dobavlenie();
            frm.agent = agent;
            DialogResult dr = frm.ShowDialog();
            if(dr == DialogResult.OK)
            {
                agentBindingSource.DataSource = null;
                agentBindingSource.DataSource = db.Agent.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agent agent = (Agent)agentBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить запись?" + agent.ID + "?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                db.Agent.Remove(agent);
            }
            try
            {
                db.SaveChanges();
                agentBindingSource.DataSource = db.Agent.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null) return;
            // получаем ID агента
            int n = (int)comboBox2.SelectedValue;
            // выбираем все объекты (записи) у которых значение AgentTypeID == n
            // тип коллекции нам не важен!
            var colProd = db.Agent.Where(x => x.AgentTypeID == n);
            // подключаем коллекцию к agentBindingSource
            agentBindingSource.DataSource = colProd.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
