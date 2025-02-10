using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using SispeServicios.Api.Ciudadano.DTOs;

namespace SispeServiciosApiCiudadano.Aplicacion.Utils
{
    public class GeneracionPDF
    {
        const int normalFontSize = 8;

        public void DrawMarcaAgua(XGraphics gfx, bool incluirFooter = true)
        {
            XImage image = XImage.FromFile("./Assets/Images/logo1.png");
            gfx.DrawImage(image, 20, 20, 120, 40);

            XImage image2 = XImage.FromFile("./Assets/Images/logo2.png");
            gfx.DrawImage(image2, 420, 7, 160, 80);

            if (incluirFooter)
            {
                XImage linea = XImage.FromFile("./Assets/Images/linea.png");
                gfx.DrawImage(linea, 150, 740, 450, 1);

                XImage image3 = XImage.FromFile("./Assets/Images/logo3.png");
                gfx.DrawImage(image3, 300, 750, 280, 70);

                XImage image4 = XImage.FromFile("./Assets/Images/logo4.png");
                gfx.DrawImage(image4, 0, 610, 400, 200);
            }
        }

        public void DrawTitle(XGraphics gfx, string title, double left, double top)
        {
            XFont font = new("Verdana", 18);
            XStringFormat format = new()
            {
                Alignment = XStringAlignment.Center
            };
            gfx.DrawString(title, font, XBrushes.Black, left, top, format);
        }

        public void DrawCiudadano(PdfPage page, XGraphics gfx, string nombre, XFont font, double left, double top, XStringFormat format)
        {

            gfx.DrawString(nombre, font, XBrushes.Black, left, top, format);
        }

        public void DrawDatosPersonales(LayoutHelper helper, CiudadanoVisualizacionDTO ciudadanoDto, XFont fontHeader, XFont fontNormal, double left, double top, XStringFormat format, XStringFormat formatCenter)
        {
            int altoSeccion = 80;
            top = helper.GetLinePositionPage(normalFontSize);
            XPen pen = new(XColors.Black, 0.5);
            helper.Gfx.DrawRoundedRectangle(pen, left - 50, top, 560, altoSeccion, 40, 40);
            XRect rect = new(left - 25, top-10, 105, 20);
            helper.Gfx.DrawRectangle(XBrushes.White, rect);
            helper.Gfx.DrawString("Datos Personales", fontHeader, XBrushes.Black, left + 25, top-9, formatCenter);

            top = helper.SetCurrentPosition(top + altoSeccion);

            helper.GetLineBeforePositionPage(normalFontSize);

            helper.Gfx.DrawString("Tipo de Documento", fontNormal, XBrushes.DarkGray, left - 20, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.TipoDocumento != null ? ciudadanoDto.TipoDocumento.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 70, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString("Número de Documento", fontNormal, XBrushes.DarkGray, left + 180, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.NumeroDocumento != null ? ciudadanoDto.NumeroDocumento.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 280, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString("Fecha de Nacimiento", fontNormal, XBrushes.DarkGray, left + 330, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.FechaNacimiento != null ? ciudadanoDto.FechaNacimiento.ToString("dd/MM/yyyy") : string.Empty, fontNormal, XBrushes.Black, left + 420, helper.GetBeforePosition(), format);

            helper.GetLineBeforePositionPage(normalFontSize*3);

            helper.Gfx.DrawString("Nacionalidad", fontNormal, XBrushes.DarkGray, left - 20, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.Nacionalidad != null ? ciudadanoDto.Nacionalidad.Nacionalidad.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 50, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString("Sexo", fontNormal, XBrushes.DarkGray, left + 180, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.GeneroCiudadano != null ? ciudadanoDto.GeneroCiudadano.Nombre.ToString().Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 220, helper.GetBeforePosition(), format);

            if ((bool)ciudadanoDto.TieneLibretaMilitar)
            {
                helper.Gfx.DrawString("Libreta Militar", fontNormal, XBrushes.DarkGray, left + 330, helper.GetBeforePosition(), format);
                helper.Gfx.DrawString(ciudadanoDto.NumeroLibretaMiltar.ToString().Replace("\n", "").Replace("\r", ""), fontNormal, XBrushes.Black, left + 400, helper.GetBeforePosition(), format);
            }
        }

        public void DrawDatosdeContacto(LayoutHelper helper, CiudadanoVisualizacionDTO ciudadanoDto, XFont fontHeader, XFont fontNormal, double left, double top, XStringFormat format, XStringFormat formatCenter)
        {
            int altoSeccion = 90;
            XPen pen = new(XColors.Black, 0.5);
            helper.Gfx.DrawRoundedRectangle(pen, left - 50, top, 560, altoSeccion, 40, 40);
            XRect rect = new(left - 25, top - 7, 105, 25);
            helper.Gfx.DrawRectangle(XBrushes.White, rect);
            helper.Gfx.DrawString("Datos de Contacto", fontHeader, XBrushes.Black, left + 25, top - 7, formatCenter);

            helper.SetCurrentPosition(top + altoSeccion);
            helper.GetLineBeforePositionPage(normalFontSize);

            helper.Gfx.DrawString("Correo", fontNormal, XBrushes.DarkGray, left - 20, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.CorreoElectronico != null ? ciudadanoDto.CorreoElectronico.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 15, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString("Teléfono Celular", fontNormal, XBrushes.DarkGray, left + 180, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.Telefono != null ? ciudadanoDto.Telefono.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 250, helper.GetBeforePosition(), format);

            if (ciudadanoDto.Telefono != null)
            {
                helper.Gfx.DrawString("Teléfono Fijo", fontNormal, XBrushes.DarkGray, left + 330, helper.GetBeforePosition(), format);
                helper.Gfx.DrawString(ciudadanoDto.Telefono != null ? ciudadanoDto.Telefono.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 390, helper.GetBeforePosition(), format);
            }

            helper.GetLineBeforePositionPage(normalFontSize * 3);

            helper.Gfx.DrawString("Dirección de Residencia", fontNormal, XBrushes.DarkGray, left - 20, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.DireccionResidencia != null ? ciudadanoDto.DireccionResidencia.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 80, helper.GetBeforePosition(), format);

            if (ciudadanoDto.BarrioResidencia != null)
            {
                helper.Gfx.DrawString("Barrio", fontNormal, XBrushes.DarkGray, left + 330, helper.GetBeforePosition(), format);
                helper.Gfx.DrawString(ciudadanoDto.BarrioResidencia != null ? ciudadanoDto.BarrioResidencia.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 370, helper.GetBeforePosition(), format);
            }

            helper.GetLineBeforePositionPage(normalFontSize * 3);

            helper.Gfx.DrawString("País de Residencia", fontNormal, XBrushes.DarkGray, left -20, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.PaisResidencia != null ? ciudadanoDto.PaisResidencia.Nombre.ToString().Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 60, helper.GetBeforePosition(), format);

            helper.Gfx.DrawString("Departamento", fontNormal, XBrushes.DarkGray, left + 180, helper.GetBeforePosition(), format);
            helper.Gfx.DrawString(ciudadanoDto.DepartamentoResidencia != null ? ciudadanoDto.DepartamentoResidencia.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 240, helper.GetBeforePosition(), format);

            if(ciudadanoDto.Ciudad != string.Empty)
            {

                helper.Gfx.DrawString("Ciudad", fontNormal, XBrushes.DarkGray, left + 330, helper.GetBeforePosition(), format);
                helper.Gfx.DrawString(ciudadanoDto.Ciudad != null ? ciudadanoDto.Ciudad.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 400, helper.GetBeforePosition(), format);
            }
            else
            {
                helper.Gfx.DrawString("Municipio", fontNormal, XBrushes.DarkGray, left + 330, helper.GetBeforePosition(), format);
                helper.Gfx.DrawString(ciudadanoDto.MunicipioResidencia != null ? ciudadanoDto.MunicipioResidencia.Replace("\n", "").Replace("\r", "") : string.Empty, fontNormal, XBrushes.Black, left + 400, helper.GetBeforePosition(), format);
            }


            top = helper.GetLinePositionPage(normalFontSize);

        }

        public double DrawPerfilLaboral(LayoutHelper helper, CiudadanoVisualizacionDTO ciudadanoDto, XFont fontHeader, XFont fontNormal, double left, double top, XStringFormat format, XStringFormat formatCenter)
        {
            string text = ciudadanoDto.PerfilLaboral != null ? ciudadanoDto.PerfilLaboral.Replace("\n", "").Replace("\r", "") : string.Empty;
            double alto = 70;
            float maxWidth = 500;
            var topPerfilLaboral = top;
            var infoText = TotalLineasTextoSeccionPerfilLaboral(helper, text, fontNormal, maxWidth);

            if (helper.swCreoPagina)
            {
                helper.GetLinePositionPage(normalFontSize * 2);
                top = helper.GetLinePositionPage(normalFontSize*3);
                XPen pen = new(XColors.Black, 0.5);
                helper.Gfx.DrawRoundedRectangle(pen, left - 50, top, 560, infoText.Item1 < alto ? alto : infoText.Item1 + 60, 40, 40);

                XRect rect = new(left - 25, top - 8, 105, 20);
                helper.Gfx.DrawRectangle(XBrushes.White, rect);
                helper.Gfx.DrawString("Perfil Laboral", fontHeader, XBrushes.Black, left + 25, top - 8, formatCenter);

                helper.SetCurrentPosition(top);
                string[] words = infoText.Item2.Split(Environment.NewLine);
                foreach (string word in words)
                {
                    helper.Gfx.DrawString(word, fontNormal, XBrushes.Black, left - 20, helper.GetBeforePosition());
                    helper.GetLineBeforePositionPage(normalFontSize);
                }
            }
            else
            {
                
                XPen pen = new(XColors.Black, 0.5);
                helper.Gfx.DrawRoundedRectangle(pen, left - 50, topPerfilLaboral, 560, infoText.Item1+25 < alto ? alto : infoText.Item1+80, 40, 40);

                XRect rect = new(left - 25, topPerfilLaboral - 7, 105, 20);
                helper.Gfx.DrawRectangle(XBrushes.White, rect);
                helper.Gfx.DrawString("Perfil Laboral", fontHeader, XBrushes.Black, left + 25, topPerfilLaboral - 7, formatCenter);

                string[] words = infoText.Item2.Split(Environment.NewLine);
                topPerfilLaboral = topPerfilLaboral + 20;
                foreach (string word in words)
                {
                    helper.Gfx.DrawString(word, fontNormal, XBrushes.Black, left - 20, topPerfilLaboral);
                    topPerfilLaboral = topPerfilLaboral + 10;
                }
            }            

            helper.Gfx.DrawString("Posibilidad de viajar", fontNormal, XBrushes.DarkGray, left - 20, topPerfilLaboral, format);
            helper.Gfx.DrawString(ciudadanoDto.PosibilidadViajar != null ? (ciudadanoDto.PosibilidadViajar == true ? "Si" : "No") : string.Empty, fontNormal, XBrushes.Black, left + 70, topPerfilLaboral, format);
            helper.Gfx.DrawString("Cambio de Municipio", fontNormal, XBrushes.DarkGray, left + 100, topPerfilLaboral, format);
            helper.Gfx.DrawString(ciudadanoDto.DispuestoCambiarMunicipio != null ? (ciudadanoDto.DispuestoCambiarMunicipio == true ? "Si" : "No") : string.Empty, fontNormal, XBrushes.Black, left + 190, topPerfilLaboral, format);
            helper.Gfx.DrawString("Desplazarce diariamente de Municipio", fontNormal, XBrushes.DarkGray, left + 215, topPerfilLaboral, format);
            helper.Gfx.DrawString(ciudadanoDto.DispuestoDesplazarseDiariamente != null ? (ciudadanoDto.DispuestoDesplazarseDiariamente == true ? "Si" : "No") : string.Empty, fontNormal, XBrushes.Black, left + 370, topPerfilLaboral, format);
            helper.Gfx.DrawString("Teletrabajo", fontNormal, XBrushes.DarkGray, left + 400, topPerfilLaboral, format);
            helper.Gfx.DrawString(ciudadanoDto.InteresOfertasTeletrabajo != null ? (ciudadanoDto.InteresOfertasTeletrabajo == true ? "Si" : "No") : string.Empty, fontNormal, XBrushes.Black, left + 450, topPerfilLaboral, format);

            top = topPerfilLaboral + 40;
            return top;
        }

        public double DrawInformacionLaboral(LayoutHelper helper, CiudadanoVisualizacionDTO ciudadanoDto, XFont fontHeader, XFont fontNormal, double left, double top, XStringFormat format, XStringFormat formatCenter)
        {

            double alto = 90;
            float maxWidth = 500;
            double altoDinamico = 0;
            double altoHabilidades = 0;
            double altoConocimiento = 0;

            if (ciudadanoDto.InformacionLaboral.Count > 0)
            {
                double topDinamico = 0;
                foreach (var infoLaboral in ciudadanoDto.InformacionLaboral)
                {
                    string text = infoLaboral.Funciones != null ? infoLaboral.Funciones.ToString().Replace("\n", "").Replace("\r", "") : string.Empty;

                    var infoText = TotalLineasTextoSeccionPerfilLaboral(helper, text, fontNormal, maxWidth);
                    altoDinamico = (infoText.Item1 == 0 ? infoText.Item1 + 9 : infoText.Item1) + 50; ;

                    string habilidades = string.Empty;
                    for (int i = 0; i < infoLaboral.HabilidadDestrezaInformacionLaboral.Count(); i++)
                    {
                        if (i == 0)
                        {
                            habilidades = infoLaboral.HabilidadDestrezaInformacionLaboral[i].ToString();
                        }
                        else
                        {
                            habilidades = habilidades + ", " + infoLaboral.HabilidadDestrezaInformacionLaboral[i].ToString();
                        }
                    }
                    var infoHabilidades = TotalLineasTextoSeccionPerfilLaboral(helper, habilidades , fontNormal, 450);
                    altoHabilidades = (infoHabilidades.Item1 == 0 ? infoHabilidades.Item1 + 9 : infoHabilidades.Item1) + 10;

                    string conocimientos = string.Empty;
                    for (int i = 0; i < infoLaboral.ConocimientoCompetenciaInformacionLaboral.Count(); i++)
                    {
                        if (i == 0)
                        {
                            conocimientos = infoLaboral.ConocimientoCompetenciaInformacionLaboral[i].ToString();
                        }
                        else
                        {
                            conocimientos = conocimientos + ", " + infoLaboral.ConocimientoCompetenciaInformacionLaboral[i].ToString();
                        }
                    }
                    var infoConocimiento = TotalLineasTextoSeccionPerfilLaboral(helper, conocimientos , fontNormal, 450);
                    altoConocimiento = (infoConocimiento.Item1 == 0 ? infoConocimiento.Item1 + 9 : infoConocimiento.Item1) + 10;

                    if ((top + altoDinamico + altoHabilidades + altoConocimiento) >= helper.GetBottomMargin())
                    {
                        helper.CreatePage();
                        helper.swCreoPagina = true;
                    }
                    else
                    {
                        helper.swCreoPagina = false;
                    }

                    
                    if (helper.swCreoPagina)
                    {
                        top =helper.GetLinePositionPage(normalFontSize * 2);

                        altoDinamico = top + infoText.Item1 < alto ? alto : infoText.Item1 + alto + 40;

                        XPen pen = new(XColors.Black, 0.5);
                        helper.Gfx.DrawRoundedRectangle(pen, left - 50, top, 560, altoDinamico + altoHabilidades + altoConocimiento, 40, 40);
                        XRect rect = new(left - 25, top - 10, 110, 20);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect);
                        helper.Gfx.DrawString("Información Laboral", fontHeader, XBrushes.Black, left + 27, top - 8, formatCenter);

                        topDinamico = top + 15;
                        helper.Gfx.DrawString("Empresa", fontNormal, XBrushes.DarkGray, left - 20, topDinamico, format);
                        helper.Gfx.DrawString(infoLaboral.NombreEmpresa != null ? infoLaboral.NombreEmpresa : string.Empty, fontNormal, XBrushes.Black, left + 40, topDinamico, format);
                        helper.Gfx.DrawString("Periodo", fontNormal, XBrushes.DarkGray, left + 110, topDinamico, format);
                        helper.Gfx.DrawString(infoLaboral.FechaIngreso != null ? infoLaboral.FechaIngreso.ToString("dd/MM/yyyy") : string.Empty, fontNormal, XBrushes.Black, left + 145, topDinamico, format);
                        helper.Gfx.DrawString(infoLaboral.FechaRetiro != null ? infoLaboral.FechaRetiro?.ToString("dd/MM/yyyy") : string.Empty, fontNormal, XBrushes.Black, left + 197, topDinamico, format);

                        helper.Gfx.DrawString("Cargo", fontNormal, XBrushes.DarkGray, left + 253, topDinamico, format);
                        helper.Gfx.DrawString(ciudadanoDto.PosibilidadViajar != null ? (ciudadanoDto.PosibilidadViajar == true ? "Si" : "No") : string.Empty, fontNormal, XBrushes.Black, left + 290, topDinamico, format);

                        topDinamico += 15;


                        helper.Gfx.DrawString("Habilidades", fontNormal, XBrushes.DarkGray, left - 20, topDinamico, format);
                        string[] wordsh = infoHabilidades.Item2.Split(Environment.NewLine);
                        topDinamico += 8;
                        foreach (string wordh in wordsh)
                        {
                            helper.Gfx.DrawString(wordh, fontNormal, XBrushes.Black, left + 40, topDinamico);
                            topDinamico += 10;
                        }


                        helper.Gfx.DrawString("Conocimiento", fontNormal, XBrushes.DarkGray, left - 20, topDinamico, format);

                        string[] wordsc = infoConocimiento.Item2.Split(Environment.NewLine);
                        topDinamico += 9;
                        foreach (string wordc in wordsc)
                        {
                            helper.Gfx.DrawString(wordc, fontNormal, XBrushes.Black, left + 40, topDinamico);
                            topDinamico += 10;
                        }

                        helper.SetCurrentPosition(top);
                        helper.SetBeforePosition(helper.GetCurrentPosition());
                        string[] words = infoText.Item2.Split(Environment.NewLine);
                        topDinamico += 7;
                        foreach (string word in words)
                        {
                            helper.Gfx.DrawString(word, fontNormal, XBrushes.Black, left - 20, topDinamico);
                            topDinamico += 10;
                        }
                    }
                    else
                    {
                        if(topDinamico > 0)
                        {
                            top = topDinamico;
                        }

                        altoDinamico = top + infoText.Item1 < alto ? alto : infoText.Item1 + alto;

                        XPen pen = new(XColors.Black, 0.5);
                        helper.Gfx.DrawRoundedRectangle(pen, left - 50, top, 560, altoDinamico + altoHabilidades + altoConocimiento, 40, 40);
                        XRect rect = new(left - 25, top - 10, 110, 20);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect);
                        helper.Gfx.DrawString("Información Laboral", fontHeader, XBrushes.Black, left + 27, top - 8, formatCenter);

                        topDinamico = top + 15;
                        helper.Gfx.DrawString("Empresa", fontNormal, XBrushes.DarkGray, left - 20, topDinamico, format);
                        helper.Gfx.DrawString(infoLaboral.NombreEmpresa != null ? infoLaboral.NombreEmpresa : string.Empty, fontNormal, XBrushes.Black, left + 40, topDinamico, format);
                        helper.Gfx.DrawString("Periodo", fontNormal, XBrushes.DarkGray, left + 110, topDinamico, format);
                        helper.Gfx.DrawString(infoLaboral.FechaIngreso != null ? infoLaboral.FechaIngreso.ToString("dd/MM/yyyy") : string.Empty, fontNormal, XBrushes.Black, left + 145, topDinamico, format);
                        helper.Gfx.DrawString(infoLaboral.FechaRetiro != null ? infoLaboral.FechaRetiro?.ToString("dd/MM/yyyy") : string.Empty, fontNormal, XBrushes.Black, left + 197, topDinamico, format);

                        helper.Gfx.DrawString("Cargo", fontNormal, XBrushes.DarkGray, left + 253, topDinamico, format);
                        helper.Gfx.DrawString(ciudadanoDto.PosibilidadViajar != null ? (ciudadanoDto.PosibilidadViajar == true ? "Si" : "No") : string.Empty, fontNormal, XBrushes.Black, left + 290, topDinamico, format);

                        topDinamico += 15;


                        helper.Gfx.DrawString("Habilidades", fontNormal, XBrushes.DarkGray, left - 20, topDinamico, format);
                        string[] wordsh = infoHabilidades.Item2.Split(Environment.NewLine);
                        topDinamico += 8;
                        foreach (string wordh in wordsh)
                        {
                            helper.Gfx.DrawString(wordh, fontNormal, XBrushes.Black, left + 40, topDinamico);
                            topDinamico += 10;
                        }


                        helper.Gfx.DrawString("Conocimiento", fontNormal, XBrushes.DarkGray, left - 20, topDinamico, format);

                        string[] wordsc = infoConocimiento.Item2.Split(Environment.NewLine);
                        topDinamico += 9;
                        foreach (string wordc in wordsc)
                        {
                            helper.Gfx.DrawString(wordc, fontNormal, XBrushes.Black, left + 40, topDinamico);
                            topDinamico += 10;
                        }

                        helper.SetCurrentPosition(top);
                        helper.SetBeforePosition(helper.GetCurrentPosition());
                        string[] words = infoText.Item2.Split(Environment.NewLine);
                        topDinamico += 7;
                        foreach (string word in words)
                        {
                            helper.Gfx.DrawString(word, fontNormal, XBrushes.Black, left - 20, topDinamico);
                            topDinamico += 10;
                        }

                    }

                    top += 15;
                    top = helper.SetCurrentPosition(top);
                }
                top += altoDinamico +  altoHabilidades + altoConocimiento;
            }
            return top;
        }

        public double DrawEducacionFormal(LayoutHelper helper, CiudadanoVisualizacionDTO ciudadanoDto, XFont fontHeader, XFont fontNormal, double left, double top, XStringFormat format, XStringFormat formatCenter)
        {
            int altoSeccion = 95;
            if(ciudadanoDto.EducacionFormal.Count > 0)
            {

                if ((top + altoSeccion) >= helper.GetBottomMargin())
                {
                    helper.CreatePage();
                    helper.swCreoPagina = true;
                }
                else
                {
                    helper.swCreoPagina = false;
                }

                if (helper.swCreoPagina)
                {
                    XPen pen = new(XColors.Black, 0.5);
                    top = helper.GetCurrentPosition();
                    var topEducionFormal = top + 4;
                    var topSeccionDestrezas = top + 4;

                    if (ciudadanoDto.EducacionFormal.Count > 0)
                    {

                        helper.Gfx.DrawRoundedRectangle(pen, left - 50, topEducionFormal, 295, altoSeccion, 40, 40);
                        XRect rect = new(left - 25, topEducionFormal - 7, 105, 25);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect);
                        helper.Gfx.DrawString("Educación Formal", fontHeader, XBrushes.Black, left + 25, topEducionFormal - 7, formatCenter);

                        topEducionFormal += 9;
                        foreach (var item in ciudadanoDto.EducacionFormal)
                        {
                            helper.Gfx.DrawString(item.NivelEducativo != null ? item.NivelEducativo.Nombre : string.Empty, fontNormal, XBrushes.DarkGray, left - 20, topEducionFormal, format);
                            helper.Gfx.DrawString(item.Institucion != null ? item.Institucion : string.Empty, fontNormal, XBrushes.Black, left + 40, topEducionFormal, format);
                            if (item.FechaFinalizacion != null)
                            {
                                helper.Gfx.DrawString(item.FechaFinalizacion?.ToString("dd/MM/yyyy"), fontNormal, XBrushes.DarkGray, left + 130, topEducionFormal, format);
                            }

                            if (item.TarjetaProfesional == true)
                            {
                                helper.Gfx.DrawString(item.NumeroTarjetaProfesional, fontNormal, XBrushes.Black, left + 190, topEducionFormal, format);
                            }
                            topEducionFormal += 15;
                            top += 15;
                        }
                    }


                    if (ciudadanoDto.Destrezas.Count > 0)
                    {

                        helper.Gfx.DrawRoundedRectangle(pen, left + 260, topSeccionDestrezas, 250, altoSeccion, 40, 40);
                        XRect rect2 = new(left + 280, topSeccionDestrezas - 5, 90, 20);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect2);
                        helper.Gfx.DrawString("Destrezas", fontHeader, XBrushes.Black, left + 320, topSeccionDestrezas - 7, formatCenter);
                        var topDeztrezas = (topSeccionDestrezas);
                        int f = 1;
                        foreach (var item in ciudadanoDto.Destrezas)
                        {
                            if (f == 1)
                            {
                                helper.Gfx.DrawString(item.Nombre != null ? item.Nombre : string.Empty, fontNormal, XBrushes.DarkGray, left + 320, top - 20, format);
                            }
                            else
                            {
                                helper.Gfx.DrawString(item.Nombre != null ? item.Nombre : string.Empty, fontNormal, XBrushes.DarkGray, left + 320, topDeztrezas, format);
                            }

                            topDeztrezas += 7;

                            f++;
                        }
                        top = topDeztrezas;
                    }

                }
                else
                {
                    XPen pen = new(XColors.Black, 0.5);
                    var topEducionFormal = top + 4;
                    var topSeccionDestrezas = top + 4;

                    if(ciudadanoDto.EducacionFormal.Count > 0)
                    {
                        
                        helper.Gfx.DrawRoundedRectangle(pen, left - 50, topEducionFormal, 295, altoSeccion, 40, 40);
                        XRect rect = new(left - 25, topEducionFormal - 7, 105, 25);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect);
                        helper.Gfx.DrawString("Educación Formal", fontHeader, XBrushes.Black, left + 25, topEducionFormal-7, formatCenter);

                        topEducionFormal += 9;
                        foreach (var item in ciudadanoDto.EducacionFormal)
                        {
                            helper.Gfx.DrawString(item.NivelEducativo != null ? item.NivelEducativo.Nombre : string.Empty, fontNormal, XBrushes.DarkGray, left - 20, topEducionFormal, format);
                            helper.Gfx.DrawString(item.Institucion != null ? item.Institucion : string.Empty, fontNormal, XBrushes.Black, left + 40, topEducionFormal, format);
                            if (item.FechaFinalizacion != null)
                            {
                                helper.Gfx.DrawString(item.FechaFinalizacion?.ToString("dd/MM/yyyy"), fontNormal, XBrushes.DarkGray, left + 130, topEducionFormal, format);
                            }

                            if (item.TarjetaProfesional == true)
                            {
                                helper.Gfx.DrawString(item.NumeroTarjetaProfesional, fontNormal, XBrushes.Black, left + 190, topEducionFormal, format);
                            }
                            topEducionFormal += 15;
                            top += 15;
                        }
                    }


                    if(ciudadanoDto.Destrezas.Count > 0)
                    {
                        
                        helper.Gfx.DrawRoundedRectangle(pen, left + 260, topSeccionDestrezas, 250, altoSeccion, 40, 40);
                        XRect rect2 = new(left + 280, topSeccionDestrezas - 5, 90, 20);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect2);
                        helper.Gfx.DrawString("Destrezas", fontHeader, XBrushes.Black, left + 320, topSeccionDestrezas-7, formatCenter);
                        var topDeztrezas = (topSeccionDestrezas);
                        foreach (var item in ciudadanoDto.Destrezas)
                        {
                            helper.Gfx.DrawString(item.Nombre != null ? item.Nombre : string.Empty, fontNormal, XBrushes.DarkGray, left + 295, topDeztrezas, format);
                            topDeztrezas += 7;
                        }
                        top = topDeztrezas;
                    }

                }
            }

            top = helper.SetCurrentPositionOri(top+60);
            return top;
        }

        public void DrawEducacionInFormal(LayoutHelper helper, CiudadanoVisualizacionDTO ciudadanoDto, XFont fontHeader, XFont fontNormal, double left, double top, XStringFormat format, XStringFormat formatCenter)
        {
            int altoSeccion = 120;

            if(ciudadanoDto.EducacionNoFormal.Count > 0)
            {

                if ((top + altoSeccion) >= helper.GetBottomMargin())
                {
                    helper.CreatePage();
                    helper.swCreoPagina = true;
                }
                else
                {
                    helper.swCreoPagina = false;
                }

                if (helper.swCreoPagina)
                {
                    XPen pen = new(XColors.Black, 0.5);
                    top = helper.GetCurrentPosition();
                    var topEducacionInformal = top + 20;
                    var topSeccionIdiomas = top + 20;

                    if (ciudadanoDto.EducacionNoFormal.Count > 0)
                    {

                        helper.Gfx.DrawRoundedRectangle(pen, left - 50, topEducacionInformal, 295, altoSeccion, 40, 40);
                        XRect rect = new(left - 25, topEducacionInformal - 7, 105, 25);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect);
                        helper.Gfx.DrawString("Educación Informal", fontHeader, XBrushes.Black, left + 25, topEducacionInformal - 7, formatCenter);

                        topEducacionInformal = topEducacionInformal + 10;

                        foreach (var item in ciudadanoDto.EducacionNoFormal)
                        {
                            helper.Gfx.DrawString(item.TipoCertificacionCapacitacion != null ? item.TipoCertificacionCapacitacion : string.Empty, fontNormal, XBrushes.DarkGray, left - 20, topEducacionInformal, format);
                            helper.Gfx.DrawString(item.NombrePrograma != null ? item.NombrePrograma : string.Empty, fontNormal, XBrushes.Black, left + 45, topEducacionInformal, format);
                            if (item.FechaCertificacion != null)
                            {
                                helper.Gfx.DrawString("Certificado", fontNormal, XBrushes.DarkGray, left + 155, topEducacionInformal, format);
                                helper.Gfx.DrawString(item.FechaCertificacion?.ToString("yyyy"), fontNormal, XBrushes.Black, left + 205, topEducacionInformal, format);
                            }
                            topEducacionInformal += 15;
                        }
                    }

                    if (ciudadanoDto.Idiomas.Count > 0)
                    {

                        helper.Gfx.DrawRoundedRectangle(pen, left + 260, topSeccionIdiomas, 250, altoSeccion, 40, 40);
                        XRect rect2 = new(left + 280, topSeccionIdiomas - 5, 90, 20);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect2);
                        helper.Gfx.DrawString("Idiomas", fontHeader, XBrushes.Black, left + 320, topSeccionIdiomas - 5, formatCenter);
                        var topIdiomas = (topSeccionIdiomas + 15);


                        helper.Gfx.DrawString("Idioma", fontNormal, XBrushes.DarkGray, left + 280, topIdiomas, format);
                        helper.Gfx.DrawString("Escrito", fontNormal, XBrushes.DarkGray, left + 320, topIdiomas, format);
                        helper.Gfx.DrawString("Hablado", fontNormal, XBrushes.DarkGray, left + 365, topIdiomas, format);
                        helper.Gfx.DrawString("Escucha", fontNormal, XBrushes.DarkGray, left + 415, topIdiomas, format);
                        helper.Gfx.DrawString("Lectura", fontNormal, XBrushes.DarkGray, left + 465, topIdiomas, format);

                        topIdiomas += 12;
                        foreach (var item in ciudadanoDto.Idiomas)
                        {

                            helper.Gfx.DrawString(item.Idioma != null ? item.Idioma.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 283, topIdiomas, format);
                            helper.Gfx.DrawString(item.NivelEscrito != null ? item.NivelEscrito.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 323, topIdiomas, format);
                            helper.Gfx.DrawString(item.NivelHablado != null ? item.NivelHablado.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 368, topIdiomas, format);
                            helper.Gfx.DrawString(item.NivelEscucha != null ? item.NivelEscucha.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 418, topIdiomas, format);
                            helper.Gfx.DrawString(item.NivelLectura != null ? item.NivelLectura.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 468, topIdiomas, format);

                            topIdiomas += 10;

                        }
                    }
                }
                else
                {
                    var topEducacionInformal = top + 20;
                    var topSeccionIdiomas = top + 20;
                    XPen pen = new(XColors.Black, 0.5);

                    if (ciudadanoDto.EducacionNoFormal.Count > 0)
                    {                       
                        
                        helper.Gfx.DrawRoundedRectangle(pen, left - 50, topEducacionInformal, 295, altoSeccion, 40, 40);
                        XRect rect = new(left - 25, topEducacionInformal - 7, 105, 25);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect);
                        helper.Gfx.DrawString("Educación Informal", fontHeader, XBrushes.Black, left + 25, topEducacionInformal - 7, formatCenter);

                        topEducacionInformal = topEducacionInformal + 10;

                        foreach (var item in ciudadanoDto.EducacionNoFormal)
                        {
                            helper.Gfx.DrawString(item.TipoCertificacionCapacitacion != null ? item.TipoCertificacionCapacitacion : string.Empty, fontNormal, XBrushes.DarkGray, left - 20, topEducacionInformal, format);
                            helper.Gfx.DrawString(item.NombrePrograma != null ? item.NombrePrograma : string.Empty, fontNormal, XBrushes.Black, left + 45, topEducacionInformal, format);
                            if (item.FechaCertificacion != null)
                            {
                                helper.Gfx.DrawString("Certificado", fontNormal, XBrushes.DarkGray, left + 155, topEducacionInformal, format);
                                helper.Gfx.DrawString(item.FechaCertificacion?.ToString("yyyy"), fontNormal, XBrushes.Black, left + 205, topEducacionInformal, format);
                            }

                            //helper.Gfx.DrawString(item.PaisId.ToString(), fontNormal, XBrushes.Black, left + 175, topEducacionInformal, format);
                            topEducacionInformal += 15;

                        }
                    }

                    if(ciudadanoDto.Idiomas.Count > 0)
                    {
                        
                        helper.Gfx.DrawRoundedRectangle(pen, left + 260, topSeccionIdiomas, 250, altoSeccion, 40, 40);
                        XRect rect2 = new(left + 280, topSeccionIdiomas - 5, 90, 20);
                        helper.Gfx.DrawRectangle(XBrushes.White, rect2);
                        helper.Gfx.DrawString("Idiomas", fontHeader, XBrushes.Black, left + 320, topSeccionIdiomas-5, formatCenter);
                        var topIdiomas = (topSeccionIdiomas+15);


                        helper.Gfx.DrawString("Idioma", fontNormal, XBrushes.DarkGray, left + 280, topIdiomas, format);
                        helper.Gfx.DrawString("Escrito", fontNormal, XBrushes.DarkGray, left + 320, topIdiomas, format);
                        helper.Gfx.DrawString("Hablado", fontNormal, XBrushes.DarkGray, left + 365, topIdiomas, format);
                        helper.Gfx.DrawString("Escucha", fontNormal, XBrushes.DarkGray, left + 415, topIdiomas, format);
                        helper.Gfx.DrawString("Lectura", fontNormal, XBrushes.DarkGray, left + 465, topIdiomas, format);

                        topIdiomas += 12;
                        foreach (var item in ciudadanoDto.Idiomas)
                        {

                            helper.Gfx.DrawString(item.Idioma != null ? item.Idioma.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 283, topIdiomas, format);
                            helper.Gfx.DrawString(item.NivelEscrito != null ? item.NivelEscrito.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 323, topIdiomas, format);
                            helper.Gfx.DrawString(item.NivelHablado != null ? item.NivelHablado.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 368, topIdiomas, format);
                            helper.Gfx.DrawString(item.NivelEscucha != null ? item.NivelEscucha.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 418, topIdiomas, format);
                            helper.Gfx.DrawString(item.NivelLectura != null ? item.NivelLectura.ToString() : string.Empty, fontNormal, XBrushes.Black, left + 468, topIdiomas, format);


                            topIdiomas += 10;

                        }
                    }

                }
            }

        }

        public  (double,string) TotalLineasTextoSeccionPerfilLaboral(LayoutHelper helper, string text, XFont font, float maxWidth)
        {
            string[] words = text.Split(' ');
            string currentLine = "";
            string justifiedText = "";
            double alturaRectangulo = 0;
            helper.swCreoPagina = false;
            foreach (string word in words)
            {
                string testLine = currentLine + word + " ";
                XSize textSize = helper.Gfx.MeasureString(testLine, font);

                if (textSize.Width > maxWidth && !string.IsNullOrEmpty(currentLine))
                {
                    alturaRectangulo += font.Size;
                    justifiedText += currentLine.Trim() + Environment.NewLine;
                    currentLine = word + " ";
                }
                else
                {
                    currentLine = testLine;
                }
            }
            justifiedText += currentLine.Trim();
            return (alturaRectangulo, justifiedText);
        }

    }


}
