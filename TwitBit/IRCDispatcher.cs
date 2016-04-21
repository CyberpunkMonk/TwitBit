using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace TwitBit {
    class IRCDispatcher:EventArgs{
        public event Action<string> MessageRecieved;

        public virtual void onChatUpdated(string message) {
            MessageRecieved?.Invoke(message);
        }

        //Manages IRC chat, responsible for handling connection
        //If chat is updated, blink form
        //else, sleep for some time.
        public IRCDispatcher() {

        }

        public void Notify() {
            //Something happened in the chat, inform Form1 (specifically, call blink or page or whatever)

        }

    }
}
