using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje_2
{
    class Kart  
    {
        private string baslik;

        private string icerik;
        private Buyukluk kartBuyuklugu;
        private Line line;
        private int atananKisiId;
        
        public Kart(string baslik, string icerik, Buyukluk kartBuyuklugu, Line line, int atananKisiId)
        {
            this.Baslik = baslik;
            this.icerik = icerik;
            this.kartBuyuklugu = kartBuyuklugu;
            this.line = line;
            this.atananKisiId = atananKisiId;
            Board.Kartlar.Add(this);
        }

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public Buyukluk KartBuyuklugu { get => kartBuyuklugu; set => kartBuyuklugu = value; }
        internal Line Line { get => line; set => line = value; }
        internal int AtananKisiId { get => atananKisiId; set => atananKisiId = value; }
    }





}