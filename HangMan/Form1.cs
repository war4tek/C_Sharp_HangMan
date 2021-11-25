using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        List<int> phraseList;
        List<string> images;
        int correctLetterCount;
        int imageIndex;
        string phrase;
        int textboxcount;
        int letterOnPanelX;
        int letterOnPanelY = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            letterOnPanelX = 0;
            letterOnPanelY = 0;
            correctLetterCount = 0;
            imageIndex = 0;
            phrase = "";
            textboxcount = 0;
            pictureBox1.Visible = false;

            phraseList = new List<int>();
            images = new List<string>();

            ClearPhrase();
            ClearLettersUsedPanel();
        }

        private void CreateNewGame()
        {
            Initialize();

            string selectedCategory = comboBox1.GetItemText(comboBox1.SelectedItem);
            string path = "";

            if ((!String.IsNullOrEmpty(selectedCategory)))
            {
                string startupPath = Application.StartupPath.Replace(@"bin\Debug", "");
                string category = @"Categories\";

                if (selectedCategory.Equals("Sight Words"))
                {
                    path = $"{startupPath}{category}SightWords.txt";
                    phrase = GetPhrasesFromFile(path);
                }
                else if(selectedCategory.Equals("Colors"))
                {
                    path = $"{startupPath}{category}Colors.txt";
                    phrase = GetPhrasesFromFile(path);
                }
                else if (selectedCategory.Equals("Numbers"))
                {
                    path = $"{startupPath}{category}Numbers.txt";
                    phrase = GetPhrasesFromFile(path);
                }
                else if (selectedCategory.Equals("Bob"))
                {
                    path = $"{startupPath}{category}Bob.txt";
                    phrase = GetPhrasesFromFile(path);
                }
                else if(selectedCategory.Equals("Names"))
                {
                    path = $"{startupPath}{category}Names.txt";
                    phrase = GetPhrasesFromFile(path);
                }
                else
                {
                    phrase = GetPhrase();
                }
            }  

            DrawPhrase(phrase);
            textboxcount = GetTextBoxCount();
            letterLbl.Visible = true;
            letterTexBox.Visible = true;
            letterTexBox.Focus();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            CreateNewGame();
        }

        private string GetPhrase()
        {
            List<string> phrases = new List<string>
            {
                "Hello World".ToUpper(),
                "I love my dad".ToUpper(),
                "You are my friend".ToUpper(),
                "New Mexico".ToUpper()
            };

            Random r = new Random();
            int randomNumber = r.Next(0, phrases.Count);
            string phrase = phrases[randomNumber];
            return phrase;
        }

        private string GetPhrasesFromFile(string file)
        {
            string[] phrases = System.IO.File.ReadAllLines(file);

            Random r = new Random();
            int randomNumber = r.Next(0, phrases.Length);
            string phrase = phrases[randomNumber];
            return phrase;
        }

        private void ClearPhrase()
        {
            List<TextBox> tb = new List<TextBox>();
            foreach (TextBox t in phrasePanel.Controls)
            {
                tb.Add(t);
            }
            foreach (TextBox t in tb)
            {
                phrasePanel.Controls.Remove(t);
            }
        }

        private void ClearLettersUsedPanel()
        {
            List<Label> tb = new List<Label>();
            foreach (Label t in lettersUsedPanel.Controls)
            {
                tb.Add(t);
            }
            foreach (Label t in tb)
            {
                lettersUsedPanel.Controls.Remove(t);
            }
        }

        /*
         * Draw Phrase accepts a phrase and draws the textboxes that will contain the letter.
         * Initially the phrase is drawn with text boxes only and no letters. Subsuquent drawings 
         * of the textbox contain the letters that were correctly chosen. 
         * 
         */

        private void DrawPhrase(string phrase)
        {
            int x = 40;
            int y = 10;
         
            for (int i = 0; i < phrase.Length; i++)
            {
                if(phrase[i] == ' ')
                {
                    x += 25;
                }
                else
                {
                    if (x > 550)
                    {
                        x = 40;
                        y += 50;
                    }
                    TextBox tb = new TextBox();

                    tb.TextAlign = HorizontalAlignment.Center;
                    tb.Size = new Size(30, 30);

                    if (phraseList.Contains(i))
                    {
                        tb.Text = phrase[i].ToString();
                        correctLetterCount++;
                    }
                    else
                    {
                        tb.Text = "";
                    }

                    Point p = new Point(x, y);
                    tb.Location = p;
                    phrasePanel.Controls.Add(tb);

                    x += 30;
                }
            }
        }

        private void DrawImage()
        {
            string startupPath = Application.StartupPath.Replace(@"bin\Debug", "");
            List<string> images = LoadImagesInList();
            string temp = @"Images\";
            string path = $"{startupPath}{temp}{images[imageIndex]}";

            Bitmap b = new Bitmap(path);
            pictureBox1.Image = (Image) b;
            pictureBox1.Visible = true;
            drawingPanel.Controls.Add(pictureBox1);
            imageIndex++;
        }

        private List<string> LoadImagesInList()
        {
            List<string> imageList = new List<string>
            {
                "hangman.png", "head.png","body.png","leftarm.png",
                "rightarm.png","leftleg.png","rightleg.png"
            };
            return imageList;
        }

        private int GetTextBoxCount()
        {
            List<TextBox> tbs = new List<TextBox>();

            foreach (TextBox t in phrasePanel.Controls)
            {
                tbs.Add(t);
            }
            return tbs.Count;
        }

        private void ClearPhraseBtn_Click(object sender, EventArgs e)
        {
            ClearPhrase();
        }

        private string BuildPath(string file)
        {
            string startupPath = Application.StartupPath;
            string firstPart = startupPath.Remove(startupPath.IndexOf("bin"));
            string soundPath = $"{firstPart}Sounds\\{file}";
            return soundPath;
        }

        private void LetterTexBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(letterTexBox.Text))
            {
                string letter = letterTexBox.Text;
                List<int> lettersFound = FindIndexesOf(phrase.ToUpper(), letter.ToUpper());
                phraseList.AddRange(lettersFound);
                string file;

                if (lettersFound.Count > 0)
                {
                    file = "correct.wav";
                    PlayWav(BuildPath(file));

                    ClearPhrase();
                    DrawPhrase(phrase);
                    textboxcount = GetTextBoxCount();

                    //check if game is over
                    //compare how many textboxes have a letter assigned to them 
                    //with the total number of text boxes.this determines the winner
                    if(textboxcount == phraseList.Count)
                    {
                        file = "applause.mp3";
                        PlayMP3(BuildPath(file));
        
                        MessageBox.Show("You win!", "Hangman");
                        CreateNewGame();
                    }
                }
                else
                {
                    file = "wrong.mp3";
                    PlayMP3(BuildPath(file));
                    DrawImage();
                    DrawLetterOnPanel(letter);

                    if (imageIndex == 7)
                    {
                        file = "lost.wav";
                        PlayWav(BuildPath(file));
                        MessageBox.Show("You lose", "Hangman");
                        CreateNewGame();
                    }
                }
                ResetLetterTextBox();
            }
        }

        private void ResetLetterTextBox()
        {
            letterTexBox.Clear();
            letterTexBox.Select(0, 0);
            letterTexBox.Focus();
            letterTexBox.ScrollToCaret();
        }

        private void PlayMP3(string path)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = path;
            wplayer.controls.play();
        }

        private void PlayWav(string path)
        {
            SoundPlayer player;
            player = new SoundPlayer(path);
            player.Play();
        }

        private void DrawLetterOnPanel(string letter)
        {
            Point p = new Point(letterOnPanelX, letterOnPanelY);
            AddLabel(letter, p);

            letterOnPanelX += 30;
            letterOnPanelY += 0;
        }


        private void AddLabel(string letter, Point p)
        {
            Label lbl = new Label
            {
                Size = new Size(30,30),
                Text = letter.ToUpper(),
                Location = p
            };

            lettersUsedPanel.Controls.Add(lbl);
        }
        private List<int> FindIndexesOf(string str, string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Specify a value to search for!", "value");
            }

            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            //play sound file 
            string startupPath = Application.StartupPath.Replace(@"bin\Debug", "");
            string soundFolder = @"Sounds\";
            SoundPlayer player;
            string soundPath;


            soundPath = $"{startupPath}{soundFolder}correct.wav";

            player = new SoundPlayer(soundPath);
            player.Load();
            player.Play();
        }
    }
}
