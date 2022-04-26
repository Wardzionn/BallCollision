using Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Model
{
    public class CollisionModel
    {
        public LogicAPI collisionLogic;

        public CollisionModel()
        {
            collisionLogic = new CollisionLogic();
        }
    }
}
