using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace TrackAge
{
    public partial class AddPackage : Form
    {
        public AddPackage()
        {
            InitializeComponent();
        }

        private void btn_AddPackage_Click(object sender, EventArgs e)
        {
            var newPack = new Package
            {
                name = txt_Name.Text,
                number = txt_Number.Text,
                courier = lb_Courier.Text
            };

            JSONModify.JSONAdd(newPack);

            this.Close();
        }
    }
}
