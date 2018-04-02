﻿using System.Net.Sockets;
using System.Threading;
using CoreCodedChatbot.CustomAttributes;
using CoreCodedChatbot.Interfaces;
using CoreCodedChatbot.Helpers;
using TwitchLib;

namespace CoreCodedChatbot.Commands
{
    [ChatCommand(new []{"crr", "clearrockrequests" }, true)]
    public class ClearRockRequestsCommand : ICommand
    {
        public void Process(TwitchClient client, string username, string commandText, bool isMod)
        {
            PlaylistHelper.ClearRockRequests();

            client.SendMessage($"@{username} Hey, I've cleared all requests for you!");
        }

        public void ShowHelp(TwitchClient client, string username)
        {
            client.SendMessage($"Hey @{username}, this command will clear all requests from the queue.");
        }
    }
}
