using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using VisualVersionofService;
using VisualVersionofService.Comunications;

namespace MQTT_Test_Batch_Sender
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Disposable> ThingsToDispose;
            ThingsToDispose = new List<Disposable>();
            const string Broker = "tcp://10.197.10.32:61616";
            const string SubTopicName = "SNP.Inbound";
            TopicPublisher MainPublisher;//publishes to the Pac-Light Outbound topic
            MainPublisher = new TopicPublisher(SubTopicName, Broker);
            ThingsToDispose.Add(new Disposable(nameof(MainPublisher), MainPublisher));
            string rootFolder = @"C:\Users\d.paddock\Desktop\";
            string textFile = @"Messages.txt";
            string[] lines=null;
            try
            {
                lines = File.ReadAllLines(rootFolder+textFile);
                foreach (string line in lines)
                {
                    MainPublisher.SendMessage(line);
                    Thread.Sleep(100);
                }
            }
            catch
            {
            }
            foreach (Disposable disposable in ThingsToDispose)
                disposable.Dispose();
        }
    }
}
