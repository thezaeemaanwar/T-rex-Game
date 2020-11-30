using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopterGame
{
  public interface IPlayer
    {
        int GetScore();
        void GainPoint();
        bool Alive();
        void Kill();
        bool TopScore();
    }
}
