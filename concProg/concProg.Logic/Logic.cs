using concProg.Data;

namespace concProg.Logic
{
    public class Logic
    {
        public Logic() { }
        public List<Sphere> CreateSpheres(int limits, int number)
        {
            var spheres = new List<Sphere>();

            for (int i = 0; i < number; i++)
            {
                spheres.Add(new Sphere(limits, i));
            }
            return spheres;

        }
    }
}