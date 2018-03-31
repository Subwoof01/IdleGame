using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame.SaveLoad
{
    public partial class SaveForm : Form
    {
        private Player _player;

        public SaveForm(Player player)
        {
            InitializeComponent();
            _player = player;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(@"Saves\" + textBox1.Text + ".dat");
            bf.Serialize(file, _player);
            file.Close();
            this.Close();
        }
    }
}
