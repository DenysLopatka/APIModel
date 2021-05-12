using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2904Project.API
{
    class Code
    {
        
        
        public ClientAuthModel CreateUserViaApi()
        {
            var client = new RestClient("https://api.newbookmodels.com/api/v1/auth/client/signup/");
            var request = new RestRequest(Method.POST);
            // var user = new Dictionary<string, string>
            // {
            //     { "email", $"asda2sd2asd{DateTime.Now:ddyyyymmHHssmm}@asdasd.ert" },
            //     { "first_name", "asdasdasd" },
            //     { "last_name", "asdasdasd" },
            //     { "password", "123qweQWE" },
            //     { "phone_number", "3453453454" }
            // };

            var userModel = new UserSignUpModule
            {
                Email = $"asda2sd2asd{DateTime.Now:ddyyyymmHHssmm}@asdasd.ert",
                FirstName = "Den",
                LastName = "Den",
                Password = "123qweQWE",
                PhoneNumber = "3453453454"
            };

            request.AddHeader("content-type", "application/json");
            request.AddJsonBody(userModel);
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);
            var createdUser = JsonConvert.DeserializeObject<ClientAuthModel>(response.Content);

            return createdUser;
        }

        public class ClientAuthModel
        {
            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("token_data")]
            public TokenData TokenData { get; set; }
        }

        public class ClientProfile
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("facebook_followers")]
            public object FacebookFollowers { get; set; }

            [JsonProperty("instagram_followers")]
            public object InstagramFollowers { get; set; }

            [JsonProperty("has_invite")]
            public bool HasInvite { get; set; }

            [JsonProperty("company_website")]
            public object CompanyWebsite { get; set; }

            [JsonProperty("company_name")]
            public object CompanyName { get; set; }

            [JsonProperty("company_description")]
            public object CompanyDescription { get; set; }

            [JsonProperty("referral")]
            public object Referral { get; set; }

            [JsonProperty("phone_number")]
            public string PhoneNumber { get; set; }

            [JsonProperty("is_sms_enabled")]
            public bool IsSmsEnabled { get; set; }

            [JsonProperty("location_latitude")]
            public object LocationLatitude { get; set; }

            [JsonProperty("location_longitude")]
            public object LocationLongitude { get; set; }

            [JsonProperty("location_name")]
            public object LocationName { get; set; }

            [JsonProperty("location_city_name")]
            public object LocationCityName { get; set; }

            [JsonProperty("location_admin1_code")]
            public object LocationAdmin1Code { get; set; }

            [JsonProperty("location_timezone")]
            public object LocationTimezone { get; set; }

            [JsonProperty("company_address")]
            public object CompanyAddress { get; set; }

            [JsonProperty("industry")]
            public object Industry { get; set; }

            [JsonProperty("twitter_followers")]
            public object TwitterFollowers { get; set; }

            [JsonProperty("youtube_followers")]
            public object YoutubeFollowers { get; set; }
        }

        public class User
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("payment_method_connected")]
            public bool PaymentMethodConnected { get; set; }

            [JsonProperty("is_staff")]
            public bool IsStaff { get; set; }

            [JsonProperty("email_verified")]
            public bool EmailVerified { get; set; }

            [JsonProperty("client_profile")]
            public ClientProfile ClientProfile { get; set; }

            [JsonProperty("has_password")]
            public bool HasPassword { get; set; }

            [JsonProperty("avatar")]
            public object Avatar { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("first_name")]
            public string FirstName { get; set; }

            [JsonProperty("last_name")]
            public string LastName { get; set; }
        }

        public class TokenData
        {
            [JsonProperty("token")]
            public string Token { get; set; }

            [JsonProperty("token_refresh_expires")]
            public string TokenRefreshExpires { get; set; }

            [JsonProperty("firebase_token")]
            public string FirebaseToken { get; set; }

            [JsonProperty("firebase_token_expires")]
            public string FirebaseTokenExpires { get; set; }
        }

        public class Root
        {
            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("token_data")]
            public TokenData TokenData { get; set; }
        }

    }
}
