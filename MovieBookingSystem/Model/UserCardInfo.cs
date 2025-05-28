using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingSystem.Model
{
    public class UserCardInfo
    {
        public static UserCardInfo cardCurrentInfo { get; set; }
        private string cardName;
        private int cardNum;
        private string expDate;
        private int cvvNumber;

        public string CardName
        {
            get { return cardName; } set { cardName = value; }
        }

        public int CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }
        public string ExpDate
        {
            get { return expDate; }
            set { expDate = value; }
        }
        public int CvvNumber
        {
            get { return cvvNumber; }
            set { cvvNumber = value; }
        }

        public UserCardInfo()
        {
            //default constructor
        }

        public UserCardInfo(string cardName, int cardNumber, string expDate, int cvvNumber)
        {
            this.cardName = cardName;
            this.cardNum = cardNumber;
            this.expDate = expDate;
            this.cvvNumber = cvvNumber;
        }





    }
}
