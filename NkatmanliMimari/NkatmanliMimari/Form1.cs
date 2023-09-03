using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccsessLayer;
using LogicLayer;

namespace NkatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse (txtmaas.Text);
            ent.Sehir = txtsehir.Text;
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLpersonelSil(ent.Id);
                
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtgorev.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();   
        }

        private void txtgorev_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
        }
    }
}
