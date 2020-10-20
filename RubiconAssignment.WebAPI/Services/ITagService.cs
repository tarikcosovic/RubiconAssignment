using RubiconAssignment.Model;
using RubiconAssignment.WebAPI.ViewModels;
using System.Threading.Tasks;

namespace RubiconAssignment.WebAPI.Services
{
    public interface ITagService
    {
        Task<TagVM> Get();
        Task<Tag> Insert(Tag tag);
    }
}
