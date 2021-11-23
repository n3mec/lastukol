using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastukol
{
    public partial class Minimum : Form
    {
        public Minimum()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int min=0;
            bool minJe = false;
            foreach (string line in textBox1.Lines)
            {
                try {
                    int x = int.Parse(line);
                    if (x % 2 == 0) {
                        if (!minJe) { min = x; minJe = true; }
                        else if (min > x) { min = x; }
                    }
                    
                }
                catch { }
            }
            if (minJe) { MessageBox.Show("Minimum je " + min, "Výsledek", MessageBoxButtons.OK); }
            else { MessageBox.Show("Nebylo nalezeno žádné minimum", "Výsledek", MessageBoxButtons.OK); }
        }
    }
}
