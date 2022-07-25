namespace FamilyMeetingApp.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xamarin.Forms;
    using Interfaces;
    using Resources;


    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale( ci );
        }

        public static string Accept
        {
            get { return Resource.Accept; }
        }

        public static string BtnLogin
        {
            get { return Resource.BtnLogin; }
        }

        public static string BtnRegister
        {
            get { return Resource.BtnRegister; }
        }

        public static string EmailPlaceHolder
        {
            get { return Resource.EmailPlaceHolder; }
        }

        public static string EmailValidation
        {
            get { return Resource.EmailValidation; }
        }

        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string ForgotPass
        {
            get { return Resource.ForgotPass; }
        }

        public static string Login
        {
            get { return Resource.Login; }
        }

        public static string NoInternet
        {
            get { return Resource.NoInternet; }
        }

        public static string PasswordPlaceHolder
        {
            get { return Resource.PasswordPlaceHolder; }
        }

        public static string PasswordValidation
        {
            get { return Resource.PasswordValidation; }
        }
        
        public static string Rememberme
        {
            get { return Resource.Rememberme; }
        }

        public static string TurnOnInternet
        {
            get { return Resource.TurnOnInternet; }
        }

    }
}
