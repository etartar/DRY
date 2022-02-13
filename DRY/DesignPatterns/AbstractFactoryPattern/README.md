Abstract Factory yapısın da ise benzer nesne üretimlerini gerçekleştirebilmek adına her nesne için ayrı bir fabrika sınıfı oluşturmamız gerekmektedir.
Ayrıca bu desen, birden fazla interface kullanımı için gerçekleştirilir. Factory Design Pattern da bulunan koşullu durum (if/else...) problemi Abstract
Factory'de çözülür.

Bununla beraber, factory de olduğu gibi nesne ve istemci arasındaki bağımlılığı ortadan kaldırma hedeflenmektedir. Böylece daha esnek ve dolayısıyla
güncellenebilmesi daha kolay olan bir yazılım gerçekleştirilmiş olacaktır.

Abstract Factory methodunda amaç aynı başlık altında gruplanabilecek nesnelerin instancelarını aynı factory sınıfı ile almaktır.