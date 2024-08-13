# MyList ve Davetliler Listesi Uygulaması

Bu proje, C# dilinde özel bir liste sınıfı olan `MyList<T>`'yi kullanarak bir davetliler listesini numaralandırarak ekrana yazdırır.

## Proje Açıklaması

Proje, `MyList<T>` adında bir liste sınıfı tanımlar ve bu sınıfı kullanarak bir davetliler listesi oluşturur. Ardından, bu listeyi numaralandırarak ekrana yazdırır.

### MyList<T> Sınıfı

- **Tanım**: `MyList<T>` sınıfı, generic bir liste yapısını temsil eder ve dinamik olarak eleman eklemeyi sağlar.
- **Özellikler**:
  - `Add(T item)`: Listeye bir eleman ekler.
  - `Count`: Listenin eleman sayısını döndürür.
  - `this[int index]`: İndeks ile elemanlara erişim sağlar.

### Program Sınıfı

- **`Main` Metodu**:
  - `MyList<string>` türünde bir `davetliler` listesi oluşturur.
  - Listeye dört ziyaretçi ismi ekler.
  - Listeyi numaralandırarak ekrana yazdırır.

### Nasıl Çalışır?

1. **Liste Oluşturma**:
   - `MyList<string>` türünde bir nesne oluşturulur.
   - `Add` metodunu kullanarak elemanlar eklenir.

2. **Listeyi Yazdırma**:
   - `for` döngüsü kullanılarak listenin her bir elemanı sırasıyla yazdırılır.


