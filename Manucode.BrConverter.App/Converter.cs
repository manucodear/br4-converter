using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manucode.BrConverter.App
{
    public class Converter
    {
        private readonly string _folder;
        private readonly bool _isRecursive;
        private readonly string[] _files;
        private readonly string _outPutFolder;
        private readonly string OUTPUT_FOLDER = "Output";
        public Action<string> OutputCallback;
        public Action<int> ProgressCallback;
        public string OutputFolder => _outPutFolder;
        public int NumberFiles { get => _files.Length; }

        public Converter(string folder, bool isRecursive)
        {
            _folder = folder;
            _isRecursive = isRecursive;
            _outPutFolder = $"{folder}\\{OUTPUT_FOLDER}";
            _files = Directory.GetFiles(folder, "*.br4", isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
        }
        
        public void Convert()
        {
            var fileNumber = 0;
            Directory.CreateDirectory(_outPutFolder);
            foreach (var file in _files)
            {
                var fileInfo = new FileInfo(file);
                Directory.CreateDirectory(fileInfo.DirectoryName.Replace(_folder, _outPutFolder));
                var outputFileName = file.Replace(fileInfo.Extension, ".mp3").Replace(_folder, _outPutFolder);
                using (var input = File.OpenRead(file))
                {
                    var buffer = new byte[1];
                    using (var output = File.OpenWrite(outputFileName))
                    {
                        while (input.Read(buffer, 0, 1) > 0)
                        {
                            buffer[0] = System.Convert.ToByte(buffer[0] ^ 255);
                            output.Write(buffer, 0, 1);
                        }
                        fileNumber++;
                        if (ProgressCallback != null) ProgressCallback(fileNumber);
                    }
                }
                WriteOutput($"{file} =====> {outputFileName}");
            }
            WriteOutput($"Files converted: {fileNumber}");
        }

        private void WriteOutput(string text)
        {
            if (OutputCallback != null) OutputCallback(text);
        }
    }
}
