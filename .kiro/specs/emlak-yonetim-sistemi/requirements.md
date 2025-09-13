# Requirements Document

## Introduction

Bu doküman, mevcut emlak yönetim sisteminin kapsamlı gereksinimlerini tanımlar. Sistem, emlak portföyü yönetimi, müşteri ilişkileri, hizmet yönetimi, finansal işlemler ve raporlama süreçlerini kapsayan entegre bir çözümdür. Sistem, emlak danışmanları, ofis yöneticileri ve sistem yöneticileri tarafından kullanılmak üzere tasarlanmıştır.

## Requirements

### Requirement 1: Müşteri Yönetimi

**User Story:** Emlak danışmanı olarak, müşteri bilgilerini ekleyip yönetebilmek istiyorum ki müşteri portföyümü etkin şekilde takip edebilim.

#### Acceptance Criteria

1. WHEN kullanıcı yeni müşteri ekleme işlemi başlattığında THEN sistem müşteri türü (Bireysel/Kurumsal) seçimi yapmasını SAĞLAMALI
2. WHEN bireysel müşteri eklendiğinde THEN sistem ad, soyad, telefon, e-posta ve adres bilgilerini zorunlu alan olarak KONTROL ETMELİ
3. WHEN kurumsal müşteri eklendiğinde THEN sistem firma adı, yetkili kişi, telefon ve e-posta bilgilerini zorunlu alan olarak KONTROL ETMELİ
4. WHEN müşteri kaydedildiğinde THEN sistem otomatik olarak benzersiz müşteri kodu OLUŞTURMALI
5. WHEN müşteri bilgileri güncellendiğinde THEN sistem değişiklik tarihini ve kullanıcısını KAYDETMELI
6. WHEN müşteri silinmek istendiğinde THEN sistem aktif portföy kaydı varsa silme işlemini ENGELLEMELI

### Requirement 2: Portföy Yönetimi

**User Story:** Emlak danışmanı olarak, portföy kayıtlarını yönetebilmek istiyorum ki mülk envanterini güncel tutabilim.

#### Acceptance Criteria

1. WHEN yeni portföy kaydı oluşturulduğunda THEN sistem portföy türü (Kiralık/Satılık) seçimini ZORUNLU KILMALI
2. WHEN portföy kaydedildiğinde THEN sistem il, ilçe, mahalle, portföy tipi ve mal sahibi bilgilerini zorunlu alan olarak KONTROL ETMELİ
3. WHEN portföy durumu güncellendiğinde THEN sistem durum değişiklik tarihini KAYDETMELI
4. WHEN portföy satıldığında veya kiralandığında THEN sistem portföy durumunu otomatik olarak "Tamamlandı" olarak GÜNCELLEMELI
5. WHEN portföy aranırken THEN sistem il, ilçe, mahalle, fiyat aralığı ve portföy türüne göre filtreleme SAĞLAMALI
6. WHEN portföy listelenirken THEN sistem sayfalama ve sıralama özelliği SUNMALI

### Requirement 3: Hizmet Yönetimi

**User Story:** Ofis yöneticisi olarak, sunulan hizmetleri tanımlayıp yönetebilmek istiyorum ki hizmet kalitesini standardize edebilim.

#### Acceptance Criteria

1. WHEN yeni hizmet tanımlandığında THEN sistem hizmet adı, hizmet türü ve ücret bilgilerini zorunlu alan olarak KONTROL ETMELİ
2. WHEN hizmet kaydedildiğinde THEN sistem başlangıç ve bitiş tarihlerini DOĞRULAMALI
3. WHEN hizmet ücreti güncellendiğinde THEN sistem eski ücret bilgisini tarihçede SAKLAMALI
4. WHEN hizmet silinmek istendiğinde THEN sistem aktif kullanımda olup olmadığını KONTROL ETMELİ
5. WHEN hizmet raporlanırken THEN sistem hizmet türüne göre gruplama SAĞLAMALI

### Requirement 4: Finansal İşlemler

**User Story:** Muhasebe sorumlusu olarak, finansal işlemleri takip edebilmek istiyorum ki mali durumu kontrol edebilim.

#### Acceptance Criteria

1. WHEN ödeme kaydı oluşturulduğında THEN sistem ödeme metodu, tutar ve tarih bilgilerini zorunlu alan olarak KONTROL ETMELİ
2. WHEN kasa işlemi yapıldığında THEN sistem kasa bakiyesini otomatik olarak GÜNCELLEMELI
3. WHEN banka hesabı işlemi yapıldığında THEN sistem hesap bakiyesini GÜNCELLEMELI
4. WHEN finansal rapor oluşturulduğunda THEN sistem tarih aralığına göre filtreleme SAĞLAMALI
5. WHEN ödeme geciktiğinde THEN sistem otomatik hatırlatma GÖNDERMEL

### Requirement 5: Personel Yönetimi

**User Story:** İnsan kaynakları sorumlusu olarak, personel bilgilerini yönetebilmek istiyorum ki organizasyon yapısını takip edebilim.

#### Acceptance Criteria

1. WHEN yeni personel eklendiğinde THEN sistem ad, soyad, departman ve unvan bilgilerini zorunlu alan olarak KONTROL ETMELİ
2. WHEN personel bilgileri güncellendiğinde THEN sistem değişiklik geçmişini KAYDETMELI
3. WHEN personel harcaması kaydedildiğinde THEN sistem harcama türü ve tutarını DOĞRULAMALI
4. WHEN personel performansı değerlendirildiğinde THEN sistem portföy ve satış verilerini KULLANMALI

### Requirement 6: Lokasyon Yönetimi

**User Story:** Sistem yöneticisi olarak, lokasyon bilgilerini hiyerarşik olarak yönetebilmek istiyorum ki adres bilgileri tutarlı olsun.

#### Acceptance Criteria

1. WHEN il bilgisi eklendiğinde THEN sistem il kodunun benzersiz olmasını SAĞLAMALI
2. WHEN ilçe eklendiğinde THEN sistem hangi ile bağlı olduğunu KONTROL ETMELİ
3. WHEN mahalle eklendiğinde THEN sistem hangi ilçeye bağlı olduğunu KONTROL ETMELİ
4. WHEN lokasyon silinmek istendiğinde THEN sistem bağımlı kayıtları KONTROL ETMELİ

### Requirement 7: Raporlama ve Analiz

**User Story:** Yönetici olarak, detaylı raporlar alabilmek istiyorum ki iş performansını analiz edebilim.

#### Acceptance Criteria

1. WHEN satış raporu oluşturulduğunda THEN sistem tarih aralığı, danışman ve portföy türüne göre filtreleme SAĞLAMALI
2. WHEN müşteri raporu oluşturulduğunda THEN sistem müşteri türü ve lokasyona göre gruplama SUNMALI
3. WHEN finansal rapor oluşturulduğunda THEN sistem gelir-gider analizi YAPMAL
4. WHEN performans raporu oluşturulduğunda THEN sistem danışman bazında karşılaştırma SAĞLAMALI
5. WHEN rapor dışa aktarılırken THEN sistem Excel ve PDF formatlarını DESTEKLEMELI

### Requirement 8: Güvenlik ve Yetkilendirme

**User Story:** Sistem yöneticisi olarak, kullanıcı yetkilerini yönetebilmek istiyorum ki veri güvenliğini sağlayabilim.

#### Acceptance Criteria

1. WHEN kullanıcı sisteme giriş yaptığında THEN sistem kullanıcı adı ve şifre doğrulaması YAPMALI
2. WHEN yetkisiz işlem denendiğinde THEN sistem erişimi ENGELLEMELI
3. WHEN kritik işlem yapıldığında THEN sistem işlem logunu KAYDETMELI
4. WHEN şifre değiştirildiğinde THEN sistem güçlü şifre kurallarını KONTROL ETMELİ

### Requirement 9: Veri Bütünlüğü ve Doğrulama

**User Story:** Sistem kullanıcısı olarak, veri girişi sırasında doğrulama yapılmasını istiyorum ki hatalı veri girişi önlensin.

#### Acceptance Criteria

1. WHEN zorunlu alan boş bırakıldığında THEN sistem uyarı mesajı GÖSTERMELI
2. WHEN geçersiz format girildiğinde THEN sistem format hatası BILDIRMELI
3. WHEN duplicate kayıt girilmeye çalışıldığında THEN sistem duplicate uyarısı VERMELI
4. WHEN referans bütünlüğü bozulacak işlem yapıldığında THEN sistem işlemi ENGELLEMELI

### Requirement 10: Sistem Performansı ve Kullanılabilirlik

**User Story:** Son kullanıcı olarak, sistemin hızlı ve kullanıcı dostu olmasını istiyorum ki verimli çalışabilim.

#### Acceptance Criteria

1. WHEN sayfa yüklendiğinde THEN sistem 3 saniye içinde yanıt VERMELI
2. WHEN arama yapıldığında THEN sistem sonuçları 2 saniye içinde GÖSTERMELI
3. WHEN form doldurulurken THEN sistem otomatik tamamlama özelliği SUNMALI
4. WHEN hata oluştuğunda THEN sistem anlaşılır hata mesajı GÖSTERMELI
5. WHEN sistem yoğun kullanımda olduğunda THEN performans düşüşü %20'yi GEÇMEMELI

## Eksik Kalan Alanlar ve İyileştirme Önerileri

### 1. Entegrasyon Gereksinimleri
- Harici emlak portalları ile entegrasyon (sahibinden.com, hurriyetemlak.com)
- CRM sistemleri ile entegrasyon
- Muhasebe yazılımları ile entegrasyon
- E-imza sistemleri ile entegrasyon

### 2. Mobil Uygulama Gereksinimleri
- Android ve iOS mobil uygulaması
- Offline çalışma kapasitesi
- Push notification desteği
- GPS tabanlı lokasyon servisleri

### 3. İleri Düzey Özellikler
- Yapay zeka destekli fiyat tahmini
- Otomatik portföy eşleştirme
- Chatbot müşteri desteği
- Blockchain tabanlı sözleşme yönetimi

### 4. İş Zekası ve Analitik
- Dashboard ve KPI takibi
- Predictive analytics
- Market analizi raporları
- Trend analizi

### 5. Teknik İyileştirmeler
- Mikroservis mimarisi
- Cloud deployment
- API Gateway
- Containerization (Docker)
- CI/CD pipeline

### 6. Güvenlik İyileştirmeleri
- Two-factor authentication
- Role-based access control (RBAC)
- Data encryption
- Audit logging
- GDPR compliance

### 7. Kullanıcı Deneyimi İyileştirmeleri
- Modern UI/UX tasarımı
- Responsive design
- Accessibility compliance
- Multi-language support
- Dark mode desteği