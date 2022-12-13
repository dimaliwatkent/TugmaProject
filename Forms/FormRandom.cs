using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugmaProject.Forms
{
    public partial class FormRandom : Form
    {
        string[] wordList = System.IO.File.ReadAllLines("TagalogWords.txt");
        Random rand = new Random();
        int numRhyme = 0;
        public FormRandom()
        {
            InitializeComponent();
            
        }

        private void btn_Randomize_Click(object sender, EventArgs e)
        {

            if (rb_6.Checked) numRhyme = 6;
            else if (rb_4.Checked) numRhyme = 4;
            else numRhyme = 2;

            if (cb_generateWord.Checked == true)
            {
                List<string> listWord = GenRandomWord();
                
                if (listWord.Count < numRhyme) { }
                else
                {
                    string newListWord = string.Join("\n", listWord);
                    lbl_GenWord.Text = newListWord;
                }

                
            }
            else
            {
                string randomWord = wordList[rand.Next(0, wordList.Length)];
                lbl_GenWord.Text = randomWord;
            }
        }

        public List<string> GenRandomWord()
        {
            string randomWord = wordList[rand.Next(0, wordList.Length)];
            RhymeGen GenerateRhyme = new RhymeGen(randomWord, "ExactRhyme", numRhyme);
            return GenerateRhyme.GenerateWord();
        }

        private void cb_generateWord_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (cb_generateWord.Checked == true)
            {
                rb_2.Visible = true;
                rb_4.Visible = true;
                rb_6.Visible = true;
                lbl_2.Visible = true;
                lbl_4.Visible = true;
                lbl_6.Visible = true;
            }
            else
            {
                rb_2.Visible = false;
                rb_4.Visible = false;
                rb_6.Visible = false;
                lbl_2.Visible = false;
                lbl_4.Visible = false;
                lbl_6.Visible = false;
            }
        }
    }
}
