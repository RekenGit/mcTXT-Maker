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
    public partial class Form3 : Form
    {
        string filepath = "Block";
        decimal ilosc = 1;
        string bname = "";
        string bfolder = "";

        public Form3()
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
            if (filepath == "") filepath = bname + "_stairs";
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
                            z = "_inner";
                            z2 = "facing=east,half=bottom,shape=inner_left";
                            z3 = ",\"y\": 270,\"uvlock\": true";
                            break;
                        case 2:
                            z = "_inner";
                            z2 = "facing=east,half=bottom,shape=inner_right";
                            break;
                        case 3:
                            z = "_outer";
                            z2 = "facing=east,half=bottom,shape=outer_left";
                            z3 = ",\"y\": 270,\"uvlock\": true";
                            break;
                        case 4:
                            z = "_outer";
                            z2 = "facing=east,half=bottom,shape=outer_left";
                            break;
                        case 5:
                            z2 = "facing=east,half=bottom,shape=straight";
                            break;
                            //----
                        case 6:
                            z = "_inner";
                            z2 = "facing=east,half=top,shape=inner_left";
                            z3 = ",\"x\": 180,\"uvlock\": true";
                            break;
                        case 7:
                            z = "_inner";
                            z2 = "facing=east,half=top,shape=inner_right";
                            z3 = ",\"x\": 180,\"y\": 90,\"uvlock\": true";
                            break;
                        case 8:
                            z = "_outer";
                            z2 = "facing=east,half=top,shape=outer_left";
                            z3 = ",\"x\": 180,\"uvlock\": true";
                            break;
                        case 9:
                            z = "_outer";
                            z2 = "facing=east,half=top,shape=outer_right";
                            z3 = ",\"x\": 180,\"y\": 90,\"uvlock\": true";
                            break;
                        case 10:
                            z2 = "facing=east,half=top,shape=straight";
                            z3 = ",\"x\": 180,\"uvlock\": true";
                            break;
                            //--------------------------------------
                        case 11:
                            z = "_inner";
                            z2 = "facing=north,half=bottom,shape=inner_left";
                            z3 = ",\"y\": 180,\"uvlock\": true";
                            break;
                        case 12:
                            z = "_inner";
                            z2 = "facing=north,half=bottom,shape=inner_right";
                            z3 = ",\"y\": 270,\"uvlock\": true";
                            break;
                        case 13:
                            z = "_outer";
                            z2 = "facing=north,half=bottom,shape=outer_left";
                            z3 = ",\"y\": 180,\"uvlock\": true";
                            break;
                        case 14:
                            z = "_outer";
                            z2 = "facing=north,half=bottom,shape=outer_right";
                            z3 = ",\"y\": 270,\"uvlock\": true";
                            break;
                        case 15:
                            z2 = "facing=north,half=bottom,shape=straight";
                            z3 = ",\"y\": 270,\"uvlock\": true";
                            break;
                            //----
                        case 16:
                            z = "_inner";
                            z2 = "facing=north,half=top,shape=inner_left";
                            z3 = ",\"x\": 180,\"y\": 270,\"uvlock\": true";
                            break;
                        case 17:
                            z = "_inner";
                            z2 = "facing=north,half=top,shape=inner_right";
                            z3 = ",\"x\": 180,\"uvlock\": true";
                            break;
                        case 18:
                            z = "_outer";
                            z2 = "facing=north,half=top,shape=outer_left";
                            z3 = ",\"x\": 180,\"y\": 270,\"uvlock\": true";
                            break;
                        case 19:
                            z = "_outer";
                            z2 = "facing=north,half=top,shape=outer_right";
                            z3 = ",\"x\": 180,\"uvlock\": true";
                            break;
                        case 20:
                            z2 = "facing=north,half=top,shape=straight";
                            z3 = ",\"x\": 180,\"y\": 270,\"uvlock\": true";
                            break;
                        //--------------------------------------
                        case 21:
                            z = "_inner";
                            z2 = "facing=south,half=bottom,shape=inner_left";
                            break;
                        case 22:
                            z = "_inner";
                            z2 = "facing=south,half=bottom,shape=inner_right";
                            z3 = ",\"y\": 90,\"uvlock\": true";
                            break;
                        case 23:
                            z = "_outer";
                            z2 = "facing=south,half=bottom,shape=outer_left";
                            break;
                        case 24:
                            z = "_outer";
                            z2 = "facing=south,half=bottom,shape=outer_right";
                            z3 = ",\"y\": 90,\"uvlock\": true";
                            break;
                        case 25:
                            z2 = "facing=south,half=bottom,shape=straight";
                            z3 = ",\"y\": 90,\"uvlock\": true";
                            break;
                        //----
                        case 26:
                            z = "_inner";
                            z2 = "facing=south,half=top,shape=inner_left";
                            z3 = ",\"x\": 180,\"y\": 90,\"uvlock\": true";
                            break;
                        case 27:
                            z = "_inner";
                            z2 = "facing=south,half=top,shape=inner_right";
                            z3 = ",\"x\": 180,\"y\": 180,\"uvlock\": true";
                            break;
                        case 28:
                            z = "_outer";
                            z2 = "facing=south,half=top,shape=outer_left";
                            z3 = ",\"x\": 180,\"y\": 90,\"uvlock\": true";
                            break;
                        case 29:
                            z = "_outer";
                            z2 = "facing=south,half=top,shape=outer_right";
                            z3 = ",\"x\": 180,\"y\": 180,\"uvlock\": true";
                            break;
                        case 30:
                            z2 = "facing=south,half=top,shape=straight";
                            z3 = ",\"x\": 180,\"y\": 90,\"uvlock\": true";
                            break;
                        //--------------------------------------
                        case 31:
                            z = "_inner";
                            z2 = "facing=west,half=bottom,shape=inner_left";
                            z3 = ",\"y\": 90,\"uvlock\": true";
                            break;
                        case 32:
                            z = "_inner";
                            z2 = "facing=west,half=bottom,shape=inner_right";
                            z3 = ",\"y\": 180,\"uvlock\": true";
                            break;
                        case 33:
                            z = "_outer";
                            z2 = "facing=west,half=bottom,shape=outer_left";
                            z3 = ",\"y\": 90,\"uvlock\": true";
                            break;
                        case 34:
                            z = "_outer";
                            z2 = "facing=west,half=bottom,shape=outer_right";
                            z3 = ",\"y\": 180,\"uvlock\": true";
                            break;
                        case 35:
                            z2 = "facing=west,half=bottom,shape=straight";
                            z3 = ",\"y\": 180,\"uvlock\": true";
                            break;
                        //----
                        case 36:
                            z = "_inner";
                            z2 = "facing=west,half=top,shape=inner_left";
                            z3 = ",\"x\": 180,\"y\": 180,\"uvlock\": true";
                            break;
                        case 37:
                            z = "_inner";
                            z2 = "facing=west,half=top,shape=inner_right";
                            z3 = ",\"x\": 180,\"y\": 270,\"uvlock\": true";
                            break;
                        case 38:
                            z = "_outer";
                            z2 = "facing=west,half=top,shape=outer_left";
                            z3 = ",\"x\": 180,\"y\": 180,\"uvlock\": true";
                            break;
                        case 39:
                            z = "_outer";
                            z2 = "facing=west,half=top,shape=outer_right";
                            z3 = ",\"x\": 180,\"y\": 270,\"uvlock\": true";
                            break;
                        case 40:
                            z2 = "facing=west,half=top,shape=straight";
                            z3 = ",\"x\": 180,\"y\": 180,\"uvlock\": true";
                            break;
                    }
                    if (1 == ilosc)
                    {
                        File.Write("    \"" + z2 + "\": {\n");
                        File.Write("        \"model\":\"minecraft:block/" + bname + "_stairs" + z + "\"" + z3 + "\n");
                        File.Write("    },\n");
                    }
                    else
                    {
                        File.Write("    \"" + z2 + "\": [\n");
                        File.Write("        {\"model\":\"minecraft:block/" + bname + "_stairs" + z + "\"" + z3 + "},\n");
                        for (int i = 1; i <= ilosc; i++)
                        {
                            if (i == ilosc)
                            {
                                File.Write("        {\"model\":\"minecraft:block/" + bfolder + "/" + i + "_stairs" + z + "\"" + z3 + "}\n");
                            }
                            else
                            {
                                File.Write("        {\"model\":\"minecraft:block/" + bfolder + "/" + i + "_stairs" + z + "\"" + z3 + "},\n");
                            }
                        }
                        if(j==y) File.Write("    ]\n");
                        else File.Write("    ],\n");
                    }
                }
            }

            File.Write("{\n");
            File.Write("  \"variants\": {\n");
            napisz(40);
            File.Write("  }\n");
            File.Write("}");
            File.Close();
        }
    }
}
