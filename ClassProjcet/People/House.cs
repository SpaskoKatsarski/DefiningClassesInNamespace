namespace ClassProjcet
{
    public class House
    {
        public House(string houseModel, bool isTwoStory)
        {
            this.HouseModel = houseModel;
            this.IsTwoStory = isTwoStory;
        }

        public string HouseModel { get; set; }

        public bool IsTwoStory { get; set; }
    }
}
