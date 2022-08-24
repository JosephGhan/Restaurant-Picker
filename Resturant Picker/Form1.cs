using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Resturant_Picker
{
    public partial class Form1 : Form
    {
        public Restaurant[] restaurants;
        public XDocument xmlFile;
        public const string fl = "C:\\Users\\Joe\\source\\repos\\Resturant Picker\\Resturant Picker\\Restaurants.xml";
        public int counter;
        public int max;
        public int user;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load the XML file to an array of Restaurant objects
            //Get Path to XML file
            //string dir = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Restaurants.xml");
            //Load file into an XDocument
            LoadArry();
            //Set status label 
            lblStts.Text = "Loaded XML";

            counter = 0;
            user = 1;
            //Set 
            lblRstrnt.Text = restaurants[counter].Name;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check if the text box has a name
            if (txtNm.Text != "")
            {
                //Add the xml element
                XElement root = new XElement("Rstrnt");
                root.Add(new XAttribute("name", txtNm.Text));
                xmlFile.Element("Rstrnts").Add(root);
                //Save the file$
                xmlFile.Save(fl);
                LoadArry();
                lblStts.Text = "Added new restaurant";
                txtNm.Text = "";
            }
            else
            {
                //show error
                MessageBox.Show("Please enter a restaurant name to add");
            }
        }

        private void LoadArry()
        {
            //File.ReadAllText(dir)
            xmlFile = XDocument.Load(fl);
            //Create query to select Restaurants
            var qry = from c in xmlFile.Elements("Rstrnts").Elements("Rstrnt")
                      select c;
            //Initialize array and counter
            max = qry.Count();
            restaurants = new Restaurant[max];
            int i = 0;
            //Loop through the query and create the array of retaurant objects
            foreach (XElement rstrnt in qry)
            {
                //Set index to new restaurant object with name and both users as false.
                restaurants[i] = new Restaurant(Name = rstrnt.Attribute("name").Value);
                i++;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (user == 1)
                restaurants[counter].Usr1 = true;
            else
                restaurants[counter].Usr2 = true;

            counter++;
            
            CheckMax();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            counter++;

            CheckMax();
           
        }

        private void CheckMax()
        {
            if (counter == max)
            {
                if (user == 1)
                {
                    user = 2;
                    counter = 0;
                    lblTrn.Text = "User 2";
                    lblRstrnt.Text = restaurants[counter].Name;
                }
                else
                    ShowResults();
                
            }
            else
                lblRstrnt.Text = restaurants[counter].Name;
        }

        private void ShowResults()
        {
            foreach (Restaurant rst in restaurants)
            {
                if (rst.Usr1 && rst.Usr2)
                {
                    lstMchd.Items.Add(rst.Name);
                }
            }

            if(lstMchd.Items.Count == 0)
            {
                MessageBox.Show("Yall messed up", "No matches", MessageBoxButtons.OK);
            }

            btnNo.Enabled = false;
            btnYes.Enabled = false;
        }
    }
}
