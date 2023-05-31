﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dpresence
{
    class DiscordConnection
    {
        private DiscordRpcClient client;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public void InitPresence(string con)
        {
            client = new DiscordRPC.DiscordRpcClient("1113320553298788433");

            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            // This does not show anything
            //AllocConsole();

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                MessageBox.Show("Now running rich presence", "Successful Connection");
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = "Can someone hug me",
                State = con,
                Assets = new Assets()
                {
                    LargeImageKey = "sub",
                    LargeImageText = "This is not real lol"
                }
            });
        }
    }
}