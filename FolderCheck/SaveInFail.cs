using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace FolderCheck
{
    delegate void GetMessageUser(string msg);
    /// <summary>
    /// для сохранения адресов в файл
    /// </summary>
    sealed class SaveInFile
    {
        static GetMessageUser _msg;
        public static GetMessageUser GetMessageUserPath{set{ _msg = value;}}
        static GetMessegeError error;
        public static GetMessegeError GetErrorOutputPath{set { error = value; }}
        FileStream _fileStream;
        StreamWriter _writer;
        string fullname;
        /// <summary>
        /// получает адресса для сохранения
        /// </summary>
        public List<string> AllAdress { get; set; }        
        public SaveInFile(string dir,string namefaile)
        {            
            this.CheckFolder(dir);
             fullname= dir + @"\" + CheckAdress( namefaile); 
        }
        /// <summary>
        /// проверяет наличие папки на диске С
        /// </summary>
        private void CheckFolder(string str)
        {
            DirectoryInfo directory = new DirectoryInfo(str);
            if (!directory.Exists)
                directory.Create();
        }
        /// <summary>
        /// сохранение одного адресса. Для главного адреса
        /// </summary>
        /// <param name="path"></param>
        public void SaveOnePathOfDorectory(string path)
        {
            using (_fileStream = new FileStream(fullname, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (_writer = new StreamWriter(_fileStream, Encoding.Unicode))
                { 
                    _writer.WriteLine(path);         
                }
            }
        }
        /// <summary>
        /// сохранение содержимого 
        /// </summary>
        public bool SaveFile()
        {
            try
            {
                using (_fileStream = new FileStream(fullname, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (_writer = new StreamWriter(_fileStream, Encoding.Unicode))
                    {
                        if (AllAdress.Count > 0)//если папка не пуста
                        {
                            foreach (string str in AllAdress)
                            {
                                _writer.WriteLine(str);
                            }
                        }
                        else throw new FileNotFoundException("Папка пуста");
                        return true;
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                _msg?.Invoke(ex.Message);
            }
            catch (ArgumentException ex)
            {
                error?.Invoke(ex.Message);
            }
            catch (IOException ex)
            {
                error?.Invoke(ex.Message);
            }
            catch (Exception ex)
            {
                error?.Invoke(ex.Message);
            }
            return false;
        }
        private string CheckAdress(string path)
        {
            string temp = ".txt";
            Regex regex = new Regex(@"^.*\.(txt|TXT)$");//^.*\.(jpg|JPG|gif|GIF|doc|DOC|pdf|PDF)$
            if (regex.IsMatch(path)) return path;
            
            else return path + temp;
        }
        public void CreateNewFile()
        {
            using (_fileStream = new FileStream(fullname, FileMode.CreateNew, FileAccess.Write))
            {
                
            }
        }
    }
}
