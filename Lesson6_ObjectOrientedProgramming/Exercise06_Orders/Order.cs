﻿using System;

namespace Exercise06_Orders
{
    internal class Order
    {
        public Order()
        {
            status = "";
        }
        protected DateTime date;
        protected string status;

        protected OrderDetail[] o;

        public double calcTax()
        {
            return 0;
        }

        public double calcTotal()
        {
            return 0;
        }
        public double calcTotalWeight()
        {
            return 0;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public string GetStatus()
        {
            return status;
        }
        public void SetDate(DateTime date)
        {
            this.date = date;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }
    }
}