using System;

namespace PrototypePattern
{
    public class Mouse : IAnimal
    {
        public string Name { get; set; }
        public Mouse()
        {
            Console.WriteLine("Mouse has been created");
            this.Name = "Original";
        }

        public IAnimal Clone()
        {
            Console.WriteLine("Mouse has been cloned");
            Mouse mouseObject = null;

            try
            {
                mouseObject = (Mouse)this.MemberwiseClone();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Clone Failed", ex);
            }

            return mouseObject;
        }
    }
}
