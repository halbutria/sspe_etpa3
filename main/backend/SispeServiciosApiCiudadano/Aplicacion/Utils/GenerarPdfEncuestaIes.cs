using Org.BouncyCastle.Asn1.Pkcs;
using PdfSharpCore.Drawing;
using PdfSharpCore.Drawing.Layout;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServiciosApiCiudadano.DTOs;

namespace SispeServiciosApiCiudadano.Aplicacion.Utils
{
    public class GenerarPdfEncuestaIes
    {
        public static byte[] GenerarPDF(CiudadanoEncuentasIesDTO ciudadanoEncuentasIesDTO)
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

            helper.GetLinePositionPage(normalFontSize, false);
            top = helper.GetLinePositionPage(normalFontSize, false);
            obj.DrawTitle(helper.Gfx, "Encuesta diagnóstico ocupacional egresados IES", ((helper.Page.Width - 30) / 2), top);
            helper.GetLinePositionPage(normalFontSize * 2, false);
            top = helper.GetLinePositionPage(normalFontSize, false);
            string nombreCiudadano = string.Format("{0} {1} {2} {3}", ciudadanoEncuentasIesDTO.PrimerNombre, ciudadanoEncuentasIesDTO.SegundoNombre, ciudadanoEncuentasIesDTO.PrimerApellido, ciudadanoEncuentasIesDTO.SegundoApellido);
            obj.DrawCiudadano(helper.Page, helper.Gfx, nombreCiudadano, fontHeader, left + 210, top, formatCenter);
            top = helper.GetLinePositionPage(normalFontSize, false);
            double anchoTotal = helper.Page.Width;

            double columna1Ancho = anchoTotal * 0.6;
            double columna2Ancho = anchoTotal * 0.33;

            // Altura de fila
            double alturaFila = 20;

            // Posición inicial de la tabla
            double posXInicial = 20;
            double posYInicial = 125;


            // Estilos
            XFont fuente = new XFont("Verdana", 7, XFontStyle.Regular);
            XBrush brocha = XBrushes.Black;

            List<EncuentaIesDTO> encuentaIesDTOs = ObtenerlistadoPreguntas(ciudadanoEncuentasIesDTO);
            foreach (var item in encuentaIesDTOs)
            {
                if (item.Respuesta == "***")
                {
                    fuente = new XFont("Verdana", 7, XFontStyle.Bold);
                    helper.Gfx.DrawString(item.Pregunta, fuente, brocha, new XRect(posXInicial, posYInicial, columna1Ancho + columna2Ancho, alturaFila), XStringFormats.TopLeft);
                    fuente = new XFont("Verdana", 7, XFontStyle.Regular);
                }
                else
                {
                    helper.Gfx.DrawString(item.Pregunta, fuente, brocha, new XRect(posXInicial + 1, posYInicial, columna1Ancho, alturaFila), XStringFormats.TopLeft);
                    helper.Gfx.DrawString(item.Respuesta.Length > 54 ? item.Respuesta.Substring(0, 54) : item.Respuesta, fuente, brocha, new XRect(posXInicial + 1 + columna1Ancho, posYInicial, columna2Ancho, alturaFila), XStringFormats.TopLeft);
                }
                // (Opcional) Dibujar bordes de las celdas
                XPen borde = new XPen(XColors.Black, 0.25);
                if (item.Respuesta == "***")
                {
                    helper.Gfx.DrawRectangle(borde, posXInicial, posYInicial, columna1Ancho + columna2Ancho, alturaFila);
                }
                else
                {
                    helper.Gfx.DrawRectangle(borde, posXInicial, posYInicial, columna1Ancho, alturaFila);
                    helper.Gfx.DrawRectangle(borde, posXInicial + columna1Ancho, posYInicial, columna2Ancho, alturaFila);
                }
                posYInicial = posYInicial + 10;
            }

            using (MemoryStream memoryStream = new())
            {
                document.Save(memoryStream, false);
                pdfBytes = memoryStream.ToArray();
            }

            return pdfBytes;
        }

        private static List<EncuentaIesDTO> ObtenerlistadoPreguntas(CiudadanoEncuentasIesDTO ciudadanoEncuentasIesDTO) {
            List<EncuentaIesDTO> encuentaIesDTOs = new List<EncuentaIesDTO>();
            ParametricosEncuentaIesDTO parametricosEncuentaIesDTO = new ParametricosEncuentaIesDTO();

            List<ParametricosEncuentaIesDTO> listaParametrosEncuesta = parametricosEncuentaIesDTO.ObtenerParametricos();

            encuentaIesDTOs.Add(new EncuentaIesDTO() { 
                Orden = 1,
                Pregunta = "Tipo de documento",
                Respuesta = "Cédula de ciudadanía"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 2,
                Pregunta = "Número de documento",
                Respuesta = ciudadanoEncuentasIesDTO.NumeroDocumento
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 3,
                Pregunta = "Sexo",
                Respuesta = ciudadanoEncuentasIesDTO.Sexo ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 4,
                Pregunta = "EstadoCivil",
                Respuesta = ciudadanoEncuentasIesDTO.EstadoCivil ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 5,
                Pregunta = "País residencia",
                Respuesta = ciudadanoEncuentasIesDTO.PaisResidencia ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 6,
                Pregunta = "Departamento residencia",
                Respuesta = ciudadanoEncuentasIesDTO.DepartamentoResidencia ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 7,
                Pregunta = "Municipio residencia",
                Respuesta = ciudadanoEncuentasIesDTO.MunicipioResidencia ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 8,
                Pregunta = "Egresado",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "ListaEgresado" && x.Id == ciudadanoEncuentasIesDTO.EgresadoId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 9,
                Pregunta = "Programa",
                Respuesta = ciudadanoEncuentasIesDTO.Programa ?? "",
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 10,
                Pregunta = "Inicio Programa",
                Respuesta = ciudadanoEncuentasIesDTO.FechaInicioPrograma?.ToString("yyyyMM") ?? "",
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 11,
                Pregunta = "Fin Programa",
                Respuesta = ciudadanoEncuentasIesDTO.FechaFinPrograma?.ToString("yyyyMM") ?? "",
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 12,
                Pregunta = "Tiempo transcurrido para obtener el primer empleo con su profesión",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "TiempoTranscurridoPrimerEmpleo" && x.Id == ciudadanoEncuentasIesDTO.TiempoTranscurridoPrimerEmpleoId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 13,
                Pregunta = "¿A diligenciar esta encuesta, cuántos empleos relacionados con su profesión ha tenido?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "EmpleosRelacionados" && x.Id == ciudadanoEncuentasIesDTO.EmpleosRelacionadoId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 14,
                Pregunta = "¿Actualmente tiene empleo?",
                Respuesta = ciudadanoEncuentasIesDTO.TieneEmpleoId == null ? "" : ciudadanoEncuentasIesDTO.TieneEmpleoId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 15,
                Pregunta = "¿El trabajo que desempeña es de manera independiente, por cuenta propia?",
                Respuesta = ciudadanoEncuentasIesDTO.TrabajaPorCuentaPropiaId == null ? "" : ciudadanoEncuentasIesDTO.TrabajaPorCuentaPropiaId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 16,
                Pregunta = "Indique el tiempo de trabajo semanal",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "TiemposTrabajoSemanal" && x.Id == ciudadanoEncuentasIesDTO.TiempoTrabajoSemanalId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 17,
                Pregunta = "Sus ingresos salariales se encuentran entre",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "IngresoSalariales" && x.Id == ciudadanoEncuentasIesDTO.IngresoSalarialId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 18,
                Pregunta = "¿Desea cambiar el trabajo que tiene actualmente?",
                Respuesta = ciudadanoEncuentasIesDTO.CambiarTrabajoActualId == null ? "" : ciudadanoEncuentasIesDTO.CambiarTrabajoActualId== 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 19,
                Pregunta = "¿por qué desea cambiar de trabajo o empleo?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "MotivosCambioEmpleo" && x.Id == ciudadanoEncuentasIesDTO.MotivoCambioEmpleoId)?.Nombre ?? ""
            });

            if (ciudadanoEncuentasIesDTO.OtroMotivoCambioEmpleo != null)
            {
                encuentaIesDTOs.Add(new EncuentaIesDTO()
                {
                    Orden = 20,
                    Pregunta = "Otro motivo por el que cambia de empleo",
                    Respuesta = ciudadanoEncuentasIesDTO.OtroMotivoCambioEmpleo ?? ""
                });
            }

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 21,
                Pregunta = "¿Qué medio empleó para obtener su actual empleo?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "MediosEmpleadoParaBusquedaEmeplado" && x.Id == ciudadanoEncuentasIesDTO.MedioEmpleadoParaBusquedaEmepladoId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 22,
                Pregunta = "¿El sector al cual pertenece la empresa en la que trabaja es?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "SectoresEmpresa" && x.Id == ciudadanoEncuentasIesDTO.sectorEmpresaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 23,
                Pregunta = "¿El sector económico al cual pertenece la empresa en la cual labora es?",
                Respuesta = ciudadanoEncuentasIesDTO.SectorEconomico ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 24,
                Pregunta = "¿La antigüedad en su actual empleo es?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "AntiguedadesEmpleo" && x.Id == ciudadanoEncuentasIesDTO.AntiguedadEmpleoId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 25,
                Pregunta = "¿El tipo de contrato que tiene en la empresa es?",
                Respuesta = ciudadanoEncuentasIesDTO.TipoContrato ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 26,
                Pregunta = "¿El trabajo que desempeña está en el nivel jerárquico de?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "JerarquiasEmeplo" && x.Id == ciudadanoEncuentasIesDTO.JerarquiaEmeploId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 27,
                Pregunta = "Grado de satisfacción en su empleo actual",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosSatisfaccion" && x.Id == ciudadanoEncuentasIesDTO.SatisfechoConTrabajoActualId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 28,
                Pregunta = "Grado de satisfacción en su empleo actual",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosSatisfaccion" && x.Id == ciudadanoEncuentasIesDTO.SatisfechoConTrabajoActualId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 29,
                Pregunta = "Grado de satisfacción con el número de horas trabajadas",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosSatisfaccion" && x.Id == ciudadanoEncuentasIesDTO.SatisfechoConNumeroHorasTrabajadaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 30,
                Pregunta = "Grado de satisfacción con la aplicación del conocimiento",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosSatisfaccion" && x.Id == ciudadanoEncuentasIesDTO.SatisfechoConAplicacionConocimientosId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 31,
                Pregunta = "Grado de satisfacción con el pago o ganancia que recibe de su trabajo o empleo",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosSatisfaccion" && x.Id == ciudadanoEncuentasIesDTO.SatisfechoConRemuneracionId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 32,
                Pregunta = "Grado de satisfacción con los beneficios y prestaciones que recibe",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosSatisfaccion" && x.Id == ciudadanoEncuentasIesDTO.SatisfechoConBeneficiosId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 33,
                Pregunta = "Grado de satisfacción con su jornada laboral actual",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosSatisfaccion" && x.Id == ciudadanoEncuentasIesDTO.SatisfechoConJornadaLaboralId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 34,
                Pregunta = "¿Cómo considera que es su trabajo actual?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "ConsideracionesTrabajo" && x.Id == ciudadanoEncuentasIesDTO.ConsideracionTrabajoActualId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 35,
                Pregunta = "¿Grado de relación entre la profesión y el área de trabajo actual?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosRelacionProfesion" && x.Id == ciudadanoEncuentasIesDTO.GradoRelacionProfesionEmpleoActualId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 36,
                Pregunta = "Área en la cual trabaja",
                Respuesta = ciudadanoEncuentasIesDTO.AreaTrabajo ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 37,
                Pregunta = "La empresa en la cual trabaja es",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "TamañosEmpresa" && x.Id == ciudadanoEncuentasIesDTO.TamanioEmpresaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 38,
                Pregunta = "¿cuáles son las razones por las cuales trabaja en esta modalidad en vez de empleado?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "RazonesTrabajoIndependiente" && x.Id == ciudadanoEncuentasIesDTO.RazonesTrabajoIndependienteId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 39,
                Pregunta = "¿cuál de las siguientes formas de trabajo realizó?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "FormasTrabajoRealizado" && x.Id == ciudadanoEncuentasIesDTO.FormaTrabajoRealizadoId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 40,
                Pregunta = "En caso de haber tenido empleo, cual fue el motivo de desvinculación del último empleo",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "MotivosDesvinculacionLaboral" && x.Id == ciudadanoEncuentasIesDTO.MotivoDesvinculacionUltimoEmpleoId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 41,
                Pregunta = "En las últimas 8 semanas ha hecho gestiones concretas y se encuentra disponible para trabajar",
                Respuesta = ciudadanoEncuentasIesDTO.DisponibleParaTrabajar8SemanasId == null ? "" : ciudadanoEncuentasIesDTO.DisponibleParaTrabajar8SemanasId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 42,
                Pregunta = "Usted en los últimos 12 meses ha hecho gestiones concretas y se encuentra disponible para trabajar",
                Respuesta = ciudadanoEncuentasIesDTO.DisponibleParaTrabajar12MesesId == null ? "" : ciudadanoEncuentasIesDTO.DisponibleParaTrabajar12MesesId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 42,
                Pregunta = "A continuacion valore la pertinencia de la formación recibida de 1 a 5 siendo 1 la más baja y 5 la más alta en cada pregunta",
                Respuesta = "***"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 43,
                Pregunta = "Fundamentación teórica",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "ValoracionesPercepcionUniversidad" && x.Id == ciudadanoEncuentasIesDTO.FundamentacionTeoricaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 44,
                Pregunta = "Relación teoría – práctica",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "ValoracionesPercepcionUniversidad" && x.Id == ciudadanoEncuentasIesDTO.RelacionTeoriaPracticaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 45,
                Pregunta = "Desarrollo de habilidades de investigación",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "ValoracionesPercepcionUniversidad" && x.Id == ciudadanoEncuentasIesDTO.RelacionTeoriaPracticaId)?.Nombre ?? ""
            });
            
            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 46,
                Pregunta = "Formación humana y ética (formación integral)",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "ValoracionesPercepcionUniversidad" && x.Id == ciudadanoEncuentasIesDTO.RelacionTeoriaPracticaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 47,
                Pregunta = "¿Recomendaría usted el programa de pregrado y/o postgrado que cursó en la Universidad?",
                Respuesta = ciudadanoEncuentasIesDTO.RecomiendaElProgramaUniversidadId == null ? "" : ciudadanoEncuentasIesDTO.RecomiendaElProgramaUniversidadId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 48,
                Pregunta = "¿Cuál es la principal razón para recomendar el programa?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "RazonesRecomendarPrograma" && x.Id == ciudadanoEncuentasIesDTO.RazonRecomendarProgramaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 49,
                Pregunta = "¿Cuál es la principal razón para recomendar el programa?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "RazonesRecomendarPrograma" && x.Id == ciudadanoEncuentasIesDTO.RazonRecomendarProgramaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 50,
                Pregunta = "¿Conoce usted el proceso de acreditación en el cual se encuentra la Universidad?",
                Respuesta = ciudadanoEncuentasIesDTO.ConoceAcreditacionUniversidadId == null ? "No" : ciudadanoEncuentasIesDTO.ConoceAcreditacionUniversidadId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 51,
                Pregunta = "¿Conserva algún tipo de relación con la universidad?",
                Respuesta = ciudadanoEncuentasIesDTO.ConcervaRelacionConUniversidadId == null ? "No" : ciudadanoEncuentasIesDTO.ConcervaRelacionConUniversidadId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 52,
                Pregunta = "¿En qué proporción su formación académica le aporta a su desempeño laboral?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "AportesFormacionDesempenioLaboral" && x.Id == ciudadanoEncuentasIesDTO.AporteFormacionDesempenioLaboralId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 53,
                Pregunta = "Ha terminado algún postgrado (graduado)",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "EstudiosPostgrado" && x.Id == ciudadanoEncuentasIesDTO.EstudioPostgradoTerminadoId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 54,
                Pregunta = "Nombre del postgrado",
                Respuesta = ciudadanoEncuentasIesDTO.NombrePostgrado ?? ""
            });
            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 55,
                Pregunta = "Nombre de la Universidad donde lo cursó",
                Respuesta = ciudadanoEncuentasIesDTO.UniversidadPostgrado ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 56,
                Pregunta = "¿Se encuentra realizando estudios de postgrado?",
                Respuesta = ciudadanoEncuentasIesDTO.RealizandoEstudiosPostgradoId == null ? "No" : ciudadanoEncuentasIesDTO.RealizandoEstudiosPostgradoId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 57,
                Pregunta = "Nombre del postgrado en curso",
                Respuesta = ciudadanoEncuentasIesDTO.NombrePostgradoEnCurso ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 58,
                Pregunta = "Nombre de la Universidad donde lo cursa",
                Respuesta = ciudadanoEncuentasIesDTO.UniversidadPostgradoEnCurso ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 59,
                Pregunta = "¿Considera alguna capacitación especifica que requiere para mejorar su desempeño laboral?",
                Respuesta = ciudadanoEncuentasIesDTO.CapacitacionRequeridaMejorarId == null ? "No" : ciudadanoEncuentasIesDTO.CapacitacionRequeridaMejorarId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 60,
                Pregunta = " ¿En qué área lo sugiere?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "AreaCapacitacionesRequeridas" && x.Id == ciudadanoEncuentasIesDTO.AreaCapacitacionRequeridaId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 61,
                Pregunta = "Describa la capacitación requerida",
                Respuesta = ciudadanoEncuentasIesDTO.CapacitacionRequeridaMejorar ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 62,
                Pregunta = "¿El grado de escolaridad de su padre es?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosEscolaridad" && x.Id == ciudadanoEncuentasIesDTO.GradoEscolariadPadreId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 63,
                Pregunta = "¿El grado de escolaridad de su madre es?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "GradosEscolaridad" && x.Id == ciudadanoEncuentasIesDTO.GradoEscolariadMadreId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 64,
                Pregunta = "¿Trabajó durante su carrera?",
                Respuesta = ciudadanoEncuentasIesDTO.TrabajoDuranteSuCarreraId == null ? "No" : ciudadanoEncuentasIesDTO.TrabajoDuranteSuCarreraId == 1 ? "Si" : "No"
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 65,
                Pregunta = "¿Cuál fue la principal razón para que trabajara durante su carrera?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "RazonesTrabajoDuranteEstudio" && x.Id == ciudadanoEncuentasIesDTO.RazonTrabajoDuranteSuCarreraId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 65,
                Pregunta = "¿Desde cuándo empezó usted a trabajar?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "TiemposDuranteEstudio" && x.Id == ciudadanoEncuentasIesDTO.CuandoComenzoTrabajarId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 65,
                Pregunta = "¿Qué efectos tuvo trabajar durante sus estudios profesionales?",
                Respuesta = listaParametrosEncuesta.Find(x => x.Tipo == "EfectosTrabajoDuranteEstudios" && x.Id == ciudadanoEncuentasIesDTO.EfectosTrabajoDuranteEstudiosId)?.Nombre ?? ""
            });

            encuentaIesDTOs.Add(new EncuentaIesDTO()
            {
                Orden = 65,
                Pregunta = "Describa otros efectos del trabajo durante sus estudios profesionales",
                Respuesta = ciudadanoEncuentasIesDTO.OtrosEfectosTrabajoDuranteEstudios ?? ""
            });

            return encuentaIesDTOs;
        }
    }
}
