namespace RabiulPortfolio.Models;

public record AcademicProject(
    string Title,
    string Tech,
    string Desc,
    string GithubFrontend,
    string GithubBackend,
    string Live,
    string[] Features);
