using PdfSharpCore.Fonts;

namespace SispeServiciosApiCiudadano.Aplicacion.Utils
{
    public class CustomFontResolver : IFontResolver
    {
        public string DefaultFontName => throw new NotImplementedException();

        public byte[] GetFont(string faceName)
        {
            string fontFileName = "Verdana.ttf";
            return File.ReadAllBytes(fontFileName);
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {

            string fontName = "Verdana";

            // You may need to adjust this based on your font file (e.g., "Regular", "Bold", "Italic", etc.)
            //string style = (isBold ? "Bold" : "") + (isItalic ? "Italic" : "");

            return new FontResolverInfo(fontName);
        }
    }
}
