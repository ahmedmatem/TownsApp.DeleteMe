using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TownsApp
{
    public partial class FormEditTown : Form
    {
        public string TownName => textBoxTownName.Text;

        public FormEditTown(string townName)
        {
            InitializeComponent();
            textBoxTownName.Text = townName;
        }
    }
}
