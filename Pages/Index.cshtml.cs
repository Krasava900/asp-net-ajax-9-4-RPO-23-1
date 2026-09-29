using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetWebApp.Pages;

public class IndexModel : PageModel
{
[BindProperty]
public string Name { get; set; }

[BindProperty]
public string Phone { get; set; }

[BindProperty]
public string Email { get; set; }

[BindProperty]
public string Speciality { get; set; }

[BindProperty]
public string Course { get; set; }

[BindProperty]
public string BirthDate { get; set; }

[BindProperty]
public string[] Technologies { get; set; } = Array.Empty<string>();

[BindProperty]
public string City { get; set; }

[BindProperty]
public string ProgrammingLanguage { get; set; }

[BindProperty]
public string EducationFormat { get; set; }

[BindProperty]
public string About { get; set; }

public void OnGet()
{
}

public IActionResult OnPost()
{
    var student = new
    {
        Name,
        Phone,
        Email,
        Speciality,
        Course,
        BirthDate,
        Technologies,
        City,
        ProgrammingLanguage,
        EducationFormat,
        About
    };

    return new JsonResult(student);
}


}
