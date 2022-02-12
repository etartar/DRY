Yaptığımız projemizde nesnemizi birden fazla oluşturmamız gerektiğinde normalde “new” olarak oluşturmak yerine 
bir tane oluşturduğumuz nesnemizin klonunu oluşturmamızı sağlayan bir design patterndir.

Prototype Pattern kullanılmasının amacı üretilen nesnenin çok kaynak tüketmesi durumunun engellenmesini sağlamaktır.

Biliyoruz ki, Shallow Copy ve Deep Copy olmak üzere iki tür nesne kopyalama işlemi mevcuttur. 
Shallow Copy ile nesnelerin bellekteki adresleri kopyalanmakta dolayısıyla yüzeysel olarak bir kopyalama işlemi gerçekleştirileceği için 
yeni bir nesne üretilmemekte, var olan nesne üzerine referanslar ile işaretleme yapılmaktadır. 
Anlayacağınız Shallow Copy, Prototype Design Pattern için uygun tercih olmayacaktır.

Lakin Deep Copy ile nesneler birebir kopyalanabilmekte ve bu kopya sonucu ile asıl nesne farklı referanslar ile işaretlenebilmektedir. 
İşte Prototype Design Pattern’de bu kopyalama yaklaşımında bulunmak en doğrusudur.

