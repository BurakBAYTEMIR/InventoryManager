﻿using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen isim giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olun")]
        public string ConfirmPassword { get; set; }
    }
}