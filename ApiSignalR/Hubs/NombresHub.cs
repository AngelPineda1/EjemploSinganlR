using Microsoft.AspNetCore.SignalR;

namespace ApiSignalR.Hubs
{
    public class NombresHub:Hub
    {
        public async void AgregarNombre(string nombre)
        {
            // Hacer algo con el nombre
            await Clients.All.SendAsync("NombreNuevo", nombre);

        }


    }
}
