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
            if (addTownForm.ShowDialog() == DialogResult.OK)
            {
                var townName = addTownForm.TownName;
                // Add the new town to the database
                AddTownInDatabase(townName);
                ReloadTowns();
            }
        }

        private void AddTownInDatabase(string townName)
        {
            using (var context = new TownsDbContext())
            {
                Town newTown = new Town()
                {
                    Name = townName
                };
                context.Add(newTown);
                context.SaveChanges();
            }
        }

        private void buttonEditTown_Click(object sender, EventArgs e)
        {
            Town selectedTown = (Town)townBindingSource.Current;
            var editTownForm = new FormEditTown(selectedTown.Name);
            if (editTownForm.ShowDialog() == DialogResult.OK)
            {
                var editTownName = editTownForm.TownName;
                selectedTown.Name = editTownName;
                // Update the town in the database
                UpdateTown(selectedTown);
                ReloadTowns();
            }
        }

        private void UpdateTown(Town selectedTown)
        {
            using (var context = new TownsDbContext())
            {
                var townForUpdate = context.Towns.FirstOrDefault(t => t.Id == selectedTown.Id);
                if (townForUpdate is not null)
                {
                    townForUpdate.Name = selectedTown.Name;
                    context.SaveChanges();
                }
            }
        }

        private void buttonDeleteTown_Click(object sender, EventArgs e)
        {
            var selectedTown = (Town)townBindingSource.Current;
            var deleteTownForm = new FormDeleteTown(selectedTown.Name);
            if(deleteTownForm.ShowDialog() == DialogResult.OK)
            {
                DeleteTown(selectedTown);
                ReloadTowns();
            }
        }

        private void DeleteTown(Town town)
        {
            using (var context = new TownsDbContext())
            {
                context.Remove(town);
                context.SaveChanges();
            }
        }
    }
}
