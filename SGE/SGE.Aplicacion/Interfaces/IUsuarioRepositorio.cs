using SGE.Aplicacion.Entidades;

namespace SGE.Aplicacion.Interfaces
{
    public interface IUsuarioRepositorio
    {
        void registrarUsuario(Usuario unUsuario);
        bool loginUsuario(string correo, string hash);
        List<EPermiso> obtenerPermisosUsuario(int idUsuario);
    }
}