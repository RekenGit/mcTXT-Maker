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
    public partial class Form2 : Form
    {
        string filepath = "Block";
        decimal ilosc = 1;
        string bname = "";
        string bfolder = "";
        bool bs = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filepath = textBox1.Text;
            ilosc = numericUpDown1.Value;
            bname = textBox3.Text;
            bfolder = textBox4.Text;
            bs = checkBox1.Checked;

            if (bname == "") MessageBox.Show("Podaj Nazwę", "Podaj nazwę bloku", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (filepath == "") filepath = bname+"_slab";
            if (ilosc == 0) MessageBox.Show("Podaj inną ilość!", "Błędna ilość", MessageBoxButtons.OK, MessageBoxIcon.Error);

            StreamWriter File = new StreamWriter(filepath + ".json");

            void napisz(int y)
            {
                string z = "";
                string z2 = "";
                switch (y)
                {
                    case 1:
                        z = "_slab";
                        z2 = "bottom";
                        break;
                    case 2:
                        z = "";
                        z2 = "double";
                        break;
                    case 3:
                        z = "_slab_top";
                        z2 = "top";
                        break;
                }
                if (1 == ilosc)
                {
                    File.Write("    \"type="+z2+"\": {\n");
                    if (y == 2)
                    {
                        if (bs) File.Write("        \"model\":\"minecraft:block/" + bname + z + "s\"\n");
                        else File.Write("        \"model\":\"minecraft:block/" + bname + z + "\"\n");
                    }
                    else File.Write("        \"model\":\"minecraft:block/" + bname + z + "\"\n");
                    if (y == 3) File.Write("    }\n");
                    else File.Write("    },\n");
                }
                else
                {
                    File.Write("    \"type=" + z2 + "\": [\n");
                    if (y == 2)
                    {
                        if (bs) File.Write("        {\"model\":\"minecraft:block/" + bname + z + "s\"},\n");
                        else File.Write("        {\"model\":\"minecraft:block/" + bname + z + "\"},\n");
                    }
                    else File.Write("        {\"model\":\"minecraft:block/" + bname + z + "\"},\n");

                    for (int i = 1; i <= ilosc; i++)
                    {
                        if (i == ilosc)
                        {
                            File.Write("        {\"model\":\"minecraft:block/" + bfolder + "/" + i + z + "\"}\n");
                        }
                        else
                        {
                            File.Write("        {\"model\":\"minecraft:block/" + bfolder + "/" + i + z + "\"},\n");
                        }
                    }
                    if (y==3) File.Write("    ]\n");
                    else File.Write("    ],\n");
                }
            }

            File.Write("{\n");
            File.Write("  \"variants\": {\n");
            napisz(1);
            napisz(2);
            napisz(3);
            File.Write("  }\n");
            File.Write("}");
            File.Close();
        }
    }
}
