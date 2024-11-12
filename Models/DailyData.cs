using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataApi.Models
{
  public class Sale
  {
      [JsonProperty("id")]
      public string Id { get; set; }

      [JsonProperty("amount")]
      public decimal Amount { get; set; }

      [JsonProperty("customer_type")]
      public string CustomerType { get; set; }

      [JsonProperty("sales_channel")]
      public string SalesChannel { get; set; }

      [JsonProperty("date")]
      public DateTime Date { get; set; }
  }

}
