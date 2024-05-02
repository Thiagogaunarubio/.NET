namespace SGE.Aplicacion;

public class CasoDeUsoTramiteAlta(ITramiteRepositorio repo)
{
    public void Ejecutar(Tramite tramite)
    {
        repo.TramiteAlta(tramite);
    }
}
