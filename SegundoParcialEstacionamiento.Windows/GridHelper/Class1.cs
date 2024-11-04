using SegundoParcialEstacionamiento.Entidades;

namespace SegundoParcialEstacionamiento.Windows.GridHelper
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(r, dgv);
            }
        }

        private static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Movimiento movimiento:
                    //r.Cells[0].Value = movimiento.Vehiculo!.ToString();
                    //r.Cells[1].Value = movimiento.Vehiculo.GetType().Name;
                    //r.Cells[2].Value = movimiento.HoraEntrada;
                    //r.Cells[3].Value = movimiento.HoraSalida is null ? string.Empty : movimiento.HoraSalida.Value;
                    //r.Cells[4].Value = movimiento.Estadia ?? 0;
                    //r.Cells[5].Value = movimiento.Costo is null ? string.Empty : movimiento.Costo.Value.ToString("C");
                    break;

            }
            r.Tag = obj;
        }

    }

}
