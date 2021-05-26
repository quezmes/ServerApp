using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public class Server
    {
        private IModService _modService = new RequestMod();
        public Server(params string[] modifiers)
        {
            foreach (var mod in modifiers)
            {
                _modService.ModStateEnable(mod);
            }
        }

        public string Process(string request)
        {
            var echo = "echo";
            var reqToLower = request.Trim().ToLower();
            if(reqToLower == "ping")
                return _modService.ModifyString("Pong");
            else if (reqToLower[0..echo.Length] == echo)
            {
                return _modService.ModifyString(request.Substring(echo.Length).Trim());
            }
            return "Bad request!";
        }

        
    }
}
