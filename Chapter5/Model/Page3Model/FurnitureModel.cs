
namespace Chapter5.Model.Page3Model
{

    public class FurnitureTypeModel
    {
        public string FurnitureType { get; set; }
        public string FurnitureImage { get; set; }
        public int ItemsTotal { get; set; }
    }

    public class FurnitureModel
    {
        public enum FurnitureTypes
        {
            Chairs,
            Tables,
            Sofa,
            CupBoards
        }
        public string FurnitureType { get;set; }
        public string FurnitureName { get; set; }
        public string FurniturePrize { get; set; }
        public string FurnitureImage { get; set; }
        public string FurnitureDiscount { get; set; }       
    }
}
