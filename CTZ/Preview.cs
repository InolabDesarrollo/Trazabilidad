using MaterialSkin.Controls;
using System;

namespace CTZ
{
    public partial class Preview : MaterialForm
    {
        private string _url;
        private Functions ft = new Functions();

        public Preview()
        {
            //Clase para mostrar una ventana de navegacion para visualizar los links en la aplicación
            InitializeComponent();
        }

        public string GetUrl()
        {
            return _url;
        }

        public void SetUrl(string value)
        {
            _url = value;
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            if (ft.IsValid(GetUrl()))
            {
                webBrowser1.Navigate(GetUrl());
            }
            else
            {
                this.Close();
            }
        }
    }
}