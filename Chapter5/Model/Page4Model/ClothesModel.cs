
namespace Chapter5.Model.Page4Model
{
    public enum Categorys
    {
        All,
        Winter,
        Men,
        Women,
        Sports,
        Other
    }
    public class CategoryModel
    {
        public Categorys Category { get; set; }
    }
    public class ClothesModel
    {
        public string ClothName { get; set; }
        public string ClothPrize { get; set; }
        public string ClothImage { get; set; }
        public Categorys ClothType {  get; set; }
    }
}
