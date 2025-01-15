using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm
{
    public  class CryptoManager
    {
        // bu arkadaş günümüz sistemlerinde en düşük 16 mümkünse 32 istemektedir.
        /*         
        
        Rfc2898DeriveBytes (ve dolayısıyla PBKDF2) için tuz (salt) boyutu konusunda net bir "en iyi" değer olmamakla birlikte, bazı önemli faktörler ve genel kabul görmüş uygulamalar vardır. Tuzun amacı, aynı parolaya sahip farklı kullanıcıların farklı hash değerlerine sahip olmasını sağlamaktır. Bu, "rainbow table" saldırılarını engeller.

        Minimum Tuz Boyutu:

        Rfc2898DeriveBytes için minimum tuz boyutu 8 byte'tır (64 bit). Ancak, bu artık yeterli güvenlik sağlamaz.

        Önerilen Tuz Boyutu:

        Günümüzde en az 16 byte (128 bit) tuz kullanılması önerilmektedir. Hatta bazı uzmanlar 32 byte (256 bit) veya daha büyük tuzlar önermektedir.

        Neden Daha Büyük Tuz?

        Daha büyük bir tuz, saldırganın "rainbow table" oluşturmasını veya önceden hesaplanmış hash değerlerini kullanmasını zorlaştırır. Tuz ne kadar büyük olursa, saldırganın denemesi gereken olası kombinasyon sayısı o kadar artar.

        Tuz Boyutunun Performansa Etkisi:

        Tuz boyutunun performansa etkisi genellikle ihmal edilebilir düzeydedir. PBKDF2'nin performansını asıl etkileyen faktör tekrar sayısıdır (iterations). Bu nedenle, güvenlikten ödün vermeden yeterince büyük bir tuz kullanmak mantıklıdır.

        Özetle:

        Minimum: 8 byte (artık önerilmez)
        Önerilen: En az 16 byte (128 bit)
        Daha Güvenli Alternatifler: 32 byte (256 bit) veya daha büyük
        Pratikte Ne Kullanmalısınız?

        Çoğu modern uygulama için 16 byte tuz yeterli güvenliği sağlar.
        Ancak, çok yüksek güvenlik gereksinimleriniz varsa veya gelecekteki olası saldırılara karşı ek koruma sağlamak istiyorsanız,
        32 byte veya daha büyük bir tuz kullanabilirsiniz.

         */
        // Bu değerler byte değerindedir
        // 1 byte = 8 bit -- 32 byte = 256 bit(32 * 8 bit) -- 64 byte = 512 bit(64 * 8 bit)
        private const int saltSize = 32; // 256/8
        private const int hashSize = 64; // 512/8 - SHA512 algoritması ile birlikte çağıracağımız için bu değer böyle büyük oluyor.
        // bu günümüz güvenlik açısından tercih edilen en düşük değer. 
        // bu değeri arttırmak donanıma yük bindirir ve uygulamayı geciktirir.
        private const int iterationCount = 10_000;

        // This method create salt
        // Nusret gibi bol bol tuzlar. :)
        public byte[] GenerateSalt()
        {
            //Salt için boş bir byte array oluşturduk ve boyutunu 32 byte verdik.
            // byte[] salt = new byte[32];
            byte[] salt = new byte[saltSize];
            // Bu arkadaş salt için oluşturduğumuz array'i dolduracak umarım, yani öyle bekliyoruz :D
            RandomNumberGenerator.Create().GetBytes(salt);
            // Doldurduğumuz array'i kendimize saklarsak olmaz. :D
            return salt;            

        }

        // Şimdi geldi şifreyi şifrelemeye :)
        public string HashPassword(string password, byte[] salt) {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterationCount, HashAlgorithmName.SHA512))
            {
                // Şifre burada şifrelenmiş şekilde byte array tipinde oluyor. 
                // Matrix sahnesi gibi bir sürü ikili sayılar :D
                // byte[] hashedByte = pbkdf2.GetBytes(64);
                byte[] hashedByte = pbkdf2.GetBytes(hashSize);
                return ConvertBase64ToString(hashedByte);
            }
        
        }
        // Bu arkadaşı ayrı yazdım ki şifrelenmiş şifreyi encode ettiği anlaşılsın.
        // basitçe byte array'i string formatına çeviriyor.
        public string ConvertBase64ToString(byte[] hashPass) { 
          return Convert.ToBase64String(hashPass);
        }

        // Bu arkadaşı ayrı yazdım ki şifrelenmiş şifreyi decode ettiği anlaşılsın.
        // basitçe string'i byte array formatına çeviriyor.
        public byte[] ConvertStringToBase64(string base64Val) { 
        return Convert.FromBase64String(base64Val);
        }

        // Şimdide hash ile byteları karşılaştırma
        public bool ComparePasswordByteArray(byte[] passOne, byte[] passTwo) {
            // Eğer birinci ve ikinci password'un array boyutu birini tutmuyorsa direk yanlış
            // yani şifreler eşit uzunlukta olmadığı için karşılaştırma burada bitiyor.
            if (passOne.Length != passTwo.Length)
            {
                return false;
            }

            // Eğer eşitlik sağlandı ve buraya ulaştıysa
            // byte değerleri geziliyor ve değerlerin eşit olup olmadığına bakılıyor
            // yani "AliPisPis" ile "AliCıpCıp" bir mi diye kontrol ediyor. :D
            for (int i = 0; i < passOne.Length; i++)
            {
                if (passOne[i] != passTwo[i])
                {
                    return false;
                }
            }

            return true;
        }

    }


}
