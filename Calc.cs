namespace WinFormsApp1
{
    public partial class HM : Form
    {
        bool optDurum=false;
        double sonuc = 0;
        string onc = "";
        public HM()
        {
            InitializeComponent();
        }

        private void islev(object sender, EventArgs e)
        {
            if (txtSon.Text == "0" || optDurum)
                txtSon.Clear();
            optDurum = false;
            Button btn = (Button)sender;
            txtSon.Text += btn.Text;
        }

        private void HM_Load(object sender, EventArgs e)
        {

        }

        private void islem(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            switch(onc)
            {
                case "+":txtSon.Text = (sonuc + Double.Parse(txtSon.Text)).ToString(); break;
                case "-": txtSon.Text = (sonuc - Double.Parse(txtSon.Text)).ToString(); break;
                case "*": txtSon.Text = (sonuc * Double.Parse(txtSon.Text)).ToString(); break;
                case "/": txtSon.Text = (sonuc / Double.Parse(txtSon.Text)).ToString(); break;
            }
            sonuc = Double.Parse(txtSon.Text);
            txtSon.Text = sonuc.ToString();
            onc = yeniOpt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSon.Text = "0";
            onc = "";
            sonuc = 0;
            optDurum=false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            optDurum = true;
            switch (onc)
            {
                case "+": txtSon.Text = (sonuc + Double.Parse(txtSon.Text)).ToString(); break;
                case "-": txtSon.Text = (sonuc - Double.Parse(txtSon.Text)).ToString(); break;
                case "*": txtSon.Text = (sonuc * Double.Parse(txtSon.Text)).ToString(); break;
                case "/": txtSon.Text = (sonuc / Double.Parse(txtSon.Text)).ToString(); break;
            }
            sonuc = Double.Parse(txtSon.Text);
            txtSon.Text = sonuc.ToString();
            onc = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(txtSon.Text == "0")
            {
                txtSon.Text = "0";
            }
            else if(optDurum)
            {
                txtSon.Text = "0";
            }

            if (!txtSon.Text.Contains(",")) 
            {
                txtSon.Text += ",";
            }
            optDurum = false;
        }

        private void txtSon_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}