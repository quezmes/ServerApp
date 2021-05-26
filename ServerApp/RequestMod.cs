using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public class RequestMod : IModService
    {
        public bool _timeMod = false;
        public bool _toUpperMod = false;

        public string ModifyString(string toModify)
        {

            if (_timeMod) toModify = AddTimeMod(toModify);
            if (_toUpperMod) toModify = AddUpperMod(toModify);

            return toModify;
        }

        public void ModStateEnable(string mod)
        {
            switch (mod.ToLower())
            {
                case "time": 
                    _timeMod = true;
                    break;
                case "toupper":
                    _toUpperMod = true;
                    break;
                default:
                    break;
            }
        }

        private string AddTimeMod(string toModify)
        {
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            return $"{timeSpan} {toModify}";
        }

        private string AddUpperMod(string toModify)
        {
            return toModify.ToUpper();
        }
    }
}
