using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai17_tinhlaisuat
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TINH_Click(object sender, EventArgs e)
        {
            // Xóa ListBox
            listBox1.Items.Clear();

            // Để giá trị vào biến
            double soTien = Convert.ToInt64(textTIEN.Text);
            int soNam = (int)Sonam.Value;
            double laiSuat = double.Parse(cbxlai.SelectedItem.ToString().Replace("%", "")) / 100;
            // MessageBox.Show("Lai suat " + laiSuat);

            for (int i = 1; i <= soNam; i++)
            {
                double tienLai = soTien * laiSuat;
                listBox1.Items.Add("Năm " + i + " Tiền gốc: " + soTien.ToString("0,##0.00") + " - Lãi: " + tienLai.ToString("N", new CultureInfo("en-US")));
                soTien += tienLai;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i = 0.01; i <= 0.101; i += 0.001)
            {
                // cbxLaiSuat.Items.Add(String.Format("{0:P2}.", i));
                cbxlai.Items.Add(String.Format("{0:P1}", Math.Round(i, 3)));
                // cbxLaiSuat.Items.Add(Math.Round(i, 3));
            }
            textTIEN.Text = "10000000";
            cbxlai.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
