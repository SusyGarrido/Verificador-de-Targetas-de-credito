using System;
using System.ComponentModel.DataAnnotations;

namespace credito.Models
{
    public class Tarjeta
    {
        [Required(ErrorMessage = "El número de tarjeta es necesario.")]
        //[CreditCard] 
        public string TarjetaNum { get; set; }
        public TipoTarjeta TipoTarjeta { get; set; }

        public bool Valida { get; set; }
     
        public Tarjeta(string tarjetaNum)
        {
            this.TarjetaNum = tarjetaNum;
            Valida = esValida();
            TipoTarjeta = tipoDeTarjeta();            
        }


        /// Basado en el algoritmo de Luhn determinar si esta tarjeta es valida
        /// como estamos dentro de la clase de tarjeta tenemos acceso a la propiedad TarjetaNum 
        private bool esValida()
        {
            int num=0;
            int resul=0;
            int conver=0;
            int suma=0;
            
            for(int i=TarjetaNum.Length-1;i>=0;i-=2)
            {
                conver=0;
                int a=(int)char.GetNumericValue(TarjetaNum[i]);
                suma=suma+a;
                if(i-1>=0)
                {
                    conver=(int)char.GetNumericValue(TarjetaNum[i-1]);
                }

                var ver=conver*2;
                if(ver>9){ver=ver-9;}
                resul=resul+ver;
            }
            num=resul+suma;
            return num%10==0;
        }


        /// Si la tarjeta es valida determinar de cuál tipo es VISA, MASTERCARD, AMERICANEXPRESS
        /// como estamos dentro de la clase de tarjeta tenemos acceso a la propiedad TarjetaNum 
        private TipoTarjeta tipoDeTarjeta()
        {
            var tipo=TipoTarjeta.NOVALIDA;
            if((TarjetaNum[0]=='3'&& TarjetaNum[1]=='4')||(TarjetaNum[0]=='3'&& TarjetaNum[1]=='7'))
            {
                tipo=TipoTarjeta.AMERICANEXPRESS;
            }
            if((TarjetaNum[0]=='5'&& TarjetaNum[1]=='1')||(TarjetaNum[0]=='5'&& TarjetaNum[1]=='2')||(TarjetaNum[0]=='5'&& TarjetaNum[1]=='3')||(TarjetaNum[0]=='5'&& TarjetaNum[1]=='4')||(TarjetaNum[0]=='5'&& TarjetaNum[1]=='5'))
            {
                tipo=TipoTarjeta.MASTERCARD;
            }
            if(TarjetaNum[0]=='4')
            {
                tipo=TipoTarjeta.VISA;
            }
            return tipo;
        }



    }

    public enum TipoTarjeta
    {
        VISA,
        MASTERCARD,
        AMERICANEXPRESS,
        NOVALIDA


    }
}