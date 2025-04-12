using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps_1Bimestre
{
    public partial class AllForms : Form
    {
        public AllForms()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("O fechamento foi desabilitado. Você deve fechar o aplicativo de outra maneira.");
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassStyle |= 0x200;
                return cp;
            }
        }

        private void app1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("WinFormsPesoIdeal").Length == 0)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\otavi\\Source\\Repos\\Apps-1Bimestre\\Apps-1Bimestre\\Apps\\App1\\WinFormsPesoIdeal.exe");
                }

                if (System.Diagnostics.Process.GetProcessesByName("WinFormsPesoIdeal").Length != 0)
                {
                    app1Btn.Enabled = false;
                    app2Btn.Enabled = false;
                    app3Btn.Enabled = false;
                    app4Btn.Enabled = false;
                    app5Btn.Enabled = false;
                    app6Btn.Enabled = false;
                    app7Btn.Enabled = false;
                    MessageBox.Show("O App1 está em execução!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void app2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("App2CalcularMediaAluno").Length == 0)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\otavi\\Source\\Repos\\Apps-1Bimestre\\Apps-1Bimestre\\Apps\\App2\\App2CalcularMediaAluno.exe");
                }
                if (System.Diagnostics.Process.GetProcessesByName("App2CalcularMediaAluno").Length != 0)
                {
                    app1Btn.Enabled = false;
                    app2Btn.Enabled = false;
                    app3Btn.Enabled = false;
                    app4Btn.Enabled = false;
                    app5Btn.Enabled = false;
                    app6Btn.Enabled = false;
                    app7Btn.Enabled = false;
                    MessageBox.Show("O App2 está em execução!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void app3Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("App3-EPI-Funcionario").Length == 0)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\otavi\\Source\\Repos\\Apps-1Bimestre\\Apps-1Bimestre\\Apps\\App3\\App3-EPI-Funcionario.exe");
                }
                if (System.Diagnostics.Process.GetProcessesByName("App3-EPI-Funcionario").Length != 0)
                {
                    app1Btn.Enabled = false;
                    app2Btn.Enabled = false;
                    app3Btn.Enabled = false;
                    app4Btn.Enabled = false;
                    app5Btn.Enabled = false;
                    app6Btn.Enabled = false;
                    app7Btn.Enabled = false;
                    MessageBox.Show("O App3 está em execução!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void app4Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("App4-Habilitacao").Length == 0)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\otavi\\Source\\Repos\\Apps-1Bimestre\\Apps-1Bimestre\\Apps\\App4\\App4-Habilitacao.exe");
                }
                if (System.Diagnostics.Process.GetProcessesByName("App4-Habilitacao").Length != 0)
                {
                    app1Btn.Enabled = false;
                    app2Btn.Enabled = false;
                    app3Btn.Enabled = false;
                    app4Btn.Enabled = false;
                    app5Btn.Enabled = false;
                    app6Btn.Enabled = false;
                    app7Btn.Enabled = false;
                    MessageBox.Show("O App4 está em execução!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void app5Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("App5-Triangulos").Length == 0)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\otavi\\Source\\Repos\\Apps-1Bimestre\\Apps-1Bimestre\\Apps\\App5\\App5-Triangulos.exe");
                }
                if (System.Diagnostics.Process.GetProcessesByName("App5-Triangulos").Length != 0)
                {
                    app1Btn.Enabled = false;
                    app2Btn.Enabled = false;
                    app3Btn.Enabled = false;
                    app4Btn.Enabled = false;
                    app5Btn.Enabled = false;
                    app6Btn.Enabled = false;
                    app7Btn.Enabled = false;
                    MessageBox.Show("O App5 está em execução!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void app6Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("App6_Sistema_Vendas").Length == 0)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\otavi\\Source\\Repos\\Apps-1Bimestre\\Apps-1Bimestre\\Apps\\App6\\App6_Sistema_Vendas.exe");
                }
                if (System.Diagnostics.Process.GetProcessesByName("App6_Sistema_Vendas").Length != 0)
                {
                    app1Btn.Enabled = false;
                    app2Btn.Enabled = false;
                    app3Btn.Enabled = false;
                    app4Btn.Enabled = false;
                    app5Btn.Enabled = false;
                    app6Btn.Enabled = false;
                    app7Btn.Enabled = false;
                    MessageBox.Show("O App6 está em execução!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void app7Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName("App7-Advinhacoes").Length == 0)
                {
                    System.Diagnostics.Process.Start("C:\\Users\\otavi\\Source\\Repos\\Apps-1Bimestre\\Apps-1Bimestre\\Apps\\App7\\App7-Advinhacoes.exe");
                }
                if (System.Diagnostics.Process.GetProcessesByName("App7-Advinhacoes").Length != 0)
                {
                    app1Btn.Enabled = false;
                    app2Btn.Enabled = false;
                    app3Btn.Enabled = false;
                    app4Btn.Enabled = false;
                    app5Btn.Enabled = false;
                    app6Btn.Enabled = false;
                    app7Btn.Enabled = false;
                    MessageBox.Show("O App7 está em execução!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pararBtn_Click(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName("WinFormsPesoIdeal").Length != 0)
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("WinFormsPesoIdeal");
                foreach (System.Diagnostics.Process process in processes)
                {
                    process.Kill();
                    app1Btn.Enabled = true;
                    app2Btn.Enabled = true;
                    app3Btn.Enabled = true;
                    app4Btn.Enabled = true;
                    app5Btn.Enabled = true;
                    app6Btn.Enabled = true;
                    app7Btn.Enabled = true;
                }
            }
            if (System.Diagnostics.Process.GetProcessesByName("App2CalcularMediaAluno").Length != 0)
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("App2CalcularMediaAluno");
                foreach (System.Diagnostics.Process process in processes)
                {
                    process.Kill();
                    app1Btn.Enabled = true;
                    app2Btn.Enabled = true;
                    app3Btn.Enabled = true;
                    app4Btn.Enabled = true;
                    app5Btn.Enabled = true;
                    app6Btn.Enabled = true;
                    app7Btn.Enabled = true;
                }
            }
            if (System.Diagnostics.Process.GetProcessesByName("App3-EPI-Funcionario").Length != 0)
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("App3-EPI-Funcionario");
                foreach (System.Diagnostics.Process process in processes)
                {
                    process.Kill();
                    app1Btn.Enabled = true;
                    app2Btn.Enabled = true;
                    app3Btn.Enabled = true;
                    app4Btn.Enabled = true;
                    app5Btn.Enabled = true;
                    app6Btn.Enabled = true;
                    app7Btn.Enabled = true;
                }
            }
            if (System.Diagnostics.Process.GetProcessesByName("App4-Habilitacao").Length != 0)
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("App4-Habilitacao");
                foreach (System.Diagnostics.Process process in processes)
                {
                    process.Kill();
                    app1Btn.Enabled = true;
                    app2Btn.Enabled = true;
                    app3Btn.Enabled = true;
                    app4Btn.Enabled = true;
                    app5Btn.Enabled = true;
                    app6Btn.Enabled = true;
                    app7Btn.Enabled = true;
                }
            }
            if (System.Diagnostics.Process.GetProcessesByName("App5-Triangulos").Length != 0)
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("App5-Triangulos");
                foreach (System.Diagnostics.Process process in processes)
                {
                    process.Kill();
                    app1Btn.Enabled = true;
                    app2Btn.Enabled = true;
                    app3Btn.Enabled = true;
                    app4Btn.Enabled = true;
                    app5Btn.Enabled = true;
                    app6Btn.Enabled = true;
                    app7Btn.Enabled = true;
                }
            }
            if (System.Diagnostics.Process.GetProcessesByName("App6_Sistema_Vendas").Length != 0)
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("App6_Sistema_Vendas");
                foreach (System.Diagnostics.Process process in processes)
                {
                    process.Kill();
                    app1Btn.Enabled = true;
                    app2Btn.Enabled = true;
                    app3Btn.Enabled = true;
                    app4Btn.Enabled = true;
                    app5Btn.Enabled = true;
                    app6Btn.Enabled = true;
                    app7Btn.Enabled = true;
                }
            }
            if (System.Diagnostics.Process.GetProcessesByName("App7-Advinhacoes").Length != 0)
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("App7-Advinhacoes");
                foreach (System.Diagnostics.Process process in processes)
                {
                    process.Kill();
                    app1Btn.Enabled = true;
                    app2Btn.Enabled = true;
                    app3Btn.Enabled = true;
                    app4Btn.Enabled = true;
                    app5Btn.Enabled = true;
                    app6Btn.Enabled = true;
                    app7Btn.Enabled = true;
                }
            }

        }

    }
}
