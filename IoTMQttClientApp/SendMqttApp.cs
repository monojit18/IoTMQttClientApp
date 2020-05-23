using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;

namespace IoTMQttClientApp
{
    public static class SendMqttApp
    {

        private static DeviceClient kDeviceClient1 = null;
        private static DeviceClient kDeviceClient2 = null;
        private static DeviceClient kDeviceClient3 = null;
        private static DeviceClient kDeviceClient4 = null;
        private static DeviceClient kDeviceClient5 = null;
        private static DeviceClient kDeviceClient6 = null;
        private static DeviceClient kDeviceClient7 = null;
        private static DeviceClient kDeviceClient8 = null;
        private static DeviceClient kDeviceClient9 = null;
        private static DeviceClient kDeviceClient10 = null;
        private static DeviceClient kDeviceClient11 = null;
        private static DeviceClient kDeviceClient12 = null;
        private static DeviceClient kDeviceClient13 = null;
        private static DeviceClient kDeviceClient14 = null;
        private static DeviceClient kDeviceClient15 = null;
        private static DeviceClient kDeviceClient16 = null;
        private static DeviceClient kDeviceClient17 = null;
        private static DeviceClient kDeviceClient18 = null;
        private static DeviceClient kDeviceClient19 = null;
        private static DeviceClient kDeviceClient20 = null;
        private static DeviceClient kDeviceClient21 = null;
        private static DeviceClient kDeviceClient22 = null;
        private static DeviceClient kDeviceClient23 = null;
        private static DeviceClient kDeviceClient24 = null;
        private static DeviceClient kDeviceClient25 = null;
        private static DeviceClient kDeviceClient26 = null;
        private static DeviceClient kDeviceClient27 = null;
        private static DeviceClient kDeviceClient28 = null;
        private static DeviceClient kDeviceClient29 = null;
        private static DeviceClient kDeviceClient30 = null;
        private static DeviceClient kDeviceClient31 = null;
        private static DeviceClient kDeviceClient32 = null;


        private static Dictionary<string, DeviceClient> kDeviceConnectionDictionary = null;

        private static async Task SendDeviceToCloudMessagesAsync(string messageString,
                                                                    DeviceClient deviceClient)
        {
            
            var message = new Message(Encoding.ASCII.GetBytes(messageString));            
            deviceClient?.SendEventAsync(message);            

        }

        [FunctionName("SendMqttApp")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            log.LogInformation("C# HTTP trigger function processed a request.");

            var deviceIdString = "scef1";
            if (req.Headers.ContainsKey("deviceId"))
                deviceIdString = req.Headers["deviceId"];

            string messageString = await new StreamReader(req.Body).ReadToEndAsync();
            log.LogInformation(messageString);
            
            if (kDeviceClient1 == null)
            {

                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_1");
                kDeviceClient1 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient2 == null)
            {

                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_2");
                kDeviceClient2 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient3 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_3");
                kDeviceClient3 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient4 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_4");
                kDeviceClient4 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient5 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_5");
                kDeviceClient5 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient6 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_6");
                kDeviceClient6 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient7 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_7");
                kDeviceClient7 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient8 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_8");
                kDeviceClient8 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient9 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_9");
                kDeviceClient9 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient10 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_10");
                kDeviceClient10 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient11 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_11");
                kDeviceClient11 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient12 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_12");
                kDeviceClient12 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient13 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_13");
                kDeviceClient13 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient14 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_14");
                kDeviceClient14 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient15 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_15");
                kDeviceClient15 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }


            if (kDeviceClient16 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_16");
                kDeviceClient16 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient17 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_17");
                kDeviceClient17 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient18 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_18");
                kDeviceClient18 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient19 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_19");
                kDeviceClient19 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient20 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_20");
                kDeviceClient20 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient21 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_21");
                kDeviceClient21 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient22 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_22");
                kDeviceClient22 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient23 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_23");
                kDeviceClient23 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient24 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_24");
                kDeviceClient24 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient25 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_25");
                kDeviceClient25 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient26 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_26");
                kDeviceClient26 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient27 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_27");
                kDeviceClient27 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient28 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_28");
                kDeviceClient28 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient29 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_29");
                kDeviceClient29 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient30 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_30");
                kDeviceClient30 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient31 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_31");
                kDeviceClient31 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }

            if (kDeviceClient32 == null)
            {
                var deviceConnString = Environment.GetEnvironmentVariable("CONN_DEVICE_32");
                kDeviceClient32 = DeviceClient.CreateFromConnectionString(deviceConnString,
                                                                        TransportType.Mqtt);
            }       

            if (kDeviceConnectionDictionary == null)
            {

                kDeviceConnectionDictionary = new Dictionary<string, DeviceClient>()
                {

                    ["scef1"] = kDeviceClient1,
                    ["scef2"] = kDeviceClient2,
                    ["scef3"] = kDeviceClient3,
                    ["scef4"] = kDeviceClient4,
                    ["scef5"] = kDeviceClient5,
                    ["scef6"] = kDeviceClient6,
                    ["scef7"] = kDeviceClient7,
                    ["scef8"] = kDeviceClient8,
                    ["scef9"] = kDeviceClient9,
                    ["scef10"] = kDeviceClient10,
                    ["scef11"] = kDeviceClient11,
                    ["scef12"] = kDeviceClient12,
                    ["scef13"] = kDeviceClient13,
                    ["scef14"] = kDeviceClient14,
                    ["scef15"] = kDeviceClient15,
                    ["scef16"] = kDeviceClient16,
                    ["scef17"] = kDeviceClient17,
                    ["scef18"] = kDeviceClient18,
                    ["scef19"] = kDeviceClient19,
                    ["scef20"] = kDeviceClient20,
                    ["scef21"] = kDeviceClient21,
                    ["scef22"] = kDeviceClient22,
                    ["scef23"] = kDeviceClient23,
                    ["scef24"] = kDeviceClient24,
                    ["scef25"] = kDeviceClient25,
                    ["scef26"] = kDeviceClient26,
                    ["scef27"] = kDeviceClient27,
                    ["scef28"] = kDeviceClient28,
                    ["scef29"] = kDeviceClient29,
                    ["scef30"] = kDeviceClient30,
                    ["scef31"] = kDeviceClient31,
                    ["scef32"] = kDeviceClient32

                };

            }

            var deviceClient = kDeviceConnectionDictionary[deviceIdString];
            await SendDeviceToCloudMessagesAsync(messageString, deviceClient);

            log.LogInformation($"Aft:{DateTime.Now.ToLongTimeString()}");
            return new OkObjectResult("OK");

        }
    }
}
