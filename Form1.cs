using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biyoinformatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked == true)
                    MessageBox.Show("Lütfen Tek Şeçim Yapınız!");
                checkBox2.Checked = false;
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;

                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;

                    button1.Enabled = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;

                    button1.Enabled = false;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;

                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;

                button2.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;

                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;

                button2.Enabled = false;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label7.Enabled = true;

                textBox7.Enabled = true;

                button3.Enabled = true;
            }
            else
            {
                label7.Enabled = false;

                textBox7.Enabled = false;

                button3.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                int k = Convert.ToInt32(textBox7.Text);
                kHizala(k);
            }
             catch
            {

                MessageBox.Show("Lütfen k değerini rakamsal olarak giriniz!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked == true | checkBox7.Checked == true)
            {
                if (checkBox5.Checked == true)
                    MessageBox.Show("Lütfen Tek Şeçim Yapınız!");
                checkBox5.Checked = false;
            }
            else
            {
                if (checkBox5.Checked == true)
                {
                    groupBox1.Visible = true;
                }
                else
                {
                    groupBox1.Visible = false;

                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true | checkBox7.Checked == true)
            {
                if (checkBox6.Checked == true)
                    MessageBox.Show("Lütfen Tek Şeçim Yapınız!");
                checkBox6.Checked = false;
            }
            else
            {

                if (checkBox6.Checked == true)
                {
                    groupBox2.Visible = true;
                }

                else
                {
                    groupBox2.Visible = false;
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true | checkBox5.Checked == true)
            {
                if (checkBox7.Checked == true)
                    MessageBox.Show("Lütfen Tek Şeçim Yapınız!");
                checkBox7.Checked = false;
            }
            else
            {
                if (checkBox7.Checked == true)
                {
                    groupBox3.Visible = true;
                }
                else
                {
                    groupBox3.Visible = false;
                }
            }
        }

        public void kHizala(int k)
        {
            string dizi1 = textBox8.Text;
            string dizi2 = textBox9.Text;
            int dizi1_length = dizi1.Length;
            int dizi2_length = dizi2.Length;



            char[] d_dizi1 = new char[dizi1_length];
            char[] d_dizi2 = new char[dizi2_length];

            d_dizi1 = dizi1.ToCharArray();
            d_dizi2 = dizi2.ToCharArray();


            //Skor tablosunu tanımlama
            string[,] noktaTablosu = new string[dizi2_length + 2, dizi1_length + 2];


            //Tabloya değerleri doldurma
            for (int i = 0; i < dizi2_length; i++)
            {
                noktaTablosu[i + 1, 0] = d_dizi2[i].ToString();
                for (int j = 0; j < dizi1_length; j++)
                {
                    noktaTablosu[0, j + 1] = d_dizi1[j].ToString();
                    if (d_dizi2[i] == d_dizi1[j])
                    {
                        noktaTablosu[i + 1, j + 1] = "*";
                    }

                }
            }

            // Komşusu olanları sayıyoruz
            int sayac = 1;
            int[,] sayaclar = new int[dizi2_length + 1, dizi1_length + 1];
            int gecici_j, gecici_i;
            for (int i = 0; i < dizi2_length + 1; i++)
            {
                gecici_i = i;
                for (int j = 0; j < dizi1_length + 1; j++)
                {
                    gecici_j = j;
                    while (noktaTablosu[i, j] != null)
                    {
                        if (noktaTablosu[i, j] == noktaTablosu[i + 1, j + 1])
                        {
                            sayac++;
                            i++;
                            j++;

                        }
                        else
                        {
                            j = gecici_j;
                            i = gecici_i;
                            break;
                        }
                    }
                    sayaclar[i, j] = sayac;
                    sayac = 1;
                }
            }

            // maximum
            int table2_max = 0;
            int temp_i = 0, temp_j = 0;

            for (int i = 0; i < dizi2_length + 1; i++)
            {
                for (int j = 0; j < dizi1_length + 1; j++)
                {
                    if (sayaclar[i, j] > table2_max)
                    {
                        table2_max = sayaclar[i, j];
                        temp_i = i;
                        temp_j = j;
                    }
                }
            }


            string[] dizilim1 = new string[dizi1_length];
            string[] dizilim2 = new string[dizi2_length];
            int sayi = 0;
            while (sayi < table2_max)
            {
                dizilim2[sayi] = noktaTablosu[0, temp_j];
                dizilim1[sayi] = noktaTablosu[temp_i, 0];
                sayi++;
                temp_i++;
                temp_j++;
            }

            string[,] renk = new string[dizi2_length + 1, dizi1_length + 1];
            //Tabloyu yazdırma
            for (int i = 0; i < dizi2_length + 1; i++)
            {
                for (int j = 0; j < dizi1_length + 1; j++)
                {
                    Label lbl = new Label();
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    lbl.BackColor = Color.White;
                    lbl.Text = noktaTablosu[i, j];
                    lbl.Size = new Size(25, 25);
                    lbl.Location = new Point(25 * j, 25 * i);

                    panel1.Controls.Add(lbl);
                    //Tabloyu Boyama
                    if (lbl.Text == "*")
                    {
                        if (noktaTablosu[i, j] == noktaTablosu[i - 1, j - 1] || noktaTablosu[i, j] == noktaTablosu[i + 1, j + 1])
                        {
                            if (sayaclar[i, j] >= k)
                            {
                                lbl.BackColor = Color.OliveDrab;
                                renk[i, j] = "yesil";
                            }
                            else
                            {


                                if (noktaTablosu[i, j] == noktaTablosu[i - 1, j - 1])
                                {
                                    if (renk[i - 1, j - 1] == "yesil")
                                    {
                                        lbl.BackColor = Color.OliveDrab;
                                        renk[i, j] = "yesil";
                                    }

                                }


                            }

                        }
                    }


                }
            }
            int maxscore = 0;

            List<int> enuzun4 = new List<int>();
            List<int> tempEn = new List<int>();

            int temp2 = 0;
            int temp3 = 0;
            for (int i = 0; i < dizi2_length + 1; i++)
            {
                for (int j = 0; j < dizi1_length + 1; j++)
                {
                    if (noktaTablosu[i, j] == "*")
                    {
                        tempEn.Add(i);
                        tempEn.Add(j);
                        int temp = 1;
                        temp2 = i;
                        temp3 = j;
                        while (noktaTablosu[i + 1, j + 1] == "*")
                        {
                            temp++;
                            tempEn.Add(i+1);
                            tempEn.Add(j+1);

                            i++;
                            j++;
                        }
                        i = temp2;
                        j = temp3;
                        if (temp > maxscore)
                        {
                            maxscore = temp;
                            enuzun4.Clear();
                            for (int g = 0; g < tempEn.Count; g++)
                            {
                                enuzun4.Add(tempEn[g]);
                            }
                            tempEn.Clear();
                        }
                        tempEn.Clear();
                    }

                }
            }
            for (int i = 0; i < enuzun4.Count; i++)
            {
                Point konum = new Point(25 * enuzun4[i + 1], 25 * enuzun4[i]);
                panel1.GetChildAtPoint(konum).BackColor = Color.Orange;
                i++;
            }

            string d1 = "";
            string d2 = "";
            for (int i = 0; i < table2_max; i++)
            {
                d1 += dizilim1[i].ToString();


            }
            label11.Text = d1.Length.ToString();
            label13.Text = d1;
            for (int i = 0; i < table2_max; i++)
            {
                d2 += dizilim2[i].ToString();

            }
            label14.Text = d1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                int g = Convert.ToInt32(textBox6.Text);
                int m = Convert.ToInt32(textBox5.Text);
                int mm = Convert.ToInt32(textBox4.Text);
                localHizala(g,m,mm);
            }
            catch
            {
                MessageBox.Show("Lütfen değerleri rakamsal olarak giriniz!!");
            }
           
        }

        public void localHizala(int gap, int match, int mismatch)
        {
            string dizi1 = textBox8.Text;
            string dizi2 = textBox9.Text;
            int d1Count = dizi1.Length;
            int d2Count = dizi2.Length;

            char[] d_dizi1 = new char[d1Count];
            char[] d_dizi2 = new char[d2Count];

            d_dizi1 = dizi1.ToCharArray();
            d_dizi2 = dizi2.ToCharArray();



            int[,] scoringMatrix = new int[d2Count+1, d1Count+1];

            //matrisin ilk satır ve ilk sütunu 0 ile doldurulur

            for (int i = 0; i < d2Count; i++)
            {
                scoringMatrix[i, 0] = 0;
            }

            for (int j = 0; j < d1Count; j++)
            {
                scoringMatrix[0, j] = 0;
            }


            //Tabloya değerleri doldurma
            for (int i = 1; i < d2Count+1; i++)
            {
                for (int j = 1; j < d1Count+1; j++)
                {
                    int scroeDiag = 0;
                    if (dizi1.Substring(j - 1, 1) == dizi2.Substring(i - 1, 1))
                        scroeDiag = scoringMatrix[i - 1, j - 1] + match;
                    else
                        scroeDiag = scoringMatrix[i - 1, j - 1] + mismatch;

                    int scroeLeft = scoringMatrix[i, j - 1] + gap;
                    int scroeUp = scoringMatrix[i - 1, j] + gap;
                    
                    if (scroeLeft < 0)
                        scroeLeft = 0;
                    if (scroeUp < 0)
                        scroeUp =0;
                    if (scroeDiag < 0)
                        scroeDiag = 0;
                    
                    int maxScore = Math.Max(Math.Max(scroeDiag, scroeLeft), scroeUp);

                    scoringMatrix[i, j] = maxScore;
                }
            }


            
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < d2Count+1; i++)
            {
                for (int j = 0; j < d1Count+1; j++)
                {

                    if (i == 0 & j != 0)
                    {
                        Label lbl1 = new Label();
                        lbl1.BorderStyle = BorderStyle.Fixed3D;
                        lbl1.BackColor = Color.Aqua;
                        lbl1.Text = d_dizi1[count].ToString();
                        lbl1.Size = new Size(25, 25);
                        lbl1.Location = new Point(25 * (j + 1), 25 * i);
                        panel1.Controls.Add(lbl1);
                        count++;
                    }
                    if (j == 0 & i != 0)
                    {
                        Label lbl2 = new Label();
                        lbl2.BorderStyle = BorderStyle.Fixed3D;
                        lbl2.BackColor = Color.Aqua;
                        lbl2.Text = d_dizi2[count2].ToString();
                        lbl2.Size = new Size(25, 25);
                        lbl2.Location = new Point(25 * j, 25 * (i + 1));
                        panel1.Controls.Add(lbl2);
                        count2++;
                    }
                    Label lbl = new Label();
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    lbl.BackColor = Color.White;
                    lbl.Text = scoringMatrix[i, j].ToString();
                    lbl.Size = new Size(25, 25);
                    lbl.Location = new Point(25 * (j + 1), 25 * (i + 1));

                    panel1.Controls.Add(lbl);
                }
            }

            char[] alineSeqArray = dizi2.ToCharArray();
            char[] refSeqArray = dizi1.ToCharArray();

            List<int> boyamaYolu = new List<int>();

            string AlignmentA = string.Empty;
            string AlignmentB = string.Empty;

            int max = 0;
            int m = 0; ;
            int n = 0;
            for (int i = 0; i < d2Count; i++)
            {
                for (int j = 0; j < d1Count; j++)
                {
                    if (scoringMatrix[i, j] > max)
                    {
                        max = scoringMatrix[i, j];
                        m = i;
                        n = j;
                    }
                }
            }     

            
            Point konum1 = new Point(25 * (n + 1), 25 * (m + 1));
            panel1.GetChildAtPoint(konum1).BackColor = Color.Orange;
            while (m > 0 && n > 0)
            {
                int scroeDiag = 0;

                if (alineSeqArray[m - 1] == refSeqArray[n - 1])
                    scroeDiag = match;
                else
                    scroeDiag = mismatch;

                if (m > 0 && n > 0 && scoringMatrix[m, n] == scoringMatrix[m - 1, n - 1] + scroeDiag)
                {
                    AlignmentA = refSeqArray[n - 1] + AlignmentA;
                    AlignmentB = alineSeqArray[m - 1] + AlignmentB;
                    Point konum = new Point(25 * (n), 25 * (m));
                    if (konum.X != 0 && konum.Y != 0)
                        panel1.GetChildAtPoint(konum).BackColor = Color.Orange;
                    boyamaYolu.Add(m - 1);
                    boyamaYolu.Add(n - 1);
                    m = m - 1;
                    n = n - 1;
                }
                else if (n > 0 && scoringMatrix[m, n] == scoringMatrix[m, n - 1] + gap)
                {
                    AlignmentA = refSeqArray[n - 1] + AlignmentA;
                    AlignmentB = "-" + AlignmentB;
                    Point konum = new Point(25 * (n), 25 * (m + 1));
                    if (konum.X != 0 && konum.Y != 0)
                        panel1.GetChildAtPoint(konum).BackColor = Color.Orange;
                    boyamaYolu.Add(m);
                    boyamaYolu.Add(n - 1);
                    n = n - 1;
                }
                else //if (m > 0 && scoringMatrix[m, n] == scoringMatrix[m - 1, n] + gap)
                {
                    AlignmentA = "-" + AlignmentA;
                    AlignmentB = alineSeqArray[m - 1] + AlignmentB;
                    Point konum = new Point(25 * (n + 1), 25 * (m));
                    if (konum.X != 0 && konum.Y != 0)
                        panel1.GetChildAtPoint(konum).BackColor = Color.Orange;
                    boyamaYolu.Add(m - 1);
                    boyamaYolu.Add(n);
                    m = m - 1;
                }
            }
            label13.Text = AlignmentA;
            label14.Text = AlignmentB;
            label11.Text = max.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            {
                if (checkBox2.Checked == true)
                {
                    panel1.Controls.Clear();
                    int g = Convert.ToInt32(textBox1.Text);
                    int m = Convert.ToInt32(textBox2.Text);
                    int mm = Convert.ToInt32(textBox3.Text);
                    globalHizala(g, m, mm);
                }
                else
                {
                    panel1.Controls.Clear();
                    globalBlosumHizala();
                }
            }
           //catch
            {
               // MessageBox.Show("Lütfen değerleri rakamsal olarak giriniz!!");
            }
        }

        public void globalHizala(int gap, int match, int mismatch)
        {
            string dizi1 = textBox8.Text;
            string dizi2 = textBox9.Text;
            int d1Count = dizi1.Length+1;
            int d2Count = dizi2.Length+1;

            char[] d_dizi1 = new char[d1Count];
            char[] d_dizi2 = new char[d2Count];

            d_dizi1 = dizi1.ToCharArray();
            d_dizi2 = dizi2.ToCharArray();

            int[,] scoringMatrix = new int[d2Count+1, d1Count+1];

            //matrisin ilk satır ve ilk sütunu 0 ile doldurulur
            for (int i = 0; i < d2Count+1; i++)
            {
                scoringMatrix[i, 0] = i*gap;
            }

            for (int j = 0; j < d1Count; j++)
            {
                scoringMatrix[0, j] = j*gap;
            }

            for (int i = 1; i < d2Count; i++)
            {
                for (int j = 1; j < d1Count; j++)
                {
                    int scroeDiag = 0;
                    if (dizi1.Substring(j - 1, 1) == dizi2.Substring(i - 1, 1))
                        scroeDiag = scoringMatrix[i - 1, j - 1] + match;
                    else
                        scroeDiag = scoringMatrix[i - 1, j - 1] + mismatch;

                    int scroeLeft = scoringMatrix[i, j - 1] + gap;
                    int scroeUp = scoringMatrix[i - 1, j] + gap;

                    int maxScore = Math.Max(Math.Max(scroeDiag, scroeLeft), scroeUp);

                    scoringMatrix[i, j] = maxScore;
                }
            }
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < d2Count; i++)
            {
                for (int j = 0; j < d1Count; j++)
                {

                    if (i == 0 & j != 0)
                    {
                        Label lbl1 = new Label();
                        lbl1.BorderStyle = BorderStyle.Fixed3D;
                        lbl1.BackColor = Color.Aqua;
                        lbl1.Text = d_dizi1[count].ToString();
                        lbl1.Size = new Size(25, 25);
                        lbl1.Location = new Point(25 * (j + 1), 25 * i);
                        panel1.Controls.Add(lbl1);
                        count++;
                    }
                    if (j == 0 & i != 0)
                    {
                        Label lbl2 = new Label();
                        lbl2.BorderStyle = BorderStyle.Fixed3D;
                        lbl2.BackColor = Color.Aqua;
                        lbl2.Text = d_dizi2[count2].ToString();
                        lbl2.Size = new Size(25, 25);
                        lbl2.Location = new Point(25 * j, 25 * (i + 1));
                        panel1.Controls.Add(lbl2);
                        count2++;
                    }
                    Label lbl = new Label();
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    lbl.BackColor = Color.White;
                    lbl.Text = scoringMatrix[i, j].ToString();
                    lbl.Size = new Size(25, 25);
                    lbl.Location = new Point(25 * (j + 1), 25 * (i + 1));

                    panel1.Controls.Add(lbl);
                }
            }

            char[] alineSeqArray = dizi2.ToCharArray();
            char[] refSeqArray = dizi1.ToCharArray();

            List<int> boyamaYolu = new List<int>();

            string AlignmentA = string.Empty;
            string AlignmentB = string.Empty;
            int m = d2Count - 1;
            int n = d1Count - 1;
            Point konum1 = new Point(25 * (n+1), 25 * (m+1));
            panel1.GetChildAtPoint(konum1).BackColor = Color.Orange;
            while (m > 0 && n > 0)
            {
                int scroeDiag = 0;

                if (alineSeqArray[m - 1] == refSeqArray[n - 1])
                    scroeDiag = match;
                else
                    scroeDiag = mismatch;

                if (m > 0 && n > 0 && scoringMatrix[m, n] == scoringMatrix[m - 1, n - 1] + scroeDiag)
                {
                    AlignmentA = refSeqArray[n - 1] + AlignmentA;
                    AlignmentB = alineSeqArray[m - 1] + AlignmentB;
                    Point konum = new Point(25 * (n), 25 * (m));
                    if(konum.X!=0 && konum.Y!=0)
                        panel1.GetChildAtPoint(konum).BackColor = Color.Orange;
                    boyamaYolu.Add(m-1);
                    boyamaYolu.Add(n-1);
                    m = m - 1;
                    n = n - 1;
                }
                else if (n > 0 && scoringMatrix[m, n] == scoringMatrix[m, n - 1] + gap)
                {
                    AlignmentA = refSeqArray[n - 1] + AlignmentA;
                    AlignmentB = "-" + AlignmentB;
                    Point konum = new Point(25 * (n), 25 * (m+1));
                    if (konum.X != 0 && konum.Y != 0)
                        panel1.GetChildAtPoint(konum).BackColor = Color.Orange;
                    boyamaYolu.Add(m);
                    boyamaYolu.Add(n-1);
                    n = n - 1;
                }
                else //if (m > 0 && scoringMatrix[m, n] == scoringMatrix[m - 1, n] + gap)
                {
                    AlignmentA = "-" + AlignmentA;
                    AlignmentB = alineSeqArray[m - 1] + AlignmentB;
                    Point konum = new Point(25 * (n+1), 25 * (m));
                    if (konum.X != 0 && konum.Y != 0)
                        panel1.GetChildAtPoint(konum).BackColor = Color.Orange;
                    boyamaYolu.Add(m-1);
                    boyamaYolu.Add(n);
                    m = m - 1;
                }
            }
            label13.Text = AlignmentA;
            label14.Text = AlignmentB;
            label11.Text = scoringMatrix[d2Count-1,d1Count-1].ToString();
            


        }

        char[] alfabe = new char[] { 'A', 'R', 'N', 'D', 'C', 'Q', 'E', 'G', 'H', 'I', 'L', 'K', 'M', 'F', 'P', 'S', 'T', 'W', 'Y', 'V', 'B', 'Z', 'X' };

        int[,] blosum = new int[,] { { 4 , -1 , -2 , -2 ,  0 , -1 , -1 ,  0 , -2 , -1 , -1 , -1 , -1 , -2 , -1 ,  1 ,  0 , -3 , -2 ,  0 , -2 , -1 ,  0 },
                                         {-1 ,  5 ,  0 , -2 , -3 ,  1 ,  0 , -2 ,  0 , -3 , -2 ,  2 , -1 , -3 , -2 , -1 , -1 , -3 , -2 , -3 , -1 ,  0 , -1 },
                                         {-2 ,  0 ,  6 ,  1 , -3 ,  0 ,  0 ,  0 ,  1 , -3 , -3 ,  0 , -2 , -3 , -2 ,  1 ,  0 , -4 , -2 , -3 ,  3 ,  0 , -1 },
                                         {-2 , -2 ,  1 ,  6 , -3 ,  0 ,  2 , -1 , -1 , -3 , -4 , -1 , -3 , -3 , -1 ,  0 , -1 , -4 , -3 , -3 ,  4 ,  1 , -1 },
                                         { 0 , -3 , -3 , -3 ,  9 , -3 , -4 , -3 , -3 , -1 , -1 , -3 , -1 , -2 , -3 , -1 , -1 , -2 , -2 , -1 , -3 , -3 , -2 },
                                         {-1 ,  1 ,  0 ,  0 , -3 ,  5 ,  2 , -2 ,  0 , -3 , -2 ,  1 ,  0 , -3 , -1 ,  0 , -1 , -2 , -1 , -2 ,  0 ,  3 , -1 },
                                         {-1 ,  0 ,  0 ,  2 , -4 ,  2 ,  5 , -2 ,  0 , -3 , -3 ,  1 , -2 , -3 , -1 ,  0 , -1 , -3 , -2 , -2 ,  1 ,  4 , -1 },
                                         { 0 , -2 ,  0 , -1 , -3 , -2 , -2 ,  6 , -2 , -4 , -4 , -2 , -3 , -3 , -2 ,  0 , -2 , -2 , -3 , -3 , -1 , -2 , -1 },
                                         {-2 ,  0 ,  1 , -1 , -3 ,  0 ,  0 , -2 ,  8 , -3 , -3 , -1 , -2 , -1 , -2 , -1 , -2 , -2 ,  2 , -3 ,  0 ,  0 , -1 },
                                         {-1 , -3 , -3 , -3 , -1 , -3 , -3 , -4 , -3 ,  4 ,  2 , -3 ,  1 ,  0 , -3 , -2 , -1 , -3 , -1 ,  3 , -3 , -3 , -1 },
                                         {-1 , -2 , -3 , -4 , -1 , -2 , -3 , -4 , -3 ,  2 ,  4 , -2 ,  2 ,  0 , -3 , -2 , -1 , -2 , -1 ,  1 , -4 , -3 , -1 },
                                         {-1 ,  2 ,  0 , -1 , -3 ,  1 ,  1 , -2 , -1 , -3 , -2 ,  5 , -1 , -3 , -1 ,  0 , -1 , -3 , -2 , -2 ,  0 ,  1 , -1 },
                                         {-1 , -1 , -2 , -3 , -1 ,  0 , -2 , -3 , -2 ,  1 ,  2 , -1 ,  5 ,  0 , -2 , -1 , -1 , -1 , -1 ,  1 , -3 , -1 , -1 },
                                         {-2 , -3 , -3 , -3 , -2 , -3 , -3 , -3 , -1 ,  0 ,  0 , -3 ,  0 ,  6 , -4 , -2 , -2 ,  1 ,  3 , -1 , -3 , -3 , -1 },
                                         {-1 , -2 , -2 , -1 , -3 , -1 , -1 , -2 , -2 , -3 , -3 , -1 , -2 , -4 ,  7 , -1 , -1 , -4 , -3 , -2 , -2 , -1 , -2 },
                                         { 1 , -1 ,  1 ,  0 , -1 ,  0 ,  0 ,  0 , -1 , -2 , -2 ,  0 , -1 , -2 , -1 ,  4 ,  1 , -3 , -2 , -2 ,  0 ,  0 ,  0 },
                                         { 0 , -1 ,  0 , -1 , -1 , -1 , -1 , -2 , -2 , -1 , -1 , -1 , -1 , -2 , -1 ,  1 ,  5 , -2 , -2 ,  0 , -1 , -1 ,  0 },
                                         {-3 , -3 , -4 , -4 , -2 , -2 , -3 , -2 , -2 , -3 , -2 , -3 , -1 ,  1 , -4 , -3 , -2 , 11 ,  2 , -3 , -4 , -3 , -2 },
                                         {-2 , -2 , -2 , -3 , -2 , -1 , -2 , -3 ,  2 , -1 , -1 , -2 , -1 ,  3 , -3 , -2 , -2 ,  2 ,  7 , -1 , -3 , -2 , -1 },
                                         { 0 , -3 , -3 , -3 , -1 , -2 , -2 , -3 , -3 ,  3 ,  1 , -2 ,  1 , -1 , -2 , -2 ,  0 , -3 , -1 ,  4 , -3 , -2 , -1 },
                                         {-2 , -1 ,  3 ,  4 , -3 ,  0 ,  1 , -1 ,  0 , -3 , -4 ,  0 , -3 , -3 , -2 ,  0 , -1 , -4 , -3 , -3 ,  4 ,  1 , -1 },
                                         {-1 ,  0 ,  0 ,  1 , -3 ,  3 ,  4 , -2 ,  0 , -3 , -3 ,  1 , -1 , -3 , -1 ,  0 , -1 , -3 , -2 , -2 ,  1 ,  4 , -1 },
                                         { 0 , -1 , -1 , -1 , -2 , -1 , -1 , -1 , -1 , -1 , -1 , -1 , -1 , -1 , -2 ,  0 ,  0 , -2 , -1 , -1 , -1 , -1 , -1 } };

        public void globalBlosumHizala()
        {
            

            string dizi1 = textBox8.Text;
            string dizi2 = textBox9.Text;
            int dizi1_length = dizi1.Length;
            int dizi2_length = dizi2.Length;

            char[] d_dizi1 = new char[dizi1_length];
            char[] d_dizi2 = new char[dizi2_length];

            d_dizi1 = dizi1.ToCharArray();
            d_dizi2 = dizi2.ToCharArray();



            int[] siralama1 = new int[dizi1_length];
            siralama1 = siraBul(d_dizi1);
            int[] siralama2 = new int[dizi2_length];
            siralama2 = siraBul(d_dizi2);



            int count = 0;
            int count2 = 0;
            for (int i = 0; i < dizi2_length; i++)
            {
                for (int j = 0; j < dizi1_length; j++)
                {

                    if (i == 0 & j != 0)
                    {
                        Label lbl1 = new Label();
                        lbl1.BorderStyle = BorderStyle.Fixed3D;
                        lbl1.BackColor = Color.Aqua;
                        lbl1.Text = d_dizi1[count].ToString();
                        lbl1.Size = new Size(25, 25);
                        lbl1.Location = new Point(25 * (j), 25 * i);
                        panel1.Controls.Add(lbl1);
                        count++;
                        if(j==dizi1_length-1)
                        {
                            Label lbl3 = new Label();
                            lbl3.BorderStyle = BorderStyle.Fixed3D;
                            lbl3.BackColor = Color.Aqua;
                            lbl3.Text = d_dizi1[count].ToString();
                            lbl3.Size = new Size(25, 25);
                            lbl3.Location = new Point(25 * (j+1), 25 * i);
                            panel1.Controls.Add(lbl3);
                        }
                    }
                    if (j == 0 & i != 0)
                    {
                        Label lbl2 = new Label();
                        lbl2.BorderStyle = BorderStyle.Fixed3D;
                        lbl2.BackColor = Color.Aqua;
                        lbl2.Text = d_dizi2[count2].ToString();
                        lbl2.Size = new Size(25, 25);
                        lbl2.Location = new Point(25 * j, 25 * (i));
                        panel1.Controls.Add(lbl2);
                        count2++;
                        if (i == dizi2_length - 1)
                        {
                            Label lbl3 = new Label();
                            lbl3.BorderStyle = BorderStyle.Fixed3D;
                            lbl3.BackColor = Color.Aqua;
                            lbl3.Text = d_dizi1[count2].ToString();
                            lbl3.Size = new Size(25, 25);
                            lbl3.Location = new Point(25 * j, 25 * (i+1));
                            panel1.Controls.Add(lbl3);
                        }
                    }
                    Label lbl = new Label();
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    lbl.BackColor = Color.White;
                    lbl.Text = blosum[siralama1[j], siralama2[i]].ToString();
                    lbl.Size = new Size(25, 25);
                    lbl.Location = new Point(25 * (j + 1), 25 * (i + 1));

                    panel1.Controls.Add(lbl);
                }
            }
        }

        public int[] siraBul(char[] dizi)
        {
            int[] sira = new int[dizi.Length];

            for (int i = 0; i < dizi.Length; i++)
            {
                int x = 0;
                for(int j=0;j<alfabe.Length;j++)
                {
                    if (dizi[i] == alfabe[j])
                    {
                        x = j;
                        break;
                    }               
                }
                sira[i] = x;
            }

            return sira;
        }

      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (checkBox1.Checked == true)
                    MessageBox.Show("Lütfen Tek Şeçim Yapınız!");
                checkBox1.Checked = false;
            }
            else
            {
                if (checkBox1.Checked == true)
                    button1.Enabled = true;
                else
                    button1.Enabled = false;
            }
        }
 
    }
}
