using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetProject
{
    internal class Certificate
    {
        private int id;
        private string registration; 
        private string serialNumber;
        private string workshop;
        private string customer; 
        private string contact;
        private string registrationcertificate;
        private string registrationcertificateOriginal;
        private string lastRegistration;
        private string eTypeApproveNr;
        private Boolean documentedByBrochure;
        private Boolean documentedByLab; 
        private Boolean documentedByCocDoc;
        private int mileage;
        private Boolean gearBoxVerified;
        private Boolean serviceHistoryVerified;
        private Boolean keyControlled;
        private string originalPaintThickness; 



        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    }
}
