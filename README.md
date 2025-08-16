# ASP.NET Core MVC - Müşteri ve Sipariş Görüntüleme Uygulaması

Bu proje, **ASP.NET Core MVC** kullanılarak geliştirilmiş basit bir örnek uygulamadır.  
Amaç, bir müşteriye ait bilgilerin ve ona bağlı siparişlerin **ViewModel** üzerinden **View**’da görüntülenmesini sağlamaktır.
--

 Özellikler

-   **Model Katmanı**
    -   `Customer`: Müşteri bilgilerini tutar.\
    -   `Order`: Sipariş bilgilerini tutar.\
    -   `CustomerOrderViewModel`: View için gerekli müşteri + sipariş
        listesini tek modelde toplar.
-   **Controller**
    -   `CustomerOrdersController`: Örnek müşteri ve siparişleri
        oluşturur, `Index` View'a gönderir.
-   **View**
    -   `Views/CustomerOrders/Index.cshtml`:
        -   Müşteri bilgilerini listeler\
        -   Siparişleri tablo halinde görüntüler
     
--
📚 Kullanılan Teknolojiler

.NET 7 / .NET 8 (ASP.NET Core MVC)

C#

Razor View Engine

Bootstrap (tablolar için varsayılan şablondan)
