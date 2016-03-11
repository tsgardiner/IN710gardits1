using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{  
    class Encryption
    {    
        public ICodeMachine encryptionType { get; set; }
       

        public Encryption()
        {
           
        }

        public string PlainTextToCypher(string plainText)
        {                 
            return encryptionType.Encrypt(plainText); 
        }

        public string CypherToText(string enryptedText)
        {
            return encryptionType.Decrypt(enryptedText);
        }

    }
}
