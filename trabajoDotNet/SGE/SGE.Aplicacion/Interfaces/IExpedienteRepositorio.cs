namespace SGE.Aplicacion;


public interface IExpedienteRepositorio
{
    void ExpedienteAlta(Expediente expediente);
    void ExpedienteBaja(Expediente expediente);
    
    //consultaporid
    //consultaportodos

    void ExpedienteModificacion(Expediente expediente);
}
