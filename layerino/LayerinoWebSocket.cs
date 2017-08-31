using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace layerino
{
    class LayerinoWebSocket : WebSocketBehavior
    {
        protected override void OnMessage (MessageEventArgs e)
        {
            if (e.Data == "FRONT_CONNECT")
            {

                Program.layerinoForm.OnClientConnected();
            }
            Send(e.Data);
        }
    }

}
