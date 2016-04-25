using System;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vacation_database
{
    public partial class Vacation_Database : Form
    {
        public Vacation_Database()
        {
            InitializeComponent();
        }

        private SqlDataReader accessDB(string command)
        {
            // Access the database
            SqlConnection myConnection = new SqlConnection("Server=.\\SQLEXPRESS;" +
                                                            "Database=vacation_database;" +
                                                            "Integrated Security=true;" +
                                                            "connection timeout=15");

            try
            {
                myConnection.Open();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            // Execute the command in the database
            SqlCommand cmd = new SqlCommand(command, myConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = accessDB("SELECT city, country FROM hotel_location");

            ArrayList LocationArray = new ArrayList();

            for (int i = 0; reader.Read(); i++)
            {
                // City                      // Country
                LocationArray.Add(reader.GetString(0) + ", " + reader.GetString(1));
            }

            // Set up an array to start the drop downlist with
            ArrayList SelectLocation = new ArrayList();
            SelectLocation.Add("Select a Location");

            // Sort locations alphabetically
            LocationArray.Sort();
            // Append the list of locations to the select array
            SelectLocation.AddRange(LocationArray);
            // Set the dropdown list
            locationSelect.DataSource = SelectLocation;

            // Initialize picker to tomorrow
            DateTime result = DateTime.Today.Add(TimeSpan.FromDays(1));
            dateTimePicker.Value = result;
        }

        // Cancel button function
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Purchase button function
        private void purchaseButton_Click(object sender, EventArgs e)
        {
            // Thank the user for their purchase in a message box
            MessageBox.Show("Thank you for your purchase",
            "Enjoy your vacation!", MessageBoxButtons.OK);

            // Add code for saving purchase to database (mark as unavailable)


            // Exit the application
            Application.Exit();
        }

        // Location drop-down select function
        private void locationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find currently selected location
            string location = locationSelect.SelectedItem.ToString();

            // Take the location and look up its picture
            try
            {
                locationImage.ImageLocation = location + ".jpg";
            }

            catch (Exception err)
            {
                MessageBox.Show(err.ToString(),
                "Error, unable to change picture", MessageBoxButtons.OK);
            }

            // Set all text boxes with information on selected location

            // Set price
            SqlDataReader reader = accessDB("SELECT price FROM cost");

            ArrayList cost = new ArrayList();

            for (int i = 0; reader.Read(); i++)
            {
                cost.Add(reader.GetSqlInt32(0));
            }

            priceTextBox.Text = cost[0].ToString();

            // Set if available or not
            //if (0)
                availableTextBox.Text = "No";
            //else
            //    availableTextBox.Text = "Yes";

            // Set number of beds
            bedsTextBox.Text = "1";

            // Set hotel rating
            ratingTextBox.Text = "N/A";
        }

        // Date select function
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Convert from string to DateTime
            //string date = "20100102";
            //DateTime datetime = DateTime.ParseExact(date, "yyyyMMdd", CultureInfo.InvariantCulture);

            // Get date selected
            string dateResult = dateTimePicker.Value.ToString();

            // Add code to take date and check the datebase if available
            //if (0)
                availableTextBox.Text = "No";
            //else
            //    availableTextBox.Text = "Yes";
        }
    }
}
