using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        //Loadlist
        private static Hashtable keyTable = new Hashtable();

        //Perform a check
        public static bool KeyPressed(Keys key) 
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }

        //Detect
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
