//using System
using System;
using System.Net;
using System.Windows.Forms;

//using Newtonsoft
using Newtonsoft.Json;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DirectoryShow_wb.Url = new Uri("C:/");
            path_tb.Text = "C:/";

            Api_t.Start();
            Quote();
        }

        public dynamic GetApi(string link)
        {
            string json = "";
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(link);
            }

            return JsonConvert.DeserializeObject<dynamic>(json);
        }

        private void Api_t_Tick(object sender, EventArgs e)
        {
            Quote();
        }

        public void Quote()
        {
            Quote_rtb.Clear();
            var joke = GetApi("https://api.chucknorris.io/jokes/random");
            var picture = GetApi("https://randomfox.ca/floof/");
            Fox_pb.Load(picture.image.ToString());
            Fox_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Quote_rtb.AppendText(joke.value.ToString().Replace("Chuck", "Fox"));
        }

        private void DirectoryShow_wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            path_tb.Text = DirectoryShow_wb.Url.ToString().Replace("file:///", "");
        }

        private void Back_b_Click(object sender, EventArgs e)
        {
            if (DirectoryShow_wb.CanGoBack)
                DirectoryShow_wb.GoBack();
        }

        private void Next_b_Click(object sender, EventArgs e)
        {
            if (DirectoryShow_wb.CanGoForward)
                DirectoryShow_wb.GoBack();
        }
    }
}
