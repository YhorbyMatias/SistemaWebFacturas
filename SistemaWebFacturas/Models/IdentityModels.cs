﻿using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SistemaWebFacturas.Models;

namespace SistemaWebFacturas.Models
{
    // Para agregar datos del usuario, agregue más propiedades a su clase de usuario. Visite http://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        public Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }

        public ClaimsIdentity GenerateUserIdentity(ApplicationUserManager manager)
        {
            // Tenga en cuenta que authenticationType debe coincidir con el valor definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar reclamaciones de usuario personalizadas aquí
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}

#region Aplicaciones auxiliares
namespace SistemaWebFacturas
{
    public static class IdentityHelper
    {
        // Se utilizan para XSRF al vincular inicios de sesión externos
        public const string XsrfKey = "XsrfId";

        public static void SignIn(ApplicationUserManager manager, ApplicationUser user, bool isPersistent)
        {
            IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            var identity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
            authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, identity);
        }

        public const string ProviderNameKey = "providerName";
        public static string GetProviderNameFromRequest(HttpRequest request)
        {
            return request.QueryString[ProviderNameKey];
        }

        public const string CodeKey = "code";
        public static string GetCodeFromRequest(HttpRequest request)
        {
            return request.QueryString[CodeKey];
        }

        public const string UserIdKey = "userId";
        public static string GetUserIdFromRequest(HttpRequest request)
        {
            return HttpUtility.UrlDecode(request.QueryString[UserIdKey]);
        }

        public static string GetResetPasswordRedirectUrl(string code)
        {
            return "/Account/ResetPassword?" + CodeKey + "=" + HttpUtility.UrlEncode(code);
        }

        public static string GetUserConfirmationRedirectUrl(string code, string userId)
        {
            return "/Account/Confirm?" + CodeKey + "=" + HttpUtility.UrlEncode(code) + "&" + UserIdKey + "=" + HttpUtility.UrlEncode(userId);
        }

        private static bool IsLocalUrl(string url)
        {
            return !string.IsNullOrEmpty(url) && ((url[0] == '/' && (url.Length == 1 || (url[1] != '/' && url[1] != '\\'))) || (url.Length > 1 && url[0] == '~' && url[1] == '/'));
        }

        public static void RedirectToReturnUrl(string returnUrl, HttpResponse response)
        {
            if (!String.IsNullOrEmpty(returnUrl) && IsLocalUrl(returnUrl))
            {
                response.Redirect(returnUrl);
            }
            else
            {
                response.Redirect("~/");
            }
        }
    }
}
#endregion