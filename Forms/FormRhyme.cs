using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TugmaProject.Properties;

namespace TugmaProject.Forms
{
    public partial class FormRhyme : Form
    {
        string rhymeType;
        int numResult = 100;
        public FormRhyme()
        {
            InitializeComponent();

        }

        //execute program when enter is pressed in search bar
        private void tb_SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Search_Click(null, null);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (rb_SlantRhyme.Checked)
            {
                rhymeType = "SlantRhyme";
            }
            else if (rb_EndRhyme.Checked)
            {
                rhymeType = "EndRhyme";
            }
            else
            {
                rb_ExactRhyme.Checked = true;
                rhymeType = "ExactRhyme";
            }
            if (tb_SearchBox.Text == "")
            {
                listBox_Results.Items.Add("Enter a Word");
            }
            else
            {
                RhymeGen GenerateRhyme = new RhymeGen(tb_SearchBox.Text, rhymeType, numResult);
                listBox_Results.DataSource = GenerateRhyme.GenerateWord();
            }
        }
        
    }
    class RhymeGen
    {
        public string UserWord { get; set; }
        public string RhymeType { get; set; }
        public int NumResult { get; set; }
        public RhymeGen(string userWord, string rhymeType, int numResult)
        {
            this.UserWord = userWord.ToLower();
            this.RhymeType = rhymeType;
            this.NumResult = numResult;
        }

        public List<string> GenerateWord()
        {
            string[] wordList = System.IO.File.ReadAllLines("TagalogWords.txt");

            string userVowels;
           List<string> rhymedWords = new List<string>();
           List<string> randomWords = new List<string>();

            foreach (string line in wordList)
            {
                if (line == UserWord) { }

                else if (RhymeType == "ExactRhyme")
                {
                    userVowels = UserWord.ExactRyme();
                    if (userVowels.Equals(line.ExactRyme()))
                    {
                        rhymedWords.Add(line);
                    }
                }
                else if (RhymeType == "SlantRhyme")
                {
                    userVowels = UserWord.SlantRhyme();
                    if (userVowels.Equals(line.SlantRhyme()))
                    {
                        rhymedWords.Add(line);
                    }
                }
                else
                {
                    if (UserWord.Substring(UserWord.Length - 2) == line.Substring(line.Length - 2))
                    {
                        rhymedWords.Add(line);
                    }

                }

            }
            if (rhymedWords.Count == 0)
                rhymedWords.Add("No Rhyming Word Found");

            if (rhymedWords.Count > NumResult)
            {

                for (int i = 0; i < NumResult; i++)
                {

                    var rand = new Random();
                    int index = rand.Next(0, rhymedWords.Count - 1);
                    string randomWord = rhymedWords[index];
                    randomWords.Add(randomWord);
                    rhymedWords.Remove(randomWord);
                }
                return randomWords;
            }
            else return rhymedWords;
            
        }
    }
    public static class VowelExtractor
    {
        public static string ExactRyme(this string word)
        {
            string vowels = "aeiou";
            string result = "";
            foreach (char letter in word)
            {
                if (vowels.Contains(letter))
                {
                    result += letter;
                }
            }
            if (word.Substring(word.Length - 2).Equals("ng"))
            {
                result += word.Substring(word.Length - 2);
            }
            else if (vowels.Contains(word[word.Length - 1])) { }
            else result += word[word.Length - 1];
            return result;
        }
        public static string SlantRhyme(this string word)
        {
            string vowels = "aeiou";
            string result = "";
            foreach (char letter in word)
            {
                if (vowels.Contains(letter))
                {
                    result += letter;
                }
            }
            if (word.Substring(word.Length - 2).Equals("ng"))
            {
                result += word.Substring(word.Length - 2);
            }
            else if (vowels.Contains(word[word.Length - 1])) { }
            return result;
        }
    }
}
