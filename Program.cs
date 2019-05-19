using Amazon;
using Amazon.SageMakerRuntime;
using Amazon.SageMakerRuntime.Model;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ansien.Lab
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Media media = new Media();
            //media["Name"] = "Ansien";
            //media.Id = 0;

            //Console.WriteLine(media.Id);
            //Console.WriteLine(media["Name"]);
            //Console.WriteLine(media.Setting("Name"));

            //string targetString = "2";
            //int? number = targetString.ParseInt();

            //if (number != null)
            //    Console.WriteLine(number);
            //else
            //    Console.WriteLine("Failed to parse a number");

            // * sagemaker testing
            //string result = Encoding.UTF8.GetString(await TestSageMakerEndpoint());
            //Console.WriteLine(result);


            int n = ProcessTestRequest((int a) =>
            {
                a = a + 1;
                return a;
            });

            Console.WriteLine(n);
            Console.ReadKey();
        }

        static async Task<byte[]> TestSageMakerEndpoint()
        {
            string awsAccessKey = "";
            string awsSecretKey = "";

            byte[] content = Encoding.ASCII.GetBytes("{\"instances\": [{\"data\": \"abandon\"}]}");

            InvokeEndpointRequest request = new InvokeEndpointRequest();
            request.Accept = "application/json";
            request.ContentType = "application/json";
            request.Body = new MemoryStream(content);
            request.EndpointName = "Seq2SeqEndpoint-2019-05-09-10-10-22";

            AmazonSageMakerRuntimeClient client = new AmazonSageMakerRuntimeClient(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);
            InvokeEndpointResponse response = await client.InvokeEndpointAsync(request);

            return response.Body.ToArray();
        }


        static int ProcessTestRequest(Func<int, int> handler)
        {
            int a = 1;
            Console.WriteLine(a);

            return handler(a);
        }
    }
}
