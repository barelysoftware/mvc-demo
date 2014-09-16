
namespace Mvc.Models
{
    public interface IPageViewModel<T> where T:PageBase
    {
        
        T CurrentModel { get;  }
        LayoutModel Layout { get; }
 
    }
}
