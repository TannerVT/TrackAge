using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackAge
{
    public partial class TrackAge : Form
    {
        public TrackAge()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddPackage addPack = new AddPackage();
            addPack.Show();
        }

        private void TrackAge_Load(object sender, EventArgs e)
        {

        }
    }
}
