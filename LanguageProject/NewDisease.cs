using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LanguageProject
{
    public partial class NewDisease : Form
    {
        string text;

        public NewDisease()
        {
            InitializeComponent();
            this.CenterToScreen();
           // symbol_list_logic();
            this.summary_txtbox.DragDrop += new DragEventHandler(this.summary_txtbox_DragDrop);
            assign_autocomplete();
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

        private void symbol_list_logic()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            //check for valid input in text boxes

            if (condition_txtbox.Text == "" || summary_txtbox.Text == "")
            {
                // invalid

                MessageBox.Show("Invalid Data, Please make sure you have data in each section.", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //execute commands
                DialogResult dr = MessageBox.Show("Confirm you want to submit this created summary", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.OK)
                {
                    write_to_db();
                }
            }

        }

        private void write_to_db()
        {
            string condition = condition_txtbox.Text;
            string summary = summary_txtbox.Rtf;

            byte[] bytes = Encoding.Default.GetBytes(summary);
            


            MemoryStream ms = new MemoryStream(bytes);

            StreamReader sr = new StreamReader(ms);

            text = sr.ReadToEnd();

            Console.WriteLine(bytes.Length);

            Console.WriteLine("");

            //INSERT INTO `language_simplification`.`diseases` (`Name`, `Simple_Summary`) VALUES ('dd', 'dd');

            //appears to correctly write to database

            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO diseases (Name, Simple_Summary) VALUES (@condition, @summary)";
            command.Parameters.AddWithValue("condition", condition);
            command.Parameters.AddWithValue("summary", bytes);
            command.Connection = conn;

            conn.Open();
            command.ExecuteNonQuery();
                
            conn.Close();
            
            
            
        }

        private void summary_txtbox_TextChanged(object sender, EventArgs e)
        {
            //get text length
           int text_length = summary_txtbox.TextLength;
            //setting progress bar length propertional to text length
            if (text_length <= 100)
            {
                progressBar1.Value = text_length;
            }
            else
            {
                //indicate too much text but perhaps dont hard lock them from submit
                
            }

            //check for word count and display
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            int word_count;
            string[] words = summary_txtbox.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            word_count = words.Length;
            summary_word_count_lebel.Text = "Word Count: " + word_count;

            //checking for long words that are >above certain char count threshold
            int hard_words = 0;
            foreach (string word in words)
            {
                if (word.Length > 7)
                {
                    // any word above 7 characters is considered hard 
                    hard_words++;
                }
            }

            hard_word_label.Text = "Hard Words: " + hard_words;

        }

        private void NewDisease_FormClosing(object sender, FormClosingEventArgs e)
        {
            clean_up();
        }

        private void clean_up()
        {
            //getting a new instance of the current list of conditions/diseases to send  to new consult screen so it is upto date
            List_of_Diseases list = new List_of_Diseases();
            List<string> list_of_diseases = new List<string>();

            list_of_diseases = list.return_list();

          
            ConsultScreen consult = new ConsultScreen(list_of_diseases);
            consult.Show();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void open_file_browser_Click(object sender, EventArgs e)
        {
            //opening file browser 
            OpenFileDialog files = new OpenFileDialog();
            files.Filter = "All files |*.*";
            //copying current clipboard data 
            var originalData = Clipboard.GetDataObject();

            if (files.ShowDialog() == DialogResult.OK)
            {
                //getting file new and setting it to a bitmap and then setting it to active clipboard
                //pasting to richtextbox
                string filename = files.FileName;
                Bitmap b = new Bitmap(filename);
                Clipboard.SetDataObject(b);
                summary_txtbox.Paste();

            }

            //resetting original data of clipboard
            Clipboard.SetDataObject(originalData);

            //to be deleted
            
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            summary_txtbox.Rtf = text;
            //to be deleted

        }

        private void tag_search_btn_Click(object sender, EventArgs e)
        {
            //send that tag search away ayy
            //search for any images that have that tag 

            string search_term = tag_search_autobox.Text;
            List<Image> tagged_images = new List<Image>();

            Get_Images_From_DB get_tagged = new Get_Images_From_DB();
            try
            {
                tagged_images = get_tagged.get_by_tag(search_term);
                symbol_listview.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error retrieving images ", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //get tags of neeeded tags

            ImageList symbols = new ImageList();
            symbols.ImageSize = new Size(125, 125);

            foreach (Image image in tagged_images)
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

            int number_images_return = tagged_images.Count();

            images_found_label.Text = "Images Found: " + number_images_return;

            Console.WriteLine("tagged image length: " + tagged_images.Count);

            //clear current listview elements and display matches to tag search 

           // symbol_listview.Clear();


        }

       

        private void symbol_listview_ItemDrag(object sender, ItemDragEventArgs e)
        {

          //  var image = new ListViewItem();
            


            DoDragDrop(e.Item, DragDropEffects.Move);
        }

      

        private void summary_txtbox_DragDrop(object sender, DragEventArgs e)
        {
            var originalData = Clipboard.GetDataObject();
            Console.WriteLine("called me1");
            ListViewItem img;


            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                img = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                int index = img.ImageIndex;

                Image b = img.ImageList.Images[index];
                
                Clipboard.SetDataObject(b);
                summary_txtbox.Paste();
                Console.WriteLine("called me");
            }

            Clipboard.SetDataObject(originalData);
            
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_images_to_db_menu_item_Click(object sender, EventArgs e)
        {
            InsertNewImageDB newImage = new InsertNewImageDB();
            newImage.Show();
        }

        private void about_menu_item_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Developed By: Ryan Burrett." + "  " + "Email: rburrett@dundee.ac.uk with any questions/issues. ", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exit_program_fully_menu_item_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        

        private void condition_txtbox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt1 = new ToolTip();
            tt1.SetToolTip(condition_txtbox, "This is for the name of the condition for which you are creating the summary for.");

        }

        private void summary_txtbox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt1 = new ToolTip();
            tt1.SetToolTip(summary_txtbox, "This is where to type the simplified summary explaining the condition. You are encouraged to use images and keep difficult words to a minimum.");

        }

        private void tag_search_autobox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tag_search_btn_Click(sender, e);
            }
        }

        private void tag_search_autobox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt1 = new ToolTip();
            tt1.SetToolTip(tag_search_autobox, "This is where to search for images to add to your summary. Search by keyword e.g 'Doctor'.");

        }

        private void tag_search_autobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
