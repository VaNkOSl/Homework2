namespace Homework2.Task_One
{
    public class Point 
    {
        private readonly int[] coordinates;
        private  double  mass;

        public Point()
        {
            this.coordinates = new int[3];
        }

        public int X 
        {
            get => this.coordinates[0];
            set => this.coordinates[0] = value; 
        }

        public int Y
        {
            get => this.coordinates[1]; 
            set => this.coordinates[1] = value; 
        }

        public int Z
        {
            get => this.coordinates[2]; 
            set => this.coordinates[2] = value; 
        }

        public double Mass
        {
            get => this.mass; 
            set => this.mass =  Math.Max(0,value); 
        }

        public double DistanceTo(Point point)
        {
            int deltaX = X - point.X;
            int deltaY = Y - point.Y;
            int deltaZ = Z - point.Z;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }

        public bool IsZero()
        {
            return X == 0 && Y == 0 && Z == 0; 
        }
    }
}
