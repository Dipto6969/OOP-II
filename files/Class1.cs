using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    public class File
    {
        public string name;
        public string content;
        public string type;
        public int size
        {
            get { return content.Length; }
        }
    }
    public class readOnly : File
    {
        public int isEditable()
        {
            return 0;
        }
        public readOnly (string name, string content, string type)
        {
            this.name = name;
            this.content = content;
            this.type = type;
        }

    }
    public class editable : File
    {
        public int isEditable()
        {
            return 0;
        }
        
         public editable(string name, string content, string type)
        {
            this.name = name;
            this.content = content;
            this.type = type;
        }
        
    }
}
