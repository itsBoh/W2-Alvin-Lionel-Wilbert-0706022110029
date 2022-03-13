namespace TogasWeek2
{
    public partial class FormPengaturanWarna : Form
    {
        string test;
        char[] charTest;
        int fontSize = 24;
        public FormPengaturanWarna()
        {
            InitializeComponent();
            normal();
        }

        private void normal()
        {
            fontSize = 24;
            lblOutput.Font = new Font("Arial", fontSize);
            lblOutput.ForeColor = Color.Black;
            lblOutput.Visible = true;
            lblOutput.Text = "[EMPTY]";
        }

        private void error()
        {
            MsgError msgError = new MsgError();
            msgError.Show();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            test = txtBoxInput.Text.ToLower();
            charTest = test.ToCharArray();
            if (test.Contains("isi:") && test.Count() > 4)
            {
                int charPos = txtBoxInput.Text.IndexOf(":") + 1;
                lblOutput.Text = txtBoxInput.Text.Substring(charPos);
            }
            else if (test.Contains("shown"))
            {
                lblOutput.Visible = true;
            }
            else if (test.Contains("hide"))
            {
                lblOutput.Visible = false;
            }
            else if (test.Contains("warna:") && test.Count() > 6)
            {
                if (test.Contains("dafault"))
                {
                    lblOutput.ForeColor = Color.Black;
                }
                else if (test.Contains("merah"))
                {
                    lblOutput.ForeColor = Color.Red;
                }
                else if (test.Contains("hijau"))
                {
                    lblOutput.ForeColor= Color.Green;
                }
                else if (test.Contains("biru"))
                {
                    lblOutput.ForeColor = Color.Blue;
                }
                else
                {
                    error();
                }
            }
            else if (test.Contains("besarkan") && test.Count() == 8)
            {
                fontSize += 2;
                lblOutput.Font = new Font("Arial", fontSize);
            }
            else if (test.Contains("kecilkan") && test.Count() == 8)
            {
                fontSize -= 2;
                lblOutput.Font = new Font("Arial", fontSize);
            }
            else if (test.Contains("restart") && test.Count() == 7)
            {
                normal();
            }
            else
            {
                error();
            }
        }
    }
}