using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCheck
{
    /// <summary>
    /// Помогает получить информацию для листбокса
    /// </summary>
    public sealed class InformationForUser
    {
        private List<string> newFile;
        private string information;
        private string uvedomlenie;
        DateTime dateTime;
        public List<string> InformationNewFile { get; private set; }
        public InformationForUser()
        {
            information = "Проверка";
            uvedomlenie = String.Empty;
        }
        public InformationForUser(List<string> vs, DateTime time) :this()
        {
            dateTime = time;            
            if (vs.Count > 0)
            {
                uvedomlenie = "Найдены новые файлы";
                newFile = vs;
                StrBuild();
            }
            else uvedomlenie = "Новых файлов не найдено";
            
        }
        /// <summary>
        /// выделяет только имя из подного имени файла
        /// </summary>
        private void StrBuild()
        {
            InformationNewFile = new List<string>();
            for(var i=0;i<newFile.Count;++i)
            {
                int s = newFile[i].LastIndexOf("\\");
                StringBuilder stringBuilder = new StringBuilder(newFile[i]);
                stringBuilder.Remove(0, s+1);
                InformationNewFile.Add(stringBuilder.ToString());
            }
        }
        /// <summary>
        /// возвращает строку представления информации о ситуации проверки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            information += " "+ dateTime.ToShortDateString() +" "+dateTime.ToShortTimeString()+ " " + uvedomlenie+"\n";
            return information;
        }
    }
}
