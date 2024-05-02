namespace SGE.Aplicacion;

public interface ITramiteRepositorio
{
    void TramiteAlta(Tramite tramite);
    void TramiteBaja(Tramite tramite);
    
    //consultaporetiqueta

    void TramiteModificacion(Tramite tramite);
}
