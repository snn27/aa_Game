🎮 aa Game 
Bu proje, popüler mobil oyun **"aa"**nın Unity oyun motoru kullanılarak geliştirilmiş bir versiyonudur. Proje, oyunun temel mekaniklerini anlamak ve Unity'de basit ama eksiksiz bir oyun döngüsünün nasıl oluşturulacağını öğrenmek için harika bir başlangıç noktasıdır.
✨ Öne Çıkan Özellikler
Dinamik Pin Mekaniği: Ekrana dokunarak dönen çembere iğneler (pinler) fırlatma.
Çarpışma Kontrolü: İğnelerin birbirine değmesi durumunda oyunu anında bitiren hassas kontrol sistemi.
Dinamik Puanlama: Başarıyla atılan her iğne için artan ve ekranda görüntülenen puan sistemi.
Oyun Durumu Yönetimi: Oyunun kazanma ve kaybetme durumlarını yöneten bir GameManager.
Ayarlanabilir Zorluk: Spawner ve Rotator script'leri üzerinden iğne sayısı ve dönme hızı kolayca değiştirilebilir.

⚙️ Teknik Detaylar ve Kod Mimarisi
Proje, anlaşılır ve modüler bir kod yapısıyla oluşturulmuştur. Temel mantık 5 ana script üzerine kuruludur:
Script	👑 Görevi
GameManager.cs:	Oyunun beynidir. Oyunun bittiği (GameOver) veya kazanıldığı (Win) durumları kontrol eder ve sahneler arası geçişi yönetir.
Rotator.cs:	Merkezdeki çemberin dönme hareketini sağlar. Hızı rotationSpeed ile kolayca ayarlanabilir.
Pin.cs:	Fırlatılan her iğnenin davranışlarını kontrol eder. Çembere yapıştığında puanı artırır (Score.cs'i tetikler) ve diğer iğnelere çarparsa oyunu bitirir.
Spawner.cs:	Sahnedeki iğneleri Instantiate ile oluşturur ve fırlatılmaya hazır hale getirir.
Score.cs::	Statik PinCount değişkeni ile puanı tutar ve Update() içinde bu puanı arayüzdeki Text elemanına yazdırır.
