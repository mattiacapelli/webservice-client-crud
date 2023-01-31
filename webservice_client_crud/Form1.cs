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

namespace webservice_client_crud
{
    public partial class Form1 : Form
    {
        public string reqtype;
        public class todo
        {
            string userId { get; set; }
            string id { get; set; }
            string title { get; set; }
            string completed { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            reqtype = "GET";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private async void btn_request_Click(object sender, EventArgs e)
        {
            switch (reqtype)
            {
                case "GET":

                    if(txt_id.Text != "" && txt_id.Text != null)
                    {
                        using (var httpClient = new HttpClient())
                        {
                            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/" + txt_id.Text);
                            response.EnsureSuccessStatusCode();
                            var responseContent = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(responseContent);
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
    }
}
