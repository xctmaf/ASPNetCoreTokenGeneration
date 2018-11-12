using System;
   using System.Security.Cryptography;
   using Xunit;
   using Xunit.Abstractions;

   public class GenerateRandomKeyTest
   {
       private readonly ITestOutputHelper output;

       public GenerateRandomKeyTest(ITestOutputHelper output)
       {
           this.output = output;
       }

       [Fact(Skip = "Утилита")]
       public void GenerateRandomKey()
       {
           // https://crypto.stackexchange.com/questions/34864/key-size-for-hmac-sha256
           using (var r = RandomNumberGenerator.Create())
           {
               var data = new byte[32];
               r.GetBytes(data);

               output.WriteLine(Convert.ToBase64String(data));
           }
       }
   }
