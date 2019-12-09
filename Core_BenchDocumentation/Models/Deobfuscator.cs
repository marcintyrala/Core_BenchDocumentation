using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Threading;
using System.Xml;

namespace Core_BenchDocumentation.Models
{
    class Deobfuscator
    {
        char[] charDictionaryASCII;
        byte[] charDictionaryOBFUS;
        
        /// <summary>
        /// Deobfuscate file using dictionary files.
        /// </summary>
        /// <param name="filePath"></param>
        public string Deobfuscate(string filePath)
        {
            //Ready input file
            byte[] byteOriginal=File.ReadAllBytes(filePath);
            byte charSingle;
            // Define dictionary (char and byte)
            // It's possible to concat add more dictionary files to charDictionaryOBFUS/ASCII
            charDictionaryOBFUS = Core_BenchDocumentation.Properties.Resources.DictionaryOBFUS;
            charDictionaryASCII = Core_BenchDocumentation.Properties.Resources.DictionaryASCI.ToCharArray();
            
            List<char> charTranslation = new List<char>();

            int i,j;

            for (i = 0; i < byteOriginal.Length; i++)
            {
                charSingle = byteOriginal[i];

                for (j = 0; j < charDictionaryOBFUS.Length; j++)
                {
                    if (charSingle.Equals(charDictionaryOBFUS[j]))
                    {
                        try { 
                        charTranslation.Add(charDictionaryASCII[j]);
                        break;
                        }
                        catch
                        {
                            charTranslation.Add('x');
                            break;
                        }
                    }
                    if (j== charDictionaryOBFUS.Length-1) charTranslation.Add('x');

                }
                
            }

            string outputString = new string(charTranslation.ToArray());

            // New file with unblocked content disabled
            /*
            StreamWriter outputFile = new StreamWriter(filePath+".unblock");
            outputFile.Write(outputString);
            outputFile.Close();
            */
            return outputString;
        }


    }
}
