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
                // City                                     // Country
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
            SqlDataReader price = accessDB("SELECT price FROM cost");

            ArrayList cost = new ArrayList();

            for (int i = 0; price.Read(); i++)
            {
                cost.Add(price.GetSqlInt32(0));
            }

            priceTextBox.Text = cost[0].ToString();

            // Set if available or not
            SqlDataReader available = accessDB("SELECT available FROM reservation"/* WHERE next_date_available = " + dateTimePicker.Value.ToString()*/);

            ArrayList available_reservation = new ArrayList();

            for (int i = 0; available.Read(); i++)
            {
                available_reservation.Add(available.GetSqlInt32(0));
            }

            if (available_reservation[0].Equals(1))
            {
                availableTextBox.Text = "Yes";
            }
            else
            {
                SqlDataReader next = accessDB("SELECT next_date_available FROM reservation");

                ArrayList next_available = new ArrayList();

                for (int i = 0; next.Read(); i++)
                {
                    next_available.Add(next.GetSqlString(0));
                }

                availableTextBox.Text = next_available[0].ToString();
            }

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

            // Set if available or not
            SqlDataReader available = accessDB("SELECT available FROM reservation"/* WHERE next_date_available = " + dateTimePicker.Value.ToString()*/);

            ArrayList available_reservation = new ArrayList();

            for (int i = 0; available.Read(); i++)
            {
                available_reservation.Add(available.GetSqlInt32(0));
            }

            if (available_reservation[0].Equals(1))
            {
                availableTextBox.Text = "Yes";
            }
            else
            {
                SqlDataReader next = accessDB("SELECT next_date_available FROM reservation");

                ArrayList next_available = new ArrayList();

                for (int i = 0; next.Read(); i++)
                {
                    next_available.Add(next.GetSqlString(0));
                }

                availableTextBox.Text = next_available[0].ToString();
            }
        }
    }
}
