using EFCodeOnlyFromDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCodeOnlyFromDB
{
    public partial class Form1 : Form
    {
        //EF Runtime object
        ITIContext Db = new ITIContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //defered execution 
            //var q1=(from std in Db.Students
            //       select std).ToList();
            //dataGridView1.DataSource = q1;

            //will connect for first time and retrieve student to local storage 
            Db.Students.Load();

            dataGridView1.DataSource = Db.Students.Local.ToBindingList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            Db.SaveChanges();
        }
    }
}
