using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Net
{
    //PARTIAL besagt, dass die Klasse hier nicht vollständig dargestellt wird. Der Rest befindet sich in einem
    ///anderen Dokument. Jedes Form erbt von der Klasse FORM, welche sämtliche Funktionen eines Fensters zur Verfügung stellt
    public partial class MainWindow : Form
    {
        //Konstruktor des Forms (wird bei Aufruf des Fensters aufgerufen)
        public MainWindow()
        {
            //Mit dieser Methode werden die Designerseitig gebauten Elemente gezeichnet (-> sollte immer die erste Funktion sein, welche
            ///der Konstruktor aufruft
            InitializeComponent();

            // EVENTs sind spezielle Delegates, welche nicht per Zuweisung überschrieben werden können.Methode müssen das Event per += abbonieren und
            ///per -= deabbonieren. Tritt ein Event auf (z.B. wenn ein Button geklickt wird) werden alle Methoden ausgeführt, welche dieses Event
            ///abboniert haben
            Btn_KlickMich.Click += Btn_KlickMich_Click_02;

            //Hinzufügen eines Eintrags zur Combobox
            Cbb_Auswahl.Items.Add("Neues Item");
        }

        //Click-Methoden, der einzelnen Buttons
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Ändern der Hintergrundfarbe des Buttons
            Btn_KlickMich.BackColor = Color.DarkBlue;

            //Verschieben des Buttons um 10 Pixel nach rechts
            Btn_KlickMich.Left += 10;

            //Cast des aufrufenden Objekts zum Button und Verschieben des Buttons um 10 Pixel nach rechts
            (sender as Button).Left += 10;

            //Prüfung, ob die Checkbox abgehakt ist
            if (Cbx_Haken.Checked)
                //Ändern der Hintergrundfarbe des Fensters
                this.BackColor = Color.HotPink;

            //Einfügen des markierten Elements in der Combobox als String in das Label 
            //(? ist Null-Prüfung: ToString wird nur ausgeführt, wenn SelectedItem belegt ist)
            Lbl_Output.Text = Cbb_Auswahl.SelectedItem?.ToString();
        }

        private void Btn_KlickMich_Click_02(object sender, EventArgs e)
        {
            //Anzeigen einer MessageBox mit Prüfung, welcher Button geklickt wurde
            if (MessageBox.Show("Geht es dir gut?", "Befindlichkeitsabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Aber nicht mehr lange...");
            }
            else
                MessageBox.Show("Das passiert mal...");
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziierung des neuen Fensters
            MainWindow neuesFenster = new MainWindow();
            //Manipuation des Fenstertitels
            neuesFenster.Text = "2. Fenster";
            //Öffnen des Fensters als gleichberechtigtes Fenster
            //neuesFenster.Show();
            //Öffnen des neuen Fensters als Dialogfenster (verbietet Zugriff auf alle anderen Fenster)
            neuesFenster.ShowDialog();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Schließen des aktuellen Fensters
            this.Close();
            //Beenden der kompletten Applikation
            //Application.Exit();
        }
    }
}
