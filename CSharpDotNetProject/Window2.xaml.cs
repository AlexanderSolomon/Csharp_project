using Spire.Pdf;
using Spire.Pdf.Fields;
using Spire.Pdf.Graphics;
using Spire.Pdf.Widget;
using System;
using System.Collections;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    /// Just to test the interaction with the PDF file.
    public partial class Window2 : Window
    {
        private const string Value = "Kloningsattest-02-2022-TEST.pdf";

        public Window2()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fileName = new string(Value);
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(fileName);
            PdfFormWidget formWidget = doc.Form as PdfFormWidget;
            for (int i = 0; i < formWidget.FieldsWidget.List.Count; i++)
            {
                PdfField field = formWidget.FieldsWidget.List[i] as PdfField; 

                if (field is PdfTextBoxFieldWidget)
                {
                    PdfTextBoxFieldWidget pdfTextBoxField = field as PdfTextBoxFieldWidget;
                    pdfTextBoxField.Text = "test"; 
                }
                if (field is PdfCheckBoxWidgetFieldWidget)
                {
                    PdfCheckBoxWidgetFieldWidget pdfCheckButtonField = field as PdfCheckBoxWidgetFieldWidget;
                    pdfCheckButtonField.Checked = true;
                }
            }
            PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 13f);
            PdfBrush brush = PdfBrushes.Black;
            float x = 20;
            float y = 150;
            float tempX = 0;
            float tempY = 0;
            doc.SaveToFile("saveTest.pdf");


        }
    }
}
