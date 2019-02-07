using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageProject
{
    public partial class InsertNewImageDB : Form
    {
        // element to pull all availible tags, ability to add new tags 
        // button to select image 
        // resize image in app if possible, non essential for first pass

        //insert button 

        List<string> tag_list = new List<string>();

        public InsertNewImageDB()
        {
            InitializeComponent();
            this.CenterToScreen();
            //get current tags 
            Get_Current_Tags current_tags = new Get_Current_Tags();
            tag_list = current_tags.get_tags();
            //set list data to checked listbox
            fill_checkedListbox();
        }

        private void fill_checkedListbox()
        {
            foreach (string tag in tag_list)
            {
                list_of_tags_checked_listbox.Items.Add(tag);
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //send to db 
            // pass image, checked marked tags, any additional tags
            List<string> selected_tags = new List<string>();  
            Bitmap loaded_image = null; //passing this to new form
            //getting image that was loaded
            try
            {
                Image image = pictureBox1.Image;
                loaded_image = new Bitmap(image);  
            }
            catch (Exception ex)
            {


                MessageBox.Show("No Image Selected: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (loaded_image != null)
            {
                //getting checked tags from list
                foreach (object item_checked in list_of_tags_checked_listbox.CheckedItems)
                {
                    selected_tags.Add(item_checked.ToString());

                }
               

                //getting any additional tags 
                string addi_tags = additional_tags_txtbox.Text;

                List<string> addi_tag_list = new List<string>(addi_tags.Split(',').ToList<string>());  
                                                                                                       //removing whitespace 
                addi_tag_list = addi_tag_list.Select(s => s.Trim()).ToList();

               


                //combine lists of tags

                List<string> combined_tag_list = new List<string>();
                combined_tag_list = selected_tags.Concat(addi_tag_list).ToList();
                //combined_tag_list.ForEach(Console.WriteLine);
                if (!combined_tag_list.Any()) {
                    DialogResult result = MessageBox.Show("Confirm you would like to add this image and tags to database", "Confirm Image Addition", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        clear_form(); //to add fucntion
                        Add_Image_To_DB newImage = new Add_Image_To_DB(loaded_image, combined_tag_list);

                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("ADD SOME TAGS SO THE IMAGE IS SEARCHABLE", "ADD TAGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            
           
        }

        private void clear_form()
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            //open file browser

            //opening file browser 
            OpenFileDialog files = new OpenFileDialog();
            files.Filter = "All files |*.*";
            //change filter to images eventually 
            

            if (files.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = files.FileName;
                    Bitmap b = new Bitmap(filename);
                    pictureBox1.Image = b;
                    // look into making size uniform in app
                }
                catch (Exception f)
                {

                    
                    MessageBox.Show("Error Message: " + f.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }

            
        }
    }
}
