using System.Collections.Generic;

namespace WebSamples.HttpClientGoods.Model
{
    public class Root
    {
        public string Status { get; set; }

        public object Message { get; set; }

        public List<Datum> Data { get; set; }

        public Metadata Metadata { get; set; }
    }
}