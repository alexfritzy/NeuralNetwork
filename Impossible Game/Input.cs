using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impossible_Game
{
    class Input
    {
        private HashSet<Keys> input;
        public Input()
        {
            input = new HashSet<Keys>(10);
        }

        public void AddKeyValue(Keys keyCode)
        {
            input.Add(keyCode);
        }

        public void RemoveKeyValue(Keys keyCode)
        {
            input.Remove(keyCode);
        }

        public bool IsPressed(Keys keyCode)
        {
            return input.Contains(keyCode);
        }
    }
}
