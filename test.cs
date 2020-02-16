using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Teacher_program.tests
{
    class Test
    {
        public String url;
        public int id;
        public int countNumbers;
        public int variableTask;
        public List<string[]> text;
        public string urlSound;

        private void playSimpleSound(string urlSound)
        {
            SoundPlayer simpleSound = new SoundPlayer(urlSound);
            simpleSound.Play();
        }

        public bool ExistsCatalog()
        {
            Boolean Exists = false;
            if (Directory.Exists("C:/TestsProgram"))
            {
                Exists = true;
            }
            else
            {
                Directory.CreateDirectory("C:/TestsProgram");
            }

            return Exists;
        }
    }
}
