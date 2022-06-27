using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        TestContext db;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            db = new TestContext();
            db.TestTables.Load();
            dataGridView1.DataSource = db.TestTables.Local.ToBindingList();
         
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                TestTable t = new TestTable();
                t.Flag = true;
                t.Text = "RandomText";

                db.TestTables.Add(t);
            }
            db.ChangeTracker.DetectChanges();
            db.SaveChanges();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            foreach (var item in db.TestTables)
            {
                item.Flag = false;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            }
            db.ChangeTracker.DetectChanges();
            db.SaveChanges();
        }
    }
}
