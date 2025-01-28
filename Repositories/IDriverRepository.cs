using F1_Racing_System.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace F1_Racing_System.Repositories
{
    public interface IDriverRepository
    {
        Task<List<Driver>> GetDriversAsync();
        Task<Driver?> GetDriverByIdAsync(int id);
        Task<Driver> CreateDriverAsync(Driver driver);

    //     public class DriverOperationResult
    // {
    //     public bool Success { get; set; }
    //     public Driver? Driver { get; set; }
    //     public string? ErrorMessage { get; set; }
    // }

    }
}
