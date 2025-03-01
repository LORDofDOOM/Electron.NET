﻿using ElectronNET.API.Hubs;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronNET.API
{
    public static class SignalrSerializeHelper
    {
        public static async Task<string> GetSignalrResultString(string signalrCommand)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString());

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<string> GetSignalrResultString(string signalrCommand, int parameter1, string parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<string> GetSignalrResultString(string signalrCommand, string parameter1, JObject parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<string> GetSignalrResultString(string signalrCommand, int parameter1, string parameter2, JObject parameter3)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2, parameter3);

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<string> GetSignalrResultString(string signalrCommand, JObject parameter1, JObject parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<string> GetSignalrResultString(string signalrCommand, string parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<string> GetSignalrResultString(string signalrCommand, int parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<string> GetSignalrResultString(string signalrCommand, JObject parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }


        public static async Task<string> GetSignalrResultString(string signalrCommand, JObject parameter1, string parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<string>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesString.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            string result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (string)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesString.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand, string parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand, int parameter1, JObject parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand, int parameter1, JObject parameter2, string parameter3)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2, parameter3);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand, string parameter1, string parameter2, JObject parameter3)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2, parameter3);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand, int parameter1, string parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand, int parameter1, JArray parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }


        public static async Task<bool> GetSignalrResultBool(string signalrCommand, string first, string parameter1, string[] parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), first, parameter1, parameter2);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString());

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand, int parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBool(string signalrCommand, JArray parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<bool> GetSignalrResultBoolParamater(string signalrCommand, string parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesBool.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            bool result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (bool)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesBool.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JObject> GetSignalrResultJObject(string signalrCommand, string parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<JObject>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJObject.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            JObject result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JObject)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJObject.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JObject> GetSignalrResultJObject(string signalrCommand, int parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<JObject>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJObject.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            JObject result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JObject)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJObject.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JObject> GetSignalrResultJObject(string signalrCommand, int parameter1, string parameter2, bool parameter3)
        {
            var taskCompletionSource = new TaskCompletionSource<JObject>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJObject.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2, parameter3);

            JObject result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JObject)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJObject.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }


        public static async Task<JObject> GetSignalrResultJObject(string signalrCommand)
        {
            var taskCompletionSource = new TaskCompletionSource<JObject>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJObject.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString());

            JObject result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JObject)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJObject.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JObject> GetSignalrResultJObject(string signalrCommand, JObject parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<JObject>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJObject.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            JObject result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JObject)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJObject.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JArray> GetSignalrResultJArray(string signalrCommand)
        {
            var taskCompletionSource = new TaskCompletionSource<JArray>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJArray.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString());

            JArray result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JArray)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJArray.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JArray> GetSignalrResultJArrayNoTimeout(string signalrCommand, string parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<JArray>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJArray.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            JArray result;
            try
            {
                var task = taskCompletionSource.Task;
                result = (JArray)await task;
            }
            finally
            {
                Electron.ClientResponsesJArray.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JArray> GetSignalrResultJArray(string signalrCommand, JObject parameter1, JObject parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<JArray>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJArray.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            JArray result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JArray)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJArray.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JArray> GetSignalrResultJArray(string signalrCommand, int parameter1, JObject parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<JArray>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJArray.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            JArray result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JArray)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJArray.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JArray> GetSignalrResultJArray(string signalrCommand, int parameter1, string parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<JArray>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJArray.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            JArray result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JArray)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJArray.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JArray> GetSignalrResultJArray(string signalrCommand, int parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<JArray>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJArray.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            JArray result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JArray)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJArray.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<JArray> GetSignalrResultJArray(string signalrCommand, JObject parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<JArray>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesJArray.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            JArray result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = (JArray)await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesJArray.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<int> GetSignalrResultInt(string signalrCommand)
        {
            var taskCompletionSource = new TaskCompletionSource<int>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesInt.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString());

            int result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesInt.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<int> GetSignalrResultInt(string signalrCommand, int parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<int>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesInt.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            int result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesInt.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<int> GetSignalrResultInt(string signalrCommand, string parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<int>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesInt.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            int result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesInt.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<int> GetSignalrResultInt(string signalrCommand, JObject parameter1)
        {
            var taskCompletionSource = new TaskCompletionSource<int>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesInt.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1);

            int result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesInt.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

        public static async Task<int> GetSignalrResultInt(string signalrCommand, JObject parameter1, string parameter2)
        {
            var taskCompletionSource = new TaskCompletionSource<int>();
            var guid = Guid.NewGuid();
            Electron.ClientResponsesInt.TryAdd(guid, taskCompletionSource);
            await Electron.SignalrElectron.Clients.All.SendAsync(signalrCommand, guid.ToString(), parameter1, parameter2);

            int result;
            try
            {
                var task = taskCompletionSource.Task;
                if (await Task.WhenAny(task, Task.Delay(5000)) == task)
                {
                    result = await task;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            finally
            {
                Electron.ClientResponsesInt.TryRemove(guid, out taskCompletionSource);
            }

            return result;
        }

    }
}
