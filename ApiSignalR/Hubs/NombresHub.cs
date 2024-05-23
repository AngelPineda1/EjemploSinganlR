using Microsoft.AspNetCore.SignalR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiSignalR.Hubs
{
    public class NombresHub:Hub
    {
       
        public async void AgregarNombre(string nombre)
        {
            // Hacer algo con el nombre
            await Clients.All.SendAsync("NombreNuevo", nombre);

        }

        public async void EliminarNombre(string nombre)
        {
            await Clients.All.SendAsync("NombreBorrado", nombre);
        }

    }
}
