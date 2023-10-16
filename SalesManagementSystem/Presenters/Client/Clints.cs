using Newtonsoft.Json;
using SalesManagementSystem.Presenters.Enum;
using System;
using System.Net.Sockets;
using System.Text;

namespace SalesManagementSystem.Presenters.Client
{

    public class Request
    {
        public RequestType Type { get; set; }
        public object Data { get; set; }
    }

    public class DataResponse
    {
        public string[] Data { get; set; }
    }

    public class OperationResponse
    {
        public bool Success { get; set; }
    }

    public class ErrorResponse
    {
        public string Message { get; set; }
    }

    public class Client
    {
        private const string ServerAddress = "localhost";
        private const int Port = 1234;

        public void Main()
        {
            // Send a sample request to the server
            var request = new Request { Type = RequestType.GetData, Data = "" };
            var response = SendRequest(request);

            // Process the response
            if (response is DataResponse dataResponse)
            {
                Console.WriteLine("Received data:");
                foreach (var data in dataResponse.Data)
                {
                    Console.WriteLine(data);
                }
            }
            else if (response is OperationResponse operationResponse)
            {
                Console.WriteLine("Operation executed successfully.");
            }
            else if (response is ErrorResponse errorResponse)
            {
                Console.WriteLine($"An error occurred: {errorResponse.Message}");
            }
        }

        public static object SendRequest(Request request)
        {
            TcpClient client = null;

            try
            {
                client = new TcpClient(ServerAddress, Port);

                // Serialize the request to JSON
                string requestJson = JsonConvert.SerializeObject(request);

                // Send the request to the server
                byte[] requestBytes = Encoding.UTF8.GetBytes(requestJson);
                client.GetStream().Write(requestBytes, 0, requestBytes.Length);

                // Read the response from the server
                byte[] buffer = new byte[1024];
                int bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
                string responseJson = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // Deserialize the response from JSON
                var response = JsonConvert.DeserializeObject(responseJson);
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e}");
                return new ErrorResponse { Message = "An error occurred during request processing." };
            }
            finally
            {
                client?.Close();
            }
        }
    }
}
