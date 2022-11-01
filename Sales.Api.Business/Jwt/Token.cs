using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Api.Business.Jwt;
public class Token
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }

}
