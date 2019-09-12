using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FolderCheck
{
    /// <summary>
    /// проверяет дирректорию на наличие новых файлов
    /// </summary>
    sealed class CheckDirectory
    {
        public List<string> AllContentInFile { get; set; } //файлы, которые получаем с файла
        private List<string> ContentDirectory = new List<string>();//файлы, которые собираем во время проверки      
        static GetMessegeError error;        
        public static GetMessegeError GetErrorOutputPath
        {
            set
            {
                error = value;
            }
        }
        private static CheckDirectory _checkDir = new CheckDirectory();
        public static CheckDirectory GetCheckDirectory()
        {
            return _checkDir;
        }
        private CheckDirectory()
        {
            
        }
        /// <summary>
        /// проверка дирректории
        /// </summary>
        /// <param name="str"></param>
        public void StartCheck(string str,bool prov=true)
        {
            if (prov) ContentDirectory.Clear();
            DirectoryInfo directory;
            FileInfo[] files;
            try
            {
                directory = new DirectoryInfo(str);
                files = directory.GetFiles();
                for(var i=0;i<files.Length;++i)
                {
                    ContentDirectory.Add(files[i].FullName);
                }
                DirectoryInfo[] directories = directory.GetDirectories();
                if(directories.Length>0)
                {
                    for(var i=0;i<directories.Length;++i)
                    {
                        StartCheck(directories[i].FullName,false);
                    }
                }
                   
            }
            catch (Exception ex)
            {
                error?.Invoke(ex.Message);
            }
        }

        /// <summary>
        ///  проверяет изменения в директорри
        /// </summary>
        /// <returns></returns>
        public List<string> CheckList()
        {
            List<string> _NewContent = new List<string>();
            bool temp;
            for(var i=0;i<ContentDirectory.Count;++i)
            {
                temp = false;
                for(var j=0;j<AllContentInFile.Count;++j)
                {
                    if(String.Compare(ContentDirectory[i],AllContentInFile[j])==0)
                    {
                        temp = true;
                        break;
                    }
                }
                if(!temp)
                {
                    _NewContent.Add(ContentDirectory[i]);
                }
            }
            //обновляем список для перезаписи в файл
            AllContentInFile.Clear();
            AllContentInFile.AddRange(ContentDirectory);
            return _NewContent;
        }
    }
}
