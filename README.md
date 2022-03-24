# Setur
# Bu projede kullanılan teknolojiler

-Veri tabanı CodeFirst ile oluşturulmuştur.
-PostgreSQL
-.Net Core

# NuGet Packages

-Ocelot(15.0.6)
-Newton.Json
-Microsoft.EntityFrameworkCore(5.0.12)
-Microsoft.EntityFrameworkCore.Desing(5.0.12)
-Microsoft.EntityFrameworkCore.Desing.Tools(5.0.12)
-Npgsql.EntityFrameworkCore.PostgreSQL(5.0.10)

# RehberApi

Kişi ve iletişim bilgilerinin tutulduğu servistir. Bu servisin içerisinde Create,Read,Update,Delete methodları oluşturulmuştur.

![RehberApi](https://user-images.githubusercontent.com/47839471/159953817-f26ead73-2162-49fb-a3c0-09637577d1fb.png)

![RehberApi1](https://user-images.githubusercontent.com/47839471/159954084-bb2b20df-5935-432e-8823-4bbfc5874be5.png)

# RaporApi
Rapor Tarihi local olarak, Durum ise kullanıcı tarafından giriliyor.

![RaporApi1](https://user-images.githubusercontent.com/47839471/159954847-a015d27d-f689-4ae2-9afc-c7e254440df7.png)

# ApiGateway
Api Gateway, Rapor ve Rehber Servislerini birbiriyle haberleşmesini salayan servistir. Bunu yapmak için Ocelot kullandım. ocelo.json içerisinde Route ayarlarını yapıp localhost içerisinde 44310,44366 portlarını localhost'un kendi portu olan 44306'ya çektim. 
ApiGateway Configuration başarılı olması için RehberApi, RaporApi ve ApiGateway aynı anda ayağa kaldırılmalıdır. (Solution->Properties->Startup Project->)

![AllStart](https://user-images.githubusercontent.com/47839471/159956440-740329cf-94ad-43ad-8c29-d19009f9cd1c.png)

Bu şekilde ayarladıktan sonra projeyi ayağa kaldırıp görmek yeterli olacak. İki host arasındaki yeni adresi görebiliyoruz ve artık bunu projemde kullanabilirim. Bunun avantajı tek adres üzerinde mikroservisleri haberleştirmek.

![newww](https://user-images.githubusercontent.com/47839471/159956919-3fab5903-3c70-4735-a5df-fb00726f4500.png)

# Application

![telefonindex](https://user-images.githubusercontent.com/47839471/159957670-fefd89da-4e9a-43fe-9fe7-0549e348ec46.png)

![raporindex](https://user-images.githubusercontent.com/47839471/159957615-471d5063-d1c7-4f32-86dc-1b9ff5271563.png)


# Sql

Kullandığım veri tabanı aşağıdaki şekildedir.

![sql](https://user-images.githubusercontent.com/47839471/159958124-119f4242-dfb5-417d-9c0d-7fa687977272.png)

