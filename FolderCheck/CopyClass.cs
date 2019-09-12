using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FolderCheck
{
    /// <summary>
    /// класс дает возможно скопировать совокупность файлов в заданные папки
    /// </summary>
    sealed class CopyClass
    {
        private List<string> _setPath;//папки получатели
        private List<string> _FileContent;//файлы-источники(полные имена)
        //private List<string> _newContent;//список (новых) файлов
        /// <summary>
        /// принимает только имена файлов
        /// </summary>
        public List<string> DirectoryPath{set{if (value != null) _setPath = value;}}
        public List<string> OriginFileContent{set{if (value != null) _FileContent = value;}}
        static GetMessegeError error;
        public static GetMessegeError GetErrorOutputPath
        {
            set
            {
                error = value;
            }
        }
        public CopyClass()
        {
            _setPath = new List<string>();
            _FileContent = new List<string>();
        }
        /// <summary>
        /// Функция помогает выделить имя файла
        /// </summary>
        /// <param name="fileOrigin"></param>
        /// <returns>Имя файла</returns>
        private string StrBuild(string fileOrigin)
        {
            
            int s = fileOrigin.LastIndexOf("\\");
            StringBuilder stringBuilder = new StringBuilder(fileOrigin);
            stringBuilder.Remove(0, s + 1);
            return stringBuilder.ToString();
        }
        public void CopyTo()
        {
            if(_setPath.Count>0 && _FileContent.Count>0)
            {
                try
                {
                    for(var i=0;i<_FileContent.Count;++i)
                    {
                        string temp = StrBuild(_FileContent[i]);
                        for(var j=0;j<_setPath.Count;j++)
                        {
                            string newfile = _setPath[j] + "\\" + temp;
                            File.Copy(_FileContent[i], newfile);
                        }
                    }
                    

                }catch(Exception ex)
                {
                    error?.Invoke(ex.Message);
                }
            }
        }
    }
}
