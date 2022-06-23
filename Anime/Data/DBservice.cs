using Microsoft.EntityFrameworkCore;
using Anime.Model;
using Anime.Data;



public static class DBservice
    {
    
    // 1-фигурка 2-манга 3-дакимакура
    public static void Init_db()
        {
            using (DBContext db =new DBContext())
            {
                db.SaveChanges();
            }
        }

        public static void AddProduct(string name, int price, string image,string desc, int categoryid)
        {
            using (DBContext db = new DBContext())
            {
                db.Product.Add(new Product {  
                    Name = name, 
                    Price = price, 
                    Image = image,
                    Description=desc,
                    Categoryid = categoryid
                });
                db.SaveChanges();

            }
        }

    public static void EditProduct(int id, string name, int price, string image, string desc, int categoryid)
    {
        using (DBContext db = new DBContext())
        {
            var d = db.Product.Where(x => x.Id == id).First();
            d.Name = name;
            d.Price = price;
            d.Image = image;
            d.Description = desc;
            d.Categoryid = categoryid;
            db.SaveChanges();



        }
    }

    public static void AddToCart(int id)
    {
        ids.Add(id);
    }


    public static void DeleteProduct(Product prod)
    {
        using (DBContext db = new DBContext())
        {
            db.Product.Remove(prod);
            db.SaveChanges();

        }
    }

    public static void DeleteProducts()
    {
        using (DBContext db = new DBContext())
        {
            db.Database.ExecuteSqlInterpolated($"TRUNCATE TABLE [Basket]");
            
        }
    }

    public static void DeleteCat(Categories cat)
    {
        using (DBContext db = new DBContext())
        {
            db.Categories.Remove(cat);
            db.SaveChanges();
            

        }
    }

    public static void AddUser(string login,string pass)
    {
        using(DBContext db=new DBContext())
        {
            db.Users.Add(new Users
            {
                Login = login,
                Pass = pass,
                Root = false
            });
            db.SaveChanges();
        }
    }

    public static void AddCategory(string name)
    {
        using (DBContext db = new DBContext())
        {
            db.Categories.Add(new Categories { Name = name });
            db.SaveChanges();
        }
    }

    public static void AddAdmin(string login, string pass)
    {
        using (DBContext db = new DBContext())
        {
            db.Users.Add(new Users
            {
                Login = login,
                Pass = pass,
                Root = true
            });
            db.SaveChanges();
        }
    }

    public static List<Product> products { get; set; } = new List<Product>();
    public static List<Categories> category { get; set; } = new List<Categories>();

    public static List<Users> user { get; set; } = new List<Users>();

    public static List<int> ids { get; set; } = new List<int>();



    public static void GetDataFromDB()
        {
            using (DBContext db = new DBContext())
            {
            
                category = db.Categories.ToList();
                products = db.Product.ToList();
                user = db.Users.ToList();

        }

        }

    public static Tuple<bool, string> authadmin(string login, string pass)
    {
        using (DBContext db = new DBContext())
        {
            if (db.Users.ToList().Any(x => x.Login == login && x.Pass == pass))
            {
                return Tuple.Create(db.Users.ToList().Find(x => x.Login.Equals(login) && x.Pass.Equals(pass)).Root, login);
            }
            return Tuple.Create(false, "Вход");
        }
    }

    public static void DeleteProduct(int id)
        {
        using (DBContext db = new DBContext())
        {
            db.Product.Remove(db.Product.Where(x => x.Id == id).First());

            db.SaveChanges();
        }

    }

    }

