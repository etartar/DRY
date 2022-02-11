State Design Pattern, bir nesnenin o anki durumuna bağlı olarak çalışma zamanında(runtime) 
davranışını tamamen değiştirmesini sağlayan bir tasarım desenidir.

ATM’lerdeki kart durumudur. ATM, o anda aktif bir kart takılı değilse kart alabilmekte yok eğer kart takılı değilse 
başka bir kart alamamaktadır. İşte burada da ATM’ye kartın takılı olup olmama durumlarına istinaden kart alabilme 
ya da alamama davranışları bağımlılık göstergesidir.

Yazılımlardaki durumlara göre davranış değişiklikleri genellikle if-else ya da switch case gibi kontrol blokları eşliğinde 
gerçekleştirilmektedir. Evet, bu hızlı ve kolay bir çözümdür lakin uzun vadede gelen ihtiyaçlar doğrultusunda 
ne kadar kullanışsız ve bağlayıcı bir yöntem olduğu görülebilmektedir. 

