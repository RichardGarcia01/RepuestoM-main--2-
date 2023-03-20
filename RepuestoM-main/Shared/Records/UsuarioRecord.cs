using RepuestoM.Shared.Records;

namespace RepuestoM.Shared.Records;

public class UsuarioRecord
{
    public UsuarioRecord()
    {

    }
    public UsuarioRecord(int id, UsuarioRollRecords usuarioRol, string name, string nickname, string password)
    {
        Id = Id;
        UsuarioRol = usuarioRol;
        Name = name;
        Nickname = nickname;
        Password = password;
    }

    public int Id { get; set; }
    public virtual UsuarioRollRecords UsuarioRol { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Nickname { get; set; } = null!;
    public string Password { get; set; } = null!;
}


