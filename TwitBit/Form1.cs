using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitBit {
    public partial class Form1:Form {
        private TEST _test = null;//Make singleton later
        //private delegate IRCDispatcher _ircDispatcher();//Singleton later
        private IRCDispatcher _ircDispatcher;
        //Form code generated at creation
        DateTime _lastMessage;
        public Form1() {
            InitializeComponent();
            _lastMessage=DateTime.Now;
            _ircDispatcher=new IRCDispatcher();
            _ircDispatcher.MessageRecieved+=OnMessage;//Subscribe _ircDispatcher to OnMessage event
            buttonColor.Click+=(o,e) => _ircDispatcher.onChatUpdated("From Button");
            //buttonColor+=OnMessage;
        }

        public void OnMessage(string message) {
            //Start new thread as blink.
            //blink will change to set color, wait a bit, then go back to normal
            Blink();
        }//When MessageRecieved fires, call Blink();

        /// <summary>
        /// Currently tests field instantiation via textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TESTButton_Click(Object sender,EventArgs e) {
            if(_test==null) {
                _test=new TEST();
            }
            setFromFields();
            updateLabels();
            //_test = new TEST("1.1.1.1",6667,"TESTCHANNEL");
            //updateLabels();
        }



        /// <summary>
        /// Updates debug string
        /// </summary>
        private void updateLabels() {
            if(_test==null) {
                DEBUGLabel.Text="_test not found.";
                return;
            }
            DEBUGLabel.Text=$"Channel: {_test.Channel} - IP: {_test.IP.ToString()} - Port: {_test.Port}";
        }

        /// <summary>
        /// setFromFields passes textbox parameters into _test class
        /// </summary>
        private void setFromFields() {
            if(string.IsNullOrWhiteSpace(textBoxChannel.Text))
                _test.Channel="NOT SET";//ERROR HANDLING LATER
            else
                _test.Channel=textBoxChannel.Text;

            if(string.IsNullOrWhiteSpace(textBoxIP.Text)) {
                _test.IP="NOT SET";
            }
            else
                _test.IP=textBoxIP.Text;
            if(string.IsNullOrWhiteSpace(textBoxPort.Text)) {
                _test.Port=0;//0 if not set
            }
            else
                _test.Port=Int32.Parse(textBoxPort.Text);
        }
        
        /// <summary>
        /// Blink() causes form to blink when message recieved (or on override)
        /// Optimally will sit in its own thread handler to prevent spamming, we'll cross that bridge when we get ther
        /// </summary>
        public void Blink(){
            timerBlink.Enabled=true;
            Form form = this;
            if(form==null) return;//check if null via ?
            if(form.BackColor.Equals(SystemColors.Control))
                form.BackColor=Color.Red;
            else
                form.BackColor=SystemColors.Control;
        }

        private void buttonColor_Click(Object sender,EventArgs e){
            //Consider button click as override to recieved message
            Blink();
            _lastMessage=DateTime.Now;
        }

        private void timerBlink_Tick(Object sender,EventArgs e) {
            if(DateTime.Now - _lastMessage > TimeSpan.FromSeconds(2)) {
                Blink();
                timerBlink.Enabled=false;
            }
        }
    }
}