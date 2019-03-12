using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quobject.SocketIoClientDotNet.Client;
using WMPLib;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WinQueueSpeaker
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player;
        private string socket_server = "http://192.168.1.65:19009";
        private string SplitQueue(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                result += "'" + c;
            }
            return result;

        }
        private void Speak(string text)
        {
            string url = "https://translate.google.com/translate_tts?ie=UTF-8&tl=th-TH&client=tw-ob&q=" + text;
            if (player == null) player = new WindowsMediaPlayer();

            if (player.playState == WMPPlayState.wmppsPlaying) {
               
                return;
            }
            player.URL = url;
            

            player.controls.play();

        }
        private void ShowQueue(string ch,string q,string fullname) {
            this.Text = ch+"..หมายเลข.."+q;
            this.lbShowQueue.Text = ch + "..หมายเลข.." + q;
            this.lbFullName.Text = fullname;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3};port={4}", "192.168.1.65", "hosxp_pcu", "root", "plkdata", "3306");
            var connection = new MySqlConnection(connstring);
            connection.Open();
            var socket = IO.Socket(socket_server);
            socket.On("rx1", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;                  
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '"+q+"' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();                    
                    this.ShowQueue("ช่อง..1",q,(string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" +fullname +"'ที่ช่องจ่ายยา  'ค่ะ");

                });
            });
            socket.On("rx2", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '" + q + "' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();
                    this.ShowQueue("ช่อง..2", q, (string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" + fullname + "'ที่ช่องจ่ายยา '2 'ค่ะ");

                });
            });
            socket.On("rx3", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '" + q + "' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();
                    this.ShowQueue("ช่อง..3", q, (string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" + fullname + "'ที่ช่องจ่ายยา '3 'ค่ะ");

                });
            });

            socket.On("sc1", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '" + q + "' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();
                    this.ShowQueue("โต๊ะ..1", q, (string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" + fullname + "'ที่โต๊ะซักประวัติ '1 'ค่ะ");

                });
            });

            socket.On("sc2", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '" + q + "' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();
                    this.ShowQueue("โต๊ะ..2", q, (string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" + fullname + "'ที่โต๊ะซักประวัติ '2 'ค่ะ");

                });
            });

            socket.On("sc3", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '" + q + "' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();
                    this.ShowQueue("โต๊ะ..3", q, (string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" + fullname + "'ที่โต๊ะซักประวัติ '3 'ค่ะ");

                });
            });

            socket.On("dx1", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '" + q + "' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();
                    this.ShowQueue("ห้อง..1", q, (string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" + fullname + "'ที่ห้องตรวจโรค '1 'ค่ะ");

                });
            });

            socket.On("dx2", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '" + q + "' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();
                    this.ShowQueue("ห้อง..2", q, (string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" + fullname + "'ที่ห้องตรวจโรค '2 'ค่ะ");

                });
            });

            socket.On("dx3", (data) => {
                this.Invoke((MethodInvoker)delegate {
                    string q = (string)data;
                    if (q.Equals("s99999")) return;
                    //string query = "SELECT fullname from ovst_queue_server_dep where depq = '" + q + "' order by date_visit desc limit 1";
                    string query = "SELECT fullname from ovst_queue_server where depq = '" + q + "' order by date_visit desc limit 1";
                    var cmd = new MySqlCommand(query, connection);
                    var fullname = cmd.ExecuteScalar();
                    this.ShowQueue("ห้อง..3", q, (string)fullname);
                    q = this.SplitQueue(q);
                    this.Speak("ขอเชิญหมายเลข " + q + " '" + fullname + "'ที่ห้องตรวจโรค '3 'ค่ะ");

                });
            });

        }

    }
}

