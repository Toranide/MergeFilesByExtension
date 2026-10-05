using System.Collections.Generic;

namespace MergeFilesByExtension.Models
{
    public sealed class MergeOptions
    {
        public string RootPath { get; set; }

        public string OutputDirectory { get; set; }

        public IReadOnlyCollection<string> Extensions { get; set; }

        public ISet<string> BlockList { get; set; }
    }
}
