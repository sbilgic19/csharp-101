using System;
using System.Collections;

namespace Koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en 
                küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını 
                alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran 
                programı yazınız. (Array sınıfını kullanarak yazınız.)
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

            int[] totalArr = new int[20];
            int[] asalArr = new int[asal.Count];
            int[] asalOlmayanArr = new int[asalOlmayan.Count];
            for(int i=0; i<asal.Count; i++){
                totalArr[i] = (int) asal[i];
                asalArr[i] = (int) asal[i];
            }
            for(int i=0; i<asalOlmayan.Count; i++){
                totalArr[i+asal.Count] = (int) asalOlmayan[i];
                asalOlmayanArr[i] = (int) asalOlmayan[i];
            }
            

            Array.Sort(totalArr);

            // mins
            int min1 = totalArr[0];
            int min2 = totalArr[1];
            int min3 = totalArr[2];
            // maxs
            int max1 = totalArr[17];
            int max2 = totalArr[18];
            int max3 = totalArr[19];

            int asalTotal = 0;
            for(int i=0; i<asalArr.Length; i++){
                asalTotal += asalArr[i];
            }
            double asalOrt = (double)asalTotal/asalArr.Length;

            int asalOlmayanTotal = 0;
            for(int i=0; i<asalOlmayanArr.Length; i++){
                asalOlmayanTotal += asalOlmayanArr[i];
            }
            double asalOlmayanOrt = (double) asalOlmayanTotal/asalOlmayanArr.Length;


            Console.WriteLine("En küçük 3 sayı sırasıyla {0} {1} {2} ",min1,min2,min3);
            Console.WriteLine("En büyük 3 sayı sırasıyla {0} {1} {2} ",max1,max2,max3);
            Console.WriteLine("Asal olanların ortalaması: {0} ", asalOrt);
            Console.WriteLine("Asal olmayanların ortalaması: {0} ", asalOlmayanOrt);
            Console.WriteLine("Ortalama toplamları: {0}",asalOrt+asalOlmayanOrt);



        }
    }
}
