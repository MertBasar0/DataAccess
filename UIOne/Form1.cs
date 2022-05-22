using DataAccess;
using DataAccess.Concrate;
using Entities;

namespace UIOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EFProductDal eFProductDal = new EFProductDal();

            OrderDetailDal orderDetailDal = new OrderDetailDal();

            ProductDetailDal productDetailDal = new ProductDetailDal();

            DbCon db = new DbCon();

            //foreach (Product item in eFProductDal.GetProducts())
            //{
            //    dtl_DataListesi.Items.Add(item.ProductName+" "+item.CategoryID);
            //}

            //foreach (var item in orderDetailDal.GetDetailDtos())
            //{
            //    dtl_DataListesi.Items.Add(item.OrderID+"   "+item.FirstName+"   "+item.CompanyName+"  "+item.OrderDate);
            //}


            //foreach (var item in productDetailDal.GetProductDetail())
            //{
            //    dtl_DataListesi.Items.Add(item.ProductID+"  "+item.ProductName+"  "+item.CategoryName+"  "+item.UnitPrice);
            //}

            //int kategoryId = db.Categories.FirstOrDefault(x => x.CategoryName == "Beverages").CategoryID;


            //db.Products.Add(new Product()
            //{
            //    CategoryID = kategoryId,
            //    ProductName = "HDMI Kablosu",
            //    UnitPrice = 9
            //});
            //db.SaveChanges();

            //�al��anlar�n ad�n� soyad�n�, do�um tarihlerini ve ya��n� getiren bir sorgu yaz�n�z.

            var results = (from x in db.Employees
                          select new
                          {
                              AdiSoyadi = x.FirstName + " " + x.LastName,
                              DogumTarihi = x.BirthDate,
                              Yasi = ((DateTime.Now - x.BirthDate).Days)/365
                          });
            foreach (var item in results)
            {
                dtl_DataListesi.Items.Add(item.AdiSoyadi + "     " + item.DogumTarihi + "     " + item.Yasi);

            }
        }
    }
}