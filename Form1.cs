using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace HashVerifier
{

    public partial class Form1 : Form
    {
        private int digits_counter;
        private string hash;
        private string lang;
        private string correct_mes;
        private string wrong_mes;
        private string hidden_info= "Twitter：@FortyIX \n Github: FortyIX \n 新浪微博: @说好的3犬呢";
        string select_label_var;
        int length=0;
        int selected_algo;
        

        public Form1()
        {
            InitializeComponent();

            CultureInfo cu = new CultureInfo("en-GB");
            Assembly system_language = Assembly.Load("HashVerifier");
            lang = "HashVerifier.lang." + Thread.CurrentThread.CurrentCulture.Name;
            //Console.WriteLine(currentCulture);
            ResourceManager rm = new ResourceManager(lang, system_language);


            select_label_var= rm.GetString("select_label", cu);
            sele_btn.Text = rm.GetString("select_btn",cu);
            select_label.Text = rm.GetString("select_label", cu);
            inputsha1notice.Text = rm.GetString("input_label", cu);
            progress_panel.Text = rm.GetString("progress_label", cu);
            fileselect_choose_label.Text = rm.GetString("file_progress_label", cu);
            hash_input_label.Text = rm.GetString("hash_input_label", cu);
            verif_btn.Text = rm.GetString("submit_button", cu);
            developer_web_btn.Text = rm.GetString("devloper_info", cu);
            correct_mes = rm.GetString("CorrectMessage", cu);
            wrong_mes = rm.GetString("WrongMessage", cu);
            algo_select_notice.Text = rm.GetString("algo_select_notice", cu);
            label5.Text = rm.GetString("Digits_left", cu);
            select_status.Text = rm.GetString("select_status", cu);
            this.Text = rm.GetString("title",cu);

            verif_btn.Enabled = false;
   　　　　　 input.Enabled = false;
            select_bar.Value = 0;

            digits_counter = 32;
            input.MaxLength = 32;
            counter_label.Text = digits_counter.ToString();

            //MessageBox.Show(currentCulture);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string filePath = openFileDialog1.FileName;
                byte[] tmp = File.ReadAllBytes(filePath);
                //create sha1 hash
                switch(selected_algo){

                    case 1:
                        using (SHA1 SHA1hash = SHA1.Create())
                        {

                            hash = GenerateSha1Hash(SHA1hash, tmp);

                        }
                        


                        break;

                    case 0:
                        using (MD5 md5hash = MD5.Create())
                        {

                            hash = GenerateMd5Hash(md5hash, tmp);

                        }
                       

                        break;

                    case 2:
                        using (SHA256 sha256hash = SHA256.Create())
                        {

                            hash = GenerateSha256Hash(sha256hash, tmp);

                        }
                        

                        break;

                    case 3:
                        using (SHA384 sha384hash = SHA384.Create())
                        {

                            hash = GenerateSha384Hash(sha384hash, tmp);

                        }
                        

                        break;



                }




                select_label.Text = openFileDialog1.SafeFileName;
                select_status.Enabled = true;
                select_status.Checked = true;
                fileselect_choose_label.Checked = true;
                fileselect_choose_label.Enabled = true;
                select_bar.Enabled = false;
                
                input.Enabled = true;
            }
        }




        #region Generating HASH string 

        //function to generate Hash with SHA-1 algorithm
        public string GenerateSha1Hash(SHA1 sha1hash, byte[] source)
        {

            byte[] sha1hashstring = sha1hash.ComputeHash(source);

            StringBuilder String = new StringBuilder();
            for (int i = 0; i < sha1hashstring.Length; i++)
            {
                String.Append(sha1hashstring[i].ToString("x2"));
            }

            return String.ToString();

        }

//function to generate Hash with md5 algorithm

        public string GenerateMd5Hash(MD5 MD5hash, byte[] source)
        {

            byte[] md5hashstring = MD5hash.ComputeHash(source);

            StringBuilder String = new StringBuilder();
            for (int i = 0; i < md5hashstring.Length; i++)
            {
                String.Append(md5hashstring[i].ToString("x2"));
            }

            return String.ToString();

        }

  //function to generate Hash with SHA-256 algorithm

        public string GenerateSha256Hash(SHA256 SHA256hash, byte[] source)
        {

            byte[] SHA25hashstring = SHA256hash.ComputeHash(source);

            StringBuilder String = new StringBuilder();
            for (int i = 0; i < SHA25hashstring.Length; i++)
            {
                String.Append(SHA25hashstring[i].ToString("x2"));
            }

            return String.ToString();

        }


        //function to generate Hash with SHA-384 algorithm
        public string GenerateSha384Hash(SHA384 SHA384hash, byte[] source)
        {

            byte[] sha1hashstring = SHA384hash.ComputeHash(source);

            StringBuilder String = new StringBuilder();
            for (int i = 0; i < sha1hashstring.Length; i++)
            {
                String.Append(sha1hashstring[i].ToString("x2"));
            }

            return String.ToString();

        }


        #endregion

       #region check the input

        public Boolean Verify(string input, string filestring)
        {


            return (input == filestring);

        }

        #endregion



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

            length = input.Text.Length;

            switch (selected_algo)
            {

                case 1:

                    counter_label.Text = (40 - length).ToString();
                    if (progressBar2.Value <= 90)
                    {

                        progressBar2.Value = length * 3;

                    }

                    if (progressBar2.Value > 90)
                    {

                        progressBar2.Value = 90 + (length - 30);

                    }




                    else if (progressBar2.Value == 100)
                    {
                        progressBar2.Value = 100;
                    }
                    break;

                case 0:

                    counter_label.Text = (32 - length).ToString();
                    progressBar2.Value = (length * 3);
                    if (progressBar2.Value == 96)
                    {
                        progressBar2.Value = 100;
                    }

                    break;

                case 2:

                    counter_label.Text = (64 - length).ToString();

                    if (progressBar2.Value <= 54) {

                        progressBar2.Value = length * 3;

                    }

                    if (progressBar2.Value > 54)
                    {
                        
                        progressBar2.Value = 54 + (length-18);
                       
                    }


                    else if (progressBar2.Value == 100)
                    {
                        progressBar2.Value = 100;
                    }
                    break;


                case 3:

                    counter_label.Text = (96 - length).ToString();
                    progressBar2.Value = length;
                    if (progressBar2.Value == 96)
                    {
                        progressBar2.Value = 100;
                    }
                    break;

        

            }





            if (progressBar2.Value == 100)
            {

                hash_input_label.Checked = true;
                hash_input_label.Enabled = true;
                hash_input_label.AutoCheck = false;
                verif_btn.Enabled = true;

            }
            else
            {
                verif_btn.Enabled = false;
                hash_input_label.Checked = false;
                hash_input_label.Enabled = false;
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void verif_btn_Click(object sender, EventArgs e)
        {

            switch (Verify(input.Text, hash)) {

                case true:

                    MessageBox.Show(correct_mes);
                    break;

                case false:
                    MessageBox.Show(wrong_mes);
                    break;

                default:
                    Console.Write("ERRORRRRRRRRRRRRRRRRRR");
                    break;

            }
            
            verif_btn.Enabled = false;
            input.Enabled = false;
            input.Text = "";
            select_bar.Value = 0;
            select_status.Enabled = false;
            select_status.Checked = false;
            fileselect_choose_label.Checked = false;
            fileselect_choose_label.Enabled = false;
            hash_input_label.Checked = false;
            hash_input_label.Enabled = false;
            length = 0;
            select_bar.Enabled = true;
            progressBar2.Value = 0;
            select_label.Text = select_label_var;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CultureInfo cu = new CultureInfo("zh-CN");
            Assembly system_language = Assembly.Load("HashVerifier");
            
            //Console.WriteLine(currentCulture);
            ResourceManager rm = new ResourceManager("HashVerifier.lang.zh-CN", system_language);


            //translating
            sele_btn.Text = rm.GetString("select_btn", cu);
            select_label.Text = rm.GetString("select_label", cu);
            inputsha1notice.Text = rm.GetString("input_label", cu);
            progress_panel.Text = rm.GetString("progress_label", cu);
            fileselect_choose_label.Text = rm.GetString("file_progress_label", cu);
            hash_input_label.Text = rm.GetString("hash_input_label", cu);
            verif_btn.Text = rm.GetString("submit_button", cu);
            developer_web_btn.Text = rm.GetString("devloper_info", cu);
            correct_mes = rm.GetString("CorrectMessage", cu);
            wrong_mes = rm.GetString("WrongMessage", cu);
            algo_select_notice.Text = rm.GetString("algo_select_notice", cu);
            maker_name.Text = rm.GetString("maker_name", cu);
            label5.Text = rm.GetString("Digits_left", cu);
            this.Text = rm.GetString("title", cu);
            select_status.Text = rm.GetString("select_status", cu);
            select_label_var=rm.GetString("select_label", cu);
        }

        private void chengeToEN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CultureInfo cu = new CultureInfo("en-GB");
            Assembly system_language = Assembly.Load("HashVerifier");
           
            //Console.WriteLine(currentCulture);
            ResourceManager rm = new ResourceManager("HashVerifier.lang.en-GB", system_language);


            //translating
            sele_btn.Text = rm.GetString("select_btn", cu);
            select_label.Text = rm.GetString("select_label", cu);
            inputsha1notice.Text = rm.GetString("input_label", cu);
            progress_panel.Text = rm.GetString("progress_label", cu);
            fileselect_choose_label.Text = rm.GetString("file_progress_label", cu);
            hash_input_label.Text = rm.GetString("hash_input_label", cu);
            verif_btn.Text = rm.GetString("submit_button", cu);
            developer_web_btn.Text = rm.GetString("devloper_info", cu);
            correct_mes = rm.GetString("CorrectMessage", cu);
            wrong_mes = rm.GetString("WrongMessage", cu);
            algo_select_notice.Text = rm.GetString("algo_select_notice", cu);
            maker_name.Text= rm.GetString("maker_name", cu);
            label5.Text = rm.GetString("Digits_left", cu);
            this.Text = rm.GetString("title", cu);
            select_status.Text = rm.GetString("select_status", cu);
            select_label_var = rm.GetString("select_label", cu);
        }

        private void developer_web_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://fuzhang.co.uk");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            selected_algo = select_bar.Value;

            switch (selected_algo) { 
            case 1:
                    digits_counter = 40;
                    input.MaxLength = 40;
                    counter_label.Text = digits_counter.ToString();

            break;

                case 0:
                    digits_counter = 32;
                    input.MaxLength = 32;
                    counter_label.Text = digits_counter.ToString();
            break;

                case 2:
                    digits_counter = 64;
                    input.MaxLength = 64;
                    counter_label.Text = digits_counter.ToString();
            break;

                case 3:
                    digits_counter = 96;
                    input.MaxLength = 96;
                    counter_label.Text = digits_counter.ToString();
                 
            break;


            }
        }

        private void inputsha1notice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void fclink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void maker_name_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hidden_info);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
