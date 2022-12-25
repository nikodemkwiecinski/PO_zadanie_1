using System.Media;

namespace zadanie_10
{
    class MusicFile
    {
        public int id;
        public string path;

        public MusicFile(int id, string path)
        {
            this.id = id;
            this.path = path;
        }
    }
    public partial class Form1 : Form
    {

        SoundPlayer soundPlayer = new SoundPlayer();
        List<MusicFile> musicFiles = new List<MusicFile>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "";
            if (checkBox1.Checked)
            {
                Random random = new Random();
                path = musicFiles[random.Next(0,musicFiles.Count)].path;
            }
            else
            {
                for (int i = 0; i < musicFiles.Count; i++)
                {
                    if (Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) == musicFiles[i].id)
                    {
                        path = musicFiles[i].path;
                    }
                }
            }
            if(path != "")
            {
                soundPlayer.SoundLocation = path;
                soundPlayer.Play();
            }
            else
            {
                MessageBox.Show("Nie wybrano piosenki");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog newFile = new OpenFileDialog();
            if (newFile.ShowDialog() == DialogResult.OK)
            {
                string newPath = newFile.FileName;
                int newId = Math.Abs((int)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - new DateTimeOffset(1970, 1, 1, 1, 1, 1, new TimeSpan()).ToUnixTimeMilliseconds()));
                dataGridView1.Rows.Add(newId, newPath);
                musicFiles.Add(new MusicFile(newId, newPath));
            }
        }
    }
}