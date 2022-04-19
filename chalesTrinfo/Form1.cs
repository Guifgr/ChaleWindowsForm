using chalesTrinfo.Models;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace chalesTrinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SC1Btn_Click(object sender, EventArgs e)
        {
            Id = 1;
            SetLabels(1);

        }

        private void save_Click(object sender, EventArgs e)
        {
            sucesslbl.Text = "Aguarde";
            sucesslbl.Refresh();
            try
            {
                var request = (HttpWebRequest)WebRequest.Create
                    ($"https://chales-triunfo-api.herokuapp.com/" +
                    $"PostChale/{Id}/{NameTxt.Text}/{PriceTxt.Text}/{ShortDetailTxt.Text}/{InformationTxt.Text}" +
                    "/token");
                request.Method = "GET";
                using var response = (HttpWebResponse)request.GetResponse();
                using var stream = response.GetResponseStream();
                using var streamReader = new StreamReader(stream);
                var contentString = streamReader.ReadToEnd();
                var produto = JsonConvert.DeserializeObject<Product>(contentString);

                NameTxt.Text = produto.Name;
                PriceTxt.Text = produto.Price.ToString();
                ShortDetailTxt.Text = produto.ShortInformation;
                InformationTxt.Text = produto.Information;
                sucesslbl.Text = "Salvo com sucesso";
            }
            catch(Exception ex)
            {
                sucesslbl.Text = "Nenhum chalé selecionado ou Servidor caiu "+ex.Message;
            }
        }

        private void SC2Btn_Click(object sender, EventArgs e)
        {
            Id = 2;
            SetLabels(2);
        }

        private void chaleBtn_Click(object sender, EventArgs e)
        {
            Id = 3;
            SetLabels(3);
        }

        private void WFBtn_Click(object sender, EventArgs e)
        {
            Id = 4;
            SetLabels(4);
        }
        public Product GetProduto(int id)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://chales-triunfo-api.herokuapp.com/getchale/" + id);
            request.Method = "GET";
            using var response = (HttpWebResponse)request.GetResponse();
            using var stream = response.GetResponseStream();
            using var streamReader = new StreamReader(stream);
            var contentString = streamReader.ReadToEnd();
            return JsonConvert.DeserializeObject<Product>(contentString);
        }

        public void SetLabels(int id)
        {
            sucesslbl.Text = "Aguarde";
            sucesslbl.Refresh();
            try
            {
                ChangeBtnColor(id);
                var produto = GetProduto(id);
                NameTxt.Text = produto.Name;
                PriceTxt.Text = produto.Price.ToString();
                ShortDetailTxt.Text = produto.ShortInformation;
                InformationTxt.Text = produto.Information;
                sucesslbl.Text = "Sucesso";
            }
            catch
            {
                sucesslbl.Text = "Servidor caiu, tente novamente!";

            }
        }

        public void ChangeBtnColor(int id)
        {
            SC1Btn.BackColor = Color.White;
            chaleBtn.BackColor = Color.White;
            SC2Btn.BackColor = Color.White;
            WFBtn.BackColor = Color.White;
            switch (id)
            {
                case 1:
                    SC1Btn.BackColor = Color.Red;
                    break;
                case 2:
                    SC2Btn.BackColor = Color.Red;
                    break;
                case 3:
                    chaleBtn.BackColor = Color.Red;
                    break;
                case 4:
                    WFBtn.BackColor = Color.Red;
                    break;
                default:
                    SC1Btn.BackColor = Color.White;
                    chaleBtn.BackColor = Color.White;
                    SC2Btn.BackColor = Color.White;
                    WFBtn.BackColor = Color.White;
                    break;
            }
        }
        public int Id { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
