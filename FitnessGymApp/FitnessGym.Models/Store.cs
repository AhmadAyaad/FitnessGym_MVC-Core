using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessGym.Models
{
    public sealed class Store
    {
        private static Store _instance;
        public int StoreId { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public static readonly object InstanceLock = new object();

        public static Store GetStore
        {
            get
            {
                lock (InstanceLock)
                {
                    if (_instance == null)
                        _instance = new Store();
                    return _instance;
                }
            }

        }
    }
}
