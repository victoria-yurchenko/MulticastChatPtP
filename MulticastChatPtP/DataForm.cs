using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MulticastChatPtP
{
    public partial class DataForm : Form
    {
        private readonly ChatMessage _chatMessage;

        public DataForm(ChatMessage chatMessage)
        {
            InitializeComponent();
            _chatMessage = chatMessage;
            ViewData();
        }

        private void ViewData()
        {
            if (Path.GetExtension(_chatMessage.Data.FileName) == ".txt")
            {
                var tb = new TextBox();
                pnlData.Controls.Add(tb);
                tb.Multiline = true;
                tb.Dock = DockStyle.Fill;
                tb.Text = Encoding.UTF8.GetString(Convert.FromBase64String(_chatMessage.Data.Data));
            }
            else if (Path.GetExtension(_chatMessage.Data.FileName) == ".png" ||
                    Path.GetExtension(_chatMessage.Data.FileName) == ".jpg")
            {
                var pb = new PictureBox();
                pnlData.Controls.Add(pb);
                pb.Dock = DockStyle.Fill;
                using (var memoryStream = new MemoryStream(Convert.FromBase64String(_chatMessage.Data.Data)))
                {
                    var bitmap = new Bitmap(memoryStream);
                    pb.Image = bitmap;
                }
            }
            else
                throw new Exception("The format is not available! DataForm line 46");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var saveFileDiaog = new SaveFileDialog())
            {
                if(saveFileDiaog.ShowDialog() == DialogResult.OK)
                {
                    var obj = _chatMessage.Data.Data;
                    File.WriteAllBytes(_chatMessage.Data.FileName, Convert.FromBase64String(obj));
                }
            }
            
        }
    }
}
