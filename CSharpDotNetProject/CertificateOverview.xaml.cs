using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CSharpDotNetProject
{
    /// <summary>
    /// Interaction logic for CertificateOverview.xaml
    /// </summary>
    public partial class CertificateOverview : Window
    {
        string connectionstring = "server=localhost; port=3306;database=kloningsattest;uid=root;password=gamechen0045";
        Certificate certificate = new Certificate();
        public CertificateOverview(string id)
        {
            InitializeComponent();

            initCert(id);
            insertText();

            void initCert(string id) 
            {
                MySqlConnection connection = new MySqlConnection(connectionstring);
                MySqlCommand cmd = new MySqlCommand("select * FROM kloningsattest.attest_information where Attest_ID = " + id + ";", connection);
                connection.Open();
                MySqlDataReader dt;
                dt = cmd.ExecuteReader();
                if (dt != null)
                {
                    dt.Read();
                    certificate.Id = (int)dt["Attest_ID"];
                    certificate.Date = dt["Dato"].ToString();
                    certificate.Registration = dt["Registreringsnummer"].ToString();
                    certificate.SerialNumber = dt["Stelnummer"].ToString();
                    certificate.Workshop = dt["DEKRA_Bilsyn"].ToString();
                    certificate.Worker = dt["Rapport_udfoert_af"].ToString();
                    certificate.Customer = dt["Fremstiller"].ToString();
                    certificate.Contact = dt["Kontaktperson"].ToString();
                    certificate.Registrationcertificate = dt["Registreringsattest"].ToString();
                    certificate.RegistrationcertificateOriginal = dt["Registreringsattest_original_kopi"].ToString();
                    certificate.LastRegistration = dt["Seneste_kendte_registreringsnummer"].ToString();
                    certificate.ETypeApproveNr = dt["E_typegodkendt_under_nr"].ToString();
                    certificate.DocumentedByBrochure = dt["Dokumenteret_med_brochure"].ToString();
                    certificate.DocumentedByLab = dt["Dokumenteret_med_erklaering_fra_et_proevningslaboratorium"].ToString();
                    certificate.DocumentedByCocDoc = dt["Dokumenteret_med_Originalt_CoC_dokument_data_erklaering"].ToString();
                    certificate.PicturesAppended = dt["Billeder_af_dokumenter_vedhaeftet"].ToString();
                    certificate.Mileage = (int)dt["KM_stand"];
                    certificate.GearBoxVerified = dt["Gearkassenummer_kontrolleret"].ToString();
                    certificate.ServiceHistoryVerified = dt["Medbragt_servicehitorik_kontrolleret"].ToString();
                    certificate.KeyControlled = dt["Noegler_kontrolleret_statspaerre_og_aaben_og_laasefunktion"].ToString();
                    certificate.IdentityVerified = dt["Identitet_dokumenteret_med_Originalt_CoC_dokument_data_erklaring"].ToString();
                    certificate.OriginalPaintThickness = dt["Originalt_laktykkelse"].ToString();
                    certificate.OriginalPaintThicknessMeasured = dt["Laktykkelse_maalt_til"].ToString();
                    certificate.PaintConclusion = dt["Lak_konklusion"].ToString();
                    certificate.EngineNumberVerified = dt["Motornummer_kontrolleret"].ToString();
                    certificate.OriginalPaint = dt["Koeretoej_i_original_farve"].ToString();
                    certificate.SerialCorrect = dt["Er_stelnummer_korrekt"].ToString();
                    certificate.SerialCondition = dt["Stelnummerets_tilstand"].ToString();
                    certificate.SerialDamaged = dt["Beskadiget_manglende_stelnummer"].ToString();
                    
                }
                else
                {
                }
            }
                void insertText()
                {
                    ID.Text = certificate.Id.ToString();
                    dato.Text = certificate.Date.ToString();
                    registreringsnummer.Text = certificate.Registration.ToString();
                stelnummer.Text = certificate.SerialNumber.ToString();
                workshop.Text = certificate.Workshop.ToString();
                rapport_udført_af.Text = certificate.Worker.ToString();
                fremstiller.Text = certificate.Customer.ToString();
                registreringsattest.Text = certificate.Registrationcertificate.ToString();
                registreringsattest_kopi.Text = certificate.Registrationcertificate.ToString();
                seneste_registreringsnummer.Text = certificate.LastRegistration.ToString();
                e_typegodkendt.Text = certificate.ETypeApproveNr.ToString();
                brochure.Text = certificate.DocumentedByBrochure.ToString();
                proeningslaboratorium.Text = certificate.DocumentedByLab.ToString();
                coc_dokument.Text = certificate.DocumentedByCocDoc.ToString();
                billeder_vedhæftet.Text = certificate.PicturesAppended.ToString();
                km_stand.Text = certificate.Mileage.ToString();
                gearkassenummer_kontrolleret.Text = certificate.GearBoxVerified.ToString();
                servicehistorik_kontrolleret.Text = certificate.ServiceHistoryVerified.ToString();
                noegler_kontrolleret.Text = certificate.KeyControlled.ToString();
                coc_dokument_data.Text = certificate.IdentityVerified.ToString();
                originalt_laktykkelse.Text = certificate.OriginalPaintThickness.ToString();
                laktykkelse_maalt.Text = certificate.OriginalPaintThicknessMeasured.ToString();
                lak_konklusion.Text = certificate.PaintConclusion.ToString();
                motornummer_kontrolleret.Text = certificate.EngineNumberVerified.ToString();
                koertøj_original_farve.Text = certificate.SerialCorrect.ToString();
                stelnummer_korrekt.Text = certificate.SerialCorrect.ToString();
                stelnummerets_tilstand.Text = certificate.SerialCondition.ToString();
                beskadgiet_stelnummer.Text = certificate.SerialDamaged.ToString();




                }
        }
    }
}
