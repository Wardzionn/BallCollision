namespace concProg.Data
{
    public class Sphere
    {
        int x;
        int y;
        int id { get; }

        public Sphere(int spaceSize, int id)
        {
            Random rnd = new Random();
            x = rnd.Next(0, spaceSize);
            y = rnd.Next(0, spaceSize);
            this.id = id;
        }

        public int[] getPos()
        {
            int[] position= new int[2];
            position[0] = x;
            position[1] = y;
            return position;
        }

    }
}