
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Crowdin.Api.SourceFiles
{
    public abstract class FileExportOptions
    {
        
    }
    
    [PublicAPI]
    public class GeneralFileExportOptions : FileExportOptions
    {
        [JsonProperty("exportPattern")]
        public string ExportPattern { get; set; }
    }

    [PublicAPI]
    public class PropertyFileExportOptions : FileExportOptions
    {
        [JsonProperty("escapeQuotes")]
        public EscapeQuotesMode EscapeQuotes { get; set; }
        
        [JsonProperty("escapeSpecialCharacters")]
        public EscapeSpecialCharsMode EscapeSpecialCharacters { get; set; }
    }
    
    [PublicAPI]
    public enum EscapeQuotesMode
    {
        DoNotEscapeSingleQuote = 0,
        EscapeSingleQuoteByAnotherSingleQuote = 1,
        EscapeSingleQuoteByBackSlash = 2,
        EscapeSingleQuoteByAnotherSingleQuoteOnlyIfVariables = 3
    }
    
    [PublicAPI]
    public enum EscapeSpecialCharsMode
    {
        DoNotEscape = 0,
        EscapeByBackSlash = 1
    }
}