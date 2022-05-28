using System;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int skorBot = 0, skorUser = 0;

        /// <summary>
        /// Random olarak botun seçimini yapar.
        /// </summary>
        /// <param name="secilenBtn">Seçilen butonu döndürür.</param>
        private void BotSecimiYap(out Button secilenBtn)
        {
            int rastgeleButon = new Random().Next(1, 3);
            switch (rastgeleButon)
            {
                case 1:
                    secilenBtn = btnBotTas;
                    break;
                case 2:
                    secilenBtn = btnBotKagit;
                    break;
                case 3:
                    secilenBtn = btnBotMakas;
                    break;
                default:
                    secilenBtn = btnBotTas;
                    break;
            }
        }

        /// <summary>
        /// Bot renklerini her adımda sıfırlar.
        /// </summary>
        private void ButonlariSifirla()
        {
            btnUserTas.BackColor = System.Drawing.Color.White;
            btnUserKagit.BackColor = System.Drawing.Color.White;
            btnUserMakas.BackColor = System.Drawing.Color.White;
            btnBotTas.BackColor = System.Drawing.Color.White;
            btnBotKagit.BackColor = System.Drawing.Color.White;
            btnBotMakas.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Bot kazandığı zaman skoru arttırır.
        /// </summary>
        /// <param name="userBtn">Kullanıcının seçmiş olduğu buton</param>
        /// <param name="botBtn">Botun seçmiş olduğu buton</param>
        private void BotKazandi(Button userBtn, Button botBtn)
        {
            skorBot++;
            lblSkorBot.Text = skorBot.ToString();
            botBtn.BackColor = System.Drawing.Color.Red;
            userBtn.BackColor = System.Drawing.Color.Yellow;
            lblSonuc.Text = "Kaybettiniz!";
        }

        /// <summary>
        /// Kullanıcı kazandığı zaman skoru arttırır.
        /// </summary>
        /// <param name="userBtn">Kullanıcının seçmiş olduğu buton</param>
        /// <param name="botBtn">Botun seçmiş olduğu buton</param>
        private void UserKazandi(Button userBtn, Button botBtn)
        {
            skorUser++;
            lblSkorUser.Text = skorUser.ToString();
            botBtn.BackColor = System.Drawing.Color.Yellow;
            userBtn.BackColor = System.Drawing.Color.Red;
            lblSonuc.Text = "Kazandınız!";
        }

        /// <summary>
        /// Berabere olduğu zaman bilgi verir.
        /// </summary>
        /// <param name="userBtn">Kullanıcının seçmiş olduğu buton</param>
        /// <param name="botBtn">Botun seçmiş olduğu buton</param>
        private void Berabere(Button userBtn, Button botBtn)
        {
            botBtn.BackColor = System.Drawing.Color.Green;
            userBtn.BackColor = System.Drawing.Color.Green;
            lblSonuc.Text = "Berabere!";
        }

        /// <summary>
        /// Seçimleri karşılaştırıp gerekli işlemleri yapar
        /// </summary>
        /// <param name="userBtn">Kullanıcının seçmiş olduğu buton</param>
        /// <param name="botBtn">Botun seçmiş olduğu buton</param>
        private void SecimleriKarsilastir(Button userBtn, Button botBtn)
        {
            ButonlariSifirla();
            string userBtnName = userBtn.Name;
            string botBtnName = botBtn.Name;
            switch (userBtnName)
            {
                case "btnUserTas":
                    if (botBtnName == "btnBotKagit")
                    {
                        UserKazandi(userBtn, botBtn);
                    }
                    else if (botBtnName == "btnBotMakas")
                    {
                        BotKazandi(userBtn, botBtn);
                    }
                    else
                    {
                        Berabere(userBtn, botBtn);
                    }
                    break;
                case "btnUserKagit":
                    if (botBtnName == "btnBotTas")
                    {
                        UserKazandi(userBtn, botBtn);
                    }
                    else if (botBtnName == "btnBotMakas")
                    {
                        BotKazandi(userBtn, botBtn);
                    }
                    else
                    {
                        Berabere(userBtn, botBtn);
                    }
                    break;
                case "btnUserMakas":
                    if (botBtnName == "btnBotTas")
                    {
                        UserKazandi(userBtn, botBtn);
                    }
                    else if (botBtnName == "btnBotKagit")
                    {
                        BotKazandi(userBtn, botBtn);
                    }
                    else
                    {
                        Berabere(userBtn, botBtn);
                    }
                    break;
                default:
                    break;
            }
            if (skorBot == 5)
            {
                MessageBox.Show($"Oyun bitti ! Bilgilsayar kazandı :(\r\nSiz: {skorUser} - Bilgisayar: {skorBot}");
                skorUser = 0;
                skorBot = 0;
                lblSkorBot.Text = "0";
                lblSkorUser.Text = "0";
                ButonlariSifirla();
            }
            else if (skorUser == 5)
            {
                MessageBox.Show($"Oyun bitti ! Kazandınız :)\r\nSiz: {skorUser} - Bilgisayar: {skorBot}");
                skorUser = 0;
                skorBot = 0;
                lblSkorBot.Text = "0";
                lblSkorUser.Text = "0";
                ButonlariSifirla();
            }
        }

        private void btnUserTas_Click(object sender, EventArgs e)
        {
            BotSecimiYap(out Button botBtn);
            SecimleriKarsilastir(btnUserTas, botBtn);
        }

        private void btnUserKagit_Click(object sender, EventArgs e)
        {
            BotSecimiYap(out Button botBtn);
            SecimleriKarsilastir(btnUserKagit, botBtn);
        }

        private void btnUserMakas_Click(object sender, EventArgs e)
        {
            BotSecimiYap(out Button botBtn);
            SecimleriKarsilastir(btnUserMakas, botBtn);
        }
    }
}
