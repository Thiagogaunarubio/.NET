namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente expediente)
    {
        repo.ExpedienteModificacion(expediente);
    }
}
