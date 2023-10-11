using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using geoprofs.Pages;
using System.ComponentModel.DataAnnotations;

namespace geoprofs.Pages
{
    public class UserModel : PageModel
    {
        [DataType(DataType.Boolean)]
        public bool LoggedIn { get; private set; }
        public void OnGet()
        {
            if (!(LoggedIn = true))
                return;        
        }/

        public static implicit operator UserModel(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
