using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CafeOnline.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Thumbnail = "https://phunugioi.com/wp-content/uploads/2020/02/hinh-anh-ly-cafe-dep.jpg",
                        Description = "Ly thủy tinh dáng cao, có vân đẹp mắt",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Cafe đá",
                        Thumbnail = "https://blog.maybanhang.net/hs-fs/hubfs/Mai%20Linh/cafe/cafe-sua-da.jpg?width=1200&name=cafe-sua-da.jpg",
                        Description = "A boat for one person",
                        Category = "Ly Thủy Tinh",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Cafe nóng ",
                        Thumbnail = "https://blog.maybanhang.net/hs-fs/hubfs/Mai%20Linh/cafe/cafe-den-nong.jpg?width=1200&name=cafe-den-nong.jpg",
                        Description = "Ly sứ nhỏ có quai cầm. Sở dĩ đây là cặp đôi trời sinh bởi một chiếc ly gốm sứ nhỏ sẽ giúp khách hàng nhanh chóng cảm nhận được sự quyến rũ nồng nàn từ làn hơi cafe đang bốc lên, chiếc quai tiện dụng giúp dễ dàng nâng ly lên và thưởng thức trọn vẹn.",
                        Category = "Cafe nóng",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Matchiato",
                        Thumbnail = "https://blog.maybanhang.net/hs-fs/hubfs/Mai%20Linh/cafe/matchiato-2.jpg?width=1200&name=matchiato-2.jpg",
                        Description = "Đặc trưng của Matchiato chính là sự phân tầng của ba lớp sữa, cafe và bọt kem. Ly thủy tinh sẽ giúp cho điều thú vị này được hiện lên rõ ràng và bắt mắt. Tuy nhiên để bảo toàn độ nóng tốt nhất, hãy chọn ly thủy tinh dày dặn nhất có thể nhé",
                        Category = "Matchiato",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Thumbnail = "https://lh3.googleusercontent.com/proxy/w3c1i0Y9_IBhAQ4oHbbS7QOQhHv1NKaMoq2RLIirTr7yQMkV4DDuUEC8rdrF9lO1EztJ5hClAc1JI8OnofYyIg9wBJDTd5k",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    { 
                        Name = "Soccer Ball",
                        Thumbnail = "https://vinmec-prod.s3.amazonaws.com/images/20200319_142454_870000_ca-phe-anh-huong-de.max-1800x1800.jpg",
                        Description = "FIFA-approved size and weight",
                        Category = "Espresso",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Espresso",
                        Thumbnail = "https://blog.maybanhang.net/hs-fs/hubfs/Mai%20Linh/cafe/espresso.jpg?width=1200&name=espresso.jpg",
                        Description = "Đối với các loại cafe pha máy như Espresso thì chuyện cần quan tâm nhất là làm sao để giữ được độ nóng cho thức uống. Khi đó, bạn có thể chọn những chiếc ly làm từ gốm hoặc sứ dày dặn, có thêm quai cầm và muỗng nhỏ.Tuyệt đối không nên dùng ly thủy tinh sẽ làm cafe nhanh nguội, ly kim loại hoặc ly nhựa dễ làm hương vị cafe bị biến đổi, ly sứ nóng nhưng thành ly mỏng lại làm ly nhanh nóng. Bạn thấy đó, chỉ cần chọn sai một chút thôi là bạn đã tự phá hỏng đi thành quả của mình rồi!",
                        Category = "Espresso",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Latte",
                        Thumbnail = "https://blog.maybanhang.net/hs-fs/hubfs/Mai%20Linh/cafe/latte.jpg?width=1200&name=latte.jpg",
                        Description = "Vẫn tuân thủ yêu cầu của một chiếc ly dành cho các loại cafe Ý là dày dặn và giữ nóng tốt, nhưng đối với riêng Latte, bạn nên chuẩn bị những chiếc ly có miệng rộng một chút để khoe trọn vẻ đẹp của những họa tiết mà barista đã dày công tạo nên.",
                        Category = "Latte",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Thumbnail = "https://anuongsaigon.com/wp-content/uploads/2018/10/ca-phe.jpg",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Thumbnail = "https://poh.vn/assets/uploads/images/C%C3%A0%20ph%C3%AA.jpg",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Thumbnail = "https://lh3.googleusercontent.com/proxy/sG-iDWjllx9S6Gzs4Z2bf5qRP6lZeYNDb4ZhBxriNY3GRNN9QoXvE4f2LUbYqoTCuA6RI9i8fSz8YlpM7jHIqSos30x8rVL3d7dNyptKqLa24dOLrXfPYhv84zvAId7HdXLT6qYtkObX",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Thumbnail = "https://cdn.huongnghiepaau.com/wp-content/uploads/2019/01/hinh-anh-cafe-cappuccino.jpg",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Human Chess Board",
                        Thumbnail = "https://suno.vn/blog/wp-content/uploads/2017/09/5-mo-hinh-quan-ca-phe-doc-dao-duoc-yeu-thich-nhat-hien-nay.jpg",
                        Description = "A fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Thumbnail = "https://nqtm.vn/wp-content/uploads/2020/11/anh-ly-cafe-buoi-sang-26.jpg",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
