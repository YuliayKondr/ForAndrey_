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
    public partial class DellAdress : Form
    {
        //string temp;
        AdressesSend Adresses = AdressesSend.GetAdresses();
        string sendingFolder = @"sending.txt";//для адреса куда отправлять
        string savedirect = @"C:\CheckDirectoryProgram";
        SaveInFile _saveSending;
        public DellAdress()
        {
            InitializeComponent();
            _saveSending = new SaveInFile(savedirect, sendingFolder);
            AdressesSend.GetErrorOutputPath = MessegError;
            if (Adresses.IsFull()) AddToListBox();
            else listBox1.Items.Add("нет папок");
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
        private void AddToListBox()
        {
            listBox1.Items.Clear();
            foreach (string str in Adresses)
            {
                listBox1.Items.Add(str);
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
       
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string tempdell = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(tempdell);
                if (!Adresses.SetDellAdressSending(tempdell)) throw new Exception("Файл не найден");
                SaveSendingAdressesInFile();
            } catch(Exception ex)
            {
                MessegError(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Adresses.AllDell();
        }
    }
}
