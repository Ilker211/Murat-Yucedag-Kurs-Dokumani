namespace vs_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 10.5;

            //Console.WriteLine(number);  
            //Console.WriteLine("******* Fiyat Listesi *********");
            //Console.WriteLine();
            //double applePRice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
            //applePRice = 2.5;
            //orangePrice = 3.5;
            //strawberryPrice = 4.5;
            //patatoPrice = 1.5;
            //tomatoPrice = 2.5;

            //Console.WriteLine("Elma Fiyatı: " + applePRice);
            //Console.WriteLine("Portakal Fiyatı: " + orangePrice);
            //Console.WriteLine("Çilek Fiyatı: " + strawberryPrice);
            //Console.WriteLine("Patates Fiyatı: " + patatoPrice);
            //Console.WriteLine("Domates Fiyatı: " + tomatoPrice);

            //double applekg, orangekg, strawberrykg, patatokg, tomatokg;
            //applekg = 2;
            //orangekg = 3;
            //strawberrykg = 4;
            //patatokg = 1;
            //tomatokg = 2;

            //double aplletotalprice, orangetotalprice, strawberrytotalprice, patatototalprice, tomatototalprice;
            //aplletotalprice = applekg * applePRice;
            //orangetotalprice = orangekg * orangePrice;
            //strawberrytotalprice= strawberrykg * strawberryPrice;
            //patatototalprice = patatokg * patatoPrice;
            //tomatototalprice = tomatokg * tomatoPrice;

            //Console.ReadLine();
            //Console.WriteLine("Alınan ürün -> Elma"+" Birim Fİyatı"+applePRice+" Gramaj: "+applekg+" Toplam tutar -> "+aplletotalprice );
            //Console.WriteLine("Alınan ürün -> Portakal"+" Birim Fİyatı"+orangePrice+" Gramaj: "+orangekg+" Toplam tutar -> "+orangetotalprice );
            //Console.WriteLine("Alınan ürün -> Çilek"+" Birim Fİyatı"+strawberryPrice+" Gramaj: "+strawberrykg+" Toplam tutar -> "+strawberrytotalprice );
            //Console.WriteLine("Alınan ürün -> Patates"+" Birim Fİyatı"+patatoPrice+" Gramaj: "+patatokg+" Toplam tutar -> "+patatototalprice );
            ////Console.WriteLine("Alınan ürün -> Domates"+" Birim Fİyatı"+tomatoPrice+" Gramaj: "+tomatokg+" Toplam tutar -> "+tomatototalprice );
            //Console.WriteLine("Toplam Tutar: " + (aplletotalprice + orangetotalprice + strawberrytotalprice + patatototalprice + tomatototalprice));
            //Console.ReadLine();
            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);
            //Console.ReadLine();

            #endregion

            #region Klavyeden Veri Girişleri
            //Console.WriteLine("**** C# Hava Yolları Yolcu Bilgisi **** ");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerİdentityNumber;
            //Console.Write("Adınızı Giriniz: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Soyadınızı Giriniz: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçenizi Giriniz: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehrinizi Giriniz: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaşınızı Giriniz: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Tc Kimlik Numaranızı Giriniz: ");
            //passengerİdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("Yolcu adı : "+passengerName);
            //Console.WriteLine("Yolcu Soyadı : " + passengerSurname);
            //Console.WriteLine("Yolcu İlçesi : " + passengerDistrict);
            //Console.WriteLine("Yolcu Şehri : " + passengerCity);
            //Console.WriteLine("Yolcu Yaşı : " + passengerAge);
            //Console.WriteLine("Yolcu Tc Kimlik Numarası : " + passengerİdentityNumber);


            #endregion

            #region Klavyeden tamsayı girişleri ve dönüşümleri
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 5000;
            //chairPrice = 200;
            //tvPrice = 3000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz.");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz.");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz.");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz.");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int totalPrices = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            //Console.WriteLine("Toplam tutar: "+totalPrices);

            #endregion

            #region Klavyeden ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. sınav notunuzu giriniz.");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sınav notunuzu giriniz.");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. sınav notunuzu giriniz.");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.WriteLine("Lütfen cinsiyetinizi giriniz. (E/K)");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz:"+gender);
            #endregion
        }
    }
}