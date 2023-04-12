Proje Adı:
InvoiceReader

Proje Tanımı:
Bu projede, JSON dosyalarının içeriğini okuyan ve bu verileri bir MSSQL veritabanına yazan bir backend uygulaması geliştirilmiştir. Frontend kısmı Angular, Typescript ve HTML kullanılarak oluşturulmuştur. Kullanıcılar, belirli bir formatta JSON içeriği göndererek veritabanına kaydedebilirler. Ayrıca, kaydedilen verileri görüntüleyebilirler.

Kullanılan Teknolojiler:
Backend: C# ve .NET 6 framework
Frontend: Angular, Typescript, HTML
Veritabanı: MSSQL

Kullanım:
1-Projeyi klonlayın
2-Backend uygulamasını çalıştırmak için, Visual Studio veya başka bir IDE kullanarak proje klasöründe bulunan backend.sln dosyasını açın ve F5 tuşuna basarak projeyi başlatın.
3-Frontend uygulamasını çalıştırmak için, terminali açın ve proje klasöründe frontend dizinine gidin. Ardından, npm install komutunu kullanarak gerekli bağımlılıkları yükleyin ve ng serve komutunu kullanarak uygulamayı başlatın.
4-Uygulamayı kullanmak için, web tarayıcınızda http://localhost:4200 adresine gidin.

Veri Formatı:
JSON verileri aşağıdaki formatta olmalıdır:

{
	"InvoiceHeader": {
		"InvoiceId": "SVS202300000001",
		"SenderTitle": "Gönderici Firma",
		"ReceiverTitle": "Alıcı Firma",
		"Date": "2023-01-05"
},
	"InvoiceLine": [
	{
		"Id": 1,
		"Name": "1.Ürün",
		"Quantity": 5,
		"UnitCode": "Adet",
		"UnitPrice": 10
	},
	{
		"Id": 2,
		"Name": "2.Ürün",
		"Quantity": 2,
		"UnitCode": "Litre",
		"UnitPrice": 3
	},
	{
		"Id": 3,
		"Name": "3.Ürün",
		"Quantity": 25,
		"UnitCode": "Kilogram",
		"UnitPrice": 2
	}
	]
}
