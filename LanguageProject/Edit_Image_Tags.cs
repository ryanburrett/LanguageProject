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
    public partial class Edit_Image_Tags : Form
    {

        Dictionary<int, Image> image_dictionary = new Dictionary<int, Image>();
        Dictionary<int, string> tag_dictionary = new Dictionary<int, string>();
        int GLOBAL_selected_image_ID = -1;

        public Edit_Image_Tags()
        {
            InitializeComponent();
            this.CenterToScreen();
            assign_autocomplete();
            get_ids_and_tags();
            populate_taglist();
          //  fill_images_on_load();
        }

        private void populate_taglist()
        {
            //filling list of tags 
            foreach (string tag in tag_dictionary.Values)
            {
                list_of_tags_checked_listbox.Items.Add(tag);
            }
        }

        private void get_ids_and_tags()
        {
            Get_Current_Tags get_tags_and_ids = new Get_Current_Tags();
            tag_dictionary = get_tags_and_ids.get_ids_and_tags();


        }



        private void assign_autocomplete()
        {
            Get_Current_Tags get_tag_instance = new Get_Current_Tags();
            List<string> list_of_tags = new List<string>();
            list_of_tags = get_tag_instance.get_tags();

            var tag_collection = new AutoCompleteStringCollection();
            tag_collection.AddRange(list_of_tags.ToArray());
            tag_search_autobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tag_search_autobox.AutoCompleteCustomSource = tag_collection;
        }

        private void fill_images_on_load()
        {
            symbol_listview.Columns.Add("Symbols", 150);
            symbol_listview.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);


            //populate list
            //get images from db

            ImageList symbols = new ImageList();
            symbols.ImageSize = new Size(125, 125);

            Get_Images_From_DB get_images = new Get_Images_From_DB();


            List<Image> image_list = new List<Image>();
            image_list = get_images.get_all_images();

            foreach (Image image in image_list)
            {

                try
                {
                    symbols.Images.Add(image);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }



            }


            symbol_listview.LargeImageList = symbols;
            Console.WriteLine("symbol count : " + symbols.Images.Count);
            for (int i = 0; i < symbols.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                symbol_listview.Items.Add(item);

            }
        
    }


        private void tag_search_btn_Click(object sender, EventArgs e)
        {
            //send that tag search away ayy
            //search for any images that have that tag 
            tag_search_btn.Enabled = false;
            string search_term = tag_search_autobox.Text;
            

            Get_Images_From_DB get_id_and_image = new Get_Images_From_DB();
            try
            {
                //adding images and their id to dictionary 
                image_dictionary = get_id_and_image.get_id_and_image_by_tag(search_term);
                symbol_listview.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error retrieving images ", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //get tags of neeeded tags

            ImageList symbols = new ImageList();
            symbols.ImageSize = new Size(125, 125);
            symbol_listview.LargeImageList = symbols;
            int i= 0;
            foreach (int id in image_dictionary.Keys)
            {
               
                try
                {

                    Image image;
                    image_dictionary.TryGetValue(id, out image);
                    string string_id = id.ToString();
                    symbols.Images.Add(string_id, image);

                    ListViewItem item = new ListViewItem("ID: "+string_id);
                    item.ImageIndex = i;
                    item.Tag = string_id;
                    symbol_listview.Items.Add(item);
                    i++;



                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }



            }


           // symbol_listview.LargeImageList = symbols;
            
            Console.WriteLine("symbol count : " + symbols.Images.Count);
           

            int number_images_return = image_dictionary.Values.Count();

            tag_returns_label.Text = "Images Found: " + number_images_return;

            Console.WriteLine("tagged image length: " + number_images_return);

            //clear current listview elements and display matches to tag search 

            // symbol_listview.Clear();
            tag_search_btn.Enabled = true;
        }

        private void symbol_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset the checked tags 
            for (int i = 0; i < list_of_tags_checked_listbox.Items.Count; i++)
            {
                list_of_tags_checked_listbox.SetItemChecked(i, false);
            }
            
            //get selected image
            if (symbol_listview.SelectedItems.Count > 0)
            {
                ListViewItem lv = symbol_listview.SelectedItems[0];
                string image_id = lv.Tag.ToString();
                GLOBAL_selected_image_ID = Convert.ToInt32(image_id);
                Console.WriteLine(GLOBAL_selected_image_ID);
                // send currently selected image to picture box
                image_dictionary.TryGetValue(GLOBAL_selected_image_ID, out Image selected_image);

                selected_image_picbox.Image = selected_image;

                //run tag check and update checked listbox to show which tags currently are active on this image 
                check_for_image_tags();
            }

            
           
        }

        private void check_for_image_tags()
        {
            List<int> tag_ids_for_image = new List<int>();


            Tag_Map_Query new_map_query = new Tag_Map_Query();
            tag_ids_for_image = new_map_query.get_all_tags_for_one_image(GLOBAL_selected_image_ID);

            //list of tags for selected image now needs to be compared against tag dictionary which will allow the updating of checked listbox

            List<string> tags_needing_checked = new List<string>();

            foreach (int tag in tag_ids_for_image)
            {
                try
                {   
                    if (tag_dictionary.ContainsKey(tag))
                    {

                        tag_dictionary.TryGetValue(tag, out string tag_name);
                        tags_needing_checked.Add(tag_name);


                    }
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            for(int i = 0; i < list_of_tags_checked_listbox.Items.Count; i++)
            {
                foreach(string tag_name in tags_needing_checked)
                {
                    if (list_of_tags_checked_listbox.Items[i].Equals(tag_name))
                    {
                        //set that tag in list to be checked 
                        list_of_tags_checked_listbox.SetItemChecked(i, true);
                    }
                }
            }


        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            //update tag_map table 

        }
    }
}
