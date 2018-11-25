using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07SentenceGeneration
{
    public partial class FrmMain : Form
    {

        Random random = new Random();
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string GenerateSentence()
        {
            string[] article = { "the", "a", "one", "some", "any" };
            string[] noun = { "boy", "girl", "dog", "town", "car" };
            string[] verb = { "drove", "jumped", "ran", "walked", "skipped" };
            string[] preposition = { "to", "from", "over", "under", "on" };
            string sentence="";
            //
            sentence += Capitalize(RandomWord(article));
            sentence += " " + RandomWord(noun);
            sentence += " " + RandomWord(verb);
            sentence += " " + RandomWord(preposition);
            sentence += " " + RandomWord(article);
            sentence += " " + RandomWord(noun);
            sentence += ".";
            return sentence;
        }
        private string RandomWord(string[] words)
        {
            string word = "";
            int index = random.Next(0, words.Length);
            word = words[index];
            return word;
        }
        private string Capitalize(string input)
        {
            string output;
            output = char.ToUpper(input[0]) + input.Substring(1);
            return output;
        }

        private void btGenerator_Click(object sender, EventArgs e)
        {
            lbxSentences.Items.Add(GenerateSentence());
            lbxSentences.TopIndex = lbxSentences.Items.Count - 1;

        }
    }
}
