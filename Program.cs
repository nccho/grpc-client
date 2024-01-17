// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7136");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient1" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Greeting Age: " + reply.Age);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();