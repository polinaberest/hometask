using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse
{
    class TextFile
    {
        public string extensionT = ".txt";
        public string Name { get; private set; }
        public long Size { get; private set; }
        public string Content { get; private set; }

        public TextFile(string name, string size, string content)
        {
            Name = name;
            Size = Extensions.ConvertSize(size);
            Content = content;
        }

        public override string ToString()
        {
            return $" {this.Name}\n    Extension:{this.extensionT}\n    Size: {this.Size} Bytes\n    Content:{this.Content}\n";
        }
    }
}
