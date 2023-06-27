using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tercer_app
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.BackColor = Color.Red;
            else
            {
                textBox1.CharacterCasing = CharacterCasing.Upper;
                listBox1.Items.Add(textBox1.Text);
            }

            if (textBox2.Text == "") textBox2.BackColor = Color.Red;
            else{
                textBox2.CharacterCasing = CharacterCasing.Upper;
                listBox1.Items.Add(textBox2.Text);
            }

            if (numericUpDown1.Text == "0") numericUpDown1.BackColor = Color.Red;
            else{
                listBox1.Items.Add(numericUpDown1.Text + " año/s");
            }

            if (textBox4.Text == "") textBox4.BackColor = Color.Red;
            else{
                textBox4.CharacterCasing = CharacterCasing.Upper;
                listBox1.Items.Add(textBox4.Text);
            }

            if (textBox1.Text == "") listBox1.Items.Clear(); ;
            if (textBox2.Text == "") listBox1.Items.Clear(); ;
            if (numericUpDown1.Text == "0") listBox1.Items.Clear(); ;
            if (textBox4.Text == "") listBox1.Items.Clear(); ;

        }

        //arreglar que el nombre y apellido aparezcan contatenados 
        // arreglar que solo se pueda cargar una vez la info y que se renueve si toco cancelar.

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            numericUpDown1.BackColor = Color.White;
            textBox4.BackColor = Color.White;

            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Text = "0";
            textBox4.Text = "";

            listBox1.Items.Clear();
        }
    }
}