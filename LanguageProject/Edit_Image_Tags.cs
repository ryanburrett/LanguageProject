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
        List<int> tag_ids_for_image_on_load = new List<int>();
        List<int> tag_ids_for_image_on_submit = new List<int>();
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
            list_of_tags_checked_listbox.Items.Clear();
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
            int i = 0;
            foreach (int id in image_dictionary.Keys)
            {

                try
                {

                    Image image;
                    image_dictionary.TryGetValue(id, out image);
                    string string_id = id.ToString();
                    symbols.Images.Add(string_id, image);

                    ListViewItem item = new ListViewItem("ID: " + string_id);
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
            //reset the checked tags and lists 
            tag_ids_for_image_on_submit.Clear();
            tag_ids_for_image_on_load.Clear();

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

            
           

            Tag_Map_Query new_map_query = new Tag_Map_Query();
            tag_ids_for_image_on_load = new_map_query.get_all_tags_for_one_image(GLOBAL_selected_image_ID);

            //list of tags for selected image now needs to be compared against tag dictionary which will allow the updating of checked listbox

            List<string> tags_needing_checked = new List<string>();

            foreach (int tag in tag_ids_for_image_on_load)
            {
                try
                {
                    if (tag_dictionary.ContainsKey(tag))
                    {

                        tag_dictionary.TryGetValue(tag, out string tag_name);
                        tags_needing_checked.Add(tag_name);


                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            for (int i = 0; i < list_of_tags_checked_listbox.Items.Count; i++)
            {
                foreach (string tag_name in tags_needing_checked)
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
            Image image = null;

            try
            {
                //checking for a selected image 
                 image = selected_image_picbox.Image;


                
            }
            catch (Exception ex)
            {


                MessageBox.Show("No Image Selected: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            if (image != null)
            {
                tag_ids_for_image_on_submit.Clear();

                // get all selected tags on submit, check for any additions from list and any deletions.

                // get tag name from listbox, do a reverse lookup on dictionary
                Dictionary<string, int> reverse_tag_lookup_table = new Dictionary<string, int>();

                foreach (KeyValuePair<int, string> entry in tag_dictionary)
                {
                    try
                    {
                        reverse_tag_lookup_table.Add(entry.Value, entry.Key);
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    //  Console.WriteLine("reverse_lookup"+reverse_tag_lookup_table.Keys.ToString());
                    // Console.WriteLine("normal tag map"+tag_dictionary.Keys.ToString());

                }


                //get the selected tag ids on submit by using reverse lookup table 
                foreach (object item_checked in list_of_tags_checked_listbox.CheckedItems)
                {
                    string tag_name = item_checked.ToString();

                    reverse_tag_lookup_table.TryGetValue(tag_name, out int tag_id);

                    tag_ids_for_image_on_submit.Add(tag_id);


                }

                //comapre tags on load vs submit and do appropiate db operations 
                compare_tags();
            }
            else
            {
                MessageBox.Show("No Image Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void compare_tags()
        {
            //method used to compare difference in tags lists 

            //if tag is in load list but not submit list then it has been deselected and has to be deleted from database for the selected image 
            // if tag is in submit list and not load list then it is a new addition and has to be added to database for that selected image
            List<uint> ids_to_delete = new List<uint>();
            List<uint> ids_to_add = new List<uint>();



            foreach (int load_id in tag_ids_for_image_on_load)
            {

                if (!tag_ids_for_image_on_submit.Contains(load_id))
                {
                    //converting to uint so it can be queried to databsae without issue
                    uint id = (uint)load_id;
                    // any true result means the id needs to be deleted 
                    Console.WriteLine("DETECTED ID REMOVED " + load_id);
                    ids_to_delete.Add(id);
                }

            }


            foreach (int submit_id in tag_ids_for_image_on_submit)
            {
                if (!tag_ids_for_image_on_load.Contains(submit_id))
                {
                    //converting to uint so it can be queried to databsae without issue
                    uint id = (uint)submit_id;
                    // this is a new tag detected for the image and needs to be added in db
                    Console.WriteLine("TAG WITH ID: "+submit_id+ " ADDED");
                    ids_to_add.Add(id);
                }
            }


            //getting additional tags that are manually type in 
            //getting any additional tags 
            string additional_tags = additional_tags_txtbox.Text;
           
            
                List<string> additional_tag_list = new List<string>(additional_tags.Split(',').ToList<string>());
                //removing whitespace 
                additional_tag_list = additional_tag_list.Select(s => s.Trim()).ToList();

            bool run_additional_tag_logic = true;

            //check for any tags that are equal to additional tags and throw error msg
            foreach (string tag_name in tag_dictionary.Values)
            {
                for (int i = 0; i < additional_tag_list.Count; i++)
                {
                    if (additional_tag_list[i].ToLower().Equals(tag_name.ToLower()))
                    {
                        // detected additional tag that is equal to current tag
                        MessageBox.Show("Additional Tag already exists, please select it from list and try again. Any changes made to the current list have been executed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        run_additional_tag_logic = false;
                    }
                }

            }

            //pass all the lists to be executed on database 
            // method to delete tag ids for said image
            // method to add existing tag ids to selected image 
            // method to add new tags to TAG table and [then add to tap mapping table] - brackets part can be done with method in line above 
            // 

            

            Tag_Map_Query update_mapping = new Tag_Map_Query();
            // removing tags from image
            update_mapping.delete_tag_mapping_for_image(GLOBAL_selected_image_ID, ids_to_delete);

            // adding tags for image 
            update_mapping.add_tag_mapping_for_image(GLOBAL_selected_image_ID, ids_to_add);

            //add new tags to tag table before assigning them to image 
            List<uint> new_tag_ids = new List<uint>();

            if (additional_tag_list[0].Length != 0)
            {
                if (run_additional_tag_logic == true)
                {


                    new_tag_ids = update_mapping.add_new_tags_to_db(additional_tag_list);
                    // adding new tags to tag map for image 
                    update_mapping.add_tag_mapping_for_image(GLOBAL_selected_image_ID, new_tag_ids);
                    // updates list of tags upon click

                    get_ids_and_tags();
                    populate_taglist();
                    check_for_image_tags();
                    
                }

                //clear additional tag box
                additional_tags_txtbox.Clear();
               


            }
            else
            {
                Console.WriteLine("NO ADDITIONAL TAGS TO ADD");
            }
            
            if (run_additional_tag_logic == true)
            {
                MessageBox.Show("Successfully Changed Tags", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
            



        }

        private void delete_image_btn_Click(object sender, EventArgs e)
        {
            /* button to delete the currently selected image
            // need to empty out tag_mapping table 
            // delete image itself from database 

            tag_ids_for_image_on_load is the list of ids we need to delete from database 

            convert list to uint
             */
            List<uint> tag_ids_needing_deletion = new List<uint>();

            foreach (int tag_id in tag_ids_for_image_on_load)
            {
                
                
             //converting to uint so it can be queried to databsae without issue
               uint id = (uint)tag_id;
               
                
               tag_ids_needing_deletion.Add(id);
                
            }

            
            Tag_Map_Query delete_tags = new Tag_Map_Query();
            delete_tags.delete_tag_mapping_for_image(GLOBAL_selected_image_ID, tag_ids_needing_deletion);


            //remove image from database 
            Delete_Image delete_image = new Delete_Image();
            delete_image.delete_image(GLOBAL_selected_image_ID);
        }
    }
}
