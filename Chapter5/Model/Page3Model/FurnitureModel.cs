
namespace Chapter5.Model.Page3Model
{

    public enum FurnitureTypes
    {
        Chairs,
        Tables,
        Sofa,
        CupBoards
    }
    public class FurnitureTypeModel
    {
        public FurnitureTypes FurnitureType { get; set; }
        public string FurnitureImage { get; set; }
        public int ItemsTotal { get; set; }
    }

    public class FurnitureModel
    {        
        public int FurnitureCount { get;set; }
        public FurnitureTypes FurnitureType { get;set; }
        public string FurnitureName { get; set; }
        public string FurniturePrize { get; set; }
        public string FurnitureImage { get; set; }
        public int FurnitureDiscount { get; set; }  
        public bool OutOfStock { get; set; }
    }
}
