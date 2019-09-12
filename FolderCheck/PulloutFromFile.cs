using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FolderCheck
{

    /// <summary>
    /// делегат вівода ошибок
    /// </summary>
    /// <param name="str">пояснение ошибки</param>
    delegate void GetMessegeError(string str);
    /// <summary>
    /// считывает с файла данные
    /// </summary>
    sealed class PulloutFromFile
    {
        static GetMessageUser _msg;
        public static GetMessageUser GetMessageUserPath { set { _msg = value; } }
        static GetMessegeError error;
        public static  GetMessegeError GetErrorOutputPath
        {
            set
            {
                error = value;
            }
        }
        string _oneAdress;
        FileStream _stream;
        StreamReader _reader;
        string _path;       
        List<string> _contenFile;
        public PulloutFromFile(string path)//получает адрес файла!!!
        {
            _contenFile = new List<string>();
            if (path != String.Empty)
                _path = path;            
        }
        /// <summary>
        /// для еденичного считывания
        /// </summary>
        /// <returns></returns>
        public string OneAdressCheckDirectory()
        {
           
                using (_stream = new FileStream(_path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (_reader = new StreamReader(_stream, Encoding.Unicode))
                    {

                    _oneAdress = _reader.ReadLine();

                       
                    }
                }               
                    
            return _oneAdress;
        }
        /// <summary>
        /// функция для множественного считывания
        /// </summary>
        public void ContentInFile()
        {
            try
            {
                if (_contenFile.Count > 0) _contenFile.Clear();
                using (_stream = new FileStream(_path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (_reader = new StreamReader(_stream, Encoding.Unicode))
                    {
                        while (!_reader.EndOfStream)
                        {
                            _contenFile.Add(_reader.ReadLine());
                        }
                    }
                }
            } catch (FileNotFoundException ex)
            {
                _msg?.Invoke("Отсутсвуют папки-получатели");
            }
            catch(Exception ex)
            {
                error?.Invoke(ex.Message);
            }
        }
        /// <summary>
        /// получает контент
        /// </summary>
        /// <returns>возврат файла с адресами</returns>
        public List<string> GetList()
        {
            return _contenFile;
            
        }
    }
}
