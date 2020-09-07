﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleKruume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a, b, c, h;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
            else listView1.Items[5].SubItems.Add("Не существует");

            if (triangle.ravnostor) { listView1.Items[6].SubItems.Add("Равносторонний"); pictureBox1.Image = Image.FromFile("ravnostor.png"); }
            else if (triangle.ravnobedr) { listView1.Items[6].SubItems.Add("Равнобедренный"); pictureBox1.Image = Image.FromFile("ravnobedr.png"); }
            else if (triangle.raznostor) { listView1.Items[6].SubItems.Add("Разносторонний"); pictureBox1.Image = Image.FromFile("raznostor.png"); }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = true;
            txtB.Enabled = true;
            txtC.Enabled = false;
            txtH.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = false;
            txtB.Enabled = true;
            txtC.Enabled = true;
            txtH.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = true;
            txtB.Enabled = false;
            txtC.Enabled = true;
            txtH.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = false;
            txtB.Enabled = false;
            txtC.Enabled = false;
            txtH.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
