using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCheck
{

    public partial class AddAdress : Form
    {
        string temp;
        AdressesSend Adresses = AdressesSend.GetAdresses();
        string sendingFolder = @"sending.txt";//для адреса куда отправлять
        string savedirect = @"C:\CheckDirectoryProgram";
        SaveInFile _saveSending;
        public AddAdress()
        {
            InitializeComponent();
            AdressesSend.GetErrorOutputPath = MessegError;
            if (Adresses.IsFull()) AddToListBox();
            _saveSending = new SaveInFile(savedirect, sendingFolder);
        }
        /// <summary>
        /// функция для сохранения адреса
        /// </summary>
        private void SaveSendingAdressesInFile()
        {
            if (Adresses.IsFull())
            {
                _saveSending.AllAdress = Adresses.GetListAdressSending;
                _saveSending.SaveFile();
            }
        }
        /// <summary>
        /// говорит об ошибки
        /// </summary>
        /// <param name="str"></param>
        private void MessegError(string str)
        {
            MessageBox.Show(str, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = String.Empty;
            folderDialog1.Description = "Добавление папки";
            if(folderDialog1.ShowDialog()==DialogResult.OK)
            {
                temp = folderDialog1.SelectedPath;
            }
            textBoxChoised.Text = temp;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Adresses.SetAdress(temp);            
            AddToListBox();
            SaveSendingAdressesInFile();
        }
        private void AddToListBox()
        {
            listBox1.Items.Clear();
            foreach (string str in Adresses)
            {
                listBox1.Items.Add(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
