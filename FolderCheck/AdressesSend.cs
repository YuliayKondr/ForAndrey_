using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FolderCheck
{
    /// <summary>
    /// Класс, который отвечает за хранение адресов для отправки файлов
    /// Singelton
    /// </summary>
    sealed class AdressesSend:IEnumerable
    {
        private static AdressesSend _adressessend =new AdressesSend();
        private AdressesSend()
        {
            sending = new List<string>();
        }
        public static AdressesSend GetAdresses()
        {
            return _adressessend;
        }
        //----вывод ошибок
        static GetMessegeError error;
        public static GetMessegeError GetErrorOutputPath
        {
            set
            {
                error = value;
            }
        }
        public List<string> GetListAdressSending
        {
            get
            {
                if (sending.Count > 0) return sending;
                else return null;
            }
        }
        List<string> sending;//внутренний хранитель  адресов
        public void SetAdress(string path)
        {
            try
            {
                if (CheckFolder(path))
                    sending.Add(path);
                else new FileNotFoundException("Путь не верный");
            } catch(Exception ex)
            {
                error?.Invoke(ex.Message);
            }
        }
        /// <summary>
        /// удаление адреса 
        /// </summary>
        /// <param name="path">путь удалямой паки</param>
        /// <returns>успешно ли</returns>
        public bool SetDellAdressSending(string path)
        {
            return sending.Remove(path);
        }
        /// <summary>
        /// проверка пути на наличие и правильность
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool CheckFolder(string str)
        {
            DirectoryInfo directory = new DirectoryInfo(str);
            return (directory.Exists) ? true : false;
        }
        public IEnumerator GetEnumerator()
        {
            return sending.GetEnumerator();
        }
        public bool IsFull()
        {
            return (sending.Count > 0) ? true : false;
        }
        public void AllDell()
        {
            sending.Clear();
        }
    }
}
