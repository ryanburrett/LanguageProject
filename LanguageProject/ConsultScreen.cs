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
using MailKit;
using MailKit.Security;
using MimeKit;
using System.Threading;

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
            // checking label length to make sure it displaying a condtion in the summary rtb. better ways to do this more gracefully 
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
                    string rdy_to_print = "Ready to Print";
                    //always is 1st index with current implementation 
                    string current_condition_name = word[1];
                    current_condition_name = current_condition_name.Substring(1);


                    var text = new string[] { current_condition_name, rdy_to_print };
                   
                    var new_condition_submitted_2_listview = new ListViewItem(text);

                    new_condition_submitted_2_listview.SubItems[1].Name = "Status";


                    bool add_text_to_list = manage_dictionary(current_condition_name, consult_screen_search_result_textbox.Rtf);

                    if (add_text_to_list == true)
                    {




                        ready_4_print_listview.Items.Add(new_condition_submitted_2_listview);
                        
                    }
                    else
                    {
                        // this resets the status message to 'ready to print' if the user submits the same condition and the status message was changed
                        //use case for this would be the user printed the summary. wasnt happy with something, changed the summary, resubmitted to print it again. this tells user its 
                        //ready for print again.


                        //needs fixed 
                        ready_4_print_listview.Items.RemoveByKey(current_condition_name);

                      //  int a = ready_4_print_listview.Items.IndexOfKey(current_condition_name);

                        ready_4_print_listview.Items.Add(new_condition_submitted_2_listview);
                        //    string a = ready_4_print_listview.Items[current_condition_name].SubItems["Status"].Text;


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

       

        

        private void get_selected_condition_ready_4_print()
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
        
        //print preview, needs rename 
        private void print_selected_btn_Click(object sender, EventArgs e)
        {
            if (ready_4_print_listview.SelectedItems.Count > 0)
            {

                get_selected_condition_ready_4_print();


                printPreviewDialog2.ShowDialog();
            }

        }

        private void print_selected_document_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
            checkPrint = 0;
        }

        private void print_selected_document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //tweaked code from https://support.microsoft.com/en-us/help/812425

            // get summary ready for print 
            get_selected_condition_ready_4_print();
            // Print the content of RichTextBox. Store the last character printed.
            
            checkPrint = print_waiting_zone_rtb.Print(checkPrint, print_waiting_zone_rtb.TextLength, e);



            // Check for more pages
            if (checkPrint < print_waiting_zone_rtb.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            checkPrint = 0;

            //update ready_4_print listview status 



        }

        private void update_ready_4_print_listview()
        {
            string printed_txt = "Printed";
            ready_4_print_listview.SelectedItems[0].SubItems[1].Text = printed_txt;
           // Console.WriteLine(item);


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
            if (ready_4_print_listview.SelectedItems.Count > 0)
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                    print_selected_document.Print();
            }
        }

        private void ConsultScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            //should wait for tasks to complete here
            //better method than this 
            this.Hide();
            Thread.Sleep(20000);

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

        private string get_email_address_from_other_form()
        {
            string email_address = "";
            using (Send_Email dialogForm = new Send_Email())
            {
                DialogResult send_btn = dialogForm.ShowDialog(this);
                if (send_btn == DialogResult.OK)
                {
                   email_address = dialogForm.get_email();
                }
                else
                {
                    return null;
                }

            }

            return email_address;
        }

        private async void email_summary_btn_Click(object sender, EventArgs e)
        {
            //validation needed also
            // needs to get selected item from list and then get the summary rtf and print it to file and then add pdf file to attachment 

            if (ready_4_print_listview.SelectedItems.Count > 0)
            {


                string file_location = null;
                string email_address = get_email_address_from_other_form();

                if (email_address != null)
                {

                    file_location = format_condtion_for_email();




                    if (file_location != null)
                    {

                        // running asynchronously as the sending of the email stopped program responsiveness until email was completely sent
                        // Task.WaitAll(send_email_task);
                        await Task.Factory.StartNew(() => send_email(email_address, file_location));
                    }
                }




            }

        }

        private void send_email(string email, string file_loc)
        {
            Stream file_stream = File.OpenRead(file_loc);
            
            int port = 587;
            string host = "smtp.gmail.com";
            string username = "ryanburrett17@gmail.com";
            string password = "letcjayhsmlsnfdh";
            string mailFrom = "ryanburrett17@gmail.com";

            // user inputted string
            string mailTo = email;

            string mailTitle = "Condition Summary";
            var mailMessage = new TextPart("plain") { Text = @" 
This message is being generated and sent from an Honours Project called Langauage Simplification for care settings.
                           
Developed by Ryan Burrett (rburrett@dundee.ac.uk) 
Advised by John Arnott (j.l.arnott@dundee.ac.uk)


Attached is the condition summary that you requested. It is in Rich Text Format.


                             " };



            // get attachment for condition
            var attachment = new MimePart("text/rtf", "text/rtf")
            {
                Content = new MimeContent(file_stream),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(file_loc)
            };


            var multipart = new Multipart("mixed");
            multipart.Add(mailMessage);
            multipart.Add(attachment);

            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(mailFrom));
                message.To.Add(new MailboxAddress(mailTo));
                message.Subject = mailTitle;
                message.Body = multipart;

            

            //sending email
            //note that it is using the mailkit smtpclient and NOT .net smtpclient as it is deprecated per microsofts recommendation
            
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect(host, port, SecureSocketOptions.StartTls);
                    client.Authenticate(username, password);


                    

                    client.Send(message);
                    MessageBox.Show("Successfully Sent Email", "Success", MessageBoxButtons.OK,MessageBoxIcon.None);
                    client.Disconnect(true);
                    file_stream.Dispose();
                    File.Delete(file_loc);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error when trying to send the email, try again.", "Email Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                file_stream.Dispose();
                File.Delete(file_loc);
            }
           
        }
        
        

        private string format_condtion_for_email()
        {
            string filepath = ".rtf";
            if (ready_4_print_listview.SelectedItems.Count > 0)
            {
                var item = ready_4_print_listview.SelectedItems[0].Text;
                Console.WriteLine(item);

                int random_num = generate_random_num();

                filepath = item + random_num + ".rtf";

                //get condition summary from dictionary using name

                if (dictionary_conditions.TryGetValue(item, out string summary))
                {

                    try
                    {
                        //writing condition to file which is then read back into program when sending email
                        
                        using (StreamWriter writetext = new StreamWriter(filepath))
                        {
                            writetext.WriteLine(summary);
                        }
                    }
                    catch (Exception)
                    {

                        //if someone emails the same condition before the first email is fully sent, this catch is triggered as the file is currently being used by email
                        //method while sending
                        //as a result a new file isn't written
                        //after the first task is completed, the email method actually reuses the first file that was created as data point
                        //due to the nature of how fast someone has to resend an email to trigger this catch
                        // functionally it actually does not change. the user will recieve 2 emails that are identical in condition summary content.
                        // no user can change a condition fast enough to resend an email and have this catch trigger
                        //
                        // future work would look at an elegant solution in code for this edge use case but for now I am leaving it 
                        Console.WriteLine("Resent the same condtion too fast, unable to write ");
                      
                        //issue was solved by allowing it to access different files by generating random file names 
                    }
                    




                }
            }

            return filepath;
        }

        private int generate_random_num()
        {

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int random_num1 = rnd.Next();
            int random_num2 = rnd.Next();

            int rand = random_num1 + random_num2;



            return rand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_ready_4_print_listview();
        }

        private void txt2speech_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
