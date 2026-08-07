using Catalogue;
using Microsoft.AspNetCore.Identity;

namespace Application.Models;

public class LibraryUser: IdentityUser
{
    public string? NickName { get; set; }
    public List<PersonalBook> Books { get; set; } = new();
}