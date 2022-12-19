using MulticastChatPtP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MulticastChatPtP
{
    public partial class ChatMessage : UserControl
    {
        private readonly ChatData _data;
        private readonly bool _isHaveData;

        public ChatMessage(ChatData data)
        {
            InitializeComponent();
            _isHaveData = true;
            _data = data;
            ucTbDateTime.TextAlign = HorizontalAlignment.Center;

            ucTbMessage.Text = data.Message;
            ucTbDateTime.Text = DateTime.Now.ToShortTimeString();

            if (string.IsNullOrEmpty(data.FileName))
            {
                Controls.Remove(ucBtFile);
                _isHaveData = false;
            }
        }

        public ChatData Data 
        {
            get => _data;
        }

        public bool IsHaveData 
        {
            get => _isHaveData;
        }

        public Button LoadButton 
        { 
            get => ucBtFile;
            set => ucBtFile = value;
        }
    }
}
