using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FolderCheck
{
    public partial class MainWin : Form
    {
        //----------------------------------------
        string savedirect = @"C:\CheckDirectoryProgram";
        string saveMainFile = @"main.txt";
        string saveAllContent = @"content.txt";
        string sendingFolder = @"sending.txt";//для адреса куда отправлять        
        //----------------------------------------
        private string _mainPath;//хранитель главного адреса
        PulloutFromFile _mainfrom;
        SaveInFile _mainSave;
        SaveInFile _saveInFile;
        PulloutFromFile _fromFile;        
        PulloutFromFile _fromSending;     

        AdressesSend adressesSend = AdressesSend.GetAdresses();
        CheckDirectory checkDirectory = CheckDirectory.GetCheckDirectory();
        bool first = true;
        public MainWin()
        {
            InitializeComponent();            
            SaveInFile.GetErrorOutputPath =PulloutFromFile.GetErrorOutputPath= CheckDirectory.GetErrorOutputPath = MessegError;               
            PulloutFromFile.GetMessageUserPath =SaveInFile.GetMessageUserPath = MessegeUser;                
            //контент
            _saveInFile = new SaveInFile(savedirect, saveAllContent);
            _fromFile = new PulloutFromFile(savedirect + "\\" + saveAllContent);
            //главная
            _mainSave = new SaveInFile(savedirect, saveMainFile);
            _mainfrom = new PulloutFromFile(savedirect + "\\" + saveMainFile);
            //папки-send
            _fromSending = new PulloutFromFile(savedirect + "\\" + sendingFolder);
            CheckSaveFolderAndFiles();
            if (first)
            {
                PutSendingFolder();
                PutContentFromFile();
                toolStripStatusLabel1.Text = _mainPath;
                first = true;
                timerTime.Interval = 60000;
                labelTime.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString();
                timerTime.Tick += (object sender, EventArgs e) =>
                 {
                     labelTime.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString();
                 };
                timerTime.Start();
            }
        }
        /// <summary>
        /// сохраняет контент в файл
        /// </summary>
        private void SaveContentInFile()
        {
            _saveInFile.AllAdress = checkDirectory.AllContentInFile;
            _saveInFile.SaveFile();
        }
        /// <summary>
        /// взятие контента из файла
        /// </summary>
        private void PutContentFromFile()
        {
            try
            {
                _fromFile.ContentInFile();
                checkDirectory.AllContentInFile = _fromFile.GetList();
            }catch(FileNotFoundException ex)
            {
                _saveInFile.CreateNewFile();
            }
            catch(Exception ex)
            {
                MessegError(ex.Message);
            }
        }
        /// <summary>
        /// функция для перезаписи контента при изменении главной пакпи
        /// </summary>
        private void CheckDir_chengeMainAdree()
        {
            checkDirectory.StartCheck(_mainPath);
            _saveInFile.AllAdress = checkDirectory.CheckList();            
            _saveInFile.SaveFile();
        }
        /// <summary>
        /// старт проверки главной папки
        /// </summary>
        private void CheckFolderStart()
        {
            PutContentFromFile();
            checkDirectory.StartCheck(_mainPath);            
            List<string> ls = checkDirectory.CheckList();//получаем новые файлы            
            SaveContentInFile();
            InformationForUser forUser = new InformationForUser(ls, DateTime.Now);
            listBoxStatistic.BeginUpdate();
            listBoxStatistic.Items.Add(forUser.ToString());
            if (ls.Count > 0)//сдесь делаем все что нужно, если найдены новые файлы
                             //тут мы и скопируем в другие дирректоррии
            {
                CopyClass copyClass = new CopyClass();
                copyClass.DirectoryPath = adressesSend.GetListAdressSending;
                copyClass.OriginFileContent = ls;
                copyClass.CopyTo();
                foreach (var str in forUser.InformationNewFile)
                {
                    listBoxStatistic.Items.Add(str);
                }
            }
            listBoxStatistic.EndUpdate();             
        }
        /// <summary>
        /// возвращает интервал выбранный пользователем
        /// </summary>
        /// <returns></returns>
        private Int32 SelectedIntervalUser()
        {
            
            if (timerfiftyminToolStripMenuItem3.Checked)                          
                return 45;            
            else if (timerfninToolStripMenuItem4.Checked)
                return 5;
            else if (timeronehodToolStripMenuItem.Checked)
                return 60;
            else if (timerthirtminToolStripMenuItem2.Checked)
                return 30;
            else if (timertwelveminToolStripMenuItem1.Checked)
                return 20;
            else if (timertwohodToolStripMenuItem.Checked)
                return 120;
            else if (timertenminToolStripMenuItem.Checked)
                return 10;
            else return 0;
                
        }
        /// <summary>
        /// настройка таймера
        /// </summary>
        private void NastroikaTimer()
        {            
            timerCheckFolder.Interval = 60*1000*SelectedIntervalUser();
            toolStripStatusLabel2.Text = "Проверка каждые " + (timerCheckFolder.Interval/60000).ToString()+"мин";
        }
        /// <summary>
        /// говорит об ошибки
        /// </summary>
        /// <param name="str"></param>
        private void MessegError(string str)
        {
            MessageBox.Show(str, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// увидомление
        /// </summary>
        /// <param name="msg"></param>
        private void MessegeUser(string msg)
        {
            MessageBox.Show(msg, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// Функуия проверки корневой папок и файлов
        /// </summary>
        private void CheckSaveFolderAndFiles()
        {
            try
            {
                _mainPath= _mainfrom.OneAdressCheckDirectory();
                if (_mainPath == String.Empty) throw new FileNotFoundException("Выбирите папку");
            }catch(FileNotFoundException ex)
            {
                _mainPath = OpenFileDialog("Выбирите папку, которую хотите мониторить");
                if (_mainPath == String.Empty)
                {
                    MessageBox.Show("Папка не выбрана", "Закритие программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    first = false;
                }
            }
            _mainSave.SaveOnePathOfDorectory(_mainPath);

        }
        /// <summary>
        /// открытия файла диалога
        /// </summary>
        private string OpenFileDialog(string naznach)
        {
            string temp=String.Empty;
            folderUser.Description = naznach;
            if (folderUser.ShowDialog() == DialogResult.OK)
                temp = folderUser.SelectedPath;
            return temp;
        }
        private void PutSendingFolder()
        {             
            _fromSending.ContentInFile();
            List<string> vs = _fromSending.GetList();
            if (vs.Count > 0)
                for (var i = 0; i < vs.Count; ++i)
                    adressesSend.SetAdress(vs[i]);          
        } 
        /// <summary>
        /// очищает выбранные меню минут
        /// </summary>
        /// <param name="h"></param>
        private void TakeOffChecked(Int32 h)
        {
            if (timerfiftyminToolStripMenuItem3.GetHashCode() != h)
                timerfiftyminToolStripMenuItem3.Checked = false;
            if (timerfninToolStripMenuItem4.GetHashCode() != h)
                timerfninToolStripMenuItem4.Checked = false;
            if (timeronehodToolStripMenuItem.GetHashCode() != h)
                timeronehodToolStripMenuItem.Checked = false;
            if (timerthirtminToolStripMenuItem2.GetHashCode() != h)
                timerthirtminToolStripMenuItem2.Checked = false;
            if (timertwelveminToolStripMenuItem1.GetHashCode() != h)
                timertwelveminToolStripMenuItem1.Checked = false;
            if (timertwohodToolStripMenuItem.GetHashCode() != h)
                timertwohodToolStripMenuItem.Checked = false;
            if (timertenminToolStripMenuItem.GetHashCode() != h)
                timertenminToolStripMenuItem.Checked = false;            
        }
        /// <summary>
        /// установка флажка
        /// </summary>
        /// <param name="item"></param>
        private void ChangeStripMenuItem(ref ToolStripMenuItem item)
        {
            if (!item.Checked) item.Checked = true;            
        }
        
        //Обработчики-----------------------------
       
        /// <summary>
         /// Изменения главного адреса
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>        
        private void MainadresschangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string old = _mainPath;
            _mainPath = OpenFileDialog("Выбирите папку, которую хотите мониторить\n"+"Сейчас проверяемая директория: "+old);
            if (_mainPath == String.Empty)
            {
                _mainPath = old;
            }
            _mainSave.SaveOnePathOfDorectory(_mainPath);
            toolStripStatusLabel1.Text = _mainPath;
            if(String.Compare(old,_mainPath)!=0)
                CheckDir_chengeMainAdree();
        }
        /// <summary>
        /// обработчик главная -другие - добавить
        /// </summary>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdress adress = new AddAdress();
            adress.Show();      

        }
        /// <summary>
        /// обработчик главная -другие - удалить
        /// </summary>
        private void DellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DellAdress dellAdress = new DellAdress();
            dellAdress.Show();
           
        }   
        
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 /// <summary>
        /// тест проверки папки
        /// </summary>
        /// <param name="sender"></param>        
        private void button1_MouseClick(object sender, EventArgs e)
        {

            CheckFolderStart();
        }
        /// <summary>
        /// обработчик для таймера
        /// </summary>
        private void timerCheckFolder_Tick(object sender, EventArgs e)
        {
            CheckFolderStart();            
        }    

        private void StartCheckFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckFolderStart();
            NastroikaTimer();
            timerCheckFolder.Start();
            toolStripStatusLabel3.Visible = false;
            toolStripStatusLabel4.Visible = true;
        }
       

        private void SelectedInterval_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            Int32  hash = temp.GetHashCode();
            TakeOffChecked(hash);
            if (timerfiftyminToolStripMenuItem3.GetHashCode() == hash)
            {
                ChangeStripMenuItem(ref timerfiftyminToolStripMenuItem3);
            }            
            if (timerfninToolStripMenuItem4.GetHashCode() == hash)
                ChangeStripMenuItem(ref timerfninToolStripMenuItem4);
            if (timeronehodToolStripMenuItem.GetHashCode() == hash)
                ChangeStripMenuItem(ref timeronehodToolStripMenuItem);
            if (timerthirtminToolStripMenuItem2.GetHashCode() == hash)
                ChangeStripMenuItem(ref timerthirtminToolStripMenuItem2);
            if (timertwelveminToolStripMenuItem1.GetHashCode() == hash)
                ChangeStripMenuItem(ref timertwelveminToolStripMenuItem1);
            if (timertwohodToolStripMenuItem.GetHashCode() == hash)
                ChangeStripMenuItem(ref timertwohodToolStripMenuItem);
            if (timertenminToolStripMenuItem.GetHashCode() == hash)
                ChangeStripMenuItem(ref timertenminToolStripMenuItem);
            bool prov = false;
            if (timerCheckFolder.Enabled)
            {
                timerCheckFolder.Stop();
                prov = true;
            }
            NastroikaTimer();
            if (prov && timerCheckFolder.Interval > 0)
            {
                CheckFolderStart();
                timerCheckFolder.Start();
                toolStripStatusLabel3.Visible = false;
                toolStripStatusLabel4.Visible = true;
            }
        }

        private void StopCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerCheckFolder.Stop();
            NastroikaTimer();
            toolStripStatusLabel3.Visible = true;
            toolStripStatusLabel4.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
          
    }
}
