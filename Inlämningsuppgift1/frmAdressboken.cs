using System;
using System.IO;
using System.Windows.Forms;

namespace Inlämningsuppgift1
{
    public partial class frmAdressboken : Form
    {
        public frmAdressboken()
        {
            InitializeComponent();
        }

        string file = @"C:\Programmering c#\Inlämningsuppgift1\adressboken.txt";


        public void EmptyTextBoxes()
        {
            txtNamn.Text = "";
            txtGatudress.Text = "";
            txtPostnummer.Text = "";
            txtPostOrt.Text = "";
            txtTelefon.Text = "";
            txtEpost.Text = "";
        }

      

        public void RegisteraInfo(string namn, string gatudress, string postNummer, string postOrt, string telefon, string ePost)
        {
            StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine(namn + "," + gatudress + "," + postNummer + "," + postOrt + "," + telefon + "," + ePost);
            writer.Close();
        }




        string replaceRow = ""; string oldRow = "";

        bool findInfo = false, doneUpdate = false;


        private void cmdUppdateraNyAdress_Click(object sender, EventArgs e)
        {
           

            replaceRow = txtNamn.Text + "," + txtGatudress.Text + "," + txtPostnummer.Text + ","
                + txtPostOrt.Text + "," + txtTelefon.Text + "," + txtEpost.Text;

            string tempFile = Path.GetTempFileName();
            using (var sr = new StreamReader(file))
            using (var sw = new StreamWriter(tempFile))
            {
                string row;
                while ((row = sr.ReadLine()) != null)
                {
                    if (row != oldRow)
                        sw.WriteLine(row);

                    else
                    {
                        sw.WriteLine(replaceRow);
                        findInfo = true;
                    }
                }
                sr.Close();
                sw.Close();
            }
            File.Delete(@"C:\Programmering c#\Inlämningsuppgift1\adressboken.txt");
            File.Move(tempFile, file);


            if (findInfo)
            {
                MessageBox.Show("Den inmatade informationen uppdaterades!");
                EmptyTextBoxes();
            }
           



        }


        private void cmdRegistera_Click(object sender, EventArgs e)
        {
            string namn = txtNamn.Text;
            string gatudress = txtGatudress.Text;
            string postNummer = txtPostnummer.Text;
            string postOrt = txtPostOrt.Text;
            string telefon = txtTelefon.Text;
            string ePost = txtEpost.Text;
            if (namn != "" && gatudress != "" && postNummer != "" && postOrt!= "" && telefon != "" && 
                ePost != "" && this.txtEpost.Text.IndexOf("@")>0 && this.txtEpost.Text.IndexOf(".")>0)
            {
                RegisteraInfo(namn, gatudress, postNummer, postOrt, telefon, ePost);
                MessageBox.Show("Den inmatade informationen sparades!");
            }
            else
            {
                MessageBox.Show("Försök igen!");
            }


            EmptyTextBoxes();

        }


        bool findInfoDelete = false;
        string rowDelete;

        private void cmdTabort_Click(object sender, EventArgs e)
        {

                string tempFile = Path.GetTempFileName();
                using (var sr = new StreamReader(file))
                using (var sw = new StreamWriter(tempFile))
                {
                    string row;
                    while ((row = sr.ReadLine()) != null)
                    {
                        if (row != rowDelete)
                        {
                            sw.WriteLine(row);
                        }
                        else
                        {
                            findInfoDelete = true;
                        }
                    }
                sr.Close();
                sw.Close();
                }
                
                File.Delete(@"C:\Programmering c#\Inlämningsuppgift1\adressboken.txt");
                File.Move(tempFile, file);
           

            if (findInfoDelete) MessageBox.Show("Den inmatade informationen readerades!");
            

            EmptyTextBoxes();
        }

        private void cmdBringOldRow_Click(object sender, EventArgs e)
        {
            oldRow = lsbSoka.SelectedItem.ToString();
            rowDelete = lsbSoka.SelectedItem.ToString();
            using (var sr = new StreamReader(file))
            {
                string selectedRow;
                while ((selectedRow = sr.ReadLine()) != null)
                {
                    if (selectedRow == oldRow)
                    {
                        string[] infoValues = selectedRow.Split(',');

                        txtNamn.Text = infoValues[0];
                        txtGatudress.Text = infoValues[1];
                        txtPostnummer.Text = infoValues[2];
                        txtPostOrt.Text = infoValues[3];
                        txtTelefon.Text = infoValues[4];
                        txtEpost.Text = infoValues[5];
                    }
                }
                sr.Close();
            }

            MessageBox.Show("Ange dina nya information, eller tryck på *tabort* om du vill radera dina information");
            txtSokning.Text = "";
            lsbSoka.Items.Clear();

        }

        private void txtPostnummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtNyPostnummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        private void cmdSokning_Click(object sender, EventArgs e)
        {
            lsbSoka.Items.Clear();
            string sokaValue = txtSokning.Text;
            StreamReader reader = new StreamReader(file, true);
            string row = reader.ReadLine();
            int counterInfo = 0;
            while (row != null)
            {
                string[] infoValues = row.Split(',');
                if (sokaValue == infoValues[0] || sokaValue == infoValues[1] || sokaValue == infoValues[3])
                {
                    lsbSoka.Items.Add(row);
                    counterInfo++;
                }
                row = reader.ReadLine();
            }
            reader.Close();

            if (counterInfo == 0)
            {
                MessageBox.Show("Din sökning gav inga träff! Försök igen. ");

            }
        }

    }
}
    

