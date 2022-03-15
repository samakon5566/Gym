using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            var content = $"{user} 於{DateTime.Now.ToShortTimeString()}說：{message}";
            await Clients.All.SendAsync("ReceiveMessage", content);
        }
        public async Task AddGroup(string groupName, string username)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("RecAddGroupMsg", $"{username} 已加入 聊天：{groupName}。");
        }
        public async Task LeaveGroup(string groupName, string username)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("RecLeaveGroupMsg", $"{username} 已離開 聊天：{groupName}。");
        }
        public Task SendMessageToGroup(string groupName, string username, string message,string userId,string path,string id)
        {
            return Clients.Group(groupName).SendAsync("ReceiveGroupMessage", username,message, DateTime.Now.ToShortTimeString(), userId,path,id);
        }
    }
}