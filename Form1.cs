using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace азбука_морзе
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        char[] characters = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и',
                                         'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 
                                         'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ч', 'ь',
                                         'э', 'ю', 'я', '.', ',', '?', '!', '1', '2', '3',
                                         '4', '5', '6', '7', '8', '9', '0'};
 
        string[] codeMorse = new string[] { "._", "_...", ".__", "__.", 
                                            "_..", ".", "..._", "__..",
                                            "..", ".___", "_._", "._..",
                                            "__", "_.", "___", ".__.", 
                                            "._.", "...", "_", ".._", 
                                            ".._.", "....", "_._.",
                                            "___.", "____", "__._",
                                            "_.__", "_.._", ".._..",
                                            "..__", "._._", "......", "_._._.",
                                            "..__..", "__..__", ".____", "..___", 
                                            "...__", "...._", ".....", "_....",
                                               "__...","___..", "____.", "_____" };
 
       
 
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string output = "";
            int index;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(characters, c);
                    output += codeMorse[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox2.Text = output;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string input = textBox3.Text;
            string[] split = input.Split(' ');
            string output = "";
            int index;
            foreach (string s in split)
            {
                index = Array.IndexOf(codeMorse, s);
                output += characters[index] + " ";
            }
            output = output.Remove(output.Length - 1);
            textBox4.Text = output;
        }
    }
}
