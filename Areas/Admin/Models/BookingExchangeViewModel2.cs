﻿namespace GeziRehberim.Areas.Admin.Models
{
    public class BookingExchangeViewModel2
    {

        //public class Rootobject
        //{
        //    public bool status { get; set; }
        //    public string message { get; set; }
        //    public long timestamp { get; set; }
        //    public Data data { get; set; }
        //}

       
            public string base_currency { get; set; }
            public string base_currency_date { get; set; }
            public Exchange_Rates[] exchange_rates { get; set; }
        

        public class Exchange_Rates
        {
            public string currency { get; set; }
            public string exchange_rate_buy { get; set; }
        }

    }
}

