using System.Collections.Generic;
using System.IO;

using static System.Windows.Forms.LinkLabel;

namespace AddressBookFiles
{
    public partial class Form1 : Form
    {
        List<string> address = new List<string>();
        string filePath = @"addressBook.txt";
        public Form1()
        {
            InitializeComponent();
            LoadAddresses();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
        private void LoadAddresses()
        {
            cbxName.Items.Clear(); //clear out old data
            lbxAddress.Items.Clear();
            string line;

            //Open a streamreader  
            using (StreamReader reader = new StreamReader(filePath))

                while ((line = reader.ReadLine()) != null)
                {
                    //add everything to the listbox to see it.
                    lbxAddress.Items.Add(line);
                    address.Add(line);

                    //split the line using the comma and pass it to the string array
                    string[] data = line.Split(',');
                    //add name to combo box
                    cbxName.Items.Add(data[0].Trim());

                }


        }

        private void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string person in address)
            {
                //split each address
                string[] data = person.Split(',');

                //if the address has the name of the person 
                if (data[0].Contains(cbxName.SelectedItem.ToString()))
                {
                    txtPhone.Text = data[1].Trim();
                    txtAddress.Text = data[2].Trim();

                }
            }
        }

        private void btnNewAddress_Click(object sender, EventArgs e)
        {
            string newAddress;

            newAddress = txtName.Text + ", " + txtAddress.Text + ", " + txtPhone.Text;

            // This text is always added, making the file longer over time
            using (StreamWriter writer = new StreamWriter(filePath, true))
                writer.WriteLine(newAddress);


            //load the addresses again
            LoadAddresses();

        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            string deleteThisPerson = "";

            //if there is a selected name
            if (!String.IsNullOrEmpty(cbxName.SelectedItem.ToString()))
            {

                foreach (string person in address)
                {
                    //split each address
                    string[] data = person.Split(',');

                    //if the address has the name of the person 
                    if (data[0].Contains(cbxName.SelectedItem.ToString()))
                    {
                        deleteThisPerson = person;
                        break;
                    }
                }

                address.Remove(deleteThisPerson);

                //delete the existing file
                File.Delete(filePath);

                // Write the filtered lines back to the file
                File.WriteAllLines(filePath, address);

                //load the addresses again
                LoadAddresses();

                //reset address entries
                txtAddress.Text = string.Empty;
                txtPhone.Text = string.Empty;
                cbxName.SelectedIndex = 0;
            }




        }
    }

}
