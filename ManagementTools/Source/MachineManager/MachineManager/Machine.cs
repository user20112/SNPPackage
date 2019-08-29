using SNPService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MachineManager
{
    public class Machine
    {
        public string Plant;
        public string MachineName;
        public string Engineer;
        public int Theoretical;
        public int SNPID;
        public string Line;
        public List<String> NewErrors;
        public List<String> StartingErrors;
        public int MachineID;

        public Machine(string plant, string machinename, string engineer, int theoretical, int snpid, string line, List<String> errors,int id)
        {
            Plant = plant;
            MachineName = machinename;
            Engineer = engineer;
            Theoretical = theoretical;
            SNPID = snpid;
            Line = line;
            StartingErrors = errors;
            MachineID = id;
            NewErrors = new List<string>();
        }
        public void ClearNewErrors()
        {
            NewErrors.Clear();
        }
        public void Save(TopicPublisher publisher)
        {
            string Message = "ý     { \"Machine\":\"" + MachineName + "\",\"Theo\":\"" + Theoretical.ToString() + "\", \"Line\":\"" + Line + "\", \"Engineer\":\"" + Engineer + "\",\"Errors\": \"";
            foreach (string error in NewErrors)
                Message += error + ",";
            Message = Message.Substring(0, Message.Length - 1);
            Message+= "\"}";
            publisher.SendMessage(Message);
        }
        public void Delete(TopicPublisher publisher)
        {
            publisher.SendMessage("ü     {\"Machine\": \"" + MachineName + "\", \"Line\":\"" + Line + "\"}");
        }
        public void AddNew(TopicPublisher publisher)
        {
            string Message ="þ     { \"Machine\": \"" + MachineName + "\",\"Plant\": \"" + Plant + "\",\"Engineer\": \"" + Engineer + "\",\"Theo\":\"" + Theoretical.ToString() + "\", \"Line\":\"" + Line + "\",\"Errors\": \"";
            foreach (string error in NewErrors)
                Message += error + ",";
            foreach (string error in StartingErrors)
                Message += error + ",";
            Message = Message.Substring(0, Message.Length - 1);
            Message += "\"}";
            publisher.SendMessage(Message);
        }
    }
}
