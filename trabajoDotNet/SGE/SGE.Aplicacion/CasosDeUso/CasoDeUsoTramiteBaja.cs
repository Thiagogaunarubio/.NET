namespace SGE.Aplicacion;

public class CasoDeUsoTramiteBaja(ITramiteRepositorio repo)
{
    public void Ejecutar(Tramite tramite)
    {
        repo.TramiteBaja(tramite);
    }
}
