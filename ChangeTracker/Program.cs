// See https://aka.ms/new-console-template for more information


using EntityFrameworkExamples;
using EntityFrameworkExamples.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

NorthwindContext context = new();
#region ChangeTracker 


//var categories = await context.Categories.ToListAsync();

//categories[1].Description = "test"; //Update
//context.Categories.Remove(categories[2]); //Delete

//var datas = context.ChangeTracker.Entries();

//await context.SaveChangesAsync();

#endregion

#region AcceptAllChanges Method
//  When the SaveChanges() or SaveChanges(true) methods are triggered, EF Core stops tracking
//the data it was monitoring and waits for the tracking of new changes while assuming
//that everything is in order."

//  In such a situation, if an unexpected scenario or a possible error occurs, EF Core will abandon
//the objects it was tracking, making any correction impossible.

//  Using SaveChanges(False) instructs EF Core to execute the necessary database commands, while also 
//waiting to track changes and tracking objects for re-execution if necessary, all the way until 
//the AcceptAllChanges method is called

var categories = await context.Categories.ToListAsync();

categories[1].Description = "test"; //Update
context.Categories.Remove(categories[2]); //Delete



await context.SaveChangesAsync(false);

context.ChangeTracker.AcceptAllChanges();
#endregion
#region OriginalValues Property

//returns the old values

var value = context.Entry(categories[1]).OriginalValues.GetValue<string>(nameof(Category.Description));
#endregion
#region DetectChanges Metodu
//EF Core, context nesnesi tarafından izlenen tüm nesnelerdeki değişiklikleri Change Tracker sayesinde takip edebilmekte ve nesnelerde olan verisel değişiklikler yakalanarak bunların anlık görüntüleri(snapshot)'ini oluşturabilir.
//Yapılan değişikliklerin veritabanına gönderilmeden önce algılandığından emin olmak gerekir. SaveChanges fonksiyonu çağrıldığı anda nesneler EF Core tarafından otomatik kontrol edilirler.
//Ancak, yapılan operasyonlarda güncel tracking verilerinden emin olabilmek için değişişiklerin algıulanmasını opsiyonel olarak gerçekleştirmek isteyebiliriz. İşte bunun için DetectChanges fonksiyonu kullanılabilir ve her ne kadar EF Core değişikleri otomatik algılıyor olsa da siz yine de iradenizle kontrole zorlayabilirsiniz.

//var urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 3);
//urun.Fiyat = 123;

//context.ChangeTracker.DetectChanges();
//await context.SaveChangesAsync();


#endregion