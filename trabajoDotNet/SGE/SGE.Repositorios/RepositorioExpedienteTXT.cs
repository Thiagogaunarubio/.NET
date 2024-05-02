namespace SGE.Repositorios;
using SGE.Aplicacion;

public class RepositorioExpedienteTXT
{
    readonly string _nameArch = "expedientes.txt";
    public void ExpedienteAlta(Expediente expediente)
    {
        using var sw = new StreamWriter(_nameArch, true);
    }
}
