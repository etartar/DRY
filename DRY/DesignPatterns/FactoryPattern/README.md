Sık karşılaşılan problemlerden bir tanesi ise; birbirleri ile benzer yapıda olan nesnelerin nerede en verimli şekilde yaratılacağı problemidir.

Factory Design Pattern, nesne yaratma işlemi için bir arayüz tasarlanmasını gerektirir ve alt sınıfların nesne üretmesine olanak sağlar.
Ayrıca, hangi sınıf nesnesinin oluşacağını da alt sınıflar kendileri belirler. Böylece nesne yaratma işlemini soyutlaştırır.

---------------------

Bu tasarım deseni bir nesne yaratmak için arayüz sağlar ve hangi sınıftan nesne yaratılacağını alt sınıfların belirlemesine olanak tanır.
Asıl amaç oluşturmak istediğimiz sınıfların tek tek instance oluşturmak yerine bu oluşturma işlemini tek bir sınıf üzerinden yönetmek.

---------------------

Problem:

Let’s say we have an app for which we get paid. For now, we receive payments from X, Y and Z banks on this application. 
The number of banks may increase or decrease in the future. We need to establish a flexible structure.
Deciding which bank should be processed according to the information entered by the user creates many conditions. 
When a new bank payment system arrives, it creates a big problem for others to be affected.

Solution :

During the payment process, it will be very useful to determine a single point that will decide which bank will receive the payment according to the user’s information.
Payment screen will communicate with only one point, when a new bank payment is added, it can be added from a single point and removed from a single point.