using System;
using System.Collections.Generic;
using System.Text;


namespace _0sy_intra_02
{
    interface IDrawable
    {
        public abstract void update(delta time : float );
        public abstract void draw();
    }
}
