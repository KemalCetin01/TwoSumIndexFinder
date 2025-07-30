**Soru: İki Sayının Toplamı:**

Bir tamsayı dizisi (nums) ve bir hedef tamsayı (target) verildiğinde, dizide toplamları hedefe eşit olan iki sayının indislerini döndürün.

*Her giriş için yalnızca bir geçerli çözümün olduğu varsayılabilir.

*Aynı elemanı iki kez kullanamazsınız.

*Cevabı herhangi bir sırayla döndürebilirsiniz.

------------------------------------------------------
**Örnekler:**

**Örnek 1:**
Girdi: nums = [2,7,11,15], target = 9
Çıktı: [0,1]
Açıklama: nums[0] + nums[1] = 2 + 7 = 9 olduğu için [0,1] döndürülür.

**Örnek 2:**
Girdi: nums = [3,2,4], target = 6
Çıktı: [1,2]

**Örnek 3:**
Girdi: nums = [3,3], target = 6
Çıktı: [0,1]

------------------------------------------------------
**Kısıtlamalar:**

*2 <= nums.length <= 10⁴  (Dizinin uzunluğu en az 2, en fazla 10.000 olabilir.)

*-10⁹ <= nums[i] <= 10⁹  (Dizideki her eleman -1 milyar ile +1 milyar arasında olabilir.)

*-10⁹ <= target <= 10⁹  (Hedef sayı -1 milyar ile +1 milyar arasında olabilir.) 

*Yalnızca bir geçerli çözüm olduğu garanti edilmiştir.
