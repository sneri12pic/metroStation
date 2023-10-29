using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace coursework1_OOSD
{
    public class MetroStation
    {
        private String _id;
      
        public string ID   // property
        {
            get
            {
                return _id;
            }
            set
            {
                int id_num = 0;
                if (_id != null)
                {
                    id_num = Int32.Parse(_id);
                }
                else if (value == "")
                {
                    throw new ArgumentException("ID cannot be blank!", "ID");
                }
                else if (id_num <= 999 && id_num >= 2001)
                {
                    throw new ArgumentException("ID cannot is out of bound!", "ID");
                }
                /*_id = id_num.ToString();*/
                _id = value;
            }
        }

        // Name of the Station creation
        private string name;
        public string Name
        {
            // Getter name
            get { return name; }
            // Setter name
            set
            {
                // Checking so the line is not blank
                if (value == "")
                {
                    throw new ArgumentException("Error Name is blank! ", "Name");

                }
                name = value;
                
            }
        }

        // Station Line creation
        private string line;
        public string Line
        {
            //getter, setter for 'Line'
            get { return line; }
            set
            {
                // Checking so the line is not blank
                if (value == "")
                {
                    throw new ArgumentException("Error Line is blank! ", "Line");
                }
                line = value;
            }
        }

        private int ticketsSold = 0;
        // Making another ticket sold to manipulate the actual value publicly
        public int TicketSold
        {
            // Getter Tickets Sold
            get { return ticketsSold; }
        }

        //Sell Tickets Method
        public void sellTicket()
        {
            // Keeping tickets under set boundaries of 999999
            if(ticketsSold <= 999999)
            {
                ticketsSold++;
            }
            else
            {
                throw new ArgumentException("Error number of tickets went over the set limit ", "TicketSold");
            }
        }
    }
}
