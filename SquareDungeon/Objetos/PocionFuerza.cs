﻿
using SquareDungeon.Salas;
using SquareDungeon.Entidades.Mobs;
using SquareDungeon.Entidades.Mobs.Enemigos;
using SquareDungeon.Entidades.Mobs.Jugadores;

using static SquareDungeon.Resources.Resource;

namespace SquareDungeon.Objetos
{
    class PocionFuerza : Objeto
    {
        public PocionFuerza() : base(1, NOMBRE_POCION_FUERZA, DESC_POCION_FUERZA) { }

        public override void RealizarAccion(AbstractJugador jugador, AbstractEnemigo enemigo, Sala sala)
        {
            base.RealizarAccion(jugador, enemigo, sala);
            int fueCom = jugador.GetStatCombate(AbstractMob.INDICE_FUERZA);
            jugador.AlterarStatCombate(AbstractMob.INDICE_FUERZA, (int)(fueCom * 0.2));
        }
    }
}
