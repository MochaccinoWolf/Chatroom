using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;


namespace Chatroom
{   
    public partial class Form1 : Form
    {
        


        public  static TextBox userList;

        public Form1()
        {
            
            InitializeComponent();
           
            userList = tbUserList;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        public string GetTimeStamp(DateTime value)
        {
            return value.ToString("{" + "yyyy" + "/" + "MM" + "/" + "dd" + "HH:mm:ss"+"}");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            rtbMessageList.AppendText(Form2.UserName + ":" + rtbUserMessage.Text
                //+ GetTimeStamp(DateTime.UtcNow) 
                + "\n");

            rtbUserMessage.Text = "";

          
        }

        private void rtbMessageList_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rtbUserMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbMessageList_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

       private void rtbUserMessage_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                rtbMessageList.AppendText("\n" + rtbUserMessage.Text + "\n" + GetTimeStamp(DateTime.UtcNow));

                rtbUserMessage.Text = "";
                }



           
        }



        private void btnDisconnect_Click(object sender, EventArgs e)

        {
            MessageBox.Show("You have been disconnected.");
            Application.Exit();
        }
    }



}
