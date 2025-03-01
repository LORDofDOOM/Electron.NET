﻿using ElectronNET.API.Entities;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;

namespace ElectronNET.API
{
    /// <summary>
    /// A BrowserView can be used to embed additional web content into a BrowserWindow. 
    /// It is like a child window, except that it is positioned relative to its owning window. 
    /// It is meant to be an alternative to the webview tag.
    /// </summary>
    public class BrowserView
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; internal set; }

        /// <summary>
        /// Render and control web pages.
        /// </summary>
        public WebContents WebContents { get; internal set; }

        /// <summary>
        /// Resizes and moves the view to the supplied bounds relative to the window.
        /// 
        /// (experimental)
        /// </summary>
        public async Task<Rectangle> GetBoundsAsync()
        {
            var signalrResult = await SignalrSerializeHelper.GetSignalrResultJObject("browserView-getBounds", Id);
            return ((JObject)signalrResult).ToObject<Rectangle>();
        }

        /// <summary>
        /// Set the bounds of the current view inside the window
        /// </summary>
        /// <param name="value"></param>
        public async void SetBounds(Rectangle value)
        {
            await Electron.SignalrElectron.Clients.All.SendAsync("browserView-setBounds", Id, JObject.FromObject(value, _jsonSerializer));
        }

        /// <summary>
        /// BrowserView
        /// </summary>
        internal BrowserView(int id) 
        {
            Id = id;

            // Workaround: increase the Id so as not to conflict with BrowserWindow id
            // the backend detect about the value an BrowserView
            WebContents = new WebContents(id + 1000);
        }

        /// <summary>
        /// (experimental)
        /// </summary>
        /// <param name="options"></param>
        public async void SetAutoResize(AutoResizeOptions options)
        {
            await Electron.SignalrElectron.Clients.All.SendAsync("browserView-setAutoResize", Id, JObject.FromObject(options, _jsonSerializer));
        }

        /// <summary>
        /// Color in #aarrggbb or #argb form. The alpha channel is optional.
        /// 
        /// (experimental)
        /// </summary>
        /// <param name="color">Color in #aarrggbb or #argb form. The alpha channel is optional.</param>
        public async void SetBackgroundColor(string color)
        {
            await Electron.SignalrElectron.Clients.All.SendAsync("browserView-setBackgroundColor", Id, color);
        }

        private JsonSerializer _jsonSerializer = new JsonSerializer()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };
    }
}
