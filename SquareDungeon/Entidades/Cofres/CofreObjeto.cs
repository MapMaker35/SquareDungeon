﻿using SquareDungeon.Objetos;

using static SquareDungeon.Resources.Resource;

namespace SquareDungeon.Entidades.Cofres
{
    class CofreObjeto : Cofre
    {
        public CofreObjeto(Objeto objeto) : base(NOMBRE_COFRE_OBJETO, DESC_COFRE_OBJETO, objeto) { }

        public override Objeto AbrirCofre() => (Objeto)contenido;
    }
}
