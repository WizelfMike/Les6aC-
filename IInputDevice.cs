using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Smash
{

    public interface ICharacterController
    {
        void SetCharacter(icharacter character)
        void Logic(float frametime)
    }

    public interface IInputDevice
    {
        float GetHorizontalAnalog();
        bool IsDown(GameButton button);
    }


}
