namespace ElonsToys
{
    internal class RemoteControlCar
    {
        private  int distance;
        private  int battery;

        public RemoteControlCar()
        {
            this.distance = 0;
            this.battery = 100;
        }


        internal static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        internal string DistanceDisplay()
        {
            return $"Driven {this.distance} meters";
        }

        internal string BatteryDisplay()
        {
            if(this.battery == 0) { return "Battery empty"; }
            else { return $"Battery at {this.battery}%";}
        }

        internal void Drive()
        {
            if (this.battery > 0) { this.battery--; this.distance += 20; }
        }
    }
}
