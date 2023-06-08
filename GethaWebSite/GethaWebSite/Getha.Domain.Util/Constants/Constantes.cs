using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getha.Domain.Util.Constants
{
    public class Constantes
    {
        public static char SEPARADOR = '|';

        //TRABALHANDO COM DATA
        public const string FORMATO_DATA = "dd/MM/yyyy";
        public const string FORMATO_DATA_DD_MM_YY = "dd/MM/yy";
        public const string FORMATO_DATA_HORA_ORDENACAO = "yyyyMMddHHmmss";
        public const string FORMATO_DATA_ARQUIVO = "dd-MM-yyyy";
        public const string FORMATO_DATA_BANCO = "yyyy-MM-dd";
        public const string FORMATO_DATA_HORA_BANCO = "yyyy-MM-dd HH:mm:ss";
        public const string FORMATO_HORA = "HH:mm";
        public const string FORMATO_HORA_TELA = "hh':'mm";
        public const string FORMATO_DATA_HORA_SEPARADO_HIFEN = "dd/MM/yyyy - HH:mm";
        public const string FORMATO_DATA_HORA = "dd/MM/yyyy HH:mm:ss";
        public const string FORMATO_DATA_HORA_SOLIC = "dd/MM/yyyyHH:mm";
        public const string HIFEN = "-";

        // Expressões Regex 
        public const string REGEX_ALFANUMERICO = @"^[a-z0-9\s*]*$";
        public const string REGEX_HORA_24 = @"^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$";
        public const string REGEX_HORA = @"\d{1,4}\:\d{2}";
        public const string REGEX_HTML_TAG = @"<[^>]*>";
        public const string REGEX_SUBSTITUIR_ESPACOS_EM_BRANCOS = " {2,}";

        //Extensões
        public const string EXTENSAO_PDF = ".pdf";
        public const string EXTENSAO_WORD = ".docx";
        public const string EXTENSAO_ZIP = ".zip";

        public const string DEFAULT_XML_ENCODING = "ISO-8859-1";
    }
}
