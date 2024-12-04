using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        short shortTrova = -1;
        short contpos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Both;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro?", "Blocco note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                richTextBox1.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem?.ToString() == "Trova")
            {
                shortTrova = 1;
            }
            else if (comboBox1.SelectedItem?.ToString() == "Trova e sostituisci")
            {
                shortTrova = 0;
            }

            switch (shortTrova)
            {
                case 1:
                    txt_Cerca.Visible = true;
                    txt_sostituisci.Visible = false;
                    lb_sostituisci.Visible = false;
                    break;

                case 0:
                    txt_Cerca.Visible = true;
                    txt_sostituisci.Visible = true;
                    lb_sostituisci.Visible = true;
                    break;

                default:
                    lb_trova.Visible = false;
                    txt_Cerca.Visible = false;
                    txt_sostituisci.Visible = false;
                    lb_sostituisci.Visible = false;
                    break;
            }
        }

        private void btnTrova_Click(object sender, EventArgs e)
        {
            ResetColor();

            if (shortTrova == 1)
            {
                contpos = 0;
                bool trovato = false;

                while (contpos < richTextBox1.Text.Length)
                {
                    int foundPos = richTextBox1.Text.IndexOf(txt_Cerca.Text, contpos);

                    if (foundPos > -1)
                    {
                        trovato = true;
                        contpos = (short)(foundPos + txt_Cerca.Text.Length);
                        richTextBox1.Select(foundPos, txt_Cerca.Text.Length);
                        richTextBox1.SelectionColor = Color.Blue;
                    }
                    else
                    {
                        break;
                    }
                }

                if (!trovato)
                {
                    MessageBox.Show("Non presente");
                }

                richTextBox1.DeselectAll();
            }
            else if (shortTrova == 0)
            {
                contpos = 0;
                bool trovato = false;

                while (contpos < richTextBox1.Text.Length)
                {
                    int foundPos = richTextBox1.Text.IndexOf(txt_Cerca.Text, contpos);

                    if (foundPos > -1)
                    {
                        trovato = true;
                        richTextBox1.Select(foundPos, txt_Cerca.Text.Length);
                        richTextBox1.SelectedText = txt_sostituisci.Text;
                        contpos = (short)(foundPos + txt_sostituisci.Text.Length);
                    }
                    else
                    {
                        break;
                    }
                }

                if (!trovato)
                {
                    MessageBox.Show("Non presente");
                }
            }

            txt_Cerca.Text = "";
            richTextBox1.DeselectAll();
        }

        private void ResetColor()
        {
            int originalSelectionStart = richTextBox1.SelectionStart;
            int originalSelectionLength = richTextBox1.SelectionLength;

            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.DeselectAll();

            richTextBox1.SelectionStart = originalSelectionStart;
            richTextBox1.SelectionLength = originalSelectionLength;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lb_parole.Text = "Parole: " + richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
            lb_caratteri.Text = "Caratteri:" + richTextBox1.Text.Length.ToString();
        }

        private void salva_con_nome_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Seleziona dove salvare il file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                System.IO.File.WriteAllText(filePath, richTextBox1.Text);

                MessageBox.Show("File salvato in: " + filePath);
            }
        }

        private void Importa_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleziona un file da aprire";

            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {     
                string filePath = openFileDialog.FileName;

                try
                {
                    
                    string fileContent = File.ReadAllText(filePath);
                    richTextBox1.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nella lettura del file: " + ex.Message);
                }
            }
        }
    }
}