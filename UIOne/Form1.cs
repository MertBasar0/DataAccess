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

            //var results = (from x in db.Employees
            //              select new
            //              {
            //                  AdiSoyadi = x.FirstName + " " + x.LastName,
            //                  DogumTarihi = x.BirthDate,
            //                  Yasi = ((DateTime.Now - x.BirthDate).Days)/365
            //              });
            //foreach (var item in results)
            //{
            //    dtl_DataListesi.Items.Add(item.AdiSoyadi + "     " + item.DogumTarihi + "     " + item.Yasi);

            //}

            //Kategorilerine g�re stoktaki �r�n adedini getiren sorguyu yaz�n�z.
            
            /*
             A�a��da Navigation proplar kullan�lmad��� i�in join ile KatAdi ve her �r�n i�in UrunAdet s�ralanabildi.
             */

            //var results = (from x in db.Products
            //               join y in db.Categories
            //               on x.CategoryID equals y.CategoryID
            //              select new
            //              {
            //                  ProductName = x.ProductName,
            //                  CategoryName = y.CategoryName,
            //                  UnitsInStock = Convert.ToInt32(x.UnitsInStock)
            //              }).ToList();

            //foreach (var item in results)
            //{
            //    dtl_DataListesi.Items.Add(item.ProductName + " ---- " + item.CategoryName.ToLowerInvariant()+ " ---- " + item.UnitsInStock);
            //}

            /*
             Burada Navigation Proplar kullan�larak link to entities ile istenilen sorgu yaz�labildi.
             */

            foreach (var product in productDetailDal.ProductByCategory())
            {
                dtl_DataListesi.Items.Add(product.UrunAdet + " ---- " + product.CategoryName);
            }


        }
    }
}