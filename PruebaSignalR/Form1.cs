using Microsoft.AspNetCore.SignalR.Client;

namespace PruebaSignalR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HubConnection hub;
        private async void Form1_Load(object sender, EventArgs e)
        {
            hub = new HubConnectionBuilder()
                .WithUrl("https://octavo.itesrc.net/nombres").
                WithAutomaticReconnect()
                .Build();
            hub.On<string>("NombreNuevo",x =>
            {
                this.BeginInvoke(() => {

                    lstLista.Items.Add(x);
                } );
            });
            await hub.StartAsync();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                 await hub.InvokeAsync("AgregarNombre",txtNombre.Text);
            }
        }
    }
}
