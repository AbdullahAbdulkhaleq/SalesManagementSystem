using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;
using SalesManagementSystemServer.Requests;
using System.Threading.Tasks;
using SalesManagementSystemServer.Enum;
using SalesManagementSystemServer.Responses;

namespace SalesManagementSystemServer
{
    public class Server
    {
        private int Port = Properties.Settings.Default.ServerPort;
        private string Ip = Properties.Settings.Default.ServerIP;

        public void Start()
        {
            StartServer();
        }

        private void StartServer()
        {
            TcpListener server = null;

            try
            {
                // Start listening for incoming client requests
                server = new TcpListener(IPAddress.Any, Port);
                server.Start();
                Console.WriteLine("Server started. Listening for incoming connections...");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine($"Connected to {((IPEndPoint)client.Client.RemoteEndPoint).Address}");

                    HandleClient(client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e}");
            }
            finally
            {
                server?.Stop();
            }
        }
/*
        private void HandleClient(TcpClient client)
        {
            try
            {
                // Read the request from the client
                byte[] buffer = new byte[1024];
                int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
                string requestJson = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                var request = JsonConvert.DeserializeObject<Request>(requestJson);

                // Process the request
                var response = ProcessRequest(request);

                // Serialize the response to JSON
                var responseJson = JsonConvert.SerializeObject(response);

                // Send the response back to the client
                byte[] responseBytes = Encoding.UTF8.GetBytes(responseJson);
                client.GetStream().Write(responseBytes, 0, responseBytes.Length);
            }
            catch (Exception e)
            {
                var errorResponse = new ErrorResponse { Message = "An error occurred during request processing." };
                var errorJson = JsonConvert.SerializeObject(errorResponse);
                byte[] errorBytes = Encoding.UTF8.GetBytes(errorJson);
                client.GetStream().Write(errorBytes, 0, errorBytes.Length);
                Console.WriteLine($"An error occurred: {e}");
            }
            finally
            {
                client.Close();
            }
        }*/

        private object ProcessRequest(Request request)
        {
            if (request.Type == ERequestType.GetData)
            {
                string[] data = { "Data 1", "Data 2", "Data 3" };
                return new DataResponse { Data = data };
            }
            else if (request.Type == ERequestType.SetDate)
            {
                // Perform database operations or other tasks to perform an operation
                // ...
                return new OperationResponse { Success = true };
            }
            else
            {
                throw new ArgumentException("Invalid request type.");
            }
        }


         async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;
            string request = string.Empty;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                request += Encoding.ASCII.GetString(buffer, 0, bytesRead);

                if (request.EndsWith("\r\n"))
                {
                    try
                    {
                        // Deserialize the received JSON request
                        var deserializedRequest = JsonConvert.DeserializeObject<Request>(request.Trim());

                        // Perform specific logic based on the request type
                        var response = ProcessRequest(deserializedRequest);

                        // Serialize the response to JSON
                        var serializedResponse = JsonConvert.SerializeObject(response);

                        // Prepare the response
                        byte[] responseBytes = Encoding.ASCII.GetBytes(serializedResponse + "\r\n");

                        // Write the response asynchronously
                        await stream.WriteAsync(responseBytes, 0, responseBytes.Length);
                    }
                    catch (Exception ex)
                    {
                        // Handle and log any exceptions
                        Console.WriteLine($"An error occurred: {ex.Message}");

                        // Prepare an error response
                        var errorResponse = new ErrorResponse { Message = "An error occurred during request processing." };
                        var serializedErrorResponse = JsonConvert.SerializeObject(errorResponse);
                        byte[] errorResponseBytes = Encoding.ASCII.GetBytes(serializedErrorResponse + "\r\n");

                        // Write the error response asynchronously
                        await stream.WriteAsync(errorResponseBytes, 0, errorResponseBytes.Length);
                    }

                    request = string.Empty;
                }
            }

            client.Close();
        }

    }
}