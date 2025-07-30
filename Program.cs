/*
 Soru: İki Sayının Toplamı:

Bir tamsayı dizisi (nums) ve bir hedef tamsayı (target) verildiğinde, dizide toplamları hedefe eşit olan iki sayının indislerini döndürün.

Her giriş için yalnızca bir geçerli çözümün olduğu varsayılabilir.
Aynı elemanı iki kez kullanamazsınız.
Cevabı herhangi bir sırayla döndürebilirsiniz.
Örnekler:
Örnek 1:
Girdi: nums = [2,7,11,15], target = 9
Çıktı: [0,1]
Açıklama: nums[0] + nums[1] = 2 + 7 = 9 olduğu için [0,1] döndürülür.

Örnek 2:
Girdi: nums = [3,2,4], target = 6
Çıktı: [1,2]

Örnek 3:
Girdi: nums = [3,3], target = 6
Çıktı: [0,1]
 */
namespace TwoSumIndexFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin elemanlarını aralarında virgül (',') olacak şekilde girin (örnek: 2,7,11,15): ");
            string inputString = Console.ReadLine();

            string[] parts = inputString.Split(',', StringSplitOptions.RemoveEmptyEntries); //Dizinin elemanları
            int length = parts.Length; // Dizinin boyutu

            // Uzunluk kontrolü
            if (length < 2 || length > 10000)
            {
                Console.WriteLine("HATA: Dizi uzunluğu 2 ile 10.000 arasında olmalıdır.");
                return;
            }

            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (!long.TryParse(parts[i], out long number) || number < -1_000_000_000 || number > 1_000_000_000)
                {
                    Console.WriteLine("HATA: Dizideki her sayı -1.000.000.000 ile +1.000.000.000 arasında olmalıdır.");
                    return;
                }

                numbers[i] = (int)number;
            }

            Console.Write("Hedef sayıyı girin: ");

            // Uzunluk kontrolü
            if (!long.TryParse(Console.ReadLine(), out long target) || target < -1_000_000_000 || target > 1_000_000_000)
            {
                Console.WriteLine("HATA: Hedef sayı -1.000.000.000 ile +1.000.000.000 arasında olmalıdır.");
                return;
            }

            int[] result = TwoSum(numbers, (int)target);

            if (result.Length == 2)
            {
                Console.WriteLine($"Sonuç: [{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("Toplamı hedefe eşit olan iki sayı bulunamadı.");
            }

            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0]; // Bulunamazsa boş dizi döner
        }

    }
}




