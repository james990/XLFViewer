using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Collections;



namespace XLFViewer
{
    public partial class Form_Main : Form
    {
        //Declare variables 

        struct TYPE_DATA
        {
            public string sID;
            public string sSource;
            public string sTarget;
        }

        public Form_Main()
        {
            InitializeComponent();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quite?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }


        







        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        //******************************
        // Name: Load_Click
        // Role:
        //******************************
        private void Load_Click(object sender, EventArgs e)
        {

            // Waiting Cursor
            Cursor.Current = Cursors.WaitCursor;

            // Back to normal cursor 
            Cursor.Current = Cursors.Default;
            

       
            //Clear the data from the dataGrid 
            dataGridView_Result.Rows.Clear();

            //Create an ArrayList 
            ArrayList DataList = new ArrayList();


            //Create the XML file path
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\MyProject\XLFViewer\XMLTest.xml");

            XmlNodeList NodeList = document.GetElementsByTagName("trans-unit");


            foreach (XmlNode node in NodeList)
            {  
                string sId = "";
                string sSource = "";
                string sTarget = "";

                //take the Id in sId
                sId = node.Attributes["id"].Value;

                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "source")
                    {
                        //take the source
                        sSource = child.InnerText;
                    }
                    if (child.Name == "target")
                    {
                        //take the target
                        sTarget = child.InnerText;
                    }
                }

                        //add the new data
                        TYPE_DATA data = new TYPE_DATA();
                        data.sSource = sSource;
                        data.sID = sId;
                        data.sTarget = sTarget;
                        DataList.Add(data);
            }

                        //create the table 
                        dataGridView_Result.ColumnCount = 3;
                        dataGridView_Result.Columns[0].Name = "ID";
                        dataGridView_Result.Columns[1].Name = "Source";
                        dataGridView_Result.Columns[2].Name = "Target";
                        foreach (TYPE_DATA data in DataList)
            {              
                        //Enter the information into the table
                        string[] row = new string[] { data.sID , data.sSource ,data.sTarget};
                        dataGridView_Result.Rows.Add(row);               

            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void button_Explore_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = ".xml";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox_Explore.Text = fdlg.FileName;
            }
        }


        

        

        

    }
}

            
            

         