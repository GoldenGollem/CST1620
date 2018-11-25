//Guess A Word
//Author : Nate Christensen
//Date : 10/05/2018
//FormMain.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0610GuessAWord
{
    public partial class FormMain : Form
    {
        Random randomNum = new Random();
        string[] wordBank = { "average", "pineapple", "express", "robot",
            "zebra", "mussels", "knuckle", "chocolate", "monitor", "dragon" };
        string lettersUsed="";
        string lettersUnused = "abcdefghijklmnopqrstuvwxyz";
        int numTries=0;
        string hiddenWord;
        string word;
        //Sound Variable
        SoundPlayer tada = new SoundPlayer(_0610GuessAWord.Properties.Resources.tada);
        

        public FormMain()
        {
            InitializeComponent();
        }

        private void btGuess_Click(object sender, EventArgs e)
        {
            LetterEntered();
        }

        private void txtGuessLetter_TextChanged(object sender, EventArgs e)
        {
            btReset.Visible = true;
            if (txtGuessLetter.Text != "")
            {
                btGuess.Enabled = true;
            }
            else
            {
                btGuess.Enabled = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void NewGame()
        {
            numTries = 0;
            word = wordBank[randomNum.Next(0,wordBank.Length)];
            hiddenWord = "";
            //lettersUnused = "abcdefghijklmnopqrstuvwxyz";
            for (int i =0; i < word.Length; i++)
            {
                hiddenWord += "*";
            }
            lettersUsed ="";
            //txtUnusedLetters.Text = lettersUnused;
            lbHiddenWord.Text = hiddenWord;
            lbStatus.Text = "";
            btReset.Visible = false;
            txtGuessLetter.Text = "";
            txtGuessLetter.Enabled = true;
            txtGuessLetter.Focus();
            txtLettersUsed.Text = "";
            txtTries.Text = Convert.ToString(numTries);
        }
        

        void LetterEntered()
        {
            string myLetter;
            char[] hiddenWordChars = hiddenWord.ToCharArray();
            myLetter = txtGuessLetter.Text;
            //char letter = Convert.ToChar(myLetter);

            if (lettersUsed.Contains(myLetter))
            {
                lbStatus.Text = "You already used that letter";
            }
            else
            {
                //Only counts the tries if letter has not been guessed
                numTries++;
                //Sorts Used Letters in Alpebetical Order
                lettersUsed += myLetter;
                char[] letters = lettersUsed.ToCharArray();
                Array.Sort(letters);
                lettersUsed = new string(letters);
                txtLettersUsed.Text = lettersUsed;
             /*   THIS IS NOT FUNCTIONING
                //Removes the letter from unused list
                if (lettersUnused.Contains(myLetter))
                {
                    for(int i = 0; i < lettersUnused.Length; i++)
                    {
                        if (lettersUnused.Substring(i, 1) == myLetter)
                        {
                            //A match is found
                            lettersUnused.Remove(i,1);
                        }
                    }
                    txtUnusedLetters.Text = lettersUnused;
                }
                */
                //
                Boolean found = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word.Substring(i, 1) == myLetter)
                    {
                        //A match is found
                        hiddenWordChars[i] = Convert.ToChar(myLetter);
                        found = true;
                    }
                }
                if (found) lbStatus.Text = "You guessed correctly";
                else lbStatus.Text = "You guessed incorrectly";
                hiddenWord = new string(hiddenWordChars);
                lbHiddenWord.Text = hiddenWord;
                txtGuessLetter.Text = "";
                txtTries.Text = Convert.ToString(numTries);
                if (!hiddenWord.Contains("*"))
                {
                    lbStatus.Text = "You Solved the Word";
                    btGuess.Enabled = false;
                    txtGuessLetter.Enabled = false;
                    //Win Sound Plays
                    tada.Play();
                }
            }
            txtGuessLetter.Focus();
        }
    }
}
