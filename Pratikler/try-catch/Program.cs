
using System;
namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi: "+sayi);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı. ");
            }
            
            

            try
            {
                int a = int.Parse(null);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz. ");
                Console.WriteLine(ex);
            }
            

            try
            {
                // int x = int.Parse("test");
                int b = int.Parse("-20000000000");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil. ");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz. ");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı. ");
            }
            

            
            
            
            
              





        }
    }
}