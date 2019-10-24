using System;

namespace FactoryPattern
{

 public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
public class MoneyBackCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
 public class TitaniumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
 
public class PlatinumCreditCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }

    public class CardFactory
    {
        public static ICreditCard GetCardInstance(int cardType)
        {
            ICreditCard cardDetails = null;
            if (cardType == 1)
            {
                cardDetails = new MoneyBackCreditCard();
            }
            else if (cardType == 2)
            {
                cardDetails = new TitaniumCreditCard();
            }
            else if (cardType == 3)
            {
                cardDetails = new PlatinumCreditCard();
            }
            return cardDetails;
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            int cardType = 2;
            //Getting the instance from the factory class
            ICreditCard cardDetails = CardFactory.GetCardInstance(cardType);
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }  
}
}

