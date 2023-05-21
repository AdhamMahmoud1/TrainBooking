using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBookingSystem.Models
{
    public class Train
    {
        private int trainId;
        private String kind;
        private int seatsNum;
        private String arrivatTime;
        private String date;

        public int Trainid
        {
            get { return Trainid; }
            set
            {
                this.Trainid = value;
            }
        }
        public int SeatsNum
        {
            get { return seatsNum; }
            set
            {
                this.seatsNum = value;
            }
        }

        public String Kind
        {
            get { return kind; }
            set
            {
                this.kind= value;
            }
        }

        public String ArrivalTime { get { return ArrivalTime; }
            set { ArrivalTime = value; }
        }

        public String Date {get { return Date; } set {  this.date = value; } }


    }
}
