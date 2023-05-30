using PetShopAPI.Models;

namespace PetShopAPI.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> GetUsuarios();
        Task<UsuarioModel> GetUsuarioById(int id);
        Task<UsuarioModel> PostUsuario(UsuarioModel usuario);
        Task<UsuarioModel> PutUsuario(UsuarioModel usuario, int id);
        Task<bool> DeleteUsuario(int id);
    }
}
