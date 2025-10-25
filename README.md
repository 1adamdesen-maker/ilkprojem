# HamurKralligi

Unity 2022.3 tabanlı Android hedefli "Hamur Krallığı" prototip projesi. Başlangıç Boot sahnesi Ana Menü sahnesini yükler. Ana Menü sahnesinde placeholder arka plan üzerine Türkçe "Oyna" ve "Ayarlar" butonları bulunur.

## Ön Koşullar

- Unity Hub
- Unity Editor 2022.3.x (URP olmadan, 3D şablonu)
- Android Build Support (SDK & NDK Tools, OpenJDK)

## Kurulum

1. Bu depoyu yerel bilgisayarınıza klonlayın veya indirin.
2. Unity Hub üzerinden **Add** > **Add project from disk** diyerek proje klasörünü seçin.
3. Proje ilk açılışta paketleri eşitleyene kadar bekleyin.
4. `Project Settings > Player > Android` sekmesinde paket adı `com.yourstudio.hamurkralligi` olarak ayarlanmış olmalıdır.

## Çalıştırma

1. `Assets/Scenes/Boot.unity` sahnesini açın.
2. Play tuşuna basarak Boot sahnesinin Ana Menü sahnesine geçtiğini doğrulayın.
3. Ana Menü sahnesinde yer alan UI butonlarını ve placeholder arka planı gözlemleyin.

## Android Build Alma

1. Unity'de `File > Build Settings...` menüsünü açın.
2. Platform listesinde **Android**'i seçip **Switch Platform** butonuna tıklayın.
3. Scenes In Build listesinde `Boot` ve `AnaMenu` sahnelerinin işaretli olduğundan emin olun.
4. Sağ alttan **Build** butonuna tıklayın ve boş bir klasör seçin.
5. Derleme tamamlandığında çıkış klasöründe boş bir APK/AAB oluşacaktır.

## Notlar

- `Application.targetFrameRate` uygulama başlangıcında 60 FPS'e sabitlenmiştir.
- Projede URP veya HDRP gibi scriptable render pipeline'lar etkin değildir; varsayılan yerleşik pipeline kullanılmaktadır.
