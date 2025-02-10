using PdfSharpCore;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace SispeServiciosApiCiudadano.Aplicacion.Utils
{
    public class LayoutHelper
    {
        private readonly PdfDocument _document;
        private readonly XUnit _topPosition;
        private readonly XUnit _bottomMargin;
        public XUnit _currentPosition;
        private static double _currentBeforePosition;

        public XGraphics Gfx { get; set; }

        public PdfPage Page { get; set; }

        public bool swCreoPagina { get; set; }


        public LayoutHelper(PdfDocument document, XUnit topPosition, XUnit bottomMargin)
        {
            _document = document;
            _topPosition = topPosition;
            _bottomMargin = bottomMargin;
            // Set a value outside the page - a new page will be created on the first request.
            _currentPosition = bottomMargin + 10000;
            swCreoPagina = false;
        }



        public XUnit GetLinePositionPage(XUnit requestedHeight, bool incluirFooter = true)
        {
            XUnit result;
            XUnit required = requestedHeight;
            if (_currentPosition + required + 10 > _bottomMargin)
            {
                CreatePage(incluirFooter);
                result = _currentPosition;
                _currentPosition += requestedHeight;
                swCreoPagina = true;
            }
            else
            {
                result = _currentPosition;
                _currentPosition += requestedHeight;
                swCreoPagina = false;
            }

            return result;
        }

        public double GetLineBeforePositionPage(XUnit requestedHeight)
        {
            _currentBeforePosition += requestedHeight;
            return _currentBeforePosition;
        }

        public void CreatePage(bool incluirFooter = true)
        {
            Page = _document.AddPage();
            Page.Size = PageSize.A4;
            Gfx = XGraphics.FromPdfPage(Page);
            GeneracionPDF obj = new();
            obj.DrawMarcaAgua(Gfx, incluirFooter);
            
            _currentPosition = _topPosition;
            _currentBeforePosition = _topPosition;
        }

        public XUnit GetTopMargin()
        {
            return _topPosition;
        }

        public XUnit SetCurrentPosition(XUnit value)
        {
            _currentBeforePosition = _currentPosition;
            _currentPosition = value;
            return _currentPosition;
        }
        public XUnit SetCurrentPositionOri(XUnit value)
        {
            _currentPosition = value;
            return _currentPosition;
        }

        public XUnit SetBeforePosition(XUnit value)
        {
            _currentBeforePosition = value;
            return _currentBeforePosition;
        }

        public XUnit GetBeforePosition()
        {
            return _currentBeforePosition;
        }

        public XUnit GetCurrentPosition()
        {
            return _currentPosition;
        }

        public XUnit GetBottomMargin()
        {
            return _bottomMargin;
        }

        public void SetPositionBeforePage(double topBefore)
        {
            _currentBeforePosition = topBefore;
        }

        public bool ValidateFinPagina()
        {
            return _currentPosition > _bottomMargin ? true : false;
        }


    }
}
