namespace ValidadorExpresiones.Models
{
    public class ResultadoValidacion
    {
        public bool EsValido { get; set; }
        public string Mensaje { get; set; }

        public ResultadoValidacion(bool valido, string mensaje)
        {
            EsValido = valido;
            Mensaje = mensaje;
        }
    }
}
