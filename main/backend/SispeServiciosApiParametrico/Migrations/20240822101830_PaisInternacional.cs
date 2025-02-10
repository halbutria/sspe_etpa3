using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SispeServiciosApiParametrico.Migrations
{
    public partial class PaisInternacional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaisInternacional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UsuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaisInternacional", x => x.Id);
                });

            migrationBuilder.Sql("SET IDENTITY_INSERT PaisInternacional ON");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (1, 'Afganistán', '004', 'AFG', 'Afgano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (2, 'Albania', '008', 'ALB', 'Albanés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (3, 'Alemania', '276', 'DEU', 'Alemán/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (4, 'Andorra', '020', 'AND', 'Andorrano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (5, 'Angola', '024', 'AGO', 'Angoleño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (6, 'Antigua y Barbuda', '028', 'ATG', 'Antiguano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (7, 'Arabia Saudita', '682', 'SAU', 'Saudí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (8, 'Argelia', '012', 'DZA', 'Argelino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (9, 'Argentina', '032', 'ARG', 'Argentino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (10, 'Armenia', '051', 'ARM', 'Armenio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (11, 'Australia', '036', 'AUS', 'Australiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (12, 'Austria', '040', 'AUT', 'Austriaco/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (13, 'Azerbaiyán', '031', 'AZE', 'Azerbaiyano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (14, 'Bahamas', '044', 'BHS', 'Bahameño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (15, 'Bangladés', '050', 'BGD', 'Bangladesí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (16, 'Barbados', '052', 'BRB', 'Barbadense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (17, 'Baréin', '048', 'BHR', 'Bareiní', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (18, 'Bélgica', '056', 'BEL', 'Belga', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (19, 'Belice', '084', 'BLZ', 'Beliceño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (20, 'Benín', '204', 'BEN', 'Beninés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (21, 'Bielorrusia', '112', 'BLR', 'Bielorruso/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (22, 'Birmania', '104', 'MMR', 'Birmano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (23, 'Bolivia', '068', 'BOL', 'Boliviano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (24, 'Bosnia y Herzegovina', '070', 'BIH', 'Bosnio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (25, 'Botsuana', '072', 'BWA', 'Botsuano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (26, 'Brasil', '076', 'BRA', 'Brasileño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (27, 'Brunéi', '096', 'BRN', 'Bruneano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (28, 'Bulgaria', '100', 'BGR', 'Búlgaro/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (29, 'Burkina Faso', '854', 'BFA', 'Burkinés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (30, 'Burundi', '108', 'BDI', 'Burundés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (31, 'Bután', '064', 'BTN', 'Butanés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (32, 'Cabo Verde', '132', 'CPV', 'Caboverdiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (33, 'Camboya', '116', 'KHM', 'Camboyano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (34, 'Camerún', '120', 'CMR', 'Camerunés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (35, 'Canadá', '124', 'CAN', 'Canadiense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (36, 'Catar', '634', 'QAT', 'Catarí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (37, 'Chad', '148', 'TCD', 'Chadiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (38, 'Chile', '152', 'CHL', 'Chileno/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (39, 'China', '156', 'CHN', 'Chino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (40, 'Chipre', '196', 'CYP', 'Chipriota', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (41, 'Colombia', '170', 'COL', 'Colombiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (42, 'Comoras', '174', 'COM', 'Comorense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (43, 'Congo', '178', 'COG', 'Congoleño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (44, 'Corea del Norte', '408', 'PRK', 'Norcoreano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (45, 'Corea del Sur', '410', 'KOR', 'Surcoreano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (46, 'Costa de Marfil', '384', 'CIV', 'Marfileño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (47, 'Costa Rica', '188', 'CRI', 'Costarricense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (48, 'Croacia', '191', 'HRV', 'Croata', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (49, 'Cuba', '192', 'CUB', 'Cubano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (50, 'Dinamarca', '208', 'DNK', 'Danés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (51, 'Dominica', '212', 'DMA', 'Dominiqués/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (52, 'Ecuador', '218', 'ECU', 'Ecuatoriano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (53, 'Egipto', '818', 'EGY', 'Egipcio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (54, 'El Salvador', '222', 'SLV', 'Salvadoreño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (55, 'Emiratos Árabes Unidos', '784', 'ARE', 'Emiratí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (56, 'Eritrea', '232', 'ERI', 'Eritreo/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (57, 'Eslovaquia', '703', 'SVK', 'Eslovaco/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (58, 'Eslovenia', '705', 'SVN', 'Esloveno/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (59, 'España', '724', 'ESP', 'Español/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (60, 'Estados Unidos', '840', 'USA', 'Estadounidense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (61, 'Estonia', '233', 'EST', 'Estonio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (62, 'Etiopía', '231', 'ETH', 'Etíope', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (63, 'Filipinas', '608', 'PHL', 'Filipino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (64, 'Finlandia', '246', 'FIN', 'Finlandés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (65, 'Fiyi', '242', 'FJI', 'Fiyiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (66, 'Francia', '250', 'FRA', 'Francés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (67, 'Gabón', '266', 'GAB', 'Gabonés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (68, 'Gambia', '270', 'GMB', 'Gambiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (69, 'Georgia', '268', 'GEO', 'Georgiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (70, 'Ghana', '288', 'GHA', 'Ghanés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (71, 'Granada', '308', 'GRD', 'Granadino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (72, 'Grecia', '300', 'GRC', 'Griego/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (73, 'Guatemala', '320', 'GTM', 'Guatemalteco/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (74, 'Guinea', '324', 'GIN', 'Guineano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (75, 'Guinea-Bisáu', '624', 'GNB', 'Guineano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (76, 'Guinea Ecuatorial', '226', 'GNQ', 'Ecuatoguineano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (77, 'Guyana', '328', 'GUY', 'Guyanés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (78, 'Haití', '332', 'HTI', 'Haitiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (79, 'Honduras', '340', 'HND', 'Hondureño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (80, 'Hungría', '348', 'HUN', 'Húngaro/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (81, 'India', '356', 'IND', 'Indio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (82, 'Indonesia', '360', 'IDN', 'Indonesio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (83, 'Irak', '368', 'IRQ', 'Iraquí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (84, 'Irán', '364', 'IRN', 'Iraní', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (85, 'Irlanda', '372', 'IRL', 'Irlandés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (86, 'Islandia', '352', 'ISL', 'Islandés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (87, 'Islas Marshall', '584', 'MHL', 'Marshalés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (88, 'Islas Salomón', '090', 'SLB', 'Salomonense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (89, 'Israel', '376', 'ISR', 'Israelí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (90, 'Italia', '380', 'ITA', 'Italiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (91, 'Jamaica', '388', 'JAM', 'Jamaicano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (92, 'Japón', '392', 'JPN', 'Japonés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (93, 'Jordania', '400', 'JOR', 'Jordano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (94, 'Kazajistán', '398', 'KAZ', 'Kazajo/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (95, 'Kenia', '404', 'KEN', 'Keniano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (96, 'Kirguistán', '417', 'KGZ', 'Kirguís', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (97, 'Kiribati', '296', 'KIR', 'Kiribatiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (98, 'Kuwait', '414', 'KWT', 'Kuwaití', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (99, 'Laos', '418', 'LAO', 'Laosiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (100, 'Lesoto', '426', 'LSO', 'Lesotense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (101, 'Letonia', '428', 'LVA', 'Letón/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (102, 'Líbano', '422', 'LBN', 'Libanés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (103, 'Liberia', '430', 'LBR', 'Liberiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (104, 'Libia', '434', 'LBY', 'Libio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (105, 'Liechtenstein', '438', 'LIE', 'Liechtensteiniano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (106, 'Lituania', '440', 'LTU', 'Lituano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (107, 'Luxemburgo', '442', 'LUX', 'Luxemburgués/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (108, 'Macedonia del Norte', '807', 'MKD', 'Macedonio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (109, 'Madagascar', '450', 'MDG', 'Malgache', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (110, 'Malasia', '458', 'MYS', 'Malasio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (111, 'Malaui', '454', 'MWI', 'Malauí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (112, 'Maldivas', '462', 'MDV', 'Maldivo/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (113, 'Malí', '466', 'MLI', 'Maliense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (114, 'Malta', '470', 'MLT', 'Maltés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (115, 'Marruecos', '504', 'MAR', 'Marroquí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (116, 'Mauricio', '480', 'MUS', 'Mauriciano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (117, 'Mauritania', '478', 'MRT', 'Mauritano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (118, 'México', '484', 'MEX', 'Mexicano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (119, 'Micronesia', '583', 'FSM', 'Micronesio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (120, 'Moldavia', '498', 'MDA', 'Moldavo/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (121, 'Mónaco', '492', 'MCO', 'Monegasco/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (122, 'Mongolia', '496', 'MNG', 'Mongol/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (123, 'Montenegro', '499', 'MNE', 'Montenegrino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (124, 'Mozambique', '508', 'MOZ', 'Mozambiqueño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (125, 'Namibia', '516', 'NAM', 'Namibio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (126, 'Nauru', '520', 'NRU', 'Nauruano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (127, 'Nepal', '524', 'NPL', 'Nepalí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (128, 'Nicaragua', '558', 'NIC', 'Nicaragüense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (129, 'Níger', '562', 'NER', 'Nigerino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (130, 'Nigeria', '566', 'NGA', 'Nigeriano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (131, 'Noruega', '578', 'NOR', 'Noruego/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (132, 'Nueva Zelanda', '554', 'NZL', 'Neozelandés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (133, 'Omán', '512', 'OMN', 'Omaní', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (134, 'Países Bajos', '528', 'NLD', 'Neerlandés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (135, 'Pakistán', '586', 'PAK', 'Pakistaní', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (136, 'Palaos', '585', 'PLW', 'Palauano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (137, 'Panamá', '591', 'PAN', 'Panameño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (138, 'Papúa Nueva Guinea', '598', 'PNG', 'Papú', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (139, 'Paraguay', '600', 'PRY', 'Paraguayo/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (140, 'Perú', '604', 'PER', 'Peruano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (141, 'Polonia', '616', 'POL', 'Polaco/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (142, 'Portugal', '620', 'PRT', 'Portugués/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (143, 'Reino Unido', '826', 'GBR', 'Británico/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (144, 'República Centroafricana', '140', 'CAF', 'Centroafricano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (145, 'República Checa', '203', 'CZE', 'Checo/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (146, 'República del Congo', '178', 'COG', 'Congoleño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (147, 'República Democrática del Congo', '180', 'COD', 'Congoleño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (148, 'República Dominicana', '214', 'DOM', 'Dominicano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (149, 'Ruanda', '646', 'RWA', 'Ruandés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (150, 'Rumanía', '642', 'ROU', 'Rumano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (151, 'Rusia', '643', 'RUS', 'Ruso/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (152, 'Samoa', '882', 'WSM', 'Samoano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (153, 'San Cristóbal y Nieves', '659', 'KNA', 'Cristobaleño/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (154, 'San Marino', '674', 'SMR', 'Sanmarinense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (155, 'San Vicente y las Granadinas', '670', 'VCT', 'Sanvicentino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (156, 'Santa Lucía', '662', 'LCA', 'Santalucense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (157, 'Santo Tomé y Príncipe', '678', 'STP', 'Santotomense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (158, 'Senegal', '686', 'SEN', 'Senegalés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (159, 'Serbia', '688', 'SRB', 'Serbio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (160, 'Seychelles', '690', 'SYC', 'Seychellense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (161, 'Sierra Leona', '694', 'SLE', 'Sierraleonés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (162, 'Singapur', '702', 'SGP', 'Singapurense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (163, 'Siria', '760', 'SYR', 'Sirio/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (164, 'Somalia', '706', 'SOM', 'Somalí', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (165, 'Sri Lanka', '144', 'LKA', 'Ceilanés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (166, 'Suazilandia', '748', 'SWZ', 'Suazi', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (167, 'Sudáfrica', '710', 'ZAF', 'Sudafricano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (168, 'Sudán', '729', 'SDN', 'Sudanés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (169, 'Sudán del Sur', '728', 'SSD', 'Sursudanés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (170, 'Suecia', '752', 'SWE', 'Sueco/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (171, 'Suiza', '756', 'CHE', 'Suizo/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (172, 'Surinam', '740', 'SUR', 'Surinamés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (173, 'Tailandia', '764', 'THA', 'Tailandés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (174, 'Tanzania', '834', 'TZA', 'Tanzano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (175, 'Tayikistán', '762', 'TJK', 'Tayiko/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (176, 'Timor Oriental', '626', 'TLS', 'Timorense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (177, 'Togo', '768', 'TGO', 'Togolés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (178, 'Tonga', '776', 'TON', 'Tongano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (179, 'Trinidad y Tobago', '780', 'TTO', 'Trinitense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (180, 'Túnez', '788', 'TUN', 'Tunecino/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (181, 'Turkmenistán', '795', 'TKM', 'Turcomano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (182, 'Turquía', '792', 'TUR', 'Turco/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (183, 'Tuvalu', '798', 'TUV', 'Tuvaluano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (184, 'Ucrania', '804', 'UKR', 'Ucraniano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (185, 'Uganda', '800', 'UGA', 'Ugandés/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (186, 'Uruguay', '858', 'URY', 'Uruguayo/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (187, 'Uzbekistán', '860', 'UZB', 'Uzbeko/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (188, 'Vanuatu', '548', 'VUT', 'Vanuatuense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (189, 'Ciudad del Vaticano', '336', 'VAT', 'Vaticano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (190, 'Venezuela', '862', 'VEN', 'Venezolano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (191, 'Vietnam', '704', 'VNM', 'Vietnamita', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (192, 'Yemen', '887', 'YEM', 'Yemení', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (193, 'Yibuti', '262', 'DJI', 'Yibutiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (194, 'Zambia', '894', 'ZMB', 'Zambiano/a', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("INSERT INTO PaisInternacional (Id, Nombre, Codigo, Sigla, Nacionalidad, UsuarioCreacion, UsuarioModificacion, Eliminado, FechaCreacion, FechaModificacion) VALUES (195, 'Zimbabue', '716', 'ZWE', 'Zimbabuense', 'admin', '', 0, GETDATE(), null)");

            migrationBuilder.Sql("SET IDENTITY_INSERT PaisInternacional OFF");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaisInternacional");
        }
    }
}
