﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using Syncfusion.UI.Xaml.ImageEditor;
using Syncfusion.UI.Xaml.ImageEditor.Enums;


using System.IO;
using Microsoft.Win32;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace CSharpDotNetProject
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        string connectionstring = "server=localhost;port=3306;database=kloningsattest;uid=root;password=gamechen0045";

        public Window1()
        {
            InitializeComponent();
        }

        private void OpenwindowSign(object sender, RoutedEventArgs e)
        {
            WindowSigniture sW = new WindowSigniture();
            sW.Show();
        }


        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            string query = "INSERT INTO `bil_information` (`Registreringsnummer`,`Stelnummer`,`Maerke`,`Model`,`Version`,`Foerste_registrering`,`Antal_noegler`,`Gearkassenummer`) " +
                     "VALUES('" + registreringsnummer.Text + "','" + stelnummer.Text + "','" + mærke.Text + "','" + model.Text + "'," +
                     "'" + version.Text + "','" + første_registrering.Text + "','" + antal_nøgler.Text + "','" + gearkassenummer.Text + "')";

            string query2 = "INSERT INTO `attest_information` (`Dato`,`Registreringsnummer`,`Stelnummer`,`DEKRA_Bilsyn`,`Rapport_udfoert_af`," +
                "`Fremstiller`,`Kontaktperson`,`Registreringsattest`,`Registreringsattest_original_kopi`,`Seneste_kendte_registreringsnummer`," +
                "`E_typegodkendt_under_nr`,`Dokumenteret_med_brochure`,`Dokumenteret_med_erklaering_fra_et_proevningslaboratorium`,`Dokumenteret_med_Originalt_CoC_dokument_data_erklaering`," +
                "`Billeder_af_dokumenter_vedhaeftet`,`KM_stand`,`Gearkassenummer_kontrolleret`,`Medbragt_servicehitorik_kontrolleret`,`Noegler_kontrolleret_statspaerre_og_aaben_og_laasefunktion`," +
                "`Identitet_dokumenteret_med_Originalt_CoC_dokument_data_erklaring`,`Originalt_laktykkelse`,`Laktykkelse_maalt_til`,`Lak_konklusion`,`Motornummer_kontrolleret`,`Koeretoej_i_original_farve`," +
                "`Er_stelnummer_korrekt`,`Stelnummerets_tilstand`,`Beskadiget_manglende_stelnummer`) " +
            "VALUES('" + dato.Text + "','" + registreringsnummer.Text + "','" + stelnummer.Text + "','" + dekra_bilsyn.Text + "'," +
            "'" + rapport_udført_af.Text + "','" + fremstiller.Text + "','" + kontaktperson.Text + "','" + Registreringsattest.Text + "'," +
            "'" + registreringsattest_original.Text + "','" + seneste_kendte_registreringsnummer.Text + "','" + E_typegodkendt.Text + "'," +
            "'" + identitet_dokumenteret_med_brochure.Text + "','" + identitet_dokumenteret_med_erklæring_fra_et_prøvelaboratorium.Text + "'," +
            "'" + identitet_dokumenteret_med_originalt_data_erklæring.Text + "','" + billeder_af_dokumenter_vedhæftet.Text + "','" + km_stand.Text + "'," +
            "'" + gearkassenummer_kontrolleret.Text + "','" + medbragt_servicehistorik.Text + "','" + nøgler_kontrolleret.Text + "','" + identitet_dokumenteret_med_originalt_data_erklæring.Text + "'," +
            "'" + original_laktykkelse.Text + "','" + laktykkelse_målt_til.Text + "','" + lak_konklusion.Text + "','" + motornummer_kontrolleret.Text + "','" + køretøj_i_original_farve.Text + "'," +
            "'" + stelnummer_korrekt.Text + "','" + stelnummer_tilstand.Text + "','" + beskadigt_stelnummer.Text + "')";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            int value = cmd.ExecuteNonQuery();
            int value2 = cmd2.ExecuteNonQuery();


            MessageBox.Show("Saved");
            connection.Close();

        }

        private void km_stand_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void antal_nøgler_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}