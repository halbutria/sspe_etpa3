using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServiciosApiCiudadano.Aplicacion.Utils;
using SispeServiciosApiCiudadano.DTOs;
using System.Runtime.CompilerServices;


namespace SispeServicios.Api.Ciudadano.Aplicacion.Utils
{
    public class PdfGenerator
    {       

        public static byte[] GeneracionPDF(CiudadanoVisualizacionDTO ciudadanoDto)
        {
            byte[] pdfBytes;
            const int headerFontSize = 10;
            const int normalFontSize = 8;
            PdfDocument document = new PdfDocument();
            // Sample uses DIN A4, page height is 29.7 cm. We use margins of 2.5 cm.
            LayoutHelper helper = new LayoutHelper(document, XUnit.FromPoint(XUnit.FromCentimeter(2.5)), XUnit.FromPoint(XUnit.FromCentimeter(29.7 - 4)));
            XUnit left = XUnit.FromCentimeter(2.5);
            XUnit top;
            PlatformFontResolver.ResolveTypeface("Verdana", true, true);
            XFont fontHeader = new("Verdana", headerFontSize, XFontStyle.Regular);
            XFont fontNormal = new("Verdana", normalFontSize, XFontStyle.Regular);
            XStringFormat formatCenter = new() { Alignment = XStringAlignment.Center };
            XStringFormat format = new() { Alignment = XStringAlignment.Near };
            GeneracionPDF obj = new();

            helper.GetLinePositionPage(normalFontSize);
            top = helper.GetLinePositionPage(normalFontSize);
            obj.DrawTitle(helper.Gfx, "Hoja de Vida", ((helper.Page.Width - 30) / 2), top);
            helper.GetLinePositionPage(normalFontSize*2);
            top = helper.GetLinePositionPage(normalFontSize);
            string nombreCiudadano = string.Format("{0} {1} {2} {3}", ciudadanoDto.PrimerNombre, ciudadanoDto.SegundoNombre, ciudadanoDto.PrimerApellido, ciudadanoDto.SegundoApellido);
            obj.DrawCiudadano(helper.Page, helper.Gfx, nombreCiudadano, fontHeader, left + 210, top, formatCenter);

            helper.GetLinePositionPage(normalFontSize);
            top = helper.GetLinePositionPage(normalFontSize);
            obj.DrawDatosPersonales(helper, ciudadanoDto, fontHeader, fontNormal, left, top, format, formatCenter);

            helper.GetLinePositionPage(normalFontSize);
            top = helper.GetLinePositionPage(normalFontSize);
            obj.DrawDatosdeContacto(helper, ciudadanoDto, fontHeader, fontNormal, left, top, format, formatCenter);

            top = helper.GetCurrentPosition();
            top = obj.DrawPerfilLaboral(helper, ciudadanoDto, fontHeader, fontNormal, left, top, format, formatCenter);
            top = obj.DrawInformacionLaboral(helper, ciudadanoDto, fontHeader, fontNormal, left, top, format, formatCenter);
            top = obj.DrawEducacionFormal(helper, ciudadanoDto, fontHeader, fontNormal, left, top, format, formatCenter);
            obj.DrawEducacionInFormal(helper, ciudadanoDto, fontHeader, fontNormal, left, top, format, formatCenter);

            using (MemoryStream memoryStream = new())
            {
                document.Save(memoryStream, false);
                pdfBytes = memoryStream.ToArray();
            }
            //document.Save(@"C:\TestHv.pdf");
            return pdfBytes;
        }

        public static byte[] GeneracionPDFCertificadoInscripcion(CertificadoInscripcionDTO ciudadano)
        {

            byte[] pdfBytes = new byte[1];
            GeneracionPDF obj = new();

            const int headerFontSize = 12;
            const int normalFontSize = 10;
            PdfDocument document = new PdfDocument();
            // Sample uses DIN A4, page height is 29.7 cm. We use margins of 2.5 cm.
            LayoutHelper helper = new LayoutHelper(document, XUnit.FromPoint(XUnit.FromCentimeter(2.5)), XUnit.FromPoint(XUnit.FromCentimeter(29.7 - 4)));

            XUnit left = XUnit.FromCentimeter(2.5) + 15;
            XUnit top = helper.GetCurrentPosition();

            PlatformFontResolver.ResolveTypeface("Verdana", true, true);

            XFont fontHeader = new("Verdana", headerFontSize, XFontStyle.Regular);
            XFont fontNormal = new("Verdana", normalFontSize, XFontStyle.Regular);
            XStringFormat formatCenter = new() { Alignment = XStringAlignment.Center };
            XStringFormat format = new() { Alignment = XStringAlignment.Near };

            helper.CreatePage();

            obj.DrawMarcaAgua(helper.Gfx);
            helper.GetLinePositionPage(normalFontSize * 10);
            top = helper.GetLinePositionPage(normalFontSize);
            helper.Gfx.DrawString("CERTIFICADO DE INSCRIPCIÓN", fontHeader, XBrushes.Black, ((helper.Page.Width - 120) / 2), top, format);

            string textoContenido = string.Format("La Unidad Administrativa del Servicio Público de Empelo certifica que {0} con identificación {1} {2}, está inscrito en el sistema de información.", ciudadano.Nombre, ciudadano.TipoIdentificacion, ciudadano.NumeroIdentificacion);

            var infoText = obj.TotalLineasTextoSeccionPerfilLaboral(helper, textoContenido, fontNormal, 450);
            string[] words = infoText.Item2.Split(Environment.NewLine);
            foreach (string word in words)
            {
                helper.Gfx.DrawString(word, fontNormal, XBrushes.Black, left, helper.GetBeforePosition() + 180);
                helper.GetLineBeforePositionPage(normalFontSize * 2);
            }

            helper.Gfx.DrawString(string.Format("Bogotá, DC. ({0})", DateTime.Now.ToString("dd/MM/yyyy")), fontNormal, XBrushes.Black, left, helper.GetBeforePosition() + 230);


            using (MemoryStream memoryStream = new())
            {
                document.Save(memoryStream, false);
                pdfBytes = memoryStream.ToArray();
            }

            //document.Save(@"C:\Inscripcion.pdf");


            return pdfBytes;
        }



    }




}
