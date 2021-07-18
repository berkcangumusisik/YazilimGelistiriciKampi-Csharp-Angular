# IF - ELSE ÖRNEĞİ

kullaniciAd = 'berkcan'
kullaniciPass = 123
if kullaniciAd == 'berkcan' and kullaniciPass == 123:
  print("Başarılı")
else:
  print("Giriş başarısız")



# FONKSİYON ÖRNEĞİ
def menuListele():
  menuler = ["Kurslarım", "Tüm Kurslar", "Kampa Hazırlık",  "Sık Sorulan Sorular"]
  for menu in menuler:
    print(menu)

menuListele() 


# DÖNGÜ ÖRNEĞİ

kurslar = ["Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)","Yazılım Geliştirici Yetiştirme Kampı (Java + React)","Programlamaya Giriş için Temel Kurs"]
for kurs in kurslar:
    print(kurs)