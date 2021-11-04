namespace PrototypePattern
{
    public class CloneFactory
    {
        public IAnimal GetClone(IAnimal animal)
        {
            return animal.Clone();
        }
    }
}
