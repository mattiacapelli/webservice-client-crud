using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace webservice_client_crud
{
    public partial class Form1 : Form
    {
        public string reqtype;
        public class todo
        {
            public string id;
            public string userId;
            public string title;
            public string completed;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            reqtype = "CREATE";
            lbl_result.Text = "";
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            reqtype = "GET";
            lbl_result.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            reqtype = "UPDATE";
            lbl_result.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            reqtype = "DELETE";
            lbl_result.Text = "";
        }

        private async void btn_request_Click(object sender, EventArgs e)
        {
            switch (reqtype)
            {
                case "GET":

                    if (txt_id.Text != "" && txt_id.Text != null)
                    {
                        using (var httpClient = new HttpClient())
                        {
                            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/" + txt_id.Text);
                            response.EnsureSuccessStatusCode();
                            var responseContent = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(responseContent);

                            todo readed = JsonConvert.DeserializeObject<todo>(responseContent);

                            txt_id.Text = readed.id;
                            txt_userId.Text = readed.userId;
                            txt_title.Text = readed.title;
                            txt_completed.Text = readed.completed;

                            string result = response.StatusCode.ToString();
                            lbl_result.Text = result;
                            Console.WriteLine(result);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserisci i campi richiesti");
                    }

                    break;

                case "CREATE":

                    if (txt_id.Text != "" && txt_userId.Text != "" && txt_title.Text != "" && txt_completed.Text != "")
                    {
                        using (var httpClient = new HttpClient())
                        {
                            var payload = new { id = txt_id.Text, userId = txt_userId.Text, title = txt_title.Text, completed = txt_completed.Text };
                            var content = new StringContent(JsonConvert.SerializeObject(payload), System.Text.Encoding.UTF8, "application/json");
                            var response = await httpClient.PostAsync("https://jsonplaceholder.typicode.com/todos/", content);
                            response.EnsureSuccessStatusCode();
                            var responseContent = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(responseContent);

                            txt_id.Text = txt_userId.Text = txt_title.Text = txt_completed.Text = "";

                            string result = response.StatusCode.ToString();
                            lbl_result.Text = result;
                            Console.WriteLine(result);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserisci i campi richiesti");
                    }

                    break;

                case "DELETE":

                    if (txt_id.Text != "")
                    {
                        using (var httpClient = new HttpClient())
                        {
                            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/" + txt_id.Text);
                            response.EnsureSuccessStatusCode();
                            var responseContent = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(responseContent);

                            string result = response.StatusCode.ToString();
                            lbl_result.Text = result;
                            Console.WriteLine(result);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserisci i campi richiesti");
                    }

                    break;

                case "UPDATE":

                    if (txt_id.Text != "" && txt_userId.Text != "" && txt_title.Text != "" && txt_completed.Text != "")
                    {
                        using (var httpClient = new HttpClient())
                        {
                            var payload = new { id = txt_id.Text, userId = txt_userId.Text, title = txt_title.Text, completed = txt_completed.Text };
                            var content = new StringContent(JsonConvert.SerializeObject(payload), System.Text.Encoding.UTF8, "application/json");
                            var response = await httpClient.PutAsync("https://jsonplaceholder.typicode.com/todos/" + txt_id.Text, content);
                            response.EnsureSuccessStatusCode();
                            var responseContent = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(responseContent);

                            txt_id.Text = txt_userId.Text = txt_title.Text = txt_completed.Text = "";

                            string result = response.StatusCode.ToString();
                            lbl_result.Text = result;
                            Console.WriteLine(result);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserisci i campi richiesti");
                    }

                    break;

                default:
                    MessageBox.Show("Seleziona una richiesta");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_result.Text = "";
        }
    }
}
