using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Klavyeden girilen 20 adet pozitif sayının asal ve asal 
                olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak 
                yazınız.)
                
                .Negatif ve numeric olmayan girişleri engelleyin.
                .Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde
                ekrana yazdırın.
                .Her iki dizinin eleman sayısını ve ortalamasını ekrana 
                yazdırın.
            */
            
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new();


            int counter = 0;
            while(counter != 20){
                try{
                    int number = Convert.ToInt32(Console.ReadLine());
                    if(number < 0 ){
                        throw new Exception();
                    }
                    bool c = true; 
                    for(int i=2; i<number; i++){
                        if(number%i==0){
                            c = false;
                        }
                    }
                    if(c && number!=1){
                        asal.Add(number);
                    }
                    else{
                        asalOlmayan.Add(number);
                    }
                    counter++;
                }catch(Exception ex){
                    Console.WriteLine("Negatif veya Numerik olmayan bir değer girdiniz. ");
                }
            }

            Console.WriteLine("Asal Olanlar Yazdırılıyor...");
            foreach(var i in asal){
                Console.WriteLine(i);
            }
            Console.WriteLine("Asal Olmayanlar Yazdırılıyor...");
            foreach(var x in asalOlmayan){
                Console.WriteLine(x);
            }


        }
    }
}
