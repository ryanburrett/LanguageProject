using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Net.Mail;

namespace LanguageProject
{
    public partial class ConsultScreen : Form
    {
        List<string> list_of_diseases = new List<string>();

        
        private int checkPrint;
        Dictionary<string, string> dictionary_conditions = new Dictionary<string, string>();


        public ConsultScreen(string disease, List<string> diseases)
        {
            InitializeComponent();
            this.CenterToScreen();
            list_of_diseases = diseases;
            searchbox_consult_screen.Text = disease;
            assign_autocomplete();
            // symbol_list_logic();

            //pull summary data about disease
            get_disease_summary(disease);
            displaying_condition_label.Text = "Displaying Condition: " + disease;
            this.consult_screen_search_result_textbox.DragDrop += new DragEventHandler(this.consult_screen_search_result_textbox_DragDrop);
        }


        public void update_lists(List<string> diseases)
        {
            list_of_diseases = diseases;
            assign_autocomplete();
        }

        public ConsultScreen(List<string> diseases)
        {
            InitializeComponent();
            this.CenterToScreen();
            //list_of_diseases = diseases;

            //  symbol_list_logic();
            this.consult_screen_search_result_textbox.DragDrop += new DragEventHandler(this.consult_screen_search_result_textbox_DragDrop);
            update_lists(diseases);
            assign_autocomplete();
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


        private void tag_search_btn_Click(object sender, EventArgs e)
        {
            //send that tag search away ayy
            //search for any images that have that tag 
            tag_search_btn.Enabled = false;
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

            tag_returns_label.Text = "Images Found: " + number_images_return;

            Console.WriteLine("tagged image length: " + number_images_return);

            //clear current listview elements and display matches to tag search 

            // symbol_listview.Clear();
            tag_search_btn.Enabled = true;

        }

        private void tag_search_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tag_search_btn_Click(sender, e);
            }
        }


        public void get_disease_summary(string disease)
        {

            // select Simple_Summary from language_simplification.diseases where Name = "Diabetes";

            string get_disease_summary = "select * from diseases where Name = '" + disease + "';";
            ConnectDB newConn = new ConnectDB();
            MySqlConnection conn = newConn.connect_db();
            MySqlCommand command = new MySqlCommand(get_disease_summary, conn);

            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list_of_diseases.Add(reader.GetString("Name"));
                //string result = reader.GetString("Simple_Summary");



                byte[] bytes = (byte[])reader["Simple_Summary"];

                Console.WriteLine("byte length ::   " + bytes.Length);

                MemoryStream ms = new MemoryStream(bytes);
                ms.Position = 0;
                Console.WriteLine("STReam memory ::::::  " + ms.Length);

                string content;
                using (StreamReader sr = new StreamReader(ms, Encoding.Default, false))
                {


                    content = sr.ReadToEnd();


                }
                Console.WriteLine("Reading into content for selected condition");
                consult_screen_search_result_textbox.Rtf = content;
            }
        }

        void assign_autocomplete()
        {
            // setting up auto complete using combobox and list of diseases
            var condition_collection = new AutoCompleteStringCollection();
            condition_collection.AddRange(list_of_diseases.ToArray());
            searchbox_consult_screen.AutoCompleteSource = AutoCompleteSource.CustomSource;

            searchbox_consult_screen.AutoCompleteCustomSource = condition_collection;


            //setting up autocomplete for image tags
            Get_Current_Tags get_tag_instance = new Get_Current_Tags();
            List<string> list_of_tags = new List<string>();
            list_of_tags = get_tag_instance.get_tags();

            var tag_collection = new AutoCompleteStringCollection();
            tag_collection.AddRange(list_of_tags.ToArray());
            tag_search_autobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tag_search_autobox.AutoCompleteCustomSource = tag_collection;


        }

        private void consult_search_btn_Click(object sender, EventArgs e)
        {
            string search = searchbox_consult_screen.Text;
            if (list_of_diseases.Contains(search))
            {
                get_disease_summary(search);
                displaying_condition_label.Text = "Displaying Condition: " + search;
            }
            else
            {
                Console.WriteLine("invalid");
                MessageBox.Show("Not Valid Search, Please match search with an autocomplete suggestion.", "Not valid Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void confirm_search_result_btn_Click(object sender, EventArgs e)
        {
            if (consult_screen_search_result_textbox.Text != "" && displaying_condition_label.Text.Length > 21)
            {
                DialogResult result = MessageBox.Show("Confirm you happy with the summary and it is ready to print?", "Confirm Simplified Summary", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    //look for existing text within the summary screen
                    // if existing text is there then combine rtf files and format 
                    // else just append text to rtb
                    //
                    // note that any reference to text is within rtb and includes images, otherwise this would be alot easier...


                    /*   if (string.IsNullOrWhiteSpace(summary_preview_txtbox.Text))
                       {
                           // empty summary preview... add text.
                           string disease_text = consult_screen_search_result_textbox.Rtf;
                           summary_preview_txtbox.Rtf = disease_text;
                       }
                       else
                       {
                           //combine rtf files, to allow multiple submissions to summary box
                           Console.WriteLine("running, combine rtf files...");
                           string current_summary_text = summary_preview_txtbox.Rtf;
                           string new_text = consult_screen_search_result_textbox.Rtf;

                           string combined_rtfs = combine_rtf(current_summary_text, new_text);
                           summary_preview_txtbox.Rtf = combined_rtfs;
                       }

           */


                    //getting the current condition summary that is displayed 
                    string full_label_text = displaying_condition_label.Text;

                    string[] word = full_label_text.Split(':');

                    //always is 1st index with current implementation 
                    string current_condition_name = word[1];
                    current_condition_name = current_condition_name.Substring(1);


                    var text = new string[] { current_condition_name, "Ready to Print" };
                    var add = new ListViewItem(text);


                    bool add_text_to_list = manage_dictionary(current_condition_name, consult_screen_search_result_textbox.Rtf);

                    if (add_text_to_list == true)
                    {




                        ready_4_print_listview.Items.Add(add);

                    }
                    else
                    {
                        Console.WriteLine("i got a match with an already placed condtion");

                    }



                }
            }



        }

        private bool manage_dictionary(string condition_name, string condition_summary)
        {

            //check for already existing dictionary 

            if (dictionary_conditions.ContainsKey(condition_name))
            {
                //condtion already is submitted by user
                dictionary_conditions.Remove(condition_name);
                // adding the same condition name but it will now have the updated summary 
                dictionary_conditions.Add(condition_name, condition_summary);
                Console.WriteLine("deleted and readded a dictionary entry");
                return false;
            }
            else
            {

                dictionary_conditions.Add(condition_name, condition_summary);
                //needs validation to make sure 2 conditions cannot be added twice
                Console.WriteLine("added to dictionary");
                return true;
            }


        }





        private string combine_rtf(string current_summary_text, string new_text)
        {
            // combine rtf files 
            string summary_text = current_summary_text;
            string text_to_add = new_text;



            try
            {


                int firstPar = text_to_add.IndexOf(@"\par");
                int lastPar = text_to_add.LastIndexOf(@"\par") - 1;

                int end_of_summary = summary_text.LastIndexOf("}");

                string formatted_new_text = text_to_add.Substring(firstPar, lastPar - firstPar + 1);

                formatted_new_text = @"\par\par" + formatted_new_text;

                summary_text = summary_text.Insert(end_of_summary, formatted_new_text);

                return summary_text;





            }
            catch (Exception e)
            {
                throw e;
            }





        }

        private void add_new_summary_btn_Click(object sender, EventArgs e)
        {
            NewDisease newDisease = new NewDisease(this);
            newDisease.Show();
            // this.Close();
        }

        private void display_summary_fullscreen_btn_Click(object sender, EventArgs e)
        {
            //launch new form with only patient summary data and display full screen
            string summary = consult_screen_search_result_textbox.Rtf;
            FullScreenPreview full = new FullScreenPreview(summary);
            full.Show();
        }

        private void ConsultScreen_ResizeBegin(object sender, EventArgs e)
        {
            // current_form_height = this.Size.Height;
            // current_textbox_height = consult_screen_search_result_textbox.Height;


        }

        private void ConsultScreen_ResizeEnd(object sender, EventArgs e)
        {
            // int change = this.Size.Height - current_form_height;

            // consult_screen_search_result_textbox.Height += change;

            //  Console.WriteLine("form height change : " + change);
        }

        private void consult_screen_search_result_textbox_SizeChanged(object sender, EventArgs e)
        {
            // current_form_height = this.Size.Height;


        }

        private void print_summary_btn_Click(object sender, EventArgs e)
        {
            // PrintDialog pd = new PrintDialog();

            //  pd.ShowDialog();

            // pageSetupDialog1.ShowDialog();
            checkPrint = 0;
            printPreviewDialog1.ShowDialog();



        }


        private void symbol_listview_ItemDrag(object sender, ItemDragEventArgs e)
        {

            //  var image = new ListViewItem();



            DoDragDrop(e.Item, DragDropEffects.Move);
        }



        private void consult_screen_search_result_textbox_DragDrop(object sender, DragEventArgs e)
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
                consult_screen_search_result_textbox.Paste();
                Console.WriteLine("called me");
            }

            Clipboard.SetDataObject(originalData);

        }

        private void tag_search_txtbox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt1 = new ToolTip();
            tt1.SetToolTip(tag_search_autobox, "Search for images to add to already created summaries using this searchbox.");
        }

        private void searchbox_consult_screen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt2 = new ToolTip();
            tt2.SetToolTip(searchbox_consult_screen, "Search for a condition, with an already created simplified summary, in this searchbox.");
            //not working

        }

        private void confirm_search_result_btn_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt1 = new ToolTip();
            tt1.SetToolTip(confirm_search_result_btn, "This button confirms you are happy with the summary and will send it to be printed.");
        }



        private void menuItem5_Click(object sender, EventArgs e)
        {
            NewDisease newDisease = new NewDisease(this);
            newDisease.Show();
            // this.Close();
        }

        private void add_external_image_menu_item_Click(object sender, EventArgs e)
        {
            InsertNewImageDB newImage = new InsertNewImageDB();
            newImage.Show();
        }

        private void about_menu_item_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Developed By: Ryan Burrett." + "  " + "Email: rburrett@dundee.ac.uk with any questions/issues. ", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkPrint = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print the content of RichTextBox. Store the last character printed.
            checkPrint = consult_screen_search_result_textbox.Print(checkPrint, consult_screen_search_result_textbox.TextLength, e);



            // Check for more pages
            if (checkPrint < consult_screen_search_result_textbox.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

        }

        private void print_selected_btn_Click(object sender, EventArgs e)
        {

            if (ready_4_print_listview.SelectedItems.Count > 0)
            {
                var item = ready_4_print_listview.SelectedItems[0].Text;

                Console.WriteLine(item);

                //get condition summary from dictionary using name

                if (dictionary_conditions.TryGetValue(item, out string summary))
                {
                    //assign it to an invisible rtb



                    print_waiting_zone_rtb.Rtf = summary;
                    // Console.WriteLine(summary);
                }
            }



            checkPrint = 0;
            printPreviewDialog2.ShowDialog();


        }

        private void print_selected_document_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkPrint = 0;
        }

        private void print_selected_document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Print the content of RichTextBox. Store the last character printed.
            checkPrint = print_waiting_zone_rtb.Print(checkPrint, print_waiting_zone_rtb.TextLength, e);



            // Check for more pages
            if (checkPrint < print_waiting_zone_rtb.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;






        }

        private void view_selected_btn_Click(object sender, EventArgs e)
        {

            if (ready_4_print_listview.SelectedItems.Count > 0)
            {
                var item = ready_4_print_listview.SelectedItems[0].Text;
                Console.WriteLine(item);
                //get condition summary from dictionary using name

                if (dictionary_conditions.TryGetValue(item, out string summary))
                {




                    consult_screen_search_result_textbox.Rtf = summary;
                    displaying_condition_label.Text = "Displaying Condition: " + item;

                    // Console.WriteLine(summary);
                }
            }

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (tag_search_groupbox.Visible == false)
            {
                tag_search_groupbox.Visible = true;

                consult_screen_search_result_textbox.ReadOnly = false;
                edit_btn_flash_timer.Stop();
                edit_btn.BackColor = Color.PaleGreen;
                edit_btn.Text = "Click to Disable Edit";

            }
            else
            {
                tag_search_groupbox.Visible = false;

                consult_screen_search_result_textbox.ReadOnly = true;
                edit_btn.BackColor = Color.IndianRed;
                edit_btn.Text = "Click to Enable Edit";
            }
        }

        private void consult_screen_search_result_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConsultScreen_Load(object sender, EventArgs e)
        {

        }

        private void consult_screen_search_result_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (edit_btn.BackColor == Color.IndianRed)
            {
                //make it redder
                edit_btn.BackColor = Color.Red;
            }
            else
            {
                edit_btn.BackColor = Color.IndianRed;
            }
        }

        private void tag_search_autobox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tag_search_btn_Click(sender, e);
            }
        }

        private void edit_btn_flash_timer_Tick(object sender, EventArgs e)
        {

        }

        private void consult_screen_search_result_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (consult_screen_search_result_textbox.ReadOnly == true)
            {


                edit_btn_flash_timer.Start();


                edit_btn_flash_timer.Tick += new EventHandler(timer_Tick);





            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                print_selected_document.Print();
        }

        private void ConsultScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void edit_btn_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void edit_btn_MouseLeave(object sender, EventArgs e)
        {
            if (edit_btn.Text.Equals("Click to Enable Edit"))
            {
                edit_btn.BackColor = Color.IndianRed;
            }
            else
            {
                edit_btn.BackColor = Color.PaleGreen;
            }
        }

        private void edit_btn_MouseEnter(object sender, EventArgs e)
        {
            edit_btn.BackColor = Color.LightGray;
        }

        private void email_summary_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("ryanburrett17@gmail.com");
                mail.To.Add("ryanburrett17@gmail.com");
                mail.Subject = "Test Mail - 1";
                mail.Body = "mail with attachment";

             //   Attachment attachment;
              //  attachment = new System.Net.Mail.Attachment("your attachment file");
               // mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");

                SmtpServer.EnableSsl = true;
                
                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
