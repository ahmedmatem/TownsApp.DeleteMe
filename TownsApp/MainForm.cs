using TownsApp.Data;
using TownsApp.Data.Models;

namespace TownsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadTowns();
        }

        private List<Town> LoadTownsFromDb()
        {
            using (var context = new TownsDbContext())
            {
                return context.Towns.ToList();
            }
        }

        private void ReloadTowns()
        {
            var towns = LoadTownsFromDb();
            townBindingSource.DataSource = towns;
        }

        private void buttonAddTown_Click(object sender, EventArgs e)
        {
            var addTownForm = new FormAddTown();
            if(addTownForm.ShowDialog() == DialogResult.OK)
            {
                var townName = addTownForm.TownName;
            }
        }


    }
}
