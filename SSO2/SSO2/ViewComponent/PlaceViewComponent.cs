using SSO2.Data;
using SSO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSO2.ViewComponent
{
    public class PlaceViewComponent: Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly SSO2Context _context;
        public string Invoke(string id)
        {
            var Name = _context.Place.FindAsync(id).Result.Name;
            var Address = _context.Place.FindAsync(id).Result.Address;
            var Postcode = _context.Place.FindAsync(id).Result.Postcode;
            return $"地名: {Name}/ 地址: {Address}/ 郵遞區號: {Postcode}";
        }
    }
}