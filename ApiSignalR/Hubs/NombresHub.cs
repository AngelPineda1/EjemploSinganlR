using Microsoft.AspNetCore.SignalR;

namespace ApiSignalR.Hubs
{
    public class NombresHub:Hub
    {
        int x = 0;
        public async void AgregarNombre(string nombre)
        {
            // Hacer algo con el nombre
            await Clients.All.SendAsync("NombreNuevo", nombre);

        }

        public async void EliminarNombre(string noombre)
        {
            
        }

    }
}
