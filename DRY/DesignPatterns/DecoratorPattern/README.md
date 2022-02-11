Imagine that you are working on an existing application that sends notifications to other programs. 
The initial version of that application was only sending notifications by email but now you are asked to add some additional features in that library 
so that it can start sending notifications by SMS, or can send notifications to Facebook, Twitter, etc., or a combination of many other apps. 
You don’t want to modify existing code, you don’t want to create a big hierarchy of child and grandchild classes and still, 
you want to enhance the existing application. 
This is where the Decorator Pattern will come to rescue you and will allow you to dynamically add or remove functionality to existing classes.

The decorator pattern (also known as Wrapper) is a structural design pattern and it allows developers to dynamically add new behaviors and features to existing classes without modifying them thus respecting the open-closed principle. 
This pattern lets you structure your business logic into layers (wrappers) in a way that each layer adds some additional behavior or functionality to an existing object, promoting separation of concern. 
Furthermore, these layers can be added or removed at runtime and clients can also use the different combinations of decorators to be attached to an existing object.

-----------------------------
Ne zaman Kullanılır?
Runtime zamanında bir nesneye yeni özellikler eklemek istiyorsak kullanabiliriz.
-----------------------------

Decorator design pattern dinamik olarak nesneye yeni özellikler kazandırılmasını sağlar.
Şu öğeleri içerir;

Component: Yeni özellikler eklenmesini istediğimiz sınıfların inherit edileceği soyuttur.
ConcreteComponent: Component soyutunun yeni özellikler kazandırılarak implemente edilmiş somut halidir.

Decorator: Decorator da component soyutunun implemente edilmiş soyut bir objedir. İçerisinde component türünde bir property barındırarak onu özelleştirme işlemlerini yapar.
ConcreteDecorator: Component’e yeni özellikler ekleyen, decorator’dan türetilmiş somut sınıftır.

Örnek Senaryo:
Bir otomobilin donanım paketlerine göre fiyat ve özellikler bakımından değişmesini decorator design patternı ile uygulayacağız. 
Öncelikle ICar (Component) interface’i ve Car(ConcreteComponent) sınıfını oluşturalım.
İçerisinde bir adet car sınıfından obje barındıran ve car sınıfına yeni özellikler ekleyecek donanım paketlerini (ConcreteDecorator)tanımlayalım.
Car sınıfından bir instance alarak paketler yardımıyla özelleştirelim.