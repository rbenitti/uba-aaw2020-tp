﻿namespace Aplicacion.UseCases.Propietario
{
    public class CrearTurneroRequest
    {
        public int IdPropietario { get; set; }
        //public LatLon ubicacion { get; set; }
        public string Ciudad { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }

        public string Concepto { get; set; }
    }
}