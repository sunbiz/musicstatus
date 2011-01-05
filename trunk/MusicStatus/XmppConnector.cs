using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

using agsXMPP;


namespace MusicStatus
{
    class XmppConnector
    {
        XmppClientConnection xmppCon = new XmppClientConnection();

        public XmppConnector()
        {
            Init();
        }

        public void openConnection()
        {
            Jid jidUser = new Jid("");
            xmppCon.Username = jidUser.User;
            xmppCon.Server = jidUser.Server;
            xmppCon.Password = "";
            xmppCon.AutoResolveConnectServer = true;
            xmppCon.Status = "Music Status - Let the world know your music";
            xmppCon.Open();
        }

        private void Init()
        {
            // Subscribe to Events
            xmppCon.OnLogin += new ObjectHandler(xmppCon_OnLogin);
            xmppCon.OnRosterStart += new ObjectHandler(xmppCon_OnRosterStart);
            xmppCon.OnRosterEnd += new ObjectHandler(xmppCon_OnRosterEnd);
            xmppCon.OnRosterItem += new XmppClientConnection.RosterHandler(xmppCon_OnRosterItem);
            xmppCon.OnPresence += new agsXMPP.protocol.client.PresenceHandler(xmppCon_OnPresence);
            xmppCon.OnAuthError += new XmppElementHandler(xmppCon_OnAuthError);
            xmppCon.OnError += new ErrorHandler(xmppCon_OnError);
            xmppCon.OnClose += new ObjectHandler(xmppCon_OnClose);
            xmppCon.OnMessage += new agsXMPP.protocol.client.MessageHandler(xmppCon_OnMessage);
        }

        void xmppCon_OnMessage(object sender, agsXMPP.protocol.client.Message msg)
        {
            if (msg.Body == null)
                return;
        }

        void xmppCon_OnClose(object sender)
        {
        }

        void xmppCon_OnError(object sender, Exception ex)
        {
        }

        void xmppCon_OnAuthError(object sender, agsXMPP.Xml.Dom.Element e)
        {
        }

        void xmppCon_OnPresence(object sender, agsXMPP.protocol.client.Presence pres)
        {
        }

        void xmppCon_OnRosterItem(object sender, agsXMPP.protocol.iq.roster.RosterItem item)
        {
        }

        void xmppCon_OnRosterEnd(object sender)
        {
        }

        void xmppCon_OnRosterStart(object sender)
        {
        }

        void xmppCon_OnLogin(object sender)
        {
        }
    }
}
