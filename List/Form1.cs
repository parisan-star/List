
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckText(string text, string ch)
        {
            if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(ch))
                return true;

            MessageBox.Show("در باکس اول متن و در باکس دوم حرف را وارد کنید");
            return false;
        }
        private void CounterWords(string[] words, char ch)
        {
            int count = words.Count(word => word.Contains(ch));
            MessageBox.Show("Words:"+count);
        }
        private void CounterLetter(string[] words, char ch)
        {
            int count = words.Sum(word => word.Count(letter => letter == ch));
            MessageBox.Show("Letter:" + count);
        }
        private void ShowList(string[] words, char ch)
        {
            var filtered = words.Where(word => word.Contains(ch)).ToList();

            if (filtered.Any())
                MessageBox.Show( string.Join(" - ", filtered));
            else
                MessageBox.Show("هیچ کلمه ای شامل این حروف نیست");
        }
        private void BtnCountWord_Click(object sender, EventArgs e)
        {
            if (!CheckText(TxtGetText.Text, TxtGetChar.Text)) return;

            string[] words = TxtGetText.Text.Split(' ');
            char ch = TxtGetChar.Text[0];

            CounterWords(words, ch);
        }

        private void BtnWordList_Click(object sender, EventArgs e)
        {
            if (!CheckText(TxtGetText.Text, TxtGetChar.Text)) return;

            string[] words = TxtGetText.Text.Split(' '); 
            char ch = TxtGetChar.Text[0];

            ShowList(words, ch);
        }
        private void BtnCountLetter_Click(object sender, EventArgs e)
        {
            if (!CheckText(TxtGetText.Text, TxtGetChar.Text)) return;

            string[] words = TxtGetText.Text.Split(' '); 
            char ch = TxtGetChar.Text[0];

            CounterLetter(words, ch);
        }
    }
}
