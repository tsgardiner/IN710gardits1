﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionTool
{
    public interface ICodeMachine
    {
       string Encrypt(string text);

       string Decrypt(string text); 
    }
}
