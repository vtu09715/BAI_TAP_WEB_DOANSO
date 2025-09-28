using System;
using System.Drawing;
using System.Windows.Forms;
using VDT.GuessLib;

namespace VDT.GuessWinForm
{
    public partial class Form1 : Form
    {
        private Label lblTitle;
        private TextBox txtGuess;
        private Button btnGuess;
        private Button btnNew;
        private Label lblResult;
        private GuessEngine engine;

        public Form1()
        {
            this.Text = "VDT Guess Game - WinForm (.NET 2.0)";
            this.ClientSize = new Size(420, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            engine = new GuessEngine();

            lblTitle = new Label();
            lblTitle.Text = "VDT Guess Game (1-100) - " + engine.Signature;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 10);
            this.Controls.Add(lblTitle);

            txtGuess = new TextBox();
            txtGuess.Location = new Point(10, 40);
            txtGuess.Width = 120;
            this.Controls.Add(txtGuess);

            btnGuess = new Button();
            btnGuess.Text = "Đoán";
            btnGuess.Location = new Point(140, 38);
            btnGuess.Click += new EventHandler(btnGuess_Click);
            this.Controls.Add(btnGuess);

            btnNew = new Button();
            btnNew.Text = "Tạo mới";
            btnNew.Location = new Point(210, 38);
            btnNew.Click += new EventHandler(btnNew_Click);
            this.Controls.Add(btnNew);

            lblResult = new Label();
            lblResult.Text = "Kết quả sẽ hiển thị ở đây.";
            lblResult.AutoSize = true;
            lblResult.Location = new Point(10, 80);
            this.Controls.Add(lblResult);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess;
            if (!Int32.TryParse(txtGuess.Text.Trim(), out guess))
            {
                lblResult.Text = "Vui lòng nhập số nguyên 1-100.";
                return;
            }
            string res = engine.Guess(guess);
            lblResult.Text = res;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            engine.ResetSecret();
            lblResult.Text = "Số mới đã tạo. Hãy đoán tiếp.";
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}
