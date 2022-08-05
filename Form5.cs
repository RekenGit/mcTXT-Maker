using System;
using System.IO;
using System.Windows.Forms;

namespace MinecraftTXT
{
    public partial class Form5 : Form
    {
        string txtname = "";

        public Form5()
        {
            InitializeComponent();
        }

        void slab()
        {
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                StreamWriter File = new StreamWriter(i + "_slab.json");
                File.Write("{\n");
                File.Write("  \"parent\": \"minecraft:block/slab\",\n");
                File.Write("  \"textures\": {\n");
                File.Write("    \"bottom\": \"minecraft:block/" + txtname + i + "\",\n");
                File.Write("    \"top\": \"minecraft:block/" + txtname + i + "\",\n");
                File.Write("    \"side\": \"minecraft:block/" + txtname + i + "\"\n");
                File.Write("  }\n");
                File.Write("}");
                File.Close();
                StreamWriter File2 = new StreamWriter(i + "_slab_top.json");
                File2.Write("{\n");
                File2.Write("  \"parent\": \"minecraft:block/slab_top\",\n");
                File2.Write("  \"textures\": {\n");
                File2.Write("    \"bottom\": \"minecraft:block/" + txtname + i + "\",\n");
                File2.Write("    \"top\": \"minecraft:block/" + txtname + i + "\",\n");
                File2.Write("    \"side\": \"minecraft:block/" + txtname + i + "\"\n");
                File2.Write("  }\n");
                File2.Write("}");
                File2.Close();
            }
        }

        void stairs()
        {
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                StreamWriter File = new StreamWriter(i + "_stairs.json");
                File.Write("{\n");
                File.Write("  \"parent\": \"minecraft:block/stairs\",\n");
                File.Write("  \"textures\": {\n");
                File.Write("    \"bottom\": \"minecraft:block/" + txtname + i + "\",\n");
                File.Write("    \"top\": \"minecraft:block/" + txtname + i + "\",\n");
                File.Write("    \"side\": \"minecraft:block/" + txtname + i + "\"\n");
                File.Write("  }\n");
                File.Write("}");
                File.Close();
                StreamWriter File2 = new StreamWriter(i + "_stairs_inner.json");
                File2.Write("{\n");
                File2.Write("  \"parent\": \"minecraft:block/inner_stairs\",\n");
                File2.Write("  \"textures\": {\n");
                File2.Write("    \"bottom\": \"minecraft:block/" + txtname + i + "\",\n");
                File2.Write("    \"top\": \"minecraft:block/" + txtname + i + "\",\n");
                File2.Write("    \"side\": \"minecraft:block/" + txtname + i + "\"\n");
                File2.Write("  }\n");
                File2.Write("}");
                File2.Close();
                StreamWriter File3 = new StreamWriter(i + "_stairs_outer.json");
                File3.Write("{\n");
                File3.Write("  \"parent\": \"minecraft:block/outer_stairs\",\n");
                File3.Write("  \"textures\": {\n");
                File3.Write("    \"bottom\": \"minecraft:block/" + txtname + i + "\",\n");
                File3.Write("    \"top\": \"minecraft:block/" + txtname + i + "\",\n");
                File3.Write("    \"side\": \"minecraft:block/" + txtname + i + "\"\n");
                File3.Write("  }\n");
                File3.Write("}");
                File3.Close();
            }
        }

        void wall()
        {
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                StreamWriter File = new StreamWriter(i + "_wall_post.json");
                File.Write("{\n");
                File.Write("  \"parent\": \"minecraft:block/template_wall_post\",\n");
                File.Write("  \"textures\": {\n");
                File.Write("    \"wall\": \"minecraft:block/" + txtname + i + "\"\n");
                File.Write("  }\n");
                File.Write("}");
                File.Close();
                StreamWriter File2 = new StreamWriter(i + "_wall_side.json");
                File2.Write("{\n");
                File2.Write("  \"parent\": \"minecraft:block/template_wall_side\",\n");
                File2.Write("  \"textures\": {\n");
                File2.Write("    \"wall\": \"minecraft:block/" + txtname + i + "\"\n");
                File2.Write("  }\n");
                File2.Write("}");
                File2.Close();
                StreamWriter File3 = new StreamWriter(i + "_wall_side_tall.json");
                File3.Write("{\n");
                File3.Write("  \"parent\": \"minecraft:block/template_wall_side_tall\",\n");
                File3.Write("  \"textures\": {\n");
                File3.Write("    \"wall\": \"minecraft:block/" + txtname + i + "\"\n");
                File3.Write("  }\n");
                File3.Write("}");
                File3.Close();
            }
        }

        void block()
        {
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                StreamWriter File = new StreamWriter(i + ".json");
                File.Write("{\n");
                File.Write("  \"parent\": \"minecraft:block/cube_all\",\n");
                File.Write("  \"textures\": {\n");
                File.Write("    \"all\": \"minecraft:block/" + txtname + i + "\"\n");
                File.Write("  }\n");
                File.Write("}");
                File.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname = textBox1.Text;
            if (txtname == "") MessageBox.Show("Podaj Nazwę", "Podaj nazwę textury", MessageBoxButtons.OK, MessageBoxIcon.Error);

            bool c1 = checkBox1.Checked;
            bool c2 = checkBox2.Checked;
            bool c3 = checkBox3.Checked;
            bool c4 = checkBox4.Checked;
            if (c1 && !c2 && !c3 && !c4) slab();
            else if (!c1 && c2 && !c3 && !c4) stairs();
            else if (!c1 && !c2 && c3 && !c4) wall();
            else if (!c1 && !c2 && !c3 && c4) block();
            else MessageBox.Show("Błędne zaznaczenie!", "Zaznacz tylko 1 opcję", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
