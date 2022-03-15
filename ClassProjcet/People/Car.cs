namespace ClassProjcet
{
    public class Car
    {
        public Car(string model, int hP)
        {
            this.Model = model;
            this.HorsePowers = hP;
        }

        public string Model { get; set; }

        public int HorsePowers { get; set; }
    }
}
