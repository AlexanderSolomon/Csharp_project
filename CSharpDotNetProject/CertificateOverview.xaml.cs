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
        string connectionstring = "server=localhost; port=3306;database=kloningsattest;uid=root;password=Oliven13";
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
                    ///certificate.Worker = dt["Rapport_udført_af"].ToString();
                    certificate.Customer = dt["Fremstiller"].ToString();
                    certificate.Contact = dt["Kontaktperson"].ToString();
                    certificate.Registrationcertificate = dt["Registreringsattest"].ToString();
                    certificate.RegistrationcertificateOriginal = dt["Registreringsattest_original_kopi"].ToString();
                    certificate.LastRegistration = dt["Seneste_kendte_registreringsnummer"].ToString();
                    certificate.ETypeApproveNr = dt["E_typegodkendt_under_nr"].ToString();
                    certificate.DocumentedByBrochure = dt["Dokumenteret_med_brochure"].ToString();
                    ///certificate.DocumentedByLab = dt["Dokumenteret_med_erklæring_fra_et_prøvningslaboratorium"].ToString();
                    ///certificate.DocumentedByCocDoc = dt["Dokumenteret_med_Originalt_CoC_dokument_data_erklæring"].ToString();
                    ///certificate.PicturesAppended = dt["Billeder_af_dokumenter_vedhæftet"].ToString();
                    certificate.Mileage = (int)dt["KM_stand"];
                    certificate.GearBoxVerified = dt["Gearkassenummer_kontrolleret"].ToString();
                    certificate.ServiceHistoryVerified = dt["Medbragt_servicehitorik_kontrolleret"].ToString();
                    ///certificate.KeyControlled = dt["Nøgler_kontrolleret_statspærre_og_åben_og_låsefunktion"].ToString();
                    ///certificate.IdentityVerified = dt["Identitet_dokumenteret_med_Originalt_CoC_dokument_data_erklæring"].ToString();
                    certificate.OriginalPaintThickness = dt["Originalt_laktykkelse"].ToString();
                    ///certificate.OriginalPaintThicknessMeasured = dt["Laktykkelse_målt_til"].ToString();
                    certificate.PaintConclusion = dt["Lak_konklusion"].ToString();
                    certificate.EngineNumberVerified = dt["Motornummer_kontrolleret"].ToString();
                    /// certificate.OriginalPaint = dt["Køretøj_i_original_farve"].ToString();
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

                }
        }
    }
}
