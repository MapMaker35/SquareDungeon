﻿using SquareDungeon.Salas;
using SquareDungeon.Entidades.Mobs;
using SquareDungeon.Entidades.Mobs.Enemigos;
using SquareDungeon.Entidades.Mobs.Jugadores;

using static SquareDungeon.Resources.Resource;

namespace SquareDungeon.Objetos
{
    class PocionLetal : Objeto
    {
        public PocionLetal() : base(1, NOMBRE_POCION_LETAL, DESC_POCION_LETAL) { }

        public override void RealizarAccion(AbstractJugador jugador, AbstractEnemigo enemigo, Sala sala)
        {
            base.RealizarAccion(jugador, enemigo, sala);
            int danCritCom = jugador.GetStatCombate(AbstractMob.INDICE_DANO_CRITICO);
            jugador.AlterarStatCombate(AbstractMob.INDICE_DANO_CRITICO, (int)(danCritCom * 0.3));
        }
    }
}
