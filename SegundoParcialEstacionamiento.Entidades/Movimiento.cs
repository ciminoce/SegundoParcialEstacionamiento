namespace SegundoParcialEstacionamiento.Entidades
{
    public class Movimiento
    {
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSalida { get; set; }
        public int CalcularEstadia()
        {
            if (!HoraSalida.HasValue)
            {
                throw new InvalidOperationException("No se ha registrado la hora de salida.");
            }

            TimeSpan estadia = HoraSalida.Value - HoraEntrada;

            // Aseguramos al menos una hora de estadía
            int horas = Math.Max(1, (int)estadia.TotalHours);

            /* 
             * Si la estadía supera 10 minutos adicionales a la hora completa, sumamos una hora más
             * somos mugres no esperamos mucho
             */
            if (estadia > TimeSpan.FromHours(horas) + TimeSpan.FromMinutes(10))
            {
                horas++;
            }

            return horas;
        }
    }

}
