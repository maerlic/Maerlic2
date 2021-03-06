namespace MarcoAerlicRobotWars
{
    public class BattleArena : InterfaceBattleArena
    {
        /// <summary>
        /// Create arena supplying upper x and y cordinates.
        /// Coordinates are zero based
        /// </summary>
        /// <param name="x">Upper x coordinate</param>
        /// <param name="y">Upper y coordinate</param>
        public BattleArena(uint x, uint y)
        {
            this.UpperLatitude = x;
            this.UpperLongitude = y;
        }

        public uint UpperLatitude { get; private set; }
        public uint UpperLongitude { get; private set; }
    }
}