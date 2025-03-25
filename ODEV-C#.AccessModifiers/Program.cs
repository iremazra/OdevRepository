



//  ERİŞİM BELİRLEYİCİLER
/*C# dilinde kullanılan erişim belirleyiciler (access modifiers), sınıf üyelerine (metotlar, özellikler, alanlar) erişimi kontrol etmek için kullanılır.
  Bu belirleyiciler, nesne yönelimli programlamada (OOP) kapsülleme (encapsulation) ve bilgi gizleme (information hiding) gibi temel prensipleri destekler.*/

// PUBLİC
/* public erişim belirleyicisi, bir sınıf üyesine her yerden erişilebileceğini belirtir. Yani, sınıfın dışından bile bu üyeye erişim serbesttir.
   Gerçek Hayat Örneği: Bir kütüphanedeki kitaplar herkese açıktır. Herkes kitap alabilir, okuyabilir veya inceleyebilir. Bu, public erişimine benzer. */

// PRIVATE
/* private erişim belirleyicisi, bir sınıf üyesine yalnızca tanımlandığı sınıf içinden erişilebileceğini belirtir. Dışarıdan erişim engellenir.
   Gerçek Hayat Örneği: Bir evin anahtarı yalnızca ev sahibine aittir. Başkaları bu anahtara erişemez. Bu, private erişimine benzer. */

// PROTECTED
/* protected erişim belirleyicisi, bir sınıf üyesine yalnızca tanımlandığı sınıf ve bu sınıftan türetilen alt sınıflar (miras alan sınıflar) tarafından erişilebileceğini belirtir.
   Gerçek Hayat Örneği: Bir ailenin mirası yalnızca aile üyelerine (çocuklar, torunlar) açıktır. Dışarıdan biri bu mirasa erişemez. Bu, protected erişimine benzer. */


using ODEV_C_.AccessModifiers.Classes;
User user = new User();
