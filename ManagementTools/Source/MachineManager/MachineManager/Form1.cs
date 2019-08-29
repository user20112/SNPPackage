using SNPService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MachineManager
{
    public partial class Form1 : Form
    {
        private string ENG_DBDataSource;                                                        //Engineering Database Ip Address
        private string ENG_DBUserID;                                                            //Engineering databse user used to comunicate
        private string ENG_DBPassword;                                                          //Engineering databse password used to comunicate
        private string ENG_DBInitialCatalog;                                                    //Engineering Database that we are talking to
        public SqlConnection ENGDBConnection;
        public TopicPublisher Publisher;
        private List<Machine> Machines;

        public Form1()
        {
            InitializeComponent();
            Connect();
            refresh();
        }

        public void Connect()
        {
            ENG_DBDataSource = ConfigurationManager.AppSettings["ENGDBIP"];
            ENG_DBUserID = ConfigurationManager.AppSettings["ENGDBUser"];
            ENG_DBPassword = ConfigurationManager.AppSettings["ENGDBPassword"];
            ENG_DBInitialCatalog = ConfigurationManager.AppSettings["ENGDBDatabase"];
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();//builder to connect to the database
            builder.DataSource = ENG_DBDataSource;                                //pass it the ip username password and starting database
            builder.UserID = ENG_DBUserID;
            builder.Password = ENG_DBPassword;
            builder.InitialCatalog = ENG_DBInitialCatalog;
            ENGDBConnection = new SqlConnection(builder.ConnectionString);       //turn the string into a connection
            ENGDBConnection.Open();
            Publisher = new TopicPublisher(ConfigurationManager.AppSettings["MainTopicName"], ConfigurationManager.AppSettings["BrokerIP"]);//open the connection
        }

        public void refresh()
        {
            Machines = new List<Machine>();
            StringBuilder sqlStringBuilder = new StringBuilder();
            sqlStringBuilder.Append(" USE [" + ConfigurationManager.AppSettings["ENGDBDatabase"] + "] ");//select database
            sqlStringBuilder.Append("select * from MachineInfoTable");  //start loading the command into the string
            string SQLString = sqlStringBuilder.ToString();                             //Convert Builder to string

            using (SqlCommand command = new SqlCommand(SQLString, ENGDBConnection))
            {                                                                           //Comand Time!
                using (IDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Machine machine = new Machine(dr[5].ToString(), dr[1].ToString(), dr[6].ToString(), Convert.ToInt32(dr[4]), Convert.ToInt32(dr[3]), dr[2].ToString(), new List<String>(), Convert.ToInt32(dr[0]));
                        Machines.Add(machine);
                    }
                }
            }
            foreach (Machine machine in Machines)
            {
                sqlStringBuilder = new StringBuilder();
                sqlStringBuilder.Append(" USE [EngDb-" + machine.Line + "] ");//select database
                sqlStringBuilder.Append("SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo." + machine.MachineName + "ShortTimeStatistics')");  //start loading the command into the string
                SQLString = sqlStringBuilder.ToString();                                    //Convert Builder to string
                using (SqlCommand command = new SqlCommand(SQLString, ENGDBConnection))
                {                                                                           //Comand Time!
                    using (IDataReader dr = command.ExecuteReader())
                    {
                        int x = 0;
                        while (dr.Read())
                        {
                            if (x >= 9)
                            {
                                machine.StartingErrors.Add(dr[1].ToString());
                            }
                            x++;
                        }
                    }
                }
            }
            DisplayListView.Clear();
            DisplayListView.Columns.Add("MachineName", -2);
            DisplayListView.Columns.Add("Line", -2);
            DisplayListView.Columns.Add("Plant", -2);
            DisplayListView.Columns.Add("Engineer", -2);
            DisplayListView.Columns.Add("Theo", -2);
            DisplayListView.Columns.Add("SNPID", -2);
            DisplayListView.Columns.Add("Errors", -2);
            foreach (Machine machine in Machines)
            {
                string errorstring = "";
                try
                {
                    foreach (string error in machine.StartingErrors)
                    {
                        errorstring += error + ",";
                    }
                    errorstring = errorstring.Substring(0, errorstring.Length - 1);
                }
                catch
                {
                    errorstring = "";
                }
                DisplayListView.Items.Add(new ListViewItem(new string[7] { machine.MachineName, machine.Line, machine.Plant, machine.Engineer, machine.Theoretical.ToString(), machine.SNPID.ToString(), errorstring }));
            }
            DisplayListView.View = View.Details;
            DisplayListView.ContextMenuStrip = contextMenuStrip1;
            DisplayListView.FullRowSelect = true;
            DisplayListView.MultiSelect = false;
            DisplayListView.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(SelectionChanged);
            DisplayListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void SelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                Machine machine = Machines[GetMachineIndexByName(DisplayListView.SelectedItems[0].SubItems[0].Text, DisplayListView.SelectedItems[0].SubItems[1].Text)];
                MachineIDBox.Text = machine.SNPID.ToString();
                MachineNameBox.Text = machine.MachineName;
                LineBox.Text = machine.Line;
                PlantBox.Text = machine.Plant;
                TheoreticalBox.Text = machine.Theoretical.ToString();
                EngineerBox.Text = machine.Engineer;
                ErrorBox.Text = "";
                foreach (string Error in machine.StartingErrors)
                {
                    ErrorBox.Text += Error + ",";
                }
                ErrorBox.Text = ErrorBox.Text.Substring(0, ErrorBox.Text.Length - 1);
            }
            catch
            {
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)//new
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                            "Confirm Action",
                                            MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    Machine machine = new Machine(PlantBox.Text, MachineNameBox.Text, EngineerBox.Text, Convert.ToInt32(TheoreticalBox.Text), Convert.ToInt32(MachineIDBox.Text), LineBox.Text, new List<String>(), Convert.ToInt32(MachineIDBox.Text));
                    string[] errors = ErrorBox.Text.Split(',');
                    foreach (string error in errors)
                        machine.NewErrors.Add(error);
                    machine.AddNew(Publisher);
                    MessageBox.Show("PacketSent");
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PacketSendFailed ");
                    refresh();
                }
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)//edit
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                         "Confirm Action",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    Machine machine = Machines[GetMachineIndexByName(MachineNameBox.Text, LineBox.Text)];
                    List<string> AllErrors = new List<string>(ErrorBox.Text.Split(','));
                    machine.NewErrors = AllErrors.Except(machine.StartingErrors).ToList();
                    machine.Engineer = EngineerBox.Text;
                    machine.Theoretical = Convert.ToInt32(TheoreticalBox.Text);
                    machine.SNPID = Convert.ToInt32(MachineIDBox.Text);
                    machine.Save(Publisher);

                    MessageBox.Show("PacketSent");
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PacketSendFailed Make sure you have the Machine you would like to edit selected.");
                    refresh();
                }
            }
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)//delete
        {
            var confirmResult3 = MessageBox.Show("Are you sure?",
                                         "Confirm Action",
                                         MessageBoxButtons.YesNo);
            if (confirmResult3 == DialogResult.Yes)
            {
                try
                {
                    Machine machine = Machines[GetMachineIndexByName(MachineNameBox.Text, LineBox.Text)];
                    var confirmResult = MessageBox.Show("Are yo usure you want to delete any machine with the name" + machine.MachineName + "and line " + machine.Line,
                                             "Confirm Delete!!",
                                             MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var confirmResult2 = MessageBox.Show("Are you absolutly sure this will delete all Information for this item.",
                                 "Confirm Delete!!",
                                 MessageBoxButtons.YesNo);
                        if (confirmResult2 == DialogResult.Yes)
                        {
                            machine.Delete(Publisher);
                            MessageBox.Show("PacketSent");
                            refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PacketSendFailedMake sure you have the Machine you would like to delete selected.");
                    refresh();
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult3 = MessageBox.Show("Are you sure?",
                                            "Confirm Action",
                                            MessageBoxButtons.YesNo);
            if (confirmResult3 == DialogResult.Yes)
            {
                try
                {
                    Machine machine = Machines[GetMachineIndexByName(MachineNameBox.Text, LineBox.Text)];
                    var confirmResult = MessageBox.Show("Are yo usure you want to delete any machine with the name" + machine.MachineName + "and line " + machine.Line,
                                             "Confirm Delete!!",
                                             MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var confirmResult2 = MessageBox.Show("Are you absolutly sure this will delete all Information for this item.",
                                 "Confirm Delete!!",
                                 MessageBoxButtons.YesNo);
                        if (confirmResult2 == DialogResult.Yes)
                        {
                            machine.Delete(Publisher);
                            MessageBox.Show("PacketSent");
                            refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PacketSendFailed Make sure you have the Machine you would like to delete selected.");
                    refresh();
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Machine machine = Machines[GetMachineIndexByName(MachineNameBox.Text, LineBox.Text)];
                List<string> AllErrors = new List<string>(ErrorBox.Text.Split(','));
                machine.NewErrors = AllErrors.Except(machine.StartingErrors).ToList();
                machine.Engineer = EngineerBox.Text;
                machine.Theoretical = Convert.ToInt32(TheoreticalBox.Text);
                machine.SNPID = Convert.ToInt32(MachineIDBox.Text);
                machine.Save(Publisher);

                MessageBox.Show("PacketSent");
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PacketSendFailed Make sure you have the Machine you would like to edit selected.");
                refresh();
            }
        }

        public int GetListViewIndexByName(string name, string Line)
        {
            int x = 0;
            foreach (ListViewItem item in DisplayListView.Items)
            {
                if (item.SubItems[0].Text == name && Line == item.SubItems[1].Text)
                {
                    return x;
                }
                x++;
            }
            return x;
        }

        public int GetMachineIndexByName(string name, string Line)
        {
            int x = 0;
            foreach (Machine machine in Machines)
            {
                if (machine.MachineName == name && Line == machine.Line)
                {
                    return x;
                }
                x++;
            }
            return x;
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}