﻿
using System.ComponentModel;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Crowdin.Api.Bundles
{
    [PublicAPI]
    public class BundlePatch : PatchEntry
    {
        [JsonProperty("path")]
        public BundlePatchPath Path { get; set; }
    }

    [PublicAPI]
    public enum BundlePatchPath
    {
        [Description("/applicationId")]
        ApplicationId,
        
        [Description("/sourcePatterns")]
        SourcePatterns,
        
        [Description("/ignorePatterns")]
        IgnorePatterns,
        
        [Description("/exportPattern")]
        ExportPattern,
        
        [Description("/labelIds")]
        LabelIds
    }
}