
namespace Chapter5.Model.Page3Model
{

    public enum FurnitureTypes
    {
        Chairs,
        Tables,
        Sofa,
        CupBoards
    }
    public class FurnitureModel
    {          
        public string FurnitureType { get; set; }
        public string FurnitureName { get; set; }
        public string FurniturePrize { get; set; }
        public string FurnitureImage { get; set; }
        public string FurnitureDiscount { get; set; }
    }
}
