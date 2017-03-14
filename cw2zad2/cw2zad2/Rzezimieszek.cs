using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad2
{
    public class Rzezimieszek:Bohater
    {
        int Energia = 100;
        ERasa Rasa;
        public Rzezimieszek(ERasa R,string I)
        {
            imie = I;
            atak = 25;
            hp = 100;
            Rasa = R;
        }
        public override void BijWroga(Wrog W) {
            if (hp > 0 && W.hp > 0)
                if (Energia > 30)
                {
                    Energia -= 30;
                    W.hp -= this.atak;
                }
                else
                    W.hp -= 5;
            Energia += 5;
        }
        public override int SprawdzHp() { return hp; }
    }
}
