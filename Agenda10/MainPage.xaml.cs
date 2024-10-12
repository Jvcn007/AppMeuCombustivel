namespace Agenda10
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                string marca = txt_marca_veiculo.Text;
                string modelo = txt_modelo_veiculo.Text;

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando para o seu " + marca + " " + modelo;
                }
                else
                {
                    msg = "A gasolina está compensando para o seu " + marca + " " + modelo;
                }
                DisplayAlert("Calculado" , msg, "OK");

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }







        } // Fecha Método  
    } // Fecha Class
} // Fecha Namespace
