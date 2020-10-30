using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahrzeugpark;
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        //Benötigte Properties (Liste zum Speichern der Fahrzeuge und Zufallsgenerator)
        public List<Fahrzeug> Fahrzeugliste { get; set; }
        public Random Generator { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Initialisierung der Properties
            Fahrzeugliste = new List<Fahrzeug>()
            {
                new PKW("BMW", 250, 23000, 5),
                new Flugzeug("Boing", 750, 3000000, 9990),
                new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf)
            };

            this.Generator = new Random();

            UpdateGui();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            //Erstellen einer zufälligen neuen Person und Eintrag in die Personenliste
            Fahrzeugliste.Add(ErstelleNeuesFz());
            //Updaten der GUI
            UpdateGui();
        }

        //Methode zum Löschen markierter Fahrzeugen
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //Prüfung, ob ein Eintrag ausgewählt ist
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //Löschen des in der ListBox markierten Items aus der Personenliste
                LöscheFz(Lbx_Fahrzeuge.SelectedItem as Fahrzeug);

            //Updaten der GUI
            UpdateGui();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveFz(Fahrzeugliste);
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            Fahrzeugliste = LoadFz();

            UpdateGui();
        }

        //Methode zum Update der GUI
        private void UpdateGui()
        {
            //Löschen der Listboxinhalte
            Lbx_Fahrzeuge.Items.Clear();

            //Einfügen der Fahrzeuge aus der Liste in die Listbox
            foreach (var item in Fahrzeugliste)
            {
                Lbx_Fahrzeuge.Items.Add(item);
            }
        }

        //Methode zum zufälligen Erstellen von Fahrzeugen
        private Fahrzeug ErstelleNeuesFz()
        {
            switch (Generator.Next(1, 4))
            {
                case 1:
                    return new Flugzeug($"Boing", 800, 3600000, 9999);
                case 2:
                    return new Schiff($"Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);
                case 3:
                    return PKW.ErzeugeZufälligenPKW($"");
            }

            return null;
        }

        private void LöscheFz(Fahrzeug fz)
        {
            Fahrzeugliste.Remove(fz);
        }

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LadeFZ)
        private void SaveFz(List<Fahrzeug> fzList)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            try
            {
                using(StreamWriter writer = new StreamWriter("fahrzeugliste.txt"))
                {
                    for (int i = 0; i < Fahrzeugliste.Count; i++)
                    {
                        string fzAlsString = JsonConvert.SerializeObject(fzList[i], settings);
                        writer.WriteLine(fzAlsString);
                    }

                    MessageBox.Show("Speichern erfolgreich");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Speichern fehlgeschlagen. " + ex.Message);
            }
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.Form1.LadeText())
        private List<Fahrzeug> LoadFz()
        {
            List<Fahrzeug> fzList = new List<Fahrzeug>();

            //Erstellen eines JsonSerialiserSetting-Objekt zur Spezifizierung der Serialisierung
            JsonSerializerSettings settings = new JsonSerializerSettings();
            //TypeNameHandling markiert die Json-Zeilen mit dem entsprechenden Objekt-Typ (z.B. PKW, Flugzeug, Schiff)
            settings.TypeNameHandling = TypeNameHandling.Objects;

            try
            {
                using(StreamReader reader = new StreamReader("fahrzeugliste.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        //Lesen einer Textzeile aus der Datei
                        string fzAlsString = reader.ReadLine();
                        //Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                        Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(fzAlsString, settings);
                        //Hinzufügen des Fahrzeugs zur Liste
                        fzList.Add(fz);
                    }

                    MessageBox.Show("Laden erfolgreich");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Laden fehlgeschlagen. " + ex.Message);
            }

            return fzList;
        }
    }
}
