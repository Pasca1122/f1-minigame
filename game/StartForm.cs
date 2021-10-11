using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            labelDriver.Parent = pictureBox1;
            labelDriver.BackColor = Color.Transparent;

            comboBox1.Items.Add("Lewis Hamilton");
            comboBox1.Items.Add("Valtteri Bottas");
            comboBox1.Items.Add("Max Verstappen");
            comboBox1.Items.Add("Sergio Perez");
            comboBox1.Items.Add("Lando Norris");
            comboBox1.Items.Add("Daniel Ricciardo");
            comboBox1.Items.Add("Charles Leclerc");
            comboBox1.Items.Add("Carlos Sainz Jr.");
            comboBox1.Items.Add("Pierre Gasly");
            comboBox1.Items.Add("Yuki Tsunoda");
            comboBox1.Items.Add("Sebastian Vettel");
            comboBox1.Items.Add("Lance Stroll");
            comboBox1.Items.Add("Fernando Alonso");
            comboBox1.Items.Add("Esteban Ocon");
            comboBox1.Items.Add("George Russell");
            comboBox1.Items.Add("Nicholas Latifi");
            comboBox1.Items.Add("Kimi Räikkönen");
            comboBox1.Items.Add("Antonio Giovinazzi");
            comboBox1.Items.Add("Mick Schumacher");
            comboBox1.Items.Add("Nikita Mazepin");

            comboBox2.Items.Add("Bahrain Grand Prix");
            comboBox2.Items.Add("Emilia Romagna Grand Prix");
            comboBox2.Items.Add("Portuguese Grand Prix");
            comboBox2.Items.Add("Spanish Grand Prix");
            comboBox2.Items.Add("Monaco Grand Prix");
            comboBox2.Items.Add("Azerbaijan Grand Prix");
            comboBox2.Items.Add("French Grand Prix");
            comboBox2.Items.Add("Austrian Grand Prix");
            comboBox2.Items.Add("British Grand Prix");
            comboBox2.Items.Add("Hungarian Grand Prix");
            comboBox2.Items.Add("Belgian Grand Prix");
            comboBox2.Items.Add("Dutch Grand Prix");
            comboBox2.Items.Add("Italian Grand Prix");
            comboBox2.Items.Add("Russian Grand Prix");
            comboBox2.Items.Add("Turkish Grand Prix");
            comboBox2.Items.Add("United States Grand Prix");
            comboBox2.Items.Add("Mexico City Grand Prix");
            comboBox2.Items.Add("São Paulo Grand Prix");
            comboBox2.Items.Add("Qatar Grand Prix");
            comboBox2.Items.Add("Saudi Arabian Grand Prix");
            comboBox2.Items.Add("Abu Dhabi Grand Prix");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Track t = new Track();
            t.Show();
        }
    }
}
