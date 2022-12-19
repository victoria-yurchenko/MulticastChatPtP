using MulticastChatPtP.Models;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticastChatPtP
{
    public partial class Form1 : Form
    {
        private bool _IsActive;
        private IPAddress _multicastAddress;
        private int _remotePort;
        private int _localPort;
        public static string _path;
        private int _top;
        private int _cmName;
        private ICollection<ChatMessage> _messages;
        

        public Form1()
        {
            InitializeComponent();
            _path = string.Empty;
            _IsActive = false;
            _messages = new List<ChatMessage>();
            _cmName = 0;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.BackColor = Color.GreenYellow;
            tabControl1.TabPages["Settings"].BackColor = Color.LightYellow;
            tabControl1.TabPages["Settings"].Text = "Started";

            _IsActive = true;

            var thread = new Thread(Listen);
            thread.IsBackground = true;
            thread.Start();

            _multicastAddress = IPAddress.Parse(tbAddress.Text.Trim());
            _remotePort = Convert.ToInt32(tbRemotePort.Text.Trim());
            _localPort = Convert.ToInt32(tbLocalPort.Text.Trim());
        }

        private void Listen(object obj)
        {
            try
            {
                //create multicast socket
                var receiver = new UdpClient();
                //multicast socket must be bind to a multicast address (224.0.0.0 - 239.255.255.255)
                var localEp = new IPEndPoint(IPAddress.Any, _localPort);

                receiver.ExclusiveAddressUse = false;
                receiver.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

                receiver.Client.Bind(localEp);
                //joint multicast group
                receiver.JoinMulticastGroup(_multicastAddress);


                while (_IsActive)
                {
                    IPEndPoint ep = null;
                    var resp = receiver.Receive(ref ep);
                    var data = JsonSerializer.Deserialize<ChatData>(resp);
                    var message = new ChatMessage(data);

                    message.Location = new Point(5, _top);
                    message.LoadButton.Name = _cmName.ToString();
                    NextName();
                    _top += message.Height + 2;

                    var msg = Encoding.UTF8.GetString(resp);
                    Invoke((MethodInvoker)delegate ()
                    {
                        pnlChatMessage.Controls.Add(message);
                        _messages.Add(message);

                        if(message.IsHaveData)
                            message.LoadButton.Click += LoadButton_Click;
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chat 1:" + ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private void NextName()
        {
            _cmName++;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var chatMessage = GetMessage(sender as Button);
                var dataForm = new DataForm(chatMessage);
                dataForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private ChatMessage GetMessage(Button button)
        {
            int i = 0;
            foreach (var message in _messages)
            {
                if (button.Name == i.ToString())
                    return message;
                else
                    i++;
            }
            throw new Exception("Message wasn't found! ChatMessage line 124");
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages["Settings"].Text = "Settings";
            _IsActive = false;
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMessage.Text.Trim())) return;
            if (e.KeyCode == Keys.Enter)
            {
                //Thread thread = new Thread(SendMessage);
                //thread.IsBackground = true;
                //thread.Start();
            }
        }

        private void SendMessage(object data)
        {
            var chatData = data as ChatData;
            try
            {
                var client = new UdpClient();
                //joint multicast group
                client.JoinMulticastGroup(_multicastAddress);
                //creaate endpoint to send our messages
                var sendEp = new IPEndPoint(_multicastAddress, _remotePort);

                var json = JsonSerializer.Serialize(data as ChatData);

                var buf = Encoding.UTF8.GetBytes(json);
                client.Send(buf, buf.Length, sendEp);
                Invoke((MethodInvoker)delegate
                {
                    tbMessage.Text = string.Empty;
                });
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chat 2:" + ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                _path = openFileDialog.FileName;
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cameraForm = new CameraForm())
                {
                    if (cameraForm.ShowDialog() == DialogResult.OK)
                    {
                        _path = cameraForm.ImagePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }


            //    cameraForm.Show();
            //_path = cameraForm.ImagePath;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var fileName = string.Empty;
            var fileContent = string.Empty;
            if (!string.IsNullOrEmpty(_path))
            {
                fileName = Path.GetFileName(_path);
                var bytes = File.ReadAllBytes(_path);      //cnvert to base64
                fileContent = Convert.ToBase64String(bytes);
            }

            var data = new ChatData()
            {
                UserName = tbName.Text.Trim(),
                Message = tbMessage.Text.Trim(),
                FileName = fileName,
                Data = fileContent
            };

            var thread = new Thread(SendMessage);
            thread.IsBackground = true;
            thread.Start(data);


        }
    }
}
