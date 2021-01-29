using System;

namespace X_Password.Registers
{
    [System.Serializable]
    public class Register
    {
        public Register(string name, string description, string siteUrl, string login, string email, string password)
        {
            Name = name;
            Description = description;
            SiteUrl = siteUrl;
            Login = login;
            Email = email;
            Password = password;
        }

        public Register(string name, string login, string password)
            : this(name, "", "", login, "", password) { }

        public string Name { get; set; }
        public string Description { get; set; }
        public string SiteUrl { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return (!string.IsNullOrEmpty(Description) && Description.Length > 0) 
                ? $"{Name} - {Description}" 
                : Name;
        }

        public bool Match(string text)
        {
            var name = Name.ToLower();
            text = text.ToLower();

            return name.Contains(text) || name.Equals(text);
        }
    }
}
