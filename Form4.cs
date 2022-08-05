using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftTXT
{
    public partial class Form4 : Form
    {
        string filepath = "Block";
        decimal ilosc = 1;
        string bname = "";
        string bfolder = "";

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filepath = textBox1.Text;
            ilosc = numericUpDown1.Value;
            bname = textBox3.Text;
            bfolder = textBox4.Text;

            if (bname == "") MessageBox.Show("Podaj Nazwę", "Podaj nazwę bloku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (filepath == "") filepath = bname + "_wall";
            if (ilosc == 0) MessageBox.Show("Podaj inną ilość!", "Błędna ilość", MessageBoxButtons.OK, MessageBoxIcon.Error);

            StreamWriter File = new StreamWriter(filepath + ".json");

            void napisz(int y)
            {
                for (int j = 1; j <= y; j++)
                {
                    string z = "";
                    string z2 = "";
                    string z3 = "";
                    switch (j)
                    {
                        case 1:
                            z = "_post";
                            z2 = "when\": { \"up\": \"true\"},\"apply";
                            break;
                        case 2:
                            z = "_side";
                            z2 = "when\": { \"north\": \"low\"},\"apply";
                            z3 = ",\"uvlock\": true";
                            break;
                        case 3:
                            z = "_side";
                            z2 = "when\": { \"east\": \"low\"},\"apply";
                            z3 = ",\"y\": 90,\"uvlock\": true";
                            break;
                        case 4:
                            z = "_side";
                            z2 = "when\": { \"south\": \"low\"},\"apply";
                            z3 = ",\"y\": 180,\"uvlock\": true";
                            break;
                        case 5:
                            z = "_side";
                            z2 = "when\": { \"west\": \"low\"},\"apply";
                            z3 = ",\"y\": 270,\"uvlock\": true";
                            break;
                        case 6:
                            z = "_side_tall";
                            z2 = "when\": { \"north\": \"tall\"},\"apply";
                            z3 = ",\"uvlock\": true";
                            break;
                        case 7:
                            z = "_side_tall";
                            z2 = "when\": { \"east\": \"tall\"},\"apply";
                            z3 = ",\"y\": 90,\"uvlock\": true";
                            break;
                        case 8:
                            z = "_side_tall";
                            z2 = "when\": { \"south\": \"tall\"},\"apply";
                            z3 = ",\"y\": 180,\"uvlock\": true";
                            break;
                        case 9:
                            z = "_side_tall";
                            z2 = "when\": { \"west\": \"tall\"},\"apply";
                            z3 = ",\"y\": 270,\"uvlock\": true";
                            break;
                    }
                    File.Write("   {\n");
                    if (1 == ilosc)
                    {
                        File.Write("    \"" + z2 + "\": {\n");
                        File.Write("      \"model\":\"minecraft:block/" + bname + "_wall" + z + "\"" + z3 + "\n");
                        File.Write("    },\n");
                    }
                    else
                    {
                        File.Write("    \"" + z2 + "\": [\n");
                        File.Write("      {\"model\":\"minecraft:block/" + bname + "_wall" + z + "\"" + z3 + "},\n");
                        for (int i = 1; i <= ilosc; i++)
                        {
                            if (i == ilosc)
                            {
                                File.Write("      {\"model\":\"minecraft:block/" + bfolder + "/" + i + "_wall" + z + "\"" + z3 + "}\n");
                            }
                            else
                            {
                                File.Write("      {\"model\":\"minecraft:block/" + bfolder + "/" + i + "_wall" + z + "\"" + z3 + "},\n");
                            }
                        }
                        File.Write("    ]\n");
                        if (j == y) File.Write("   }\n");
                        else File.Write("   },\n");
                    }
                }
            }

            File.Write("{\n");
            File.Write("  \"multipart\": [\n");
            napisz(9);
            File.Write("  ]\n");
            File.Write("}");
            File.Close();
        }
    }
}
