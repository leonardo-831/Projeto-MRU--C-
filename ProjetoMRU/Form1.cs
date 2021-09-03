using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMRU
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void MS_CheckedChanged(object sender, EventArgs e)
        {
            this.showSpaceTipe.Text = "Metros";
            this.showVelTipe.Text = "Metros por Segundo";
            this.showTimeTipe.Text = "Segundos";

            this.clear();
        }

        private void kmH_CheckedChanged(object sender, EventArgs e)
        {
            this.showSpaceTipe.Text = "Kilometros";
            this.showVelTipe.Text = "Kilometros por Hora";
            this.showTimeTipe.Text = "Horas";

            this.clear();
        }

        private void spaceIni_ValueChanged(object sender, EventArgs e)
        {
            if (this.btnAutoCalc.Checked)
            {
                calc(this.spaceIni.Value, this.vel.Value, this.time.Value);
            }
        }

        private void vel_ValueChanged(object sender, EventArgs e)
        {
            if (this.btnAutoCalc.Checked)
            {
                calc(this.spaceIni.Value, this.vel.Value, this.time.Value);
            }
        }

        private void time_ValueChanged(object sender, EventArgs e)
        {
            if (this.btnAutoCalc.Checked)
            {
                calc(this.spaceIni.Value, this.vel.Value, this.time.Value);
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            calc(this.spaceIni.Value, this.vel.Value, this.time.Value);
        }

        private void calc(decimal s, decimal v, decimal t)
        {
            // S = s0 + VT;
            this.resultTitle.Visible = true;

            this.result.Text = "S = " + s.ToString() + " + " + v.ToString() + " * " + t.ToString();
            this.result.Text += "\nS = " + s.ToString() + " + " + (v * t).ToString();
            this.result.Text += "\nS = " + (s + (v * t)).ToString();
            this.result.Text += "\n\n Espaço Final = " + (s + (v * t)).ToString();

            if (this.MS.Checked)
            {
                this.result.Text += " m";
            }
            else
            {
                this.result.Text += " Km";
            }

            this.info.Visible = false;
        }

        private void newCalc_Click(object sender, EventArgs e)
        {
            this.clear();

            this.btnAutoCalc.Checked = false; 
        }

        private void clear() 
        {
            this.vel.Value = 0;
            this.spaceIni.Value = 0;
            this.time.Value = 0;

            this.result.Text = "";
            this.resultTitle.Visible = false;
            this.info.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            closeWindow();
        }

        private void closeWindow()
        {
            const string message =
        "Você Realmente Deseja Fechar o Formulário?";
            const string caption = "Exit";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void showInfo_Click(object sender, EventArgs e)
        {
            this.info.Visible = true;
        }

        private void info_Click(object sender, EventArgs e)
        {
            this.info.Visible = false; 
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
