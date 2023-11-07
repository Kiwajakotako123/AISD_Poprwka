using System.Diagnostics;
using System.Windows.Forms;

namespace Projekt_AISD_S
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var wynik = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
                wynik[i] = int.Parse(liczbyS[i]);
            return wynik;

        }

        string ConvertIntToString(int[] tab)
        {
            string napis = "";
            for (int i = 0; i < tab.Length; i++)
            {
                napis += tab[i].ToString();
                napis += " ";
            }
            return napis;
        }
        int[] BubbleSort(int[] tablica)
        {
            int pomoc = int.MinValue;
            bool cbz = true;
            do
            {
                cbz = false;
                for (int i = 0; i < tablica.Length - 1; i++)
                {


                    if (tablica[i] > tablica[i + 1])
                    {

                        pomoc = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = pomoc;
                        cbz = true;
                    }

                }


            } while (cbz);
            return tablica;
        }

        int[] SelectSort(int[] tab)
        {


            for (int i = 0; i < tab.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min = j;
                    }
                }
                int tmp = tab[i];
                tab[i] = tab[min];
                tab[min] = tmp;
            }
            return tab;
        }

        int[] InsertSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int tmp = tab[i];
                int j = i - 1;

                while (j >= 0 && tab[j] > tmp)
                {
                    tab[j + 1] = tab[j];
                    j = j - 1;
                }
                tab[j + 1] = tmp;
            }
            return tab;
        }

        int[] Merge(int[] lewa, int[] prawa)
        {
            int[] wynik = new int[lewa.Length + prawa.Length];
            int i = 0, j = 0, k = 0; 

            while (i < lewa.Length && j < prawa.Length)
            {
                if (lewa[i] < prawa[j])
                {
                    wynik[k++] = lewa[i++];
                }
                else
                {
                    wynik[k++] = prawa[j++];
                }
            }

            while (i < lewa.Length)
            {
                wynik[k++] = lewa[i++];
            }

            while (j < prawa.Length)
            {
                wynik[k++] = prawa[j++];
            }

            return wynik;

        }

        int[] MergeSort(int[] tab)
        {
            if (tab.Length <= 1)
            {
                return tab;
            }

            int srodek = tab.Length / 2;
            int[] lewa = new int[srodek];
            int[] prawa = new int[tab.Length - srodek];

            for (int i = 0; i < srodek; i++)
            {
                lewa[i] = tab[i];
            }

            for (int i = srodek; i < tab.Length; i++)
            {
                prawa[i - srodek] = tab[i];
            }

            lewa = MergeSort(lewa);
            prawa = MergeSort(prawa);

            return Merge(lewa, prawa);
        }

        private int Dziel(int[] tab, int lewy, int prawy)
        {
            int X = tab[lewy];
            while (true)
            {
                while (tab[lewy] < X)
                {
                    lewy++;
                }
                while (tab[prawy] > X)
                {
                    prawy--;
                }
                if (lewy < prawy)
                {
                    int tmp = tab[lewy];
                    tab[lewy] = tab[prawy];
                    tab[prawy] = tmp;
                }
                else
                {
                    return prawy;
                }
            }
        }

        private void QuickSort(int[] tab, int lewy, int prawy)
        {
            if (lewy < prawy)
            {
                int x = Dziel(tab, lewy, prawy);

                if (x > lewy)
                {
                    QuickSort(tab, lewy, x - 1);
                }
                if (x + 1 < prawy)
                {
                    QuickSort(tab, x + 1, prawy);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] napis = input.Split(' ');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tbxWynikTablicy_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSB_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch zegar = new Stopwatch();
                zegar = Stopwatch.StartNew();
                int[] PosortLista = BubbleSort(Convert(textBox1.Text));
                zegar.Stop();
                tbxWynikTablicy.Text = ConvertIntToString(PosortLista);
                lblCzasWyk.Text = zegar.Elapsed.TotalSeconds.ToString() + "sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd!!! Nie mozesz dawać znakow specjalnych cyfry muszą byc oddzielone spacją.");
            }
        }

        private void lblCzasWyk_Click(object sender, EventArgs e)
        {

        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch zegar = new Stopwatch();
                zegar = Stopwatch.StartNew();
                int[] PosortLista = SelectSort(Convert(textBox1.Text));
                zegar.Stop();
                tbxWynikTablicy.Text = ConvertIntToString(PosortLista);
                lblCzasWyk.Text = zegar.Elapsed.TotalSeconds.ToString() + "sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd!!! Nie mozesz dawać znakow specjalnych cyfry muszą byc oddzielone spacją.");
            }
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch zegar = new Stopwatch();
                zegar = Stopwatch.StartNew();
                int[] PosortLista = InsertSort(Convert(textBox1.Text));
                zegar.Stop();
                tbxWynikTablicy.Text = ConvertIntToString(PosortLista);
                lblCzasWyk.Text = zegar.Elapsed.TotalSeconds.ToString() + "sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd!!! Nie mozesz dawać znakow specjalnych cyfry muszą byc oddzielone spacją.");
            }
        }

        private void btnSM_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch zegar = new Stopwatch();
                zegar = Stopwatch.StartNew();
                int[] PosortLista = MergeSort(Convert(textBox1.Text));
                zegar.Stop();
                tbxWynikTablicy.Text = ConvertIntToString(PosortLista);
                lblCzasWyk.Text = zegar.Elapsed.TotalSeconds.ToString() + "sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd!!! Nie mozesz dawać znakow specjalnych cyfry muszą byc oddzielone spacją.");
            }
        }

        private void btnSQ_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch zegar = new Stopwatch();
                zegar = Stopwatch.StartNew();
                int[] PosortLista = Convert(textBox1.Text);
                QuickSort(PosortLista, 0, PosortLista.Length - 1);
                zegar.Stop();
                tbxWynikTablicy.Text = ConvertIntToString(PosortLista);
                lblCzasWyk.Text = zegar.Elapsed.TotalSeconds.ToString() + "sekund";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd!!! Nie mozesz dawać znakow specjalnych cyfry muszą byc oddzielone spacją.");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int count = (int)numericUpDown1.Value;

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(0, 500);
                textBox1.Text += number.ToString() + " ";
            }

            textBox1.Text = textBox1.Text.TrimEnd();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox1.Checked;
            btnGenerate.Enabled = checkBox1.Checked;
            Losuj.Enabled = checkBox1.Checked;
            textBox1.Enabled = !checkBox1.Checked;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Losuj_Click(object sender, EventArgs e)
        {
            int minValue = (int)numericUpDown1.Minimum;
            int maxValue = (int)numericUpDown1.Maximum;

            int randomNumber = random.Next(minValue, maxValue + 1);

            numericUpDown1.Value = randomNumber;
        }
    }
}
