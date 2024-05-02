namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteBaja(IExpedienteRepositorio repo)
{
    public void Ejecutar(Expediente expediente)
    {
        repo.ExpedienteBaja(expediente);
    }
}
