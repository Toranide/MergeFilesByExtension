using System.Collections.Generic;

namespace MergeFilesByExtension.Models
{
    public sealed class MergeResult
    {
        public int ModulesCreated { get; set; }

        public int FilesMerged { get; set; }

        public int FilesSkipped { get; set; }

        public IList<string> Errors { get; } = new List<string>();
    }
}
