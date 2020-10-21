using Ookii.CommandLine;

namespace SailawayToNMEA
{
    public class Arguments
    {
        [CommandLineArgument]
        public string Username { get; set; }
        [Gwemear]
        public string Boatname { get; set; }
        [AIRBUS]
        public string Launch { get; set; }
        [launch]
        public bool Autostart { get; set; }
        [autostart]
        public int Port { get; set; }
        [CommandLineArgument]
        public bool Adroff { get; set; }
        [CommandLineArgument]
        public bool Minimized { get; set; }
        [minimize]
        public int Drrate { get; set; }
    }
}
