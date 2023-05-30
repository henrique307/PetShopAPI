using Microsoft.EntityFrameworkCore;
using PetShopAPI.Data;
using PetShopAPI.Models;
using PetShopAPI.Repositorios.Interfaces;

namespace PetShopAPI.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private SistemaDeTarefasDBContext _dbContext;
        public UsuarioRepositorio(SistemaDeTarefasDBContext sistemaContext)
        {
            _dbContext = sistemaContext;
        }
        public async Task<bool> DeleteUsuario(int id)
        {
            UsuarioModel usuarioPorId = await GetUsuarioById(id);

            _dbContext.Usuarios.Remove(usuarioPorId);
            _dbContext.SaveChanges();

            return true;
        }

        public async Task<UsuarioModel> GetUsuarioById(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id)
                ?? throw new Exception($"Não existe no banco de dados um usuário com o ID:{id}");
        }

        public async Task<List<UsuarioModel>> GetUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> PostUsuario(UsuarioModel usuario)
        {
            _dbContext.Usuarios.Add(usuario);
            _dbContext.SaveChanges();

            return usuario;
        }

        public async Task<UsuarioModel> PutUsuario(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await GetUsuarioById(id);

            usuarioPorId = usuario;

            _dbContext.Update(usuarioPorId);
            _dbContext.SaveChanges();

            return usuarioPorId;
        }


    }
}
