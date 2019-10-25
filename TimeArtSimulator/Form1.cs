using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telegram.Bot;

namespace TimeArtSimulator
{
    public partial class Form1 : Form
    {
        int interval = 1000;
        int MessageCnt = 0;
        int PreviousMessageCnt = 0;
        string lastmessage = "";
        string otherinfo = "";
        private TelegramBotClient Bot = new TelegramBotClient("886075982:AAEEhP9F89HTXKcsw77ab-uRVK1LcPTCh9o");
        PictureBox[] Lampade = new PictureBox[8];
        Random rand = new Random();
        //enum LampColor { White, Red, Red2, Green, Green2, Blue, Blue2, Blue3, Orange, Orange2, Purple, Purple2, Ciano, Ciano2, Yellow, Fuchsia};
        List<Color> colors = new List<Color>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                MessageCnt++;
                otherinfo = e.Message.From.ToString();
                lastmessage = e.Message.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bot.OnMessage += Bot_OnMessage;
            Bot.StartReceiving();
            CheckForNewMessages.Enabled = true;
            Lampade[0] = lamp1.Clone();
            Lampade[1] = lamp2.Clone();
            Lampade[2] = lamp3.Clone();
            Lampade[3] = lamp4.Clone();
            Lampade[4] = lamp5.Clone();
            Lampade[5] = lamp6.Clone();
            Lampade[6] = lamp7.Clone();
            Lampade[7] = lamp8.Clone();
            lamp1.Visible = false;
            lamp2.Visible = false;
            lamp3.Visible = false;
            lamp4.Visible = false;
            lamp5.Visible = false;
            lamp6.Visible = false;
            lamp7.Visible = false;
            lamp8.Visible = false;
            for (int i=0; i<8; i++)
            {
                Lampade[i].BringToFront();
            }
            try
            {
                string text;
                using (var streamReader = new StreamReader("colors.txt", Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                }
                string[] temp;
                temp = Regex.Replace(text, @"^\s*$\n", string.Empty, RegexOptions.Multiline).TrimEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (string hex in temp)
                {
                    colors.Add(ColorTranslator.FromHtml(hex));
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Errore nella lettura di 'colors.txt'. \r\nDi seguito i dettagli:\r\n\r\n" + error.Message, "Errore fatale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void CheckForNewMessages_Tick(object sender, EventArgs e)
        {
            if (PreviousMessageCnt != MessageCnt)
            {
                PreviousMessageCnt = MessageCnt;
                log.Text += "Comando ricevuto: '" + lastmessage + "' inviato da " + otherinfo + "\r\n";
                if (lastmessage.ToLower() == "/off")
                {
                    log.Text += "Comando riconosciuto: spegni lampade.\r\n";
                    TurnOff();
                }
                else if (lastmessage.Count() >= 7)
                {
                    if (lastmessage.Substring(0, 5).ToLower() == "/game")
                    {
                        int lastNum = lastmessage[lastmessage.Count() - 1] - 48;
                        if (lastNum > 0 && lastNum < 5)
                        {
                            log.Text += "Comando riconosciuto: gioco di colori " + lastNum + ".\r\n";
                            LaunchGame(lastNum);
                        }
                    }
                    else if (lastmessage.Count() >= 10)
                    {
                        if (lastmessage.Substring(0, 8).ToLower() == "/settime")
                        {
                            int milliseconds = 0;
                            int.TryParse(lastmessage.Substring(8, lastmessage.Length - 8), out milliseconds);
                            interval = milliseconds;
                            log.Text += "Comando riconosciuto: delay tra ogni azione cambiato a " + milliseconds + "ms.\r\n";
                        }
                    }
                }
            }
        }

        private void Start_stop_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Ferma")
            {
                (sender as Button).Image = Properties.Resources.start;
                Bot.StopReceiving();
                (sender as Button).Text = "Avvia";
            }
            else
            {
                (sender as Button).Image = Properties.Resources.stop;
                Bot.StartReceiving();
                (sender as Button).Text = "Ferma";
            }
        }

        void TurnOff()
        {
            DisableGames();
            GrayOut();
        }

        void GrayOut()
        {
            for (int i = 0; i < 8; i++)
            {
                Lampade[i].BackColor = Color.DarkGray;
                Lampade[i].Refresh();
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            try
            {
                log.Text = "";
            }
            catch
            {

            }
        }

        private void Log_TextChanged(object sender, EventArgs e)
        {
            log.Select(log.Text.Length - 1, log.Text.Length - 1);
            log.AppendText("");
            log.ScrollToCaret();
        }

        void DisableGames()
        {
            GrayOut();
            Game1.Enabled = false;
            Game2.Enabled = false;
            Game3.Enabled = false;
            Game4.Enabled = false;
        }

        void LaunchGame(int game)
        {
            DisableGames();
            GrayOut();
            switch (game)
            {
                case 1:
                    On = 0;
                    colorIndex = 0;
                    firsttime = true;
                    Game1.Enabled = true;
                    break;
                case 2:
                    On = 0;
                    colorIndex = 0;
                    Game2.Enabled = true;
                    break;
                case 3:
                    On = 0;
                    colorIndex = 0;
                    Game3.Enabled = true;
                    break;
                case 4:
                    Game4.Enabled = true;
                    break;
            }
        }

        int On = 0;
        int colorIndex = 0;
        bool firsttime = true;
        private void Game1_Tick(object sender, EventArgs e)
        {
            Game1.Interval = interval;

            GrayOut();
            if (On == -1)
            {
                Lampade[0].BackColor = colors[colorIndex];
                colorIndex++;
                if (colorIndex == colors.Count())
                {
                    colorIndex = 0;
                }
            }
            else
            {
                Lampade[On].BackColor = colors[colorIndex];
            }
            if (firsttime)
            {
                On++;
            }
            else
            {
                On--;
            }
            if (On == 8)
            {
                On = 6;
                firsttime = false;
            }
            else if (On == 0 && !firsttime)
            {
                firsttime = true;
                On--;
            }
        }

        private void Game2_Tick(object sender, EventArgs e)
        {
            Game2.Interval = interval;
            Lampade[On].BackColor = colors[colorIndex];
            On++;
            if (On == 8)
            {
                On = 0;
                colorIndex++;
                if (colorIndex == colors.Count())
                {
                    colorIndex = 0;
                }
            }
        }

        private void Game3_Tick(object sender, EventArgs e)
        {
            Game3.Interval = interval;
            Lampade[On].BackColor = colors[colorIndex];
            Lampade[7-On].BackColor = colors[colorIndex];
            On++;
            if (On == 4)
            {
                On = 0;
                colorIndex++;
                if (colorIndex == colors.Count())
                {
                    colorIndex = 0;
                }
            }
        }

        private void Game4_Tick(object sender, EventArgs e)
        {
            Game4.Interval = interval;
            Lampade[rand.Next(8)].BackColor = colors[rand.Next(colors.Count())];
        }

        private void Show_hide_Click(object sender, EventArgs e)
        {
            int difference = 126;
            if ((sender as Button).Text == "Nascondi log")
            {
                (sender as Button).Image = Properties.Resources.up;
                log.Visible = false;
                clean.Visible = false;
                start_stop.Location = new Point(start_stop.Location.X, start_stop.Location.Y + difference+2);
                fullscreen.Location=new Point(fullscreen.Location.X, start_stop.Location.Y);
                (sender as Button).Text = "Mostra log";
                show_hide.Location = new Point(clean.Location.X, start_stop.Location.Y);
                panel1.Size = new Size(panel1.Width, panel1.Height + difference);
                cover.Location = new Point(cover.Location.X, cover.Location.Y + difference);
            }
            else
            {
                (sender as Button).Image = Properties.Resources.down;
                log.Visible = true;
                clean.Visible = true;
                start_stop.Location = new Point(start_stop.Location.X, start_stop.Location.Y - difference-2);
                fullscreen.Location = new Point(fullscreen.Location.X, start_stop.Location.Y);
                (sender as Button).Text = "Nascondi log";
                show_hide.Location = new Point(clean.Location.X + clean.Size.Width + 7, start_stop.Location.Y);
                panel1.Size = new Size(panel1.Width, panel1.Height - difference);
                cover.Location = new Point(cover.Location.X, cover.Location.Y - difference);
            }
        }

        void SetButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.DarkGray;
        }

        void RevertButton(Button button)
        {
            button.FlatStyle = FlatStyle.Standard;
            button.BackColor = default(Color);
            button.UseVisualStyleBackColor = true;
        }

        private void Fullscreen_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.Sizable)
            {
                BackColor = Color.Gray;
                cover.BackColor = Color.Gray;
                SetButton(fullscreen);
                SetButton(clean);
                SetButton(start_stop);
                SetButton(show_hide);
                //panel1.Location = new Point(panel1.Location.X + 20, panel1.Location.Y + 20);
                panel1.Size = new Size(panel1.Size.Width + 20, panel1.Size.Height + 20);
                cover.BringToFront();
                clean.BringToFront();
                show_hide.BringToFront();
                start_stop.BringToFront();
                fullscreen.BringToFront();
                log.BringToFront();
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else if (FormBorderStyle == FormBorderStyle.None)
            {
                BackColor = Color.FromKnownColor(KnownColor.Control);
                cover.BackColor = Color.FromKnownColor(KnownColor.Control);
                RevertButton(fullscreen);
                RevertButton(clean);
                RevertButton(start_stop);
                RevertButton(show_hide);
                panel1.Size = new Size(panel1.Size.Width - 20, panel1.Size.Height - 20);
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
    }

    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }
}