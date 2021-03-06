#pragma checksum "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc293144fa4822367aeded2d022e99cfe52d29e9"
// <auto-generated/>
#pragma warning disable 1591
namespace ChatRoom.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
using ChatRoom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chatroom/{_username}")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to the ChatRoom</h1>\r\n<hr>");
#nullable restore
#line 12 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
 if (!_isChatting)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>\r\n        Enter your name to start chatting:\r\n    </p>");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "maxlength", "32");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                              _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                     Chatr(@_username)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "<span class=\"oi oi-chat\" aria-hidden=\"true\"></span> Chat!");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"

    // Error messages
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
     if (_message != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "invalid-feedback");
            __builder.AddContent(14, 
#nullable restore
#line 24 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                       _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "small");
            __builder.AddAttribute(17, "id", "emailHelp");
            __builder.AddAttribute(18, "class", "form-text text-muted");
            __builder.AddContent(19, 
#nullable restore
#line 25 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                                            _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
     
}
else
{
    // banner to show current user

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(22, "role", "alert");
            __builder.AddMarkupContent(23, "<span class=\"oi oi-person mr-2\" aria-hidden=\"true\"></span>\r\n        ");
            __builder.OpenElement(24, "span");
            __builder.AddContent(25, "You are connected as ");
            __builder.OpenElement(26, "b");
            __builder.AddContent(27, 
#nullable restore
#line 33 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                       _username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-sm btn-warning ml-md-auto");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                                                     DisconnectAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Disconnect");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
    // display messages

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "id", "scrollbox");
#nullable restore
#line 38 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
         foreach (var item in _messages)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
             if (item.IsNotice)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "alert alert-info");
            __builder.AddContent(37, 
#nullable restore
#line 42 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                               item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", 
#nullable restore
#line 46 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                             item.CSS

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "user");
            __builder.AddContent(42, 
#nullable restore
#line 47 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                       item.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "msg");
            __builder.AddContent(46, 
#nullable restore
#line 48 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                      item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "<hr>\r\n        ");
            __builder.OpenElement(48, "textarea");
            __builder.AddAttribute(49, "class", "input-lg");
            __builder.AddAttribute(50, "placeholder", "enter your comment");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                                                            _newMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newMessage = __value, _newMessage));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-default");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
                                                    () => SendAsync(_newMessage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\noahl\source\repos\ChatRoom\ChatRoom\Components\Chat.razor"
       
    // flag to indicate chat status
    private bool _isChatting = false;


    
    private string _username;

    protected override async Task OnInitializedAsync()
    {
        _username = httpContextAccessor.HttpContext.User.Identity.Name;
    }
    
    // on-screen message
    private string _message;

    // new message input
    private string _newMessage;

    // list of messages in chat
    private List<Message>
    _messages = new List<Message>
        ();

    private string _hubUrl;
    private HubConnection _hubConnection;

    public async Task Chatr(string _username)
    {

        // check username is valid
        if (string.IsNullOrWhiteSpace(_username))
        {
            _message = "Please enter a name";
            return;
        };

        try
        {
            // Start chatting and force refresh UI.
            _isChatting = true;
            await Task.Delay(1);

            // remove old messages if any
            _messages.Clear();

            // Create the chat client
            string baseUrl = navigationManager.BaseUri;

            _hubUrl = baseUrl.TrimEnd('/') + BlazorChatSampleHub.HubUrl;

            _hubConnection = new HubConnectionBuilder()
            .WithUrl(_hubUrl)
            .Build();

            _hubConnection.On<string, string>
                ("Broadcast", BroadcastMessage);

            await _hubConnection.StartAsync();

            await SendAsync($"[Notice] {_username} joined chat room.");
        }
        catch (Exception e)
        {
            _message = $"ERROR: Failed to start chat client: {e.Message}";
            _isChatting = false;
        }
    }

    private void BroadcastMessage(string name, string message)
    {
        bool isMine = name.Equals(_username, StringComparison.OrdinalIgnoreCase);

        _messages.Add(new Message(name, message, isMine));

        // Inform blazor the UI needs updating
        StateHasChanged();
    }

    private async Task DisconnectAsync()
    {
        if (_isChatting)
        {
            await SendAsync($"[Notice] {_username} left chat room.");

            await _hubConnection.StopAsync();
            await _hubConnection.DisposeAsync();

            _hubConnection = null;
            _isChatting = false;
        }
    }

    private async Task SendAsync(string message)
    {
        if (_isChatting && !string.IsNullOrWhiteSpace(message))
        {
            await _hubConnection.SendAsync("Broadcast", _username, message);

            _newMessage = string.Empty;
        }
    }

    private class Message
    {
    
        public Message(string username, string body, bool mine)
        {
            Username = username;
            Body = body;
            Mine = mine;
        }
        
        public string Username { get; set; }
        public string Body { get; set; }
        public bool Mine { get; set; }
        
        public bool IsNotice => Body.StartsWith("[Notice]");

        public string CSS => Mine ? "sent" : "received";
    }
            

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
