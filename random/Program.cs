Random random = new Random();
int sayı = random.Next(0, 100);
var kelime = "r";

int hak = 0;
var tekrar = "r";

for ( tekrar= kelime; ;) { 
 hak = -1;
  Console.WriteLine("merhaba sayı tahmin etme oynuna hoş geldiniz " +
  "dikkat = 3 tane tahmin etme hakkınız var " +
  "tahin doğru olursa kazanırsınız ,yanlış olursa kaybedersiniz ");
  Console.WriteLine("sayı yı tutum tahmin et ");
    for (int i = 2; i > hak; i--){
    int tahmin = Convert.ToInt32(Console.ReadLine());

        if (tahmin == sayı){
               Console.WriteLine("tebrikler doğru bildiniz " + " " + i + " " + "hakın kaldı");
               break;
        }
         else if (tahmin >= sayı){
                    Console.WriteLine("daha küçük sayı tahmin etmelisin "+" " +i+" " +"hakın kaldı");
          }
         else if (tahmin <= sayı){
                    Console.WriteLine("daha büyük sayı tahmin etmelisin " + " " + i + " " + "hakın kaldı");
         }
               
  }
    Console.WriteLine("doğru sayı  "+sayı);
   Console.WriteLine("hakın biti tekrar oynaamak  için  r tuşlayın " +
   "kapatmak için q tuşlayın");
    tekrar = "q";
    Console.WriteLine("oynamak için r çıkmak için q basın");
    tekrar = Console.ReadLine();
    if (tekrar == "q")
    {
        break;
            
    }
}





