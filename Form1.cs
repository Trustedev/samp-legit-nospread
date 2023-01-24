using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;


namespace NORECOIL
{
    public partial class Form1 : Form
    {
        public Mem m = new Mem();   
        public Form1()
        {
            InitializeComponent();
        }

        bool Durum = false;


        private void Form1_Load(object sender, EventArgs e)
        {

            m.WriteMemory("0xC8C760", "float", "1.2");
            m.WriteMemory("0xC8C7D0", "float", "0.6");
            m.WriteMemory("0xC8C530", "float", "1.25");

            deaglebar.SelectedIndex = 0;
            m4bar.SelectedIndex = 0;
            pistolbar.SelectedIndex = 0;
            tec9bar.SelectedIndex = 0;
            uzibar.SelectedIndex = 0;
            ak47bar.SelectedIndex = 0;
            shotgunbar.SelectedIndex = 0;
            susturucubar.SelectedIndex = 0;
            mp5bar.SelectedIndex = 0;


            deaglebar.Enabled = false;
              m4bar.Enabled = false;  
              pistolbar.Enabled = false;
              tec9bar.Enabled = false;
              uzibar.Enabled = false;
              ak47bar.Enabled = false;
              shotgunbar.Enabled = false;
              susturucubar.Enabled = false;
              mp5bar.Enabled = false;
            
        }




        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("gta_sa"))
                {
                    Thread.Sleep(1000);
                    return;
                }

                                               
                Durum = true;

                System.Threading.Thread.Sleep(1000);
                BGWorker.ReportProgress(0);
            }
            

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (Durum)
            {
              

                 
                DurumKontrol.Text = "AKTIF";
               
                deaglebar.Enabled = true;
                m4bar.Enabled = true;
                pistolbar.Enabled = true;
                tec9bar.Enabled = true;
                uzibar.Enabled = true;
                ak47bar.Enabled = true;
                shotgunbar.Enabled = true;
                susturucubar.Enabled = true;
                mp5bar.Enabled = true;
                

                
            }
        }
        

        private void deagle_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgnum_Click(object sender, EventArgs e)
        {
            
           
            
        }

        

        private void mp5num_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void test_Click(object sender, EventArgs e)
        {
            
        }

        private void deaglebar_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (deaglebar.GetItemText(deaglebar.SelectedItem))
            {
                
                case "[Normal]":
                    m.WriteMemory("0xC8C530", "float", "1.25");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C530", "float", "1.45");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C530", "float", "1.85");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C530", "float", "2.25");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C530", "float", "4.25");
                    break;

            }

        }

        private void mp5bar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void mp5bar_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (mp5bar.GetItemText(mp5bar.SelectedItem))
            {

                case "[Normal]":
                    m.WriteMemory("0xC8C760", "float", "1.2");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C760", "float", "1.45");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C760", "float", "1.85");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C760", "float", "3.25");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C760", "float", "10.5");
                    break;

            }
        }

        private void ak47bar_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (ak47bar.GetItemText(ak47bar.SelectedItem))
            {

                case "[Normal]":
                    m.WriteMemory("0xC8C7D0", "float", "0.6");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C7D0", "float", "0.92");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C7D0", "float", "1.35");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C7D0", "float", "8.25");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C7D0", "float", "18.5");
                    break;

            }

        }

        private void m4bar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (m4bar.GetItemText(m4bar.SelectedItem))
            {

                case "[Normal]":
                    m.WriteMemory("0xC8C840", "float", "0.8");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C840", "float", "0.98");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C840", "float", "1.12");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C840", "float", "1.85");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C840", "float", "18.5");
                    break;

            }
        }

        private void shotgunbar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (shotgunbar.GetItemText(shotgunbar.SelectedItem))
            {

                case "[Normal]":
                    m.WriteMemory("0xC8C5A0", "float", "1.4");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C5A0", "float", "1.6");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C5A0", "float", "1.8");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C5A0", "float", "1.9");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C5A0", "float", "2.8");
                    break;

            }
        }

        private void uzibar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (uzibar.GetItemText(uzibar.SelectedItem))
            {

                case "[Normal]":
                    m.WriteMemory("0xC8C6F0", "float", "1.10");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C6F0", "float", "2.4");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C6F0", "float", "3.83");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C6F0", "float", "4.5");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C6F0", "float", "17.5");
                    break;

            }
        }

        private void tec9bar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tec9bar.GetItemText(tec9bar.SelectedItem))
            {

                case "[Normal]":
                    m.WriteMemory("0xC8C8B0", "float", "1.10");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C8B0", "float", "1.4");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C8B0", "float", "1.83");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C8B0", "float", "2.5");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C8B0", "float", "8.5");
                    break;

            }
        }

        private void pistolbar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (pistolbar.GetItemText(pistolbar.SelectedItem))
            {

                case "[Normal]":
                    m.WriteMemory("0xC8C450", "float", "1.25");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C450", "float", "1.5");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C450", "float", "1.95");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C450", "float", "2.5");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C450", "float", "8.5");
                    break;

            }
        }

        private void susturucubar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (pistolbar.GetItemText(pistolbar.SelectedItem))
            {

                case "[Normal]":
                    m.WriteMemory("0xC8C4C0", "float", "1.50");
                    break;


                case "[LiteLegit]":
                    m.WriteMemory("0xC8C4C0", "float", "1.8");
                    break;


                case "[Legit]":
                    m.WriteMemory("0xC8C4C0", "float", "2.3");
                    break;


                case "[Hard]":
                    m.WriteMemory("0xC8C4C0", "float", "4.5");
                    break;


                case "[RAGE]":
                    m.WriteMemory("0xC8C4C0", "float", "8.5");
                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
    }
}