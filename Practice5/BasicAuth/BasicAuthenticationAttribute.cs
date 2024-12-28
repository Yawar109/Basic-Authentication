using System.Net;
using System.Security.Principal;
using System.Text;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace BasicAuth.Authorization
{
    public class BasicAuthenticationAttribute: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null) 
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,"UnAuthorized User | Login Failed");

            }
            else
            {
                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                //username:password base 64 encoded
                //admin:admin

                string decodedAuthToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                string[] usernampassword = decodedAuthToken.Split(":");

                string username = usernampassword[0];
                string password = usernampassword[1];

                if (ValidateUser.Login(username, password)) 
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "UnAuthorized User | Login Failed");
                }
            }
        }
    }
}
