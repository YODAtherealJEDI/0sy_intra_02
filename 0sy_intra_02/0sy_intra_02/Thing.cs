using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace _0sy_intra_02
{
    class Thing : IDrawable
    {
        public float angle;
        public vector2 position;
        public vector2 velocity;
        public vector2 acceleration;
        public override void update(delta Time : float)
        {

        }
        public virtual void draw()
        {

        }
    }
}
