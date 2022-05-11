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
        private string originalPaintThicknessMeasured;
        private string paintConclusion;
        private Boolean engineNumberVerified;
        private Boolean originalPaint;
        private Boolean serialCorrect;
        private string serialCondition;
        private string serialDamaged; 

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Registration
        {
            get { return registration; }
            set { registration = value; }
        }
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        public String Workshop
        {
            get { return workshop; }
            set { workshop = value; }
        }
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public string Registrationcertificate
        {
            get { return registrationcertificate; }
            set { registrationcertificate = value; }
        }
        public string RegistrationcertificateOriginal
        {
            get { return registrationcertificateOriginal; }
            set { registrationcertificateOriginal = value; }
        }
        public string LastRegistration
        {
            get { return lastRegistration; }
            set { lastRegistration = value; }
        }
        public string ETypeApproveNr
        {
            get { return eTypeApproveNr; }
            set { eTypeApproveNr = value; }
        }
        public Boolean GearBoxVerified
        {
            get { return gearBoxVerified; }
        }
        public Boolean ServiceHistoryVerified
        {
            get { return serviceHistoryVerified; }
            set { serviceHistoryVerified = value; }
        }
        public Boolean KeyControlled
        {
            get { return keyControlled; }
            set { keyControlled = value; }
        }
        public Boolean DocumentedByBrochure
        {
            get { return documentedByBrochure; }
            set { documentedByBrochure = value;}
        }
        public Boolean DocumentedByLab
        {
            get { return documentedByLab; }
            set { documentedByLab = value; }
        }
        public Boolean DocumentedByCocDoc
        {
            get { return documentedByCocDoc; }
            set { documentedByCocDoc = value; }
        }
        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        public string OriginalPaintThickness
        {
            get { return originalPaintThickness; }
            set { originalPaintThickness = value; }
        }
        public string OriginalPaintThicknessMeasured
        {
            get { return originalPaintThicknessMeasured; }
            set { originalPaintThicknessMeasured = value; }
        }
        public string PaintConclusion
        {
            get { return paintConclusion; }
            set { paintConclusion = value; }
        }
        public Boolean EngineNumberVerified
        {
            get { return engineNumberVerified; }
            set { engineNumberVerified = value; }
        }
        public Boolean OriginalPaint
        {
            get { return originalPaint; }
            set { originalPaint = value; }
        }
        public Boolean SerialCorrect
        {
            get { return serialCorrect; }
            set { serialCorrect = value; }
        }
        public string SerialCondition
        {
            get { return serialCondition; }
            set { serialCondition = value; }
        }
        public string SerialDamaged
        {
            get { return serialDamaged; }
            set { serialDamaged = value; }
        }
    }
}
