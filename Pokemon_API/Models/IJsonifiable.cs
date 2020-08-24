
namespace Pokemon_API.Models
{
    public interface IJsonifiable
    {
        bool IsValid { get; }
        string ErrorMessage { get; }
    }
}