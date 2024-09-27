using System.Collections.Generic;
using System.IO;

namespace AddressBookFiles
{
    public partial class Form1 : Form
    {
        List<string> address = new List<string>();
        string fileName = @"addressBook.txt";
        public Form1()
        {
            InitializeComponent();
            LoadArray();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
        private void LoadArray()
        {
            cbxName.Items.Clear(); //clear out old data
            string line;

            //Open a streamreader  
            using (StreamReader reader = new StreamReader(fileName))

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
            using (StreamWriter writer = new StreamWriter(fileName, true))
                writer.WriteLine(newAddress);


        }
    }

}
