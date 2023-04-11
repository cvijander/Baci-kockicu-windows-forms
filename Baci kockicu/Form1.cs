namespace Baci_kockicu
{
    public partial class Form1 : Form
    {
        private Random r = new Random();
        private int vrednostKockice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vrednostKockice = r.Next(1, 7);
            pictureBox1.Image = new Bitmap(vrednostKockice + ".png");
        }

        private void odigrajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int broj = vrednostKockice;
            while (broj == vrednostKockice)
                broj = r.Next(1, 7);
            pictureBox1.Image = new Bitmap(broj + ".png");
            vrednostKockice =broj;
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}